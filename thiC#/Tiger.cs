using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThi2
{
     class Tiger: Animal
    {
        public Tiger(int weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }
        public override void Show()
        {
            Console.WriteLine("Name: " + name + ", Weight: " +  weight);
        }
    }
}
