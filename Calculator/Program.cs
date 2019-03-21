using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            String opc = "True";
            int operation = 0;
            List<int> Results = new List<int>();
            //List<int> Numbers = new List<int>();

            Console.Write("Write a number: ");
            int numberone = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write another number: ");
            int numbertwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("(1):Sum\n(2):Substraction\n(3):Product\n(4):Division\n(5):Quit");
            while (opc !="5")
            {
                Console.Write("Select method: ");
                opc = Console.ReadLine();
                switch (opc)
                {
                    case "1":
                        operation = numberone + numbertwo;
                        linq(operation);
                        Results.Clear();
                        break;
                    case "2":
                        operation = numberone - numbertwo;
                        linq(operation);
                        Results.Clear();
                        break;
                    case "3":
                        operation = numberone * numbertwo;
                        linq(operation);
                        Results.Clear();
                        break;
                    case "4":
                        operation = numberone / numbertwo;
                        linq(operation);
                        Results.Clear();
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }

            int linq(int op)
            {
                Results.Add(op);
                var query =
                           from resul in Results
                           select resul;
                foreach (var v in query)
                {
                    Console.WriteLine("Result: "+v);
                }
                return 0;
            }
        }
    }
}