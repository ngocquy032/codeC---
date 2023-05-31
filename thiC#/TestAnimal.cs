using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThi2
{
    internal class TestAnimal
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion(150, "Lion");
            Tiger tiger = new Tiger(10, "Tiger");

            lion.Show();
            tiger.Show();
            Console.ReadLine();
        }
    }
}
