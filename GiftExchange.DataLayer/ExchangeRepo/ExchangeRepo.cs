using AutoMapper;
using GiftExchange.DataLayer.ExchangeContext;
using GiftExchange.DTOs.ProductDTOs;
using GiftExchange.DTOs.ReturnOfferDTOs;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftExchange.DataLayer.ExchangeRepo
{
        
    public class ExchangeRepo
    {
        private ExchangeCtxt _eCtxt;

        public ExchangeRepo()
        {
            _eCtxt = new ExchangeCtxt();
        }

        public IEnumerable<Return> GetReturns()
        {
            var returnsList = _eCtxt.Return.Include(r => r.ReturnItems).ToList();
            return returnsList;
        }

        public Return GetReturnRequest(Guid? returnId)
        {
            var returnsRequest = _eCtxt.Return.Include(r=>r.ReturnItems).FirstOrDefault(r => r.id == returnId);
            return returnsRequest;
        }

        public ReturnDTO SaveReturn(List<ProductDTO> productDTOList)
        {
            Return newReturn = new Return();
            //newReturn.CreatedDate = DateTime.Now;
            newReturn.AlterDate = DateTime.Now;
            newReturn.userID = Guid.NewGuid();

            _eCtxt.Return.Add(newReturn);

            newReturn.ReturnItems = Mapper.Map<ICollection<ReturnItem>>(productDTOList);

            foreach (var ReturnItem in newReturn.ReturnItems)
            {
                _eCtxt.Entry(ReturnItem).State = EntityState.Added;
            }

            _eCtxt.SaveChanges();


            var retDTO = Mapper.Map<ReturnDTO>(newReturn);

            return retDTO;

        }


        public ReturnOfferDTO SaveNewReturnOffer(ReturnOfferDTO returnOfferDTO)
        {

            var newReturnOffer = Mapper.Map<ReturnOffer>(returnOfferDTO);
            ReturnOffer ReturnOffer2 = Mapper.Map<ReturnOffer>(returnOfferDTO);

            _eCtxt.ReturnOffer.Add(newReturnOffer);

            foreach (var ReturnItem in newReturnOffer.ReturnOfferItems)
            {
                _eCtxt.Entry(ReturnItem).State = EntityState.Added;
            }

            _eCtxt.SaveChanges();

            ReturnOfferDTO sendback = Mapper.Map<ReturnOfferDTO>(newReturnOffer);

            return sendback;
        }

    }
}
