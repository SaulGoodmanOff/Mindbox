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
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double Radius) 
        {
            this.Radius = Radius;
        }

        public override double Square()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 1);
        }
    }
}
