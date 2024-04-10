using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Draft_Demo.Models
{
    public partial class Material
    {
        public Material()
        {
            MaterialCountHistory = new HashSet<MaterialCountHistory>();
            MaterialSupplier = new HashSet<MaterialSupplier>();
            ProductMaterial = new HashSet<ProductMaterial>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int? CountInPack { get; set; }
        public string Unit { get; set; }
        public double? CountInStock { get; set; }
        public double? MinCount { get; set; }
        public string Description { get; set; }
        public decimal? Cost { get; set; }
        public byte[]? Image { get; set; }
        public int MaterialTypeId { get; set; }

        public virtual MaterialType MaterialType { get; set; }
        public virtual ICollection<MaterialCountHistory> MaterialCountHistory { get; set; }
        public virtual ICollection<MaterialSupplier> MaterialSupplier { get; set; }
        public virtual ICollection<ProductMaterial> ProductMaterial { get; set; }

     
    }
}
