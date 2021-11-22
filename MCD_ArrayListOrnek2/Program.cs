using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MCD_ArrayListOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayListte tip yok.
            ArrayList listem = new ArrayList();
            listem.Add("Faik");
            listem.Add("Turan");
            listem.Add("123456789");
            listem.Add('E');
            listem.Add(20);
            listem.Add("Esra");
            listem.Add("Turan");
            listem.Add("123456789");
            listem.Add('K');
            listem.Add(20);
            listem.Add("Arif");
            listem.Add("Turan");
            listem.Add("123456789");
            listem.Add('E');
            listem.Add(20);

            Console.WriteLine("ArrayList oluşturuldu.");
            Console.WriteLine("Yazdırılıyor.");
            foreach (var item in listem)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("ArrayList kapasitesi = " + listem.Capacity);
            listem.Remove("Faik");

            Array.ForEach(listem.ToArray(), x => Console.WriteLine(x));

        }
    }
}
