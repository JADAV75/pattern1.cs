using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    
    internal class calc
    {
        
       
        
        static void change(ref int a, ref int b)
        {
            a = 100;
           // b = 200;
        }
        static void update(out int x, out int y)
        {
            x = 100;
            y = 200;
        }
        static void main()
        {
            int a = 10, b = 20;
            int x = 10, y = 20;
            Console.WriteLine("before change : a={0} and b={1}", a,b);
            change(ref a, ref b);
            Console.WriteLine("after change  : a={0} and b={1}", a,b);

            Console.WriteLine("before update : a={0} and b={1}", a,b);
            update(out x, out y);
            Console.WriteLine("before update : a={0} and b={1}", a,b);
        }
    }
}
