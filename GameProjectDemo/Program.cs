using System;
using System.Dynamic;
using GameProjectDemo.Abstracts;
using GameProjectDemo.Concretes;
using GameProjectDemo.Entities;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.DateOfBirth = new DateTime(2002, 05, 24);
            customer1.Id = 465312;
            customer1.FirstName = "Mehmet Ali";
            customer1.LastName = "Tüzün";
            customer1.NatId = "23623104214";

            CustomerManager customerManager = new CustomerManager(new CustomerCheckManager());
            customerManager.SignIn(customer1);

            Console.WriteLine("-----------------------------------");

            Game game1 = new Game();
            game1.CustomerName = nameof(customer1);
            game1.DevName = "CDPR";
            game1.GameName = "W3";
            game1.Id = 963258;
            game1.Price = 59.99;

            GameSellingManager gameSellingManager = new GameSellingManager();
            gameSellingManager.Add(game1);

            GameOwnerManager gameOwnerManager = new GameOwnerManager();
            gameOwnerManager.Owner(customer1, game1);
            Console.WriteLine("-----------------------------------");

            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.CampaignName = "If you got, you got!";
            campaign1.DiscountPercent = 35;

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            Console.WriteLine("-----------------------------------");

            campaignManager.BuyWithCampaign(game1, campaign1, customer1);
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("....THANK YOU FOR YOUR SHOPPING....");







        }
    }
}
