using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Draft_Demo.Models
{
    public partial class MaterialSupplier
    {
        public int MaterialId { get; set; }
        public int SupplierId { get; set; }

        public virtual Material Material { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
