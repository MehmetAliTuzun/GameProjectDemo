using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Abstracts;

namespace GameProjectDemo.Entities
{
    public class Game:IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string DevName { get; set; }
        public double Price { get; set; }
        public string CustomerName { get; set; }
    }
}
