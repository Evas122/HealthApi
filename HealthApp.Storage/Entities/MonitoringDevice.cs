using HealthApp.Common.Storage.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Storage.Entities
{
    [Table("MonitoringDevices", Schema = "HealthApp")]
    public class MonitoringDevice : BaseEntity
    {
        public string? Name { get; set; }
        public string? Type { get; set; }
        public Guid UserId { get; set; }
        public virtual User? User { get; set; }
    }
}
