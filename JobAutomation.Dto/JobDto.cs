using System;
using System.Collections.Generic;
using System.Text;

namespace JobAutomation.Dto
{
    public class JobDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        
        public DateTime CreateDate { get; set; }

        public string CreatedUser { get; set; }
    }
}
