using System;
using System.Collections.Generic;
using System.Text;

namespace Примеры
{
    class Dicts
    {
        void Test()
        {
            Dictionary<int, string> countries = new Dictionary<int, string>(5);
            countries.Add(2, "USA");
            countries.Add(1, "Russia");
            countries.Add(3, "Great Britain");
            countries.Add(4, "France");
            countries.Add(5, "China");
        }
    }
}
