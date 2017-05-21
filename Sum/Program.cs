using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление суммы чисел. Для выхода - \"0\"");
            int sum = 0;
            int n;
            do
            {
                //int n = 1;
                Console.Write("Введите число -> ");
                string str = Console.ReadLine();
                bool res = Int32.TryParse(str, out n);
                if (!res){
                    n = 1;
                    continue;
                }
                sum += n;
            } while (n != 0);
            Console.WriteLine("Сумма: " + sum);

            Console.ReadKey();
        }
    }
}
