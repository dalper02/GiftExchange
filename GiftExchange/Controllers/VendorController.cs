using AutoMapper;
using GiftExchange.DTOs.ReturnOfferDTOs;
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
        public class Query
        {
            public int sId { get; set; }
        }

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

        public ActionResult SaveReturnOffer(ReturnOfferViewModel ReturnOffer)
        {
            //var returnRequest = _logicManager.GetReturnRequest(id);
            var newReturnOfferDTO = Mapper.Map<ReturnOfferDTO>(ReturnOffer);
            //var newReturnOfferDTO = new ReturnOfferDTO()
            //{
            //    id = ReturnOffer.id,
            //    VendorUserID = ReturnOffer.VendorUserID,
            //    ReturnOfferItems = ReturnOffer.ReturnOfferItems.Select(r=> new ReturnOfferItemDTO() 
            //    { 
            //        ReturnItemId = r.ReturnItemId,
            //        isOffered = r.isOffered,
            //        price = r.price,

            //    })
                
            //};
            var updatedReturnOffer = _logicManager.CreateNewReturnOffer(newReturnOfferDTO);

            return Json(ReturnOffer, JsonRequestBehavior.AllowGet);
        }

    }
}