using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorReferrence.CalculatorClient _service = new CalculatorReferrence.CalculatorClient();
            Console.WriteLine(_service.Add(5, 6));
            Console.ReadLine();
        }
    }
}
