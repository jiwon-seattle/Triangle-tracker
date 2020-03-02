using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTest;

namespace TriangleTest.Tests
{
  [TestClass]
  public class ClassNameTests
  {
    [TestMethod]
    public void TriangleConstructor_CreateTriangleObject_SideInputs()
    {
      Triangle triangle = new Triangle(1, 2, 3);
      Assert.AreEqual(1, triangle.FirstSide);
      Assert.AreEqual(2, triangle.SecondSide);
      Assert.AreEqual(3, triangle.ThirdSide);
    }

    [TestMethod]
    public void TrueTriangle_NotTriangleFirstSide_False()
    {
      Triangle triangle = new Triangle(8, 2, 2);
      Assert.AreEqual(false, triangle.TrueTriangle());
    }

    [TestMethod]
    public void TrueTriangle_NotTriangleSecondSide_False()
    {
      Triangle triangle = new Triangle(1, 7, 1);
      Assert.AreEqual(false, triangle.TrueTriangle());
    }

    [TestMethod]
    public void TrueTriangle_NotTriangleThirdSide_False()
    {
      Triangle triangle = new Triangle(3, 3, 10);
      Assert.AreEqual(false, triangle.TrueTriangle());
    }


    [TestMethod]
    public void TrueTriangle_IsATriangle_True()
    {
      Triangle triangle = new Triangle(3, 3, 3);
      Assert.AreEqual(true, triangle.TrueTriangle());
    }

    [TestMethod]
    public void Type_NotTypeOfTriangle_NotATriangle()
    {
      Triangle triangle = new Triangle(3, 10, 3);
      Assert.AreEqual("This is not a triangle", triangle.Type());
    }

    [TestMethod]
    public void Type_TypeOfTriangle_Equilateral()
    {
      Triangle triangle = new Triangle(3, 3, 3);
      Assert.AreEqual("Equilateral", triangle.Type());
    }

    [TestMethod]
    public void Type_TypeOfTriangle_Isosceles()
    {
      Triangle triangle = new Triangle(3, 3, 5);
      Assert.AreEqual("Isosceles", triangle.Type());
    }

    [TestMethod]
    public void Type_TypeOfTriangle_Scalene()
    {
      Triangle triangle = new Triangle(3, 4, 5);
      Assert.AreEqual("Scalene", triangle.Type());
    }
  }
}