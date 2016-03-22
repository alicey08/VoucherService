using NZPost.VoucherService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NZPost.VoucherService.Admin.ViewModel
{
    public class BatchViewModel
    {
        public List<Organisation> Organisations { get; set; }
        public int? OrganisationIdForSearch { get; set; }
        public List<Department> Departments { get; set; }
        public int? DepartmentIdForSearch { get; set; }
        public List<Campaign> Campaigns { get; set; }
        public int? CampaignIdForSearch { get; set; }
        public Campaign Campaign { get; set; }
        public string BatchName { get; set; }
        public string BatchDesc { get; set; }
        public int? NoOfVouchers { get; set; }
    }
}