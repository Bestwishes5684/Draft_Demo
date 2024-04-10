using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Draft_Demo.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductCostHistory = new HashSet<ProductCostHistory>();
            ProductMaterial = new HashSet<ProductMaterial>();
            ProductSale = new HashSet<ProductSale>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int? ProductTypeId { get; set; }
        public string ArticleNumber { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public int? ProductionPersonCount { get; set; }
        public int? ProductionWorkshopNumber { get; set; }
        public decimal MinCostForAgent { get; set; }

        public virtual ProductType ProductType { get; set; }
        public virtual ICollection<ProductCostHistory> ProductCostHistory { get; set; }
        public virtual ICollection<ProductMaterial> ProductMaterial { get; set; }
        public virtual ICollection<ProductSale> ProductSale { get; set; }
    }
}
