using AutoMapper;
using GiftExchange.DataLayer.ExchangeContext;
using GiftExchange.DTOs.ProductDTOs;
using GiftExchange.DTOs.ReturnOfferDTOs;
using GiftExchange.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GiftExchange.App_Start
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            // Return & Items Mappings
            Mapper.CreateMap<ProductDTO, ProductViewModel>();
            Mapper.CreateMap<ProductViewModel, ProductDTO>();

            Mapper.CreateMap<ProductDTO, ReturnItem>();
            Mapper.CreateMap<ReturnItem, ProductDTO>();

            Mapper.CreateMap<ReturnDTO, Return>();
            Mapper.CreateMap<Return, ReturnDTO>();

            Mapper.CreateMap<ReturnDTO, ReturnViewModel>();
            Mapper.CreateMap<ReturnViewModel, ReturnDTO>();

            // Offers and Items Mappings
            Mapper.CreateMap<ReturnOfferViewModel, ReturnOfferDTO>()
                .ForMember(dest => dest.ReturnOfferItems;
            Mapper.CreateMap<ReturnOfferDTO, ReturnOfferViewModel>();

            Mapper.CreateMap<ReturnOfferItemViewModel, ReturnOfferItemDTO>();
            Mapper.CreateMap<ReturnOfferItemDTO, ReturnOfferItemViewModel>();

            Mapper.CreateMap<ReturnOffer, ReturnOfferDTO>();
            Mapper.CreateMap<ReturnOfferDTO, ReturnOffer>();

            Mapper.CreateMap<ReturnOfferItemDTO, ReturnOfferItems>();
            Mapper.CreateMap<ReturnOfferItems, ReturnOfferItemDTO>();

        }

    }
}