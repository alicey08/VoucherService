using NZPost.VoucherService.AppServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NZPost.VoucherService.Admin.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private OrganisationService organisationService;
      
        public HomeController (OrganisationService organisationService)
        {
            this.organisationService = organisationService; 
        }
        public ActionResult Index()
        {
            ViewBag.Message = organisationService.GetAllOrganisations().First().Name;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
