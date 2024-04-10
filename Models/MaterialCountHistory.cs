using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Draft_Demo.Models
{
    public partial class MaterialCountHistory
    {
        public int Id { get; set; }
        public int MaterialId { get; set; }
        public DateTime ChangeDate { get; set; }
        public double CountValue { get; set; }

        public virtual Material Material { get; set; }
    }
}
