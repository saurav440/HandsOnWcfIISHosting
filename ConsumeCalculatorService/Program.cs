using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeCalculatorService
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorServiceReference.CalculatorServiceClient proxy = new CalculatorServiceReference.CalculatorServiceClient();
            Console.WriteLine("Enter number for Addition.");
            var x = Convert.ToDouble(Console.ReadLine());
            var y = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Addition of two number: {0}", proxy.Add(x, y));
            
            Console.WriteLine("Enter number for Substraction.");
            var x1 = Convert.ToDouble(Console.ReadLine());
            var y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Substraction of two number: {0}", proxy.Subtract(x1, y1));

            Console.ReadLine();
          
        }
    }
}
