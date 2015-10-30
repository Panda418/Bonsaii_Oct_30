using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
namespace Bonsaii.Models
{
    [Table("BillProperties")]
    public partial class BillPropertyModels
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "�������")]
        [RegularExpression("[0-9]{4}", ErrorMessage = "������4λ��{0}")]
        public string Type { get; set; }
        [Required]
        [Display(Name = "��������")]
        [StringLength(50)]
        public string TypeName { get; set; }
        [Display(Name = "����ȫ��")]
        [StringLength(50)]
        public string TypeFullName { get; set; }

        [Display(Name = "���ݱ��뷽ʽ")]
        public string CodeMethod { get; set; }

        [StringLength(10)]
        [Display(Name = "������ʽ")]
        public string Code { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }

        public int Day { get; set; }

        public int SerialNumber { get; set; }
        [Display(Name = "�Զ����")]
        public bool IsAutoAudit { get; set; }
        [Display(Name = "����������")]
        public bool IsApprove { get; set; }
        [Display(Name = "�����޶������û�")]
        public bool IsLimitInput { get; set; }
        [Display(Name = "���Ӽ���")]
        public bool IsAscOrDesc { get; set; }

        public int Count { get; set; }
    }
}
