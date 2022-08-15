using System.Collections.Generic;

namespace Factory.Models
{
    public class Machine
    {
        public Machine()
        {
            this.Certifications = new HashSet<MachineEngineer>();
        }

        public int MachineId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<MachineEngineer> Certifications { get; set; }
    }
}