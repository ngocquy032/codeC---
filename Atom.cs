using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    internal class Atom
    {
        private int atomicNumber;
        private string symbol;
        private string fullName;
        private double atomicWeight;

        public bool accept()
        {
            Console.Write("Nhập số nguyên tử: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out atomicNumber))
            {
                Console.WriteLine("Dữ liệu không hợp lệ. Vui lòng nhập một số nguyên hợp lệ cho số nguyên tử.");
                return false;
            }

            Console.Write("Nhập ký hiệu: ");
            symbol = Console.ReadLine();

            Console.Write("Nhập tên đầy đủ: ");
            fullName = Console.ReadLine();

            Console.Write("Nhập khối lượng nguyên tử: ");
            input = Console.ReadLine();
            if (!double.TryParse(input, out atomicWeight))
            {
                Console.WriteLine("Dữ liệu không hợp lệ. Vui lòng nhập một số thực hợp lệ cho khối lượng nguyên tử.");
                return false;
            }

            return true;
        }

        public void display()
        {
            Console.WriteLine($"{atomicNumber,-3} {symbol,-3} {fullName,-10} {atomicWeight}");
        }
    }
}
