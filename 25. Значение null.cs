using System;
using System.Collections.Generic;
using System.Text;

namespace Примеры
{
    class Null
    {
        void Test()
        {
            object x = null;
            object y = x ?? 100;

            object z = 200;
            object t = z ?? 44;
        }
    }
}
