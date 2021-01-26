using System;
using System.Collections.Generic;

namespace Donnel_Kort_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> ProductList = new List<Product>();

   
                ProductList.Add(new Product ( "Cola",  "Zero",  "150 ml" ));
                ProductList.Add(new Product ( "Fanta", "Lemon", "1000 ml" ));
                ProductList.Add(new Product ( "Soda", "Gas", "150 ml"));



            foreach (var prod in ProductList)
            {
                Console.WriteLine("{0},{1},{2}",prod.Merk, prod.Naam, prod.Volume);
            }
            


        }
    }
}
