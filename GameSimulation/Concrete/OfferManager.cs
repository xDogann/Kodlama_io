using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSimulation.Entities;
using GameSimulation.Abstract;

namespace GameSimulation.Concrete
{
    public class OfferManager : IOfferService
    {
        

        public void Add(Offer offer)
        {
            Console.WriteLine("{0}, adlı kampanya sisteme başarıyla eklendi.", offer.OfferName);
        }

        public void Update(Offer offer)
        {
            Console.WriteLine("{0}, adlı kampanya başarıyla düzenlendi.", offer.OfferName);
        }

        public void Delete(Offer offer)
        {
            Console.WriteLine("{0}, adlı kampanya başarıyla silindi.", offer.OfferName);
        }
    }
}
