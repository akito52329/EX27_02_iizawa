using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorSampe
{
    class Triangle
    {
        private float a;
        private float b;
        private float c;
        private float s;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public Triangle(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }


        /// <summary>
        /// 三角形の面積
        /// </summary>
        /// <returns>計算</returns>
        public double GetSurface()
        {
            s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }
}
