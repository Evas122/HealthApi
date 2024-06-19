using HealthApp.Storage.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Service.Commands.HealthData
{
    public class DeleteHealthDataHandler : IRequestHandler<DeleteHealthDataCommand>
    {
        private readonly IHealthDataRepository _iHealthDataRepository;

        public DeleteHealthDataHandler(IHealthDataRepository iHealthDataRepository)
        {
            _iHealthDataRepository = iHealthDataRepository;
        }

        public async Task<Unit> Handle(DeleteHealthDataCommand request, CancellationToken cancellationToken)
        {
            await _iHealthDataRepository.DeleteAsync(request.Id);
            return Unit.Value;
        }
    }
}
