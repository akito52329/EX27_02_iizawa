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
        /// 三角形
        /// </summary>
        /// <param name="a">辺1</param>
        /// <param name="b">辺2</param>
        /// <param name="c">辺3</param>
        public Triangle(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }


        /// <summary>
        /// 三角形の面積
        /// </summary>
        /// <returns>ヘロンの公式での計算</returns>
        public double GetSurface()
        {
            s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }
}
