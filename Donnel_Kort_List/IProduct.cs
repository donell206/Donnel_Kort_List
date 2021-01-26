using System;
using System.Collections.Generic;
using System.Text;

namespace Donnel_Kort_List
{
    public interface IProduct
    {
        string Merk { get; set; }
        string Naam { get; set; }
        string Volume { get; set; }
        string GetCode();
    }
}
