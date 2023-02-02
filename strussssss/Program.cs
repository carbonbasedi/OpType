using static strussssss.opType;

namespace strussssss

{
    public class Program
    {
        static void Main()
        {

            Console.WriteLine("enter opertaion type");
        again: int opType = Convert.ToInt32(Console.ReadLine());

            switch (opType)
            {
                case (int)OpType.Square: Square n = new Square(Convert.ToInt32(Console.ReadLine())); n.CalcArea(); ; goto again;
                case (int)OpType.Rectangular:
                    Console.WriteLine("Enter Width");
                    int wid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Lenght");
                    int len = Convert.ToInt32(Console.ReadLine());
                    Rectangular r = new Rectangular(wid, len);
                    r.CalcArea(); goto again;
                case (int)OpType.Quit: break;
                default:
                    Console.WriteLine("Invalid Input");
                    goto again;
            }
        }
    }
}