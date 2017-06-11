using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechJobs.Models;

namespace TechJobs.ViewModels
{
    public class JobViewModel
    {
        public string Name { get; set; }
        public Employer Employer { get; set; }
        public Location Location { get; set; }
        public CoreCompetency CoreCompetency { get; set; }
        public PositionType PositionType { get; set; } 

        public JobViewModel(Job job)
        {
            Name = job.Name;
            Employer = job.Employer;
            Location = job.Location;
            CoreCompetency = job.CoreCompetency;
            PositionType = job.PositionType;

        }
    }


}
