using JobAutomation.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobAutomation.Repository
{
    public class JobRepository : IRepository<Job>
    {
        JobDbContext _jobDbContext;

        public JobRepository(JobDbContext jobDbContext)
        {
            _jobDbContext = jobDbContext;
        }

        public void Add(Job t)
        {
            _jobDbContext.Jobs.Add(t);
        }

        public List<Job> GetAll()
        {
            return _jobDbContext.Jobs.Select(t=>t).ToList();
        }

        public Job GetById(int id)
        {
            return _jobDbContext.Jobs.FirstOrDefault(t => t.JobId == id);
        }

        public void Remove(Job t)
        {
            _jobDbContext.Jobs.Remove(t);
        }

        public void Update(Job t)
        {
            _jobDbContext.Jobs.Update(t);
        }
    }
}
