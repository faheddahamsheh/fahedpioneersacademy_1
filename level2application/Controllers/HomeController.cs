using Domains.Entities;
using level2application.Models;
using Microsoft.AspNetCore.Mvc;
using Services;
using System.Diagnostics;

namespace level2application.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var userID = Guid.Parse("// {8DD9C6BA-4676-4964-883A-ED45B79BB711}\r\nIMPLEMENT_OLECREATE(<<class>>, <<external_name>>, \r\n0x8dd9c6ba, 0x4676, 0x4964, 0x88, 0x3a, 0xed, 0x45, 0xb7, 0x9b, 0xb7, 0x11);\r\n");

            var UserService = new UserService();
            UserService.Add(new Domains.DTOs.AddUserRequest() { 
                Id=userID,
                FullName = "fahed faeq dahamsheh",
                EmailAddress = "faheddahamsheh@gmail.com",
                Address="amman",
            Password="fahed12121212"});
            var response= UserService.GetUserInfo(userID);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
