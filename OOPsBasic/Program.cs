using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("1-Abstract");
                Console.WriteLine("2-Interface");

                Console.WriteLine("Choose above option");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Display display = new Display();
                        display.Name();
                        display.LastName();
                        break;
                        case 2:
                        DisplaySound displaySound = new DisplaySound();
                        displaySound.Tiger();
                        displaySound.Sound();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
