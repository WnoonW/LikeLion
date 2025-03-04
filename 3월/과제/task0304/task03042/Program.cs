using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task03042
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하시오 : ");
            try
            {
                int Input = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine("올바른 숫자를 입력하시오!");
            }
            finally
            {

            }
        }
    }
}
