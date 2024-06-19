using HealthApp.Common.Storage.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Storage.Entities
{
    [Table("Users", Schema ="HealthApp")]
    public class User : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public virtual ICollection<HealthData> HealthData { get; set; }
        public virtual ICollection<HealthReport> HealthReport { get; set; }
    }
}
