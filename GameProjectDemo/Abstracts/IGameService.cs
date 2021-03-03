using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Abstracts
{
    public interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);

    }
}
