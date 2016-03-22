using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace NZPost.VoucherService.Model
{
    public class Batch
    {
        public int Id { get; set; }

        [StringLength(100)]
        [Required]
        public string Name { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }
      
        [Required]
        public int NoOfVouchers { get; set; }
      
        [Required]
        public DateTime CreatedDateTime { get; set; }

        [Required]
        public User CreatedByUser { get; set; }

        [Required]
        public Campaign Campaign { get; set; }

        public virtual List<Voucher> Vouchers { get; set; }

       
    }
}
