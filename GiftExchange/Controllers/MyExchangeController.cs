using GiftExchange.Models;
using GiftExchange.LogicLayer.LogicManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GiftExchange.DTOs.ProductDTOs;
using AutoMapper;

namespace GiftExchange.Controllers
{
    public class MyExchangeController : Controller
    {
        LogicManager _logicManager;
        List<ProductViewModel> ProdList;

        public MyExchangeController()
        {
            _logicManager = new LogicManager();
            //_logicManager.GetReturns();
        }
        
        // GET: MyExchange
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FindUPC(string id)
        {

            var foundProduct = _logicManager.FindProduct(id);
            if (foundProduct == null)
                foundProduct = new ProductDTO("", "");
                //return Json(new { success = false, message = "Product not found" });

            return Json(foundProduct, JsonRequestBehavior.AllowGet);
        }


        public ActionResult SaveReturns(List<ProductViewModel> ReturnItems)
        {

            List<ProductDTO> productDTOList;
            productDTOList = Mapper.Map<List<ProductDTO>>(ReturnItems);
            var Return = _logicManager.CreateNewReturn(productDTOList);

            var ReturnVM = Mapper.Map<ReturnViewModel>(Return);

            return Json(ReturnVM);
        }

    }
}
