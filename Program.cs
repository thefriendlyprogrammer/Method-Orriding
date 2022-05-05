using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overrinduing
{

    class Test
    {
        public  void test()
        {
            Console.WriteLine("this is test method Prt");
        }
    }
    class Test1 : Test
    {
        public override void test()
        {
            Console.WriteLine("this is test method child");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test1 obj = new Test1();
            obj.test();
            Console.ReadLine();


        }
    }
}
