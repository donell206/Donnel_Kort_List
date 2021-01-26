using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Donnel_Kort_List
{
    public class Product : IProduct
    {

        private string merk;

        public string Merk
        {
            get { return merk; }
            set { merk = value; }
        }

        private string naam
;

        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }


        private string volume;

        public string Volume
        {
            get { return volume; }
            set { volume = value; }
        }




        public Product(string merk, string naam, string volume)
        {
            Merk = merk;
            Naam = naam;
            Volume = volume;
        }

        

        public string GetCode()
        {
            string result=null;

            if (true)
            {
                result = Merk.Substring(1, 3) + Naam.Substring(1, 3);
               

            }
            
           

            return result;
        }

      





    }
}
