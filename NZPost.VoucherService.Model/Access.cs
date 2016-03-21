using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace NZPost.VoucherService.Model
{
    public class Access
    {
        public int Id { get; set; }

        [StringLength(100)]
        [Required]
        public string ScreenName { get; set; }

    }
}
