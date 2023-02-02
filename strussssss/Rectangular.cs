using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strussssss
{
    internal class Rectangular : Figure
    {

        private int width;
        private int lenght;
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Width can't be smaller than 0");
                }
                width = value;
                
           
            }
        }
        public int Lenght
        {
            get
            {
                return lenght;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Lenght can't be smaller than 0");
                }
                lenght = value;
            }
        }

        public Rectangular(int width,int lenght)
        {
            Width = width;
            Lenght = lenght;
        }
        public override int CalcArea()
        {
            int res = (Width *2)+(Lenght*2);
            Console.WriteLine($"area of rectangular is {res}");
            return res;
        }


    }


}