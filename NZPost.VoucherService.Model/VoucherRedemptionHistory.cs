using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace NZPost.VoucherService.Model
{
    public class VoucherRedemptionHistory
    {
        public int Id { get; set; }

        [Required]
        public Voucher Voucher { get; set;}

        public DateTime RedemptionDateTime { get; set; }

        [StringLength(100)]
        public string IpAddress { get; set; }

         [StringLength(100)]
        public string APIKey { get; set; }

         [StringLength(100)]
         public string VoucherCode { get; set; }

         [StringLength(100)]
         public string CallingSystem { get; set; }

         [StringLength(1000)]
         public string AdditionalInfo { get; set; }
    }
}
