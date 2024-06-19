using AutoMapper;
using HealthApp.Storage.Dtos;
using HealthApp.Storage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Service.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<HealthDataDto, HealthData>().ReverseMap();
            CreateMap<HealthReportDto, HealthReport>().ReverseMap();
            CreateMap<MonitoringDeviceDto, MonitoringDevice>().ReverseMap();
            CreateMap<UserDto, User>().ReverseMap();
        }
    }
}
