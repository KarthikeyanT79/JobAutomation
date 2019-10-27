using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Web.Http.Cors;
using JobAutomation.Business;
using JobAutomation.Dto;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobAutomationAPI.Controllers
{
    [Route("api/[controller]")]
    //[EnableCors(origins: "https://localhost:44311", headers: "*", methods: "*")]
    
    [ApiController]
    public class JobController : ControllerBase
    {

        private IJobService _jobServices;

        public JobController(IJobService jobServices)
        {
            _jobServices = jobServices;
        }

        [HttpPost("AddJob")]
        public void AddJob(JobDto job)
        {

        }

        [HttpPost("UpdateJob")]
        public void UpdateJob(JobDto job)
        {

        }

        [HttpGet("GetJobs")]
        public List<JobDto> GetJobs( )
        {
            
            return _jobServices.GetAllJobs(); 
        }
    }
}