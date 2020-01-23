using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex212
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数値を入力");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0) {
                Console.WriteLine("2の倍数です");
            }
            if (a % 3 == 0) {
                Console.WriteLine("3の倍数です");
            }
            if(a % 2 == 0 && a % 3 == 0)
            {
                Console.WriteLine("2と3の公倍数です");
            }
            Console.WriteLine("コミットテスト");
        }
    }
}
