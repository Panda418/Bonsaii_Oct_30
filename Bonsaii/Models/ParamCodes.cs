namespace Bonsaii.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ParamCodes
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Display(Name="���뷽ʽ")]
        [StringLength(20)]
        public string CodeMethod { get; set; }

        [Display(Name="������ʽ")]
       
        [StringLength(10)]
        public string Code { get; set; }

        public int? Year { get; set; }

        public int? Month { get; set; }

        public int? Day { get; set; }

        public int? SerialNumber { get; set; }

        [Display(Name="��������")]
        [Column(Order = 1)]
        [StringLength(20)]
        public string ParamName { get; set; }
    }
}
