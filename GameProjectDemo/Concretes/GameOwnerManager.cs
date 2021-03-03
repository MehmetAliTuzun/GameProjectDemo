using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Abstracts;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Concretes
{
    public class GameOwnerManager:IGamerOwnerService
    {
        public void Owner(Customer customer, Game game)
        {
            Console.WriteLine(customer.FirstName + " bought to " + game.GameName + " for " + game.Price+".");
        }
    }
}
