namespace Bonsaii.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReserveFields")]
    public partial class ReserveField
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [StringLength(50)]
        [Display(Name="����")]
        public string TableName { get; set; }

        [StringLength(50)]
        [Display(Name="�ֶ���")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "��������ȷ��Ӣ������")]
        public string FieldName { get; set; }

        [StringLength(50)]
        [Display(Name="����")]
        public string Description { get; set; }

        [StringLength(50)]
        [Display(Name="״̬")]
        public string Status { get; set; }
    }
}
