using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atom[] atoms = new Atom[3];
            int count = 0;

            Console.WriteLine("Thông tin nguyên tử");
            Console.WriteLine("==================");

            while (count < atoms.Length)
            {
                atoms[count] = new Atom();
               if (!atoms[count].accept())
                {
                    continue;
               }

                count++;

                if (count == atoms.Length)
                {
                    break;
                }

            }

            Console.WriteLine("No Sym Name       Weight");
            Console.WriteLine("------------------------------------");
            for (int i = 0; i < count; i++)
            {
                atoms[i].display();
            }
        }
    }
}
