using System;
using ConsoleUtility;

namespace ConstructorSampe
{
    class ConstructorSampeMain
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(
                InteractiveInput.InputFloat("三角形の時計回りにある1つ目の辺の長さ："),
                InteractiveInput.InputFloat("三角形の時計回りにある2つ目の辺の長さ："),
                InteractiveInput.InputFloat("三角形の時計回りにある3つ目の辺の長さ："));

            Console.WriteLine($"面積は{triangle.GetSurface()}");
        }
    }
}
