using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Draft_Demo.Models
{
    public partial class Agent
    {
        public Agent()
        {
            AgentPriorityHistory = new HashSet<AgentPriorityHistory>();
            ProductSale = new HashSet<ProductSale>();
            Shop = new HashSet<Shop>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int AgentTypeId { get; set; }
        public string Address { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string DirectorName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Logo { get; set; }
        public int Priority { get; set; }

        public virtual AgentType AgentType { get; set; }
        public virtual ICollection<AgentPriorityHistory> AgentPriorityHistory { get; set; }
        public virtual ICollection<ProductSale> ProductSale { get; set; }
        public virtual ICollection<Shop> Shop { get; set; }
    }
}
