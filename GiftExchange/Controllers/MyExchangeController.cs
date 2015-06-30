using GiftExchange.Models;
using GiftExchange.LogicLayer.LogicManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GiftExchange.DTOs.ProductDTOs;

namespace GiftExchange.Controllers
{
    public class MyExchangeController : Controller
    {
        LogicManager _logicManager;
        List<Product> ProdList;

        public MyExchangeController()
        {
            _logicManager = new LogicManager();
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


        public ActionResult SaveReturns(List<Product> ReturnItems)
        {


            return Json(new { success = true, ReturnId = "1" });
        }

    }
}
