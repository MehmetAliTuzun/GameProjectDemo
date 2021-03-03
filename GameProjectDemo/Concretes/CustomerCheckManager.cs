using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Abstracts;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Concretes
{
    public class CustomerCheckManager:ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
