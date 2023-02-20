/***********************************************************
*   Автор: Кадесников Михаил                               *
*   Дата: 11.02.2023                                       *
*   Название: Возведение числа в степень                   *
************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 
{
  class Program 
  {
    static void Main(string[] args) 
    {
      int Foundation, Order, Result;

      Console.WriteLine("введите основание: ");
      Foundation = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("введите порядок: ");
      Order = Convert.ToInt32(Console.ReadLine());

      Result = Foundation;
      for(int Degree = 1; Degree < Order; ++Degree) 
      {
        Result *= Foundation;
      }

      Console.WriteLine("= " + Result);
      
      Console.ReadKey();
    }
  }
}
