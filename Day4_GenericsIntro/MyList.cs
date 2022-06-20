using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_GenericsIntro
{
    internal class MyList<T>
    {
        T[] items; // Listemizin tutulduğu dizi(array)
        T[] tempArray; // Litemizin sayısını arttırırken geçici olarak, liste verilerini burada tutulur


        //Constructer
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            tempArray = items; //Verileri geçici diziye atıyoruz.
            items = new T[items.Length + 1]; // dizimizin 1  arttırıyoruz.

            for (int i = 0; i < tempArray.Length; i++) // Geçici dizide ki verileri, ana dizimize atıyoruz
            {
                items[i] = tempArray[i];
            }
        }


        // propfull ile kendi Lenght özelliğimizi oluşturuyoruz.
        public int Count
        {
            get { return items.Length; }
 
        }

    }
}
