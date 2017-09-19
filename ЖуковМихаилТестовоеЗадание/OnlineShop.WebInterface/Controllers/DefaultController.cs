using Newtonsoft.Json;
using OnlineShop.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.WebInterface.Controllers
{
    public class DefaultController : Controller
    {
        IBrendServices _brendServices;
        
        public DefaultController(IBrendServices brendServices)
        {
            _brendServices = brendServices;
            
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public string Brends()
        {

            var brends = _brendServices.GetBrends();
            return JsonConvert.SerializeObject(brends);

        }

    }
}