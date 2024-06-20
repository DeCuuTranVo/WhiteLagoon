<h1> White Lagoon - Resort Booking Web Application </h1>

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)
![HTML5](https://img.shields.io/badge/html5-%23E34F26.svg?style=for-the-badge&logo=html5&logoColor=white)
![CSS3](https://img.shields.io/badge/css3-%231572B6.svg?style=for-the-badge&logo=css3&logoColor=white)
![JavaScript](https://img.shields.io/badge/javascript-%23323330.svg?style=for-the-badge&logo=javascript&logoColor=%23F7DF1E)
![Bootstrap](https://img.shields.io/badge/bootstrap-%238511FA.svg?style=for-the-badge&logo=bootstrap&logoColor=white)
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![MicrosoftSQLServer](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white)
![Windows](https://img.shields.io/badge/Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)
![GitHub](https://img.shields.io/badge/github-%23121011.svg?style=for-the-badge&logo=github&logoColor=white)
![Udemy](https://img.shields.io/badge/Udemy-A435F0?style=for-the-badge&logo=Udemy&logoColor=white)

<h2> 1. Project Description </h2>
This app is a web app serving the purpose of booking resort rooms for vacations.

<h2> 2. System design and main elements </h2>
<h3> 2.1. Tech stack</h3>

```
    Tech stack:
    ├── Database: Microsoft SQL Server
    └── Web Development: 
        ├── Front-end: HTML, CSS, JavaScript, Bootstrap 
        ├── Back-end: C#, .NET Core MVC, Entity Framework Core, ASP.NET Identity Core
        └── Third-party libraries: Syncfusion, Stripe, Mailtrap
```

<h3> 2.2. Design Pattern: Model - View - Template</h3>
<h3> 2.3. Architecture: Three-tier Architecture & Clean Architecture </h3>
<h3> 2.3. Project Structure </h3>

<pre>
    <b>WhiteLagoon </b>
    ├── <b>WhiteLagoon.Application </b>
    │   ├── <b>Common </b>                            
    │   │   ├── <b>DTO </b>         
    │   │   │   ├── LineChartDto.cs   
    │   │   │   ├── PieChartDto.cs
    │   │   │   └── RadialBarChartDto.cs  
    │   │   ├── <b>Interfaces</b>     
    │   │   │   ├── IAmenityRepository.cs
    │   │   │   ├── IApplicationUserRepository.cs
    │   │   │   ├── IBookingRepository.cs
    │   │   │   ├── IDbInitializer.cs
    │   │   │   ├── IRepository.cs
    │   │   │   ├── IUnitOfWork.cs
    │   │   │   ├── IVillaNumberRepository.cs
    │   │   │   └── IVillaRepository.cs
    │   │   └── <b>Utility</b>     
    │   │       └── SD.cs
    │   ├── <b>Services </b>  
    │   │   ├── <b>Implementation </b> 
    │   │   │   ├── AmenityService.cs
    │   │   │   ├── BookingService.cs
    │   │   │   ├── DashboardService.cs
    │   │   │   ├── EmailService.cs
    │   │   │   ├── PaymentService.cs
    │   │   │   ├── VillaNumberService.cs
    │   │   │   └── VillaService.cs
    │   │   └── <b>Interface </b> 
    │   │       ├── IAmenityService.cs
    │   │       ├── IBookingService.cs
    │   │       ├── IDashboardService.cs
    │   │       ├── IEmailService.cs
    │   │       ├── IPaymentService.cs
    │   │       ├── IVillaNumberService.cs
    │   │       └── IVillaService.cs
    │   └── WhiteLagoon.Application.csproj
    ├── <b>WhiteLagoon.Domain </b>
    │   ├── <b>Entities </b>         
    │   │   ├── Amenity.cs  
    │   │   ├── ApplicationUser.cs
    │   │   ├── Booking.cs
    │   │   ├── Villa.cs
    │   │   └── VillaNumber.cs 
    │   └── WhiteLagoon.Domain.csproj
    ├── <b>WhiteLagoon.Infrastructure </b>
    │   ├── <b>Data </b>
    │   │   ├── ApplicationDbContext.cs
    │   │   └── DbInitializer.cs
    │   ├── <b>Migrations </b>
    │   │   └── ...
    │   ├── <b>Repository </b>
    │   │   ├── AmenityRepository.cs
    │   │   ├── ApplicationUserRepository.cs
    │   │   ├── BookingRepository.cs
    │   │   ├── Repository.cs
    │   │   ├── UnitOfWork.cs
    │   │   ├── VillaNumberRepository.cs
    │   │   └── VillaRepository.cs
    │   └── WhiteLagoon.Infrastructure.csproj    
    ├── <b>WhiteLagoon.Web </b>
    │   ├── <b>Controllers </b>
    │   │   ├── AccountController.cs
    │   │   ├── AmenityController.cs
    │   │   ├── BookingController.cs
    │   │   ├── DashboardController.cs
    │   │   ├── HomeController.cs
    │   │   ├── VillaController.cs
    │   │   └── VillaNumberController.cs
    │   ├── <b>Models </b>
    │   │   └── ErrorViewModel.cs
    │   ├── <b>Properties </b>
    │   │   └── launchSettings.json
    │   ├── <b>ViewModels </b>
    │   │   ├── AmenityVM.cs
    │   │   ├── HomeVM.cs
    │   │   ├── LoginVM.cs
    │   │   ├── RegisterVM.cs
    │   │   └── VillaNumberVM.cs
    │   ├── <b>Views </b>
    │   │   ├── <b>Account </b> 
    |   │   │   ├── AccessDenied.cshtml
    |   │   │   ├── Login.cshtml
    |   │   │   └── Register.cshtml
    │   │   ├── <b>Amenity </b> 
    |   │   │   ├── Create.cshtml
    |   │   │   ├── Delete.cshtml
    |   │   │   ├── Index.cshtml
    |   │   │   └── Update.cshtml
    │   │   ├── <b>Booking </b> 
    |   │   │   ├── BookingConfirmation.cshtml
    |   │   │   ├── BookingDetails.cshtml
    |   │   │   ├── FinalizeBooking.cshtml
    |   │   │   └── Index.cshtml
    │   │   ├── <b>Dashboard </b> 
    |   │   │   └── Index.cshtml
    │   │   ├── <b>Home </b> 
    |   │   │   ├── Index.cshtml
    |   │   │   └── Privacy.cshtml
    │   │   ├── <b>Shared </b> 
    |   │   │   ├── Error.cshtml
    |   │   │   ├── _Layout.cshtml
    |   │   │   ├── _Layout.cshtml.css
    |   │   │   ├── _LayoutAdmin.cshtml
    |   │   │   ├── _LayoutAdmin.cshtml.css
    |   │   │   ├── _LoginPartial.cshtml
    |   │   │   ├── _LoginPartialAdmin.cshtml
    |   │   │   ├── _Notification.cshtml
    |   │   │   ├── _ValidationScriptsPartial.cshtml
    |   │   │   ├── _VillaDetail.cshtml
    |   │   │   └── _VillaList.cshtml
    │   │   ├── <b>Villa </b> 
    |   │   │   ├── Create.cshtml
    |   │   │   ├── Delete.cshtml
    |   │   │   ├── Index.cshtml
    |   │   │   └── Update.cshtml
    │   │   ├── <b>VillaNumber </b> 
    |   │   │   ├── Create.cshtml
    |   │   │   ├── Delete.cshtml
    |   │   │   ├── Index.cshtml
    |   │   │   └── Update.cshtml
    │   │   ├── _ViewImports.cshtml
    │   │   └── _ViewStart.cshtml
    │   ├── <b>wwwroot </b>
    │   │   ├── <b>css </b> 
    |   │   │   ├── apexcharts.css
    |   │   │   ├── site.css
    |   │   │   └── spinner.css
    │   │   ├── <b>exports </b> 
    |   │   │   ├── BookingDetails.docx
    |   │   │   └── ExportVillaDetails.pptx
    │   │   ├── <b>images </b> 
    |   │   │   ├── <b>Room Images </b>
    |   │   │   ├── <b>VillaImage </b>
    |   │   │   └── ...
    │   │   ├── <b>jquery-ajax-unobtrusive </b> 
    │   │   ├── <b>js </b> 
    |   │   │   ├── <b>dashboard </b> 
    |   |   │   │   ├── getCustomerAndBookingLineChart.js
    |   |   │   │   ├── getCustomerBookingPieChart.js
    |   |   │   │   ├── getTotalBookingsRadial.js
    |   |   │   │   ├── getTotalRevenueRadial.js
    |   |   │   │   ├── getTotalUserRadial.js
    |   |   │   │   └── radialChart.js
    |   │   │   ├── apexcharts.js
    |   │   │   ├── booking.js
    |   │   │   ├── jquery.unobtrusive-ajax.js
    |   │   │   ├── jquery.unobtrusive-ajax.min.js
    |   │   │   └── site.js
    │   │   ├── <b>lib </b> 
    |   │   │   ├── <b>bootstrap </b> 
    |   │   │   ├── <b>jquery-validation-unobtrusive </b> 
    |   │   │   ├── <b>jquery-validation </b> 
    |   │   │   └── <b>jquery </b> 
    │   │   └── favicon.ico
    │   ├── Program.cs
    │   ├── WhiteLagoon.Web.csproj
    │   ├── appsettings.Development.json
    │   ├── appsettings.json
    │   └── libman.json
    ├── .gitattributes
    ├── .gitignore
    ├── README.md
    └── WhiteLagoon.sln
</pre>

