﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Common.Storage.Interfaces
{
    public interface IIdentyfiableEntity<T>
    {
        T Id { get; set; }
    }

    public interface IIdentyfiableEntity : IIdentyfiableEntity<Guid> { }
}
