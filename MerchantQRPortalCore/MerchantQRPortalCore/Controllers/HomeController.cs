using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MerchantQRPortalCore.Models;
using KoClient.Core;
using Microsoft.AspNetCore.Session;
using MerchantQRPortalCore.ViewModels;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace MerchantQRPortalCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly KoWebClient _koWebClient = KoWebClient.Instance;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Login() 
        {
            return View();
        }
        public IActionResult Logout()
        {
            try
            {
                HttpContext.Session.Clear();

            }
            catch (Exception)
            {

            }

            return RedirectToAction("Login", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(SignInViewModel signInViewModel)
        {
            if (ModelState.IsValid)
            {
                signInViewModel.RoleName = Convert.ToString(signInViewModel.UserRole);

                _koWebClient.SetBaseUrl("http://10.40.1.93:44323");
                _koWebClient.SetAcceptHeader("application/json");
                _koWebClient.SetContentTypeHeader("application/json");

                string url = "api/auth/login";

                string json = JsonConvert.SerializeObject(signInViewModel);

                string response = _koWebClient.UploadString(url, json);

                var jsonResult = JsonConvert.DeserializeObject<JsonResultViewModel<LoginResponse>>(response);

                if (jsonResult.ErrorCode == 0)
                {
                    HttpContext.Session.SetString(signInViewModel.UserName, "UserName");
                    HttpContext.Session.SetString(signInViewModel.RoleName, "RoleName");
                    HttpContext.Session.SetString(jsonResult.Data.Token, "Token");

                    return RedirectToAction("Index", "Merchants");

                }

            }

            return View();

        }
    
        public IActionResult Index()
        {
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
