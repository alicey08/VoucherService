using NZPost.VoucherService.Infrastructure;
using NZPost.VoucherService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NZPost.VoucherService.AppServices
{
    public class CampaignService
    {
        private readonly IUnitOfWork uow;

        public CampaignService(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public List<Campaign> GetAllCampaigns()
        {
            return uow.Campaigns.ToList();
        }

        public Campaign GetCampaignDetails(int campaignId)
        {
            return uow.Campaigns.Where(c => c.Id == campaignId).FirstOrDefault();
        }

        public List<Campaign> SearchCampaigns(int? organisationId,int? departmentId,int? campaignId)
        {
            return uow.Campaigns.ToList();
        }

        public void AddCampaign(Campaign campaign)
        {
            uow.Campaigns.Add(campaign);
            uow.SaveChanges();
        }

        public void UpdateCampaign(Campaign campaign)
        {
            uow.SaveChanges();
        }

        public void GetCampaignSuccessReport()
        {
        }
    }
}
