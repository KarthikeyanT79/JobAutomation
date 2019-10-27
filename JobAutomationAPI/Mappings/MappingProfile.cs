using AutoMapper;
using JobAutomation.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobAutomationAPI.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            JobDtoToJob();
            JobToJobDt();
        }

        private void JobDtoToJob()
        {
            CreateMap<JobDto, Job>()
                            .ForMember(dest => dest.JobId, opt => opt.MapFrom(src => src.Id))
                            .ForMember(dest => dest.JobName, opt => opt.MapFrom(src => src.Name))
                            .ForMember(dest => dest.JobDescription, opt => opt.MapFrom(src => src.Description))
                            .ForMember(dest => dest.JobCreatedDateTime, opt => opt.MapFrom(src => src.CreateDate))
                            .ForMember(dest => dest.JobCreatedUser, opt => opt.MapFrom(src => src.CreatedUser));
        }


        private void JobToJobDt()
        {
            CreateMap<Job  , JobDto>()
                            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.JobId))
                            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.JobName))
                            .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.JobDescription))
                            .ForMember(dest => dest.CreateDate, opt => opt.MapFrom(src => src.JobCreatedDateTime))
                            .ForMember(dest => dest.CreatedUser, opt => opt.MapFrom(src => src.JobCreatedUser));
        }
    }
}
