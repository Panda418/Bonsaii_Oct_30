 using System;
 using System.Collections.Generic;
 using System.ComponentModel.DataAnnotations;
 using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
namespace Bonsaii.Models
{
    [Table("StaffArchives")]
    public class StaffArchive
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "���������")]
        [StringLength(4)]
        public string BillTypeNumber { get; set; }

        [Required]
        [Display(Name = "�����������")]
        [StringLength(10)]
        public string BillTypeName { get; set; }

        [Required]
        [Display(Name = "����")]
        [StringLength(50)]
        public string BillNumber { get; set; }

        [Required]
        [Display(Name = "Ա������")]
        [StringLength(50)]
        public string StaffNumber { get; set; }

        [Required]
        [Display(Name = "����")]
        [StringLength(50)]
        public string StaffName { get; set; }

        [Display(Name = "��ְ����")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        [Column(TypeName = "date")]
        public DateTime? LeaveDate { get; set; }

        [Required]
        [Display(Name = "�ٴ���ְ����")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        [Column(TypeName = "date")]
        public DateTime? ReApplyDate { get; set; }
        [Display(Name = "��ע")]
        [StringLength(200)]
        public string Remark { get; set; }
    }
}
