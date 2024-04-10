using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Draft_Demo.Models
{
    public partial class MaterialType
    {
        public MaterialType()
        {
            Material = new HashSet<Material>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public double DefectedPercent { get; set; }

        public virtual ICollection<Material> Material { get; set; }
    }
}
