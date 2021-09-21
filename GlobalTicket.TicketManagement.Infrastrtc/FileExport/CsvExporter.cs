
using CsvHelper;
using GlobalTicket.TicketManagement.Application.Contracts.Infrastructure;
using GlobalTicket.TicketManagement.Application.Features.Events.Queries.GetEventsExportQueryHandler;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace GlobalTicket.TicketManagement.Infrastrtc.FileExport
{
    public class CsvExporter : ICsvExporter
    {
        public byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos)
        {
            using var memoryStream = new MemoryStream();
            using (TextWriter streamWriter = new StreamWriter(memoryStream))
            {
                using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);
                csvWriter.WriteRecords(eventExportDtos);                
            }
            return memoryStream.ToArray();
        }
    }
}
