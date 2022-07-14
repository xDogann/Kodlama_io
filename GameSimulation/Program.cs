using System;
using GameSimulation.Entities;
using GameSimulation.Abstract;
using GameSimulation.Concrete;

namespace GameSimulation // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer
            {
                Id = 1, NationalityId = "4565465465",
                FirstName = "Abdüssamed", LastName = "Doğan", DateOfBirth = new DateTime(2004, 10, 20)
            };

            ItemSales itemSales=new ItemSales
            {
                FirstName="Burakhan",LastName="Bal",
                ItemSalesId = 2,ItemSalesTime= DateTime.Now, 
                ItemSalesName="Ejderha Koleksiyonu"
            };

            Offer offer = new Offer
            {
                FirstName = "Akyel", LastName = "Yıldız",
                OfferId = 4, OfferTime = DateTime.Now,
                OfferName = "Tüm Koleksiyonlarda %25 İndirim!"

            };

            GamerManager gamerManager =  new GamerManager();
            gamerManager.Add(gamer);
            gamerManager.Update(gamer);
            gamerManager.Delete(gamer);

            Console.WriteLine("\n---\n");

            OfferManager offerManager=new OfferManager();
            offerManager.Add(offer);
            offerManager.Update(offer);
            offerManager.Delete(offer);
        }
    }
}
