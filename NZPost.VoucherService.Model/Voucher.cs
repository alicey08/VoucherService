using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace NZPost.VoucherService.Model
{
    public class Voucher
    {
        public int Id { get; set; }

        [StringLength(100)]
        [Required]
        public string Code { get; set; }

        [Required]
        public Batch Batch { get; set; }

        [Required]
        public Status Status { get; set; }
    }
}
