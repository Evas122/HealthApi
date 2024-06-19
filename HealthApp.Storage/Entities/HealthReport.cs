using HealthApp.Common.Storage.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Storage.Entities
{
    [Table("HealthRepors", Schema = "HealthApp")]
    public class HealthReport : BaseEntity
    {
        public Guid UserId { get; set; }
        public DateTime Date { get; set; }
        public string? Decription { get; set; }

        public virtual User? User { get; set; }
    }
}
