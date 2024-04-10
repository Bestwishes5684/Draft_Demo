using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Draft_Demo.Models
{
    public partial class AgentPriorityHistory
    {
        public int Id { get; set; }
        public int AgentId { get; set; }
        public DateTime ChangeDate { get; set; }
        public int PriorityValue { get; set; }

        public virtual Agent Agent { get; set; }
    }
}
