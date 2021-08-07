using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility
{
    public class Square : IShape
    {
        public double SideLenght { get; set; }

        public double CalcPerimeter()
        {
            return 4 * SideLenght;
        }
    }
}
