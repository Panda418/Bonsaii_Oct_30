 using System;
 using System.Collections.Generic;
 using System.ComponentModel.DataAnnotations;
 using System.ComponentModel.DataAnnotations.Schema;
 using System.Data.Entity.Spatial;

namespace Bonsaii.Models
{
    [Table("StaffApplications")]
    public class StaffApplications
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name="���������")]
        [StringLength(4)]
        public string BillTypeNumber { get; set; }

        [Required]
        [Display(Name="�����������")]
        [StringLength(10)]
        public string BillTypeName { get; set; }

        [Required]
        [Display(Name="����")]
        [StringLength(50)]
        public string BillNumber { get; set; }
        [Required]
        [Display(Name = "Ա������")]
        [StringLength(50)]
        public string StaffNumber { get; set; }
        [Display(Name = "����")]
        [StringLength(100)]
        public string StaffName { get; set; }
        [Display(Name="��������")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        [Column(TypeName = "date")]
        public DateTime? ApplyDate { get; set; }
        [Display(Name = "������ְ����")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        [Column(TypeName = "date")]
        public DateTime? HopeLeaveDate { get; set; }
        [Display(Name="��ְ���")]
        [StringLength(50)]
        public string LeaveType { get; set; }
        [Display(Name = "��ְԭ��")]
        [StringLength(200)]
        public string LeaveReason { get; set; }
        [Display(Name="��ע")]
        [StringLength(200)]
        public string Remark { get; set; }
        [Display(Name="״̬")]
        [StringLength(50)]
        public string AuditStatus { get; set; }
    }
}
