using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Common.Storage.Dtos
{
    public enum CrudOperationResultStatus
    {
        Success,
        Failure,
        RecordNotFound
    }
}
