using System;
using System.Collections;

namespace Collections {

    class Program {

        static void Main(string[] args) 
        {
            // ArrayList

            // non-generic => object
            // dinamik

            ArrayList liste = new ArrayList();

            liste.Add(10);    //1.  Elemanı
            liste.Add("10");  //2.  Elemanı
            liste.Add("ali"); //3   Elemanı
            liste.Add(null);  //4.  Elemanı
            liste.Add(true);  //5.  Elemanı

            var liste2 = new ArrayList() {
                5,
                "ahmet",
                false,
                4.5,
                null
            };

            int[] sayilar = {10,20,30};
            
            liste.AddRange(sayilar);

            var eleman = (int)liste[0];
            var isim = liste[2].ToString();

            // insert
            liste.Insert(1, "sadık");
            liste.InsertRange(2, liste2);

            // remove
            liste.Remove(10);
            liste.RemoveAt(2);
            liste.RemoveRange(2, 3);

            // contains, indexOf
            Console.WriteLine(liste.Contains(100));
            Console.WriteLine(liste.IndexOf(10));

            // foreach (var item in liste)
            // {
            //     Console.WriteLine(item);
            // } 
        }
    }

    
}
