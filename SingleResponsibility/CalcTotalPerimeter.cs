using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility
{
    public class CalcTotalPerimeter
    {
        private IEnumerable<IShape> shapes;
        private double totalPerimeter;

        public CalcTotalPerimeter(IEnumerable<IShape> _shapes)
        {
            this.shapes = _shapes;
        }

        // Sekillerin toplam cevre uzunlugu
        public double TotalPerimeter()
        {
            totalPerimeter = 0.0;
            foreach (var shape in this.shapes)
            {
                totalPerimeter += shape.CalcPerimeter();
            }

            return totalPerimeter;
        }

        // Sonuclari ekrana yazdir
        public void PrintToConsole()
        {
            Console.WriteLine("Total Perimeter: " + totalPerimeter);
        }

    }
}
