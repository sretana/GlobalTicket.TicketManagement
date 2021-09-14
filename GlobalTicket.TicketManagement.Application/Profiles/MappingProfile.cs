using GlobalTicket.TicketManagement.Application.Features.Events;
using GlobalTicket.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using GlobalTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using GlobalTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;

namespace GlobalTicket.TicketManagement.Application.Profiles
{
    public class MappingProfile
    {
        public MappingProfile()
        {
            #region Events Mapper
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Event, EventListVm>().ReverseMap();
            });

            IMapper mapper = config.CreateMapper();
            var source = new Event();
            var dest = mapper.Map<Event, EventListVm>(source);


            var config2 = new MapperConfiguration(cfg => {
                cfg.CreateMap<Event, EventDetailVm>().ReverseMap();
            });

            IMapper mapper2 = config2.CreateMapper();
            var source2 = new Event();
            var dest2 = mapper2.Map<Event, EventDetailVm>(source2);

            var config3 = new MapperConfiguration(cfg => {
                cfg.CreateMap<Category, CategoryDto>();
            });

            IMapper mapper3 = config3.CreateMapper();
            var source3 = new Event();
            var dest3 = mapper3.Map<Event, EventDetailVm>(source3);
            #endregion
            #region Categories Mapper
            var CategoryConfig1 = new MapperConfiguration(cfg => {
                cfg.CreateMap<Category, CategoryListVm>();
            });

            IMapper CategoryMapper1 = CategoryConfig1.CreateMapper();
            var CategorySource = new Category();
            var CategoryDest = CategoryMapper1.Map<Category, CategoryListVm>(CategorySource);

            var CategoryConfig2 = new MapperConfiguration(cfg => {
                cfg.CreateMap<Category, CategoryEventListVm>();
            });

            IMapper CategoryMapper2= CategoryConfig2.CreateMapper();
            var CategorySource2 = new Category();
            var CategoryDest2 = CategoryMapper1.Map<Category, CategoryEventListVm>(CategorySource2);
            #endregion           
        }
    }
}
