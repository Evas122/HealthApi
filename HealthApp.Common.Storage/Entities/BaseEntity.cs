﻿using HealthApp.Common.Storage.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Common.Storage.Entities
{
    public abstract class BaseEntity : IIdentyfiableEntity, ITrackedEntity
    {
    [Key]
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
