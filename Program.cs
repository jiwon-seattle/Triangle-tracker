using System;
using System.Collections.Generic;
using TriangleTest.Models;

namespace TriangleTest
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter three numbers that you will make triangle with");
      string strNumber1 = Console.ReadLine();
      string strNumber2 = Console.ReadLine();
      string strNumber3 = Console.ReadLine();
      int Number1 = int.Parse(strNumber1);
      int Number2 = int.Parse(strNumber2);
      int Number3 = int.Parse(strNumber3);

      Triangle triangle = new Triangle(Number1, Number2, Number3);
      Console.WriteLine(triangle.Type());
    }

  }
}