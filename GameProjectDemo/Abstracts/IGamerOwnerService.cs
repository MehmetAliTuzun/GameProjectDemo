using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Abstracts
{
    public interface IGamerOwnerService
    {
        void Owner(Customer customer, Game game);
    }
}
