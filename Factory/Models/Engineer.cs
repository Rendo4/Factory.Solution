using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Factory.Models
{
    public class Engineer
    {
        public Engineer()
        {
            this.Certifications = new HashSet<MachineEngineer>();
        }

        public int EngineerId { get; set; }
        public string Name { get; set; }
        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }

        public virtual ICollection<MachineEngineer> Certifications { get;}
    }
}