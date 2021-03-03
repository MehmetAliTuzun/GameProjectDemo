using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Abstracts
{
    public abstract class BaseCustomerManager:ICustomerService
    {
        public virtual void SignIn(Customer customer)
        {
            Console.WriteLine("Congratulations! Registration Successful.");
            Console.WriteLine(customer.FirstName + " " + customer.LastName );
        }

        public virtual void UpdateProfile(Customer customer)
        {
            Console.WriteLine("Profile Update Successful!");
        }

        public virtual void DeleteProfile(Customer customer)
        {
            Console.WriteLine("Your registration has been successfully deleted.");
        }
    }
}
