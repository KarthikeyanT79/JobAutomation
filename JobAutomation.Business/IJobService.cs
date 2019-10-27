using JobAutomation.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobAutomation.Business
{
    public interface IJobService
    {
        void AddJob();

        void RemoveJob();

        void UpdateJob();

        List<JobDto> GetAllJobs();

        void GetJobById();

        void GetJobByName();

    }
}
