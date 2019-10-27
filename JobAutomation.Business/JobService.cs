using JobAutomation.Dto;
using JobAutomation.UnitofWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace JobAutomation.Business
{
    public class JobService : IJobService
    {
        private IJobUnitofWork _jobUnitofWork;

        public JobService(IJobUnitofWork jobUnitofWork)
        {
            _jobUnitofWork = jobUnitofWork;
        }

        public void AddJob()
        {
            //_jobUnitofWork.JobRepository.Add()
        }

        public List<JobDto> GetAllJobs()
        {
            var qry = _jobUnitofWork.JobRepository.GetAll().Select(s => AutoMapper.Mapper.Map<JobDto>(s));
            return qry.ToList();
        }

        public void GetJobById()
        {
            throw new NotImplementedException();
        }

        public void GetJobByName()
        {
            throw new NotImplementedException();
        }

        public void RemoveJob()
        {
            throw new NotImplementedException();
        }

        public void UpdateJob()
        {
            throw new NotImplementedException();
        }
    }
}
