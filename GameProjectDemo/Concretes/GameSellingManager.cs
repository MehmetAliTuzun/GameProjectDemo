using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using GameProjectDemo.Abstracts;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Concretes
{
    public class GameSellingManager:IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Your game: " + game.GameName +" has added successfully.");
            
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Your game: " + game.GameName + " has deleted successfully.");
        }
    }
}
