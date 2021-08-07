using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility
{
    public class Rectangle : IShape
    {
        public double SideALenght { get; set; }
        public double SideBLenght { get; set; }

        public double CalcPerimeter()
        {
            return 2 * (SideALenght + SideBLenght);
        }
    }
}
