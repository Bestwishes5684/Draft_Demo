using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Draft_Demo.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            MaterialSupplier = new HashSet<MaterialSupplier>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Inn { get; set; }
        public DateTime StartDate { get; set; }
        public int? QualityRating { get; set; }
        public string SupplierType { get; set; }

        public virtual ICollection<MaterialSupplier> MaterialSupplier { get; set; }
    }
}
