using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Abstracts
{
    public interface ICustomerService
    {
        void SignIn(Customer customer);
        void UpdateProfile(Customer customer);
        void DeleteProfile(Customer customer);
    }
}
