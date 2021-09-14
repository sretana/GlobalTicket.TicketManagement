using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents
{
    public class GetCategoriesListWithEventsQuery:IRequest<List<CategoryEventListVm>>
    {
        // parameter to know if a want to return ALL events or just the ones that are in the future
        public bool IncludeHistory { get; set; }
    }
}
