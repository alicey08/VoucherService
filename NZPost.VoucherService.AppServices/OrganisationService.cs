using NZPost.VoucherService.Infrastructure;
using NZPost.VoucherService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NZPost.VoucherService.AppServices
{
    public class OrganisationService
    {
        private readonly IUnitOfWork uow;
        
        public OrganisationService(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public List<Organisation> GetAllActiveOrganisations()
        {
            return uow.Organisations.Where(o=>o.Active==true).ToList();
        }

        public List<Organisation> SearchOrganisations(int? organisationId,string accountNumber,string apiKey)
        {
            return uow.Organisations.ToList();
        }

        public void AddOrganisation(Organisation organisation)
        {
            uow.Organisations.Add(organisation);
            uow.SaveChanges();
        }

        public void UpdateOrganisation(Organisation organisation)
        {

        }
    }
}
