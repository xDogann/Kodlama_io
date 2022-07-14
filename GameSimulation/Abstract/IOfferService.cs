using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSimulation.Entities;

namespace GameSimulation.Abstract
{
    public interface IOfferService
    {
        void Add(Offer offer);
        void Update(Offer offer);
        void Delete(Offer offer);
    }
}
