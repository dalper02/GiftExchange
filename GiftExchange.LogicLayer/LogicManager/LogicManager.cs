using AutoMapper;
using GiftExchange.DataLayer.ExchangeRepo;
using GiftExchange.DTOs.ProductDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftExchange.LogicLayer.LogicManager
{
    public class LogicManager
    {

        private ExchangeRepo _exchangeRepo;
        List<ProductDTO> products;

        public LogicManager()
        {

            _exchangeRepo = new ExchangeRepo();

            products = new List<ProductDTO>
            {
               new ProductDTO("1AX34563B", "GI Joe Kung Foo Grip"),
               new ProductDTO("1AX23452B", "GI Joe Private"),
               new ProductDTO("1AX23452A", "GI Joe Captain"),
               new ProductDTO("1BG009110", "GI Joe General"),
               new ProductDTO("1AX23452G", "Malibu Barbie Doll"),
               new ProductDTO("1BG009111", "Impatient Ken Doll"),
               new ProductDTO("1BG009112", "Expensive Corvette Ken Paid for"),
               new ProductDTO("A", "A Test Thing"),
            };

        }


        public ProductDTO FindProduct(string newUPC)
        {

            return products.FirstOrDefault(p => p.UPC == newUPC);

        }


        //public string CreateNewReturn(List<ProductDTO> ReturnItems)        
        public ReturnDTO CreateNewReturn(List<ProductDTO> productDTOList)
        {
            var RetDTO = _exchangeRepo.SaveReturn(productDTOList);
            return RetDTO;
        }

        public IEnumerable<ReturnDTO> GetReturns()
        {

            var returns = _exchangeRepo.GetReturns();
            var returnsDTOList = Mapper.Map<IEnumerable<ReturnDTO>>(returns);

            return returnsDTOList;

        }


        public ReturnDTO GetReturnRequest(Guid? returnId)
        {

            var ReturnRequest = _exchangeRepo.GetReturnRequest(returnId);
            var returnDTO = Mapper.Map<ReturnDTO>(ReturnRequest);

            return returnDTO;

        }


    }
}
