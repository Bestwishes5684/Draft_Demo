using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Draft_Demo.Models
{
    public partial class AgentType
    {
        public AgentType()
        {
            Agent = new HashSet<Agent>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }

        public virtual ICollection<Agent> Agent { get; set; }
    }
}
