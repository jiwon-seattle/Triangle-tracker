using System;

namespace TriangleTest.Models
{
    public class Triangle 
  {
    public int FirstSide;
    public int SecondSide;
    public int ThirdSide;

    public Triangle(int firstSide, int secondSide, int thirdSide)
    {
      FirstSide = firstSide;
      SecondSide = secondSide;
      ThirdSide = thirdSide;
    }

    public bool TrueTriangle()
    {
      if (FirstSide > SecondSide + ThirdSide) {
        return false;
      } else if (SecondSide > FirstSide + ThirdSide) {
        return false;
      } else if (ThirdSide == FirstSide + SecondSide) {
        return false;
      } else {
        return true;
      }
    }
    
    public string Type()
    {
      if (this.TrueTriangle() == false) 
      {
        return "This is not a triangle";
      } else if (FirstSide == SecondSide && FirstSide == ThirdSide) 
      {
        return "Equilateral";
      } else if (FirstSide == SecondSide || FirstSide == ThirdSide || SecondSide == ThirdSide)
      {
        return "Isosceles";
      } else {
        return "Scalene";
      }
    }
  }


}

