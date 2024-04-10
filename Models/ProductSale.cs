using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Draft_Demo.Models
{
    public partial class ProductSale
    {
        public int Id { get; set; }
        public int AgentId { get; set; }
        public int ProductId { get; set; }
        public DateTime SaleDate { get; set; }
        public int ProductCount { get; set; }

        public virtual Agent Agent { get; set; }
        public virtual Product Product { get; set; }
    }
}
