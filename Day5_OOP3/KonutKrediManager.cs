﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_OOP3
{
    internal class KonutKrediManager : IKrediManager
    {
        // Kuralların içeriğini Krediye özgü değiştiriyoruz
        public void BirseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut Kredisi hesaplanıyor..");
        }
    }
}
