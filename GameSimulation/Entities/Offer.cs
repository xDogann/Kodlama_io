using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Entities
{
    public class Offer:Gamer
    {
        public int OfferId { get; set; }
        public string OfferName { get; set; }
        public DateTime OfferTime { get; set; }

    }
}
