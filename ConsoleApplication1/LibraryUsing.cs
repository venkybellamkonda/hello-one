using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;


namespace ConsoleApplication1
{
    class LibraryUsing
    {
        static void Main()
        {
            Class1 obj = new Class1();
            obj.calculateSum(4, 5);
            obj.calculateSqrt(9);
        }
    }
}
