using HealthApp.Common.Storage.Entities;
using HealthApp.Storage.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Storage.Entities
{
    [Table("HealthData", Schema = "HealthApp")]
    public class HealthData : BaseEntity
    {
        public Guid UserId { get; set; }
        public DateTime Date {  get; set; }
        public int Pulse {  get; set; }
        public ActivityLevel ActivityLevel { get; set; }
        public int Dream {  get; set; }
        public int Steps { get; set; }
        public virtual User? User { get; set; }
    }
}
