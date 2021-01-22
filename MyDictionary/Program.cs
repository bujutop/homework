using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> musteriListesi = new MyDictionary<int, string>();
            musteriListesi.Add(00123, "Nurettin Ayıpettin");
            musteriListesi.Add(456836, "Bazı İnsanlar");
            musteriListesi.Add(452645, "Çeşitli İsimler");

            Console.WriteLine("Toplam müşteri sayısı: {0}",musteriListesi.Count);

            for(int i = 0; i < musteriListesi.Count; i++) 
            {
                Console.WriteLine("Müşteri No: {0}",musteriListesi.Keys[i]);
               
            }

            foreach (var values in musteriListesi.Values)
            {
                Console.WriteLine("Müsteri Adı: {0}",values);
            }
            

            


           
        }
    }
}
