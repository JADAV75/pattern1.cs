using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class calcmethods
    {
       static void swap(int a,int b)
        {
            int temp = 0;
                a = b;
                b = temp;

        }
             static void main()
        {
            int a = 10, b= 20;
            Console.WriteLine("before swaping a={0} and b={0}", a,b);
            swap(a,b);
            Console.WriteLine("after swaping a={0} and b={0}", a,b);

        } 
    }
}
