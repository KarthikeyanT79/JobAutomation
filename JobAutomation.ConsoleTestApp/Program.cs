using JobAutomation.EntityModel;
using System;

namespace JobAutomation.ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            JobDbContext jobDbContext = new JobDbContext();

            foreach (var item in jobDbContext.Jobs)
            {
                int jobId = item.JobId;
            }
       
            //Console.WriteLine("Hello World!");
        }
    }
}
