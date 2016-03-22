using NZPost.VoucherService.Admin.ViewModel;
using NZPost.VoucherService.AppServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NZPost.VoucherService.Admin.Controllers
{
    public class BatchController : Controller
    {
        private BatchService batchService;
        private OrganisationService organisationService;
        private DepartmentService departmentService;
        private CampaignService campaignService;

        public BatchController(BatchService batchService, OrganisationService organisationService, DepartmentService departmentService, CampaignService campaignService)
        {
            this.batchService = batchService;
            this.organisationService = organisationService;
            this.departmentService = departmentService;
            this.campaignService = campaignService;
        }
      
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            BatchViewModel vm = new BatchViewModel();
            vm.Organisations = organisationService.GetAllActiveOrganisations();
            vm.Departments = departmentService.GetAllDepartments();
            vm.Campaigns = campaignService.GetAllCampaigns();
            return View(vm);
        }

    }
}
