using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Nhan2SoNguyenLon
{
    internal class Nhan2SoNguyenLon
    {
        static void Main()
        {
            BigInteger num1, num2;

            Console.Write("Nhap so nguyen lon thu nhat: ");
            string input1 = Console.ReadLine();
            BigInteger.TryParse(input1, out num1);

            Console.Write("Nhap so nguyen lon thu hai: ");
            string input2 = Console.ReadLine();
            BigInteger.TryParse(input2, out num2);

            BigInteger result = num1 * num2;

            Console.WriteLine("Ket qua: " + result);
        }
    }

}
