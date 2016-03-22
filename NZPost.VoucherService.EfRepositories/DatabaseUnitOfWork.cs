using NZPost.VoucherService.Infrastructure;
using NZPost.VoucherService.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace NZPost.VoucherService.EfRepositories
{
    public class DatabaseUnitOfWork : DbContext, IUnitOfWork
    {
        public DatabaseUnitOfWork()
            : this("name=VoucherService")
        {
        }

        public DatabaseUnitOfWork(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        public IDbSet<Organisation> Organisations
        {
            get { return Set<Organisation>(); }
        }

        public IDbSet<Department> Departments
        {
            get { return Set<Department>(); }
        }

        public IDbSet<Access> Accesses
        {
            get { return Set<Access >(); }
        }
        public IDbSet<Batch> Batches
        {
            get { return Set<Batch>(); }
        }
        public IDbSet<Campaign> Campaigns
        {
            get { return Set<Campaign>(); }
        }
        public IDbSet<Status> Statuses
        {
            get { return Set<Status >(); }
        }
        public IDbSet<User> Users
        {
            get { return Set<User>(); }
        }
        public IDbSet<UserAccess> UserAccesses
        {
            get { return Set<UserAccess>(); }
        }
        public IDbSet<Voucher> Voucheres
        {
            get { return Set<Voucher>(); }
        }
        public IDbSet<VoucherRedemptionHistory> VoucherRedemptionHistories
        {
            get { return Set<VoucherRedemptionHistory>(); }
        }  
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Organisation>().ToTable("Organisation","VoucherService");
            modelBuilder.Entity<Department>().ToTable("Department", "VoucherService");
            modelBuilder.Entity<Access>().ToTable("Access", "VoucherService");
            modelBuilder.Entity<Batch>().ToTable("Batch", "VoucherService");
            modelBuilder.Entity<Campaign>().ToTable("Campaign", "VoucherService");
            modelBuilder.Entity<Status>().ToTable("Status", "VoucherService");
            modelBuilder.Entity<User>().ToTable("User", "VoucherService");
            modelBuilder.Entity<UserAccess>().ToTable("UserAccess", "VoucherService");
            modelBuilder.Entity<Voucher>().ToTable("Voucher", "VoucherService");
            modelBuilder.Entity<VoucherRedemptionHistory>().ToTable("VoucherRedemptionHistory", "VoucherService");
        }
    }
}
