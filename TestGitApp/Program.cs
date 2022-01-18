using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine(Add(5,7));

            Console.ReadKey();
        }


        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
