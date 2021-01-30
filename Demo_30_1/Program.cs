using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_30_1
{
    public delegate void FadA(int x);//FadiA

    class Program
    {
        public  void Dummy(int x)
        {
            Console.WriteLine(x + 9);
        }
        public static  string str(int x)
        {
            string res ="String x= " +x.ToString();
            return res;
        }
        public static ref int ChristeenB(ref int b)
        {
            b += 1;

            return ref b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Program.str(10));
            int y = 12;
            int x=ChristeenB(ref y);
            Class1 cls = new Class1();
            cls.Execute();
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
 
}
