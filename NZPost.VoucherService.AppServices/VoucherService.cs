using NZPost.VoucherService.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NZPost.VoucherService.AppServices
{
    public class VoucherService
    {
       private readonly IUnitOfWork uow;

       public VoucherService(IUnitOfWork uow)
        {
            this.uow = uow;
        }

       public void UpdateVoucherStatus(long voucherId,string statusName)
       {
           var voucher = uow.Voucheres.Where(v => v.Id == voucherId).FirstOrDefault();
           var status = uow.Statuses.Where(s => s.Name == statusName).First();
           voucher.Status = status;
           uow.SaveChanges();
       }
        public void ReissueVoucher(long voucherId)
        {
            UpdateVoucherStatus(voucherId, "issued");
        }
        public void InactivateVoucher(long voucherId)
        {
            UpdateVoucherStatus(voucherId, "Inactive");
        }
        public bool ValidateVoucher(string voucherCode)
        {
            return true;
        }

        public void RedeemVoucher(string voucherCode)
        {

        }
    }
}
