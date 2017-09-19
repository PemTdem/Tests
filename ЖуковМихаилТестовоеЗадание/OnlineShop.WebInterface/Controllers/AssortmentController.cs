using Newtonsoft.Json;
using OnlineShop.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.WebInterface.Controllers
{
    public class AssortmentController : Controller
    {
        IAssortmentServices _assortmentServices;

        public AssortmentController(IAssortmentServices assortmentServices)
        {
            _assortmentServices = assortmentServices;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult GetAssortment()
        {
            var req = Request;
            string id = req.Form.Get("id");
            string[] mid = id.Split('_');
            var assortment = _assortmentServices.GetAssortments().Where(x=>x.IdBrand == int.Parse(mid[1]));

            return Json( assortment, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult SaveChanges()
        {
            try
            {
                var req = Request;
                Guid id = new Guid(req.Form.Get("id").ToString());
                var assortment = _assortmentServices.GetAssortment(id);
                assortment.Name = req.Form.Get("Name");
                if(_assortmentServices.UpdateAssortment(assortment) == 1)
                {
                    return Json(true, JsonRequestBehavior.AllowGet);
                }
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            catch (Exception er)
            {
                return Json(er.Data, JsonRequestBehavior.AllowGet);
            }
        }

    }
}