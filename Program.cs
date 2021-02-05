using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PI_Works_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            Stack st = new Stack();

            st.Push(a);
            st.Push(b);

            a = (int)st.Pop();
            b = (int)st.Pop();

            Console.WriteLine ("1st variable {0}" ,a);
            Console.WriteLine("2st variable {0}", b);
            Console.ReadKey();





        }
    }
}
