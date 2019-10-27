using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobAutomation.EntityModel
{
    public class JobDbContext : DbContext
    {
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobGroup> JobGroup { get; set; }
        public DbSet<JobGropJobMapping> JobGropJobMapping { get; set; }

        public DbSet<JobProcess> JobProcess { get; set; }

        public DbSet<JobParameter> JobParameter { get; set; }


        public DbSet<JobProcessParamters> JobProcessParamters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlite(@"Data Source=C:\HardWork\JobAAutomation\JobAutomation.sdb;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
            modelBuilder.Entity<Job>().ToTable("Job");
            modelBuilder.Entity<JobGroup>().ToTable("JobGroup");
            modelBuilder.Entity<JobGropJobMapping>().ToTable("JobGropJobMapping");
            modelBuilder.Entity<JobProcess>().ToTable("JobProcess");
            modelBuilder.Entity<JobParameter>().ToTable("JobParameter");
            modelBuilder.Entity<JobProcessParamters>().ToTable("JobProcessParamters");
        }

        

    }
}
