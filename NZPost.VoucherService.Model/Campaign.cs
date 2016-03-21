using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace NZPost.VoucherService.Model
{
    public class Campaign
    {
        public int Id { get; set; }

        [StringLength(100)]
        [Required]
        public string Name { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }
        
        [Required]
        public DateTime StartDate { get; set; }
       
        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public bool OneOff { get; set; }

        [StringLength(1000)]
        [Required]
        public string ReturnValue { get; set; }

        [Required]
        public float Fee { get; set; }

        [StringLength(100)]
        public string VoucherCode { get; set; }

        [Required]
        public Department Department { get; set; }
    }
}
