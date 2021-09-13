using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.TicketManagement.Domain.Common
{
    class AuditableEntity
    {
        public string CreatedB { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; } 
    }
}
