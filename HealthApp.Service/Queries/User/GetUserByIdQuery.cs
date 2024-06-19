using HealthApp.Storage.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Service.Queries.User
{
    public class GetUserByIdQuery : IRequest<UserDto>
    {
        public Guid Id {  get; set; }

        public GetUserByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}
