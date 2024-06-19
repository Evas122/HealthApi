using HealthApp.Storage.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Storage.Dtos
{
    public class HealthDataDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime Date { get; set; }
        public int Pulse { get; set; }
        public ActivityLevel ActivityLevel { get; set; }
        public int Dream { get; set; }
        public int Steps { get; set; }
    }
}
