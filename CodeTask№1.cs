using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
  class Program {
    static void Main(string[] args) {
      int Foundation, Order, Result;

      Console.WriteLine("введите основание: ");
      Foundation = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("введите порядок: ");
      Order = Convert.ToInt32(Console.ReadLine());

      Result = Foundation;
      for(int Index = 1; Index < Order; ++Index) {
        Result *= Foundation;
      }
      Console.WriteLine("= " + Result);
      Console.ReadKey();
    }
  }
}
