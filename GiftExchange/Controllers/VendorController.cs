using AutoMapper;
using GiftExchange.LogicLayer.LogicManager;
using GiftExchange.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GiftExchange.Controllers
{
    public class VendorController : Controller
    {
        LogicManager _logicManager;

        public VendorController()
        {
            _logicManager = new LogicManager();
        }
        
        
        // GET: Vendor
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ReturnRequests()
        {
            var returns = _logicManager.GetReturns();
            var ReturnVM = Mapper.Map<IEnumerable<ReturnViewModel>>(returns);

            return View(ReturnVM);
        }


        public ActionResult GetReturns()
        {
            var returns = _logicManager.GetReturns();
            var ReturnVM = Mapper.Map<IEnumerable<ReturnViewModel>>(returns);

            return Json(ReturnVM, JsonRequestBehavior.AllowGet);
        }


        public ActionResult GetReturn(Guid? id)
        {
            var returnRequest = _logicManager.GetReturnRequest(id);
            var ReturnVM = Mapper.Map<ReturnViewModel>(returnRequest);

            return Json(ReturnVM, JsonRequestBehavior.AllowGet);
        }

        public ActionResult CreateReturnOffer(ReturnOfferViewModel newReturnOffer)
        {
            //var returnRequest = _logicManager.GetReturnRequest(id);
            //var ReturnVM = Mapper.Map<ReturnViewModel>(returnRequest);

            return Json(newReturnOffer, JsonRequestBehavior.AllowGet);
        }

    }
}