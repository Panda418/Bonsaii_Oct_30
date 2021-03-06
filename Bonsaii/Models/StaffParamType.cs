namespace Bonsaii.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StaffParamType")]
    public partial class StaffParamType
    {
        public StaffParamType()
        {
            StaffParam = new HashSet<StaffParam>();
        }

        [Display(Name="参数类型")]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "参数类型")]
        public string Name { get; set; }
        public virtual ICollection<StaffParam> StaffParam { get; set; }
    }
}
