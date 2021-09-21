using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.TicketManagement.Application.Features.Events.Queries.GetEventsExportQueryHandler
{
    public class EventExportFileVm
    {
        public string EventExportFileName { get; set; }
        public string ContentType { get; set; }
        public byte[] Data { get; set; }
    }
}
