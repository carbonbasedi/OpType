using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strussssss
{
    internal class Square : Figure
    {
        private int side;
        public int Side
        {
            get
            {
                return side;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("side can't be smaller than 0");
                }
                side = value;
              
            }
            


        }
        public Square(int side)
        {
            this.Side = side;
        }
        public override int CalcArea()
        {
            int res = Side * 4;
            Console.WriteLine($"area of square is {res}");
            return res;
        }


    } 

   
}
