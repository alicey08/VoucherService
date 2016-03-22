using NZPost.VoucherService.Infrastructure;
using NZPost.VoucherService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NZPost.VoucherService.AppServices
{
    public class BatchService
    {
        private readonly IUnitOfWork uow;

        public BatchService(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public List<Batch> GetAllBatches()
        {
            return uow.Batches.ToList();
        }

        public List<Batch> SearchBatches(int? organisatinId, int? DepartmentId, int? campaignId, int? batchId, string voucherCode, int? createdByUserId, DateTime? createdDateFrom, DateTime? createdDateTo)
        {
            //add all the search criteria here

            return uow.Batches.ToList();
        }

        public Batch GetBatchDetails(int batchId)
        {
            return uow.Batches.Where(b => b.Id == batchId).SingleOrDefault();
        }
    }
}
