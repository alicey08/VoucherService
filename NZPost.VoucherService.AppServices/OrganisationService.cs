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

        public List<Organisation> GetAllOrganisations()
        {
            return uow.Organisations.ToList();
        }
    }
}
