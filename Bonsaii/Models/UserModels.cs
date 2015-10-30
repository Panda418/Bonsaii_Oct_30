namespace Bonsaii.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Users")]
    public partial class UserModels
    {
        public string Id { get; set; }

        public string Email { get; set; }

        public bool EmailConfirmed { get; set; }

        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set; }

        public string PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public bool TwoFactorEnabled { get; set; }

        public DateTime? LockoutEndDateUtc { get; set; }

        public bool LockoutEnabled { get; set; }

        public int AccessFailedCount { get; set; }

        [Display(Name="����Ա����")]
        [StringLength(256)]
        public string UserName { get; set; }

        [Required]
        [StringLength(128)]
        public string Discriminator { get; set; }

        [Display(Name="��ҵ���")]
        [StringLength(10)]
        public string CompanyId { get; set; }
        [Display(Name="��ҵȫ��")]
        public string CompanyFullName { get; set; }

        public string ConnectionString { get; set; }

        [Display(Name="�Ƿ���Ч")]
        public bool IsAvailable { get; set; }
        [Display(Name="���״̬")]
        public bool IsProved { get; set; }

        [Display(Name="ע���û�")]
        public bool IsRoot { get; set; }
    }
}
