using GlobalTicket.TicketManagement.Application.Features.Events;
using GlobalTicket.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using GlobalTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using GlobalTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
using GlobalTicket.TicketManagement.Application.Features.Events.Commands.CreateEvent;
using GlobalTicket.TicketManagement.Application.Features.Events.Commands.UpdateEvent;

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


            var config4 = new MapperConfiguration(cfg => {
                cfg.CreateMap<Event, CreateEventCommandHandler>().ReverseMap();
            });

            IMapper mapper4 = config4.CreateMapper();
            var source4 = new Event();
            var dest4 = mapper4.Map<Event, CreateEventCommandHandler>(source4);


            var config5 = new MapperConfiguration(cfg => {
                cfg.CreateMap<Event, UpdateEventCommand>().ReverseMap();
            });

            IMapper mapper5 = config5.CreateMapper();
            var source5 = new Event();
            var dest5 = mapper5.Map<Event, UpdateEventCommand>(source5);


            var config6 = new MapperConfiguration(cfg => {
                cfg.CreateMap<Event, DeleteEventComman>().ReverseMap();
            });

            IMapper mapper6 = config6.CreateMapper();
            var source6 = new Event();
            var dest6 = mapper6.Map<Event, DeleteEventComman>(source6);
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
