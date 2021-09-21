using GlobalTicket.TicketManagement.Application.Features.Events.Queries.GetEventsExportQueryHandler;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.TicketManagement.Application.Contracts.Infrastructure
{
    public interface ICsvExporter
    {
        byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos);
    }
}
