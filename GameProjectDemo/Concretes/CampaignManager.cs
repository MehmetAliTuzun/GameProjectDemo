using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Abstracts;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Concretes
{
    class CampaignManager:ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign successfully added : " + campaign.CampaignName);
        }

        public void BuyWithCampaign(Game game, Campaign campaign, Customer customer)
        {
            Console.WriteLine(customer.FirstName + " purchased the " + game.GameName + " game with % " + campaign.DiscountPercent + " discount using the " + campaign.CampaignName + " campaign. New price is: " + (game.Price - ((game.Price * campaign.DiscountPercent)/100)));
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign successfully deleted : " + campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign successfully updated : " + campaign.CampaignName);
        }
    }
}
