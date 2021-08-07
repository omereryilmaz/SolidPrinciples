using System;
using System.Collections.Generic;

namespace SingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            square.SideLenght = 4;

            Rectangle rectangle = new Rectangle();
            rectangle.SideALenght = 2;
            rectangle.SideBLenght = 5;

            List<IShape> shapes = new List<IShape>();
            shapes.Add(square);
            shapes.Add(rectangle);

            CalcTotalPerimeter calcPerimeter = new CalcTotalPerimeter(shapes);
            calcPerimeter.TotalPerimeter();
            calcPerimeter.PrintToConsole();
        }
    }
}
