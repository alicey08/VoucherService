using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace NZPost.VoucherService.Model
{
    public class UserAccess
    {
        public int Id { get; set; }

        [Required]
        public User User { get; set; }

        [Required]
        public Access Access { get; set; }
    }
}
