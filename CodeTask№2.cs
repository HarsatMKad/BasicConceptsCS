/***********************************************************
*   Автор: Кадесников Михаил                               *
*   Дата: 11.02.2023                                       *
*   Название: Перенос второго символа в числе, в конец     *
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
      string Number;
      int Range;

      Console.WriteLine("введите число(>=100): ");
      Number = Console.ReadLine();
      Range = Number.Length;

      for(int NumberIndex = 0; NumberIndex < Range; ++NumberIndex) 
      { 
        if(NumberIndex != 1) 
        { 
          Console.WriteLine(Number[NumberIndex]);
	}
      }
      Console.WriteLine(Number[1]);
      
      Console.ReadKey();
    }
  }
}
