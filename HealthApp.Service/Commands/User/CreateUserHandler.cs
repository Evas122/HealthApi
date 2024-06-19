using AutoMapper;
using HealthApp.Storage.Dtos;
using HealthApp.Storage.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Service.Commands.User
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, Guid>
    {
        private readonly IUserRepository _iUserRepository;
        private readonly IMapper _mapper;

        public CreateUserHandler(IUserRepository iUserRepository, IMapper mapper)
        {
            _iUserRepository = iUserRepository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<UserDto>(request.User);
            return await _iUserRepository.AddAsync(user);
        }
    }
}
