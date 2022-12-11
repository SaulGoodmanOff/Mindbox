using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAreaOfFiguresLibrary
{
    /// <summary>
    /// Класс круга
    /// </summary>
    public class Triangle : Shape
    {

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new Exception("Сторона треугольника не может быть отрицательным числом");
            }

            else if (a > (b + c) || b > (a + c) || c > (a + b))
            {
                throw new Exception("Треугольник с такими сторонами не существует");
            }

            else
            {
                this.A = a;
                this.B = b;
                this.C = c;
            }
        }

        /// <summary>
        /// Вычисление площади треугольника по трем сторонам.
        /// </summary>
        /// <returns>
        /// Возвращает площадь треугольника.
        /// </returns>
        public override double Square()
        {
            double semiPerimetr = (A + B + C) / 2;
            double square = Math.Sqrt(semiPerimetr * (semiPerimetr - A) * (semiPerimetr - B) * (semiPerimetr - C));
            return square;
        }

        /// <summary>
        /// Проверка на то, является ли треугольник прямоугольным
        /// </summary>
        /// /// <returns>
        /// Возвращает true если треугольник прямоугольный, иначе false.
        /// </returns>
        public bool IsTheTriangleRectangular()
        {
            bool isRectangular = (A == Math.Sqrt(Math.Pow(B, 2) + Math.Pow(C, 2))
                         || B == Math.Sqrt(Math.Pow(A, 2) + Math.Pow(C, 2))
                         || C == Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2)));

            return isRectangular;
        }
    }
}
