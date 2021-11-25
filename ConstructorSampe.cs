using System;
using ConsoleUtility;

namespace ConstructorSampe
{
    class ConstructorSampeMain
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(
                  InteractiveInput.InputFloat("三角形ABCの辺ABの長さ："),
                  InteractiveInput.InputFloat("三角形ABCの辺BCの長さ："),
                  InteractiveInput.InputFloat("三角形ABCの辺CAの長さ："));

              Console.WriteLine($"三角形ABCの面積は{triangle.GetSurface()}");
        }
    }
}
