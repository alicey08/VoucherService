using NZPost.VoucherService.Infrastructure;
using NZPost.VoucherService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NZPost.VoucherService.AppServices
{
    public class DepartmentService
    {
        private readonly IUnitOfWork uow;

        public DepartmentService(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public List<Department> GetAllDepartments()
        {
            return uow.Departments.ToList();
        }
    }
}
