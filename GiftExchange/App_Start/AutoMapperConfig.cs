using AutoMapper;
using GiftExchange.DataLayer.ExchangeContext;
using GiftExchange.DTOs.ProductDTOs;
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
            Mapper.CreateMap<ProductDTO, ProductViewModel>();
            Mapper.CreateMap<ProductViewModel, ProductDTO>();

            Mapper.CreateMap<ProductDTO, ReturnItem>();
            Mapper.CreateMap<ReturnItem, ProductDTO>();

            Mapper.CreateMap<ReturnDTO, Return>();
            Mapper.CreateMap<Return, ReturnDTO>();

            Mapper.CreateMap<ReturnDTO, ReturnViewModel>();
            Mapper.CreateMap<ReturnViewModel, ReturnDTO>();

        }

    }
}