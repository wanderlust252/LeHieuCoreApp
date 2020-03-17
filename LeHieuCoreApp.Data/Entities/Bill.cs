using LeHieuCoreApp.Data.Enums;
using LeHieuCoreApp.Data.Interfaces;
using LeHieuCoreApp.Infrastruture.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LeHieuCoreApp.Data.Entities
{
    [Table("Bill")]
    public class Bill : DomainEntity<int>, ISwitchable, IDateTracking
    {
        [Required]
        [MaxLength(256)]
        public string CustomerName { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerAddress { set; get; }

        [Required]
        [MaxLength(50)]
        public string CustomerMobile { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerMessage { set; get; }
        public PaymentMethod PaymentMethod { set; get; }
        public BillStatus BillStatus { set; get; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        [DefaultValue(Status.Active)]
        public Status Status { get; set; } = Status.Active;
        [StringLength(450)]
        public string CustomerId { set; get; }

        [ForeignKey("CustomerId")]
        public virtual AppUser User { set; get; }
        public virtual ICollection<BillDetail> BillDetails { set; get; }
    }
}
