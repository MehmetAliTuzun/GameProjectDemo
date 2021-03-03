using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Abstracts;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Concretes
{
    public class CustomerManager:BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void SignIn(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.SignIn(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }
    }
}
