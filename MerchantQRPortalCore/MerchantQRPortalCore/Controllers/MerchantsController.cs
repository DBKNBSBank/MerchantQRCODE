using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using KoClient.Core;
using MerchantQRPortalCore.Constants;
using MerchantQRPortalCore.Models;
using MerchantQRPortalCore.Resources;
using MerchantQRPortalCore.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace MerchantQRPortalCore.Controllers
{
    public class MerchantsController : Controller
    {
        private readonly MerchantQRContext _merchantQRContext;
        private readonly KoWebClient _koWebClient;

        public MerchantsController(MerchantQRContext merchantQRContext)
        {
            _merchantQRContext = merchantQRContext;
            _koWebClient = KoWebClient.Instance;

            _koWebClient.SetBaseUrl(RegistryReader.BaseURL());

            _koWebClient.SetAcceptHeader("application/json");
            _koWebClient.SetContentTypeHeader("application/json");
        }

        public async Task<IActionResult> Index()
        {
            var qrCodes = await _merchantQRContext.QrCodes.ToListAsync();
            var resources = await Task.Run(() => MapQRCodeToResource(qrCodes));

            return View(resources);
        }

        public async Task<ActionResult> All()
        {
            var qrCodes = await _merchantQRContext.QrCodes.ToListAsync();

            var resource = new List<QRCodeResource>();

            await Task.Run(() =>
            {
                resource = qrCodes.Select(code => new QRCodeResource
                {
                    AccountNumber = code.AccountNumber,
                    DateCreated = code.DateCreated,
                    MerchantCode = code.MerchantCode,
                    MerchantName = code.MerchantName
                }).ToList();
            });

            return View(resource);
        }

        public async Task<ActionResult> Details(string id)
        {
            var qrCode = await _merchantQRContext.QrCodes
                .SingleOrDefaultAsync(qr => qr.MerchantCode == id);

            if (qrCode == null)
            {
                return null;
            }

            return View(qrCode);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<ActionResult> Create(QRCodeResource qRCodeResource)
        {
            if (ModelState.IsValid)
            {
                qRCodeResource.DateCreated = DateTime.Now;

                string url = RegistryReader.PostMerchantURL();

                string json = JsonConvert.SerializeObject(qRCodeResource);

                _koWebClient.UploadString(url, json);

                await LogUserActions();

                return RedirectToAction("Index", "Merchants");

            }

            return View(qRCodeResource);
        }

        private async Task LogUserActions()
        {
            SignInViewModel signInViewModel = new SignInViewModel();
            try
            {
                _merchantQRContext.UserActions.Add(new UserActions
                {

                    Action = "Created a QR Code",
                    DateConducted = DateTime.Now,
                    //Rolename = HttpContext.Session.GetString(signInViewModel.RoleName),
                    Username = HttpContext.Session.GetString(signInViewModel.UserName)

                }) ;

                await _merchantQRContext.SaveChangesAsync();

            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
        }

        private List<QRCodeResource> MapQRCodeToResource(List<QrCodes> qrCodes)
        {
            var resources = qrCodes.Select(code => new QRCodeResource
            {
                AccountNumber = code.AccountNumber,
                DateCreated = code.DateCreated,
                MerchantCode = code.MerchantCode,
                MerchantName = code.MerchantName

            }).ToList() ;

            return resources;
        
        }
    }
}
