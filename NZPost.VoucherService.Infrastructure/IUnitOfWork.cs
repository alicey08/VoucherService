using NZPost.VoucherService.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace NZPost.VoucherService.Infrastructure
{
    public interface IUnitOfWork
    {
        IDbSet<Organisation> Organisations { get; }
        IDbSet<Department> Departments { get; }
        IDbSet<Access> Accesses { get; }
        IDbSet<Batch> Batches { get; }
        IDbSet<Campaign> Campaigns { get; }
        IDbSet<Status> Statuses { get; }
        IDbSet<User> Users { get; }
        IDbSet<UserAccess> UserAccesses { get; }
        IDbSet<Voucher> Voucheres { get; }
        IDbSet<VoucherRedemptionHistory> VoucherRedemptionHistories { get; }

        int SaveChanges();
    }
}
