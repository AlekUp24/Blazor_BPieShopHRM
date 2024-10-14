using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.Shared.Domain
{
    public class TimeRegistration
    {
        public int TimeRegistrationId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string PerformedTaskDescription { get; set; } = string.Empty;

    }
}
