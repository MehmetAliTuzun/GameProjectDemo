using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Abstracts;

namespace GameProjectDemo.Entities
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public string NatId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
