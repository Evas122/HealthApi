using HealthApp.Storage.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Service.Commands.User
{
    public class CreateUserCommand : IRequest<Guid>
    {
        public UserDto User { get; set; }

        public CreateUserCommand(UserDto user)
        {
            User = user;
        }
    }
}
