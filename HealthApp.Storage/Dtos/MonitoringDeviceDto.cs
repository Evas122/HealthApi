﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Storage.Dtos
{
    public class MonitoringDeviceDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
    }
}
