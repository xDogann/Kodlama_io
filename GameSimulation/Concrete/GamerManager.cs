using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSimulation.Entities;
using GameSimulation.Abstract;

namespace GameSimulation.Concrete
{
    public class GamerManager : IGamerService
    {
       

        public void Add(Gamer gamer)
        {
            Console.WriteLine("{0} {1} Adlı oyuncu sisteme başarıyla eklendi.",gamer.FirstName, gamer.LastName);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("{0} {1} Adlı oyuncu sistemden başarıyla silindi.",gamer.FirstName,gamer.LastName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("{0} {1} Adlı oyuncu sistemde başarıyla düzenlendi.", gamer.FirstName, gamer.LastName);
        }
    }
}
