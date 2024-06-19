﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WhiteLagoon.Application.Common.Interfaces;
using WhiteLagoon.Application.Common.Utility;
using WhiteLagoon.Application.Services.Interface;
using WhiteLagoon.Domain.Entities;
using WhiteLagoon.Infrastructure.Data;

namespace WhiteLagoon.Web.Controllers
{
    [Authorize(Roles = SD.Role_Admin)]
    public class VillaController : Controller
    {
        private readonly IVillaService _villaService;

        public VillaController(IVillaService villaService)
        {
            _villaService = villaService;
        }

        public IActionResult Index()
        {
            var villas = _villaService.GetAllVillas();
            return View(villas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Villa obj) 
        { 
            if (obj.Name == obj.Description)
            {
                ModelState.AddModelError(key: "Name", errorMessage: "The description can not exactly match the name.");
            }

            if (ModelState.IsValid)
            {
                _villaService.CreateVilla(obj);

                TempData["success"] = "The villa has been created successfully.";
                return RedirectToAction(actionName: nameof(Index), controllerName: nameof(VillaController).Replace("Controller", ""));
            }
            return View(obj);
        }

        public IActionResult Update(int villaId)
        {
            Villa? obj = _villaService.GetVillaById(villaId);

            if (obj == null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(obj);
        }

        [HttpPost]
        public IActionResult Update(Villa obj)
        {
            if (ModelState.IsValid && obj.Id > 0)
            {
                _villaService.UpdateVilla(obj);

                TempData["success"] = "The villa has been updated successfully.";
                return RedirectToAction(actionName: nameof(Index), controllerName: nameof(VillaController).Replace("Controller", ""));
            }
            return View(obj);
        }

        public IActionResult Delete(int villaId)
        {
            Villa? obj = _villaService.GetVillaById(villaId);
            if (obj == null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(obj);
        }

        [HttpPost]
        public IActionResult Delete(Villa obj)
        {
            bool deleted = _villaService.DeleteVilla(obj.Id);
            if (deleted)
            {
                TempData["success"] = "The villa has been deleted successfully.";
                return RedirectToAction(actionName: "Index", controllerName: "Villa");
            }
            else
            {
                TempData["error"] = "Failed to delete the villa.";
            }
            return View(obj);
        }
    }
}
