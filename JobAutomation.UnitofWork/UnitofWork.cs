using JobAutomation.EntityModel;
using JobAutomation.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobAutomation.UnitofWork
{
    public class JobUnitofWork : IJobUnitofWork
    {
        private readonly JobRepository _jobRepository;

        private JobDbContext _jobDbContext;

        public JobRepository JobRepository
        {
            get
            {
                return _jobRepository;
            }

        }

        public JobUnitofWork()
        {
            _jobDbContext = new JobDbContext();
            _jobRepository = new JobRepository(_jobDbContext);
        }
        public void Save()
        {
            _jobDbContext.SaveChanges();
        }
    }
}
