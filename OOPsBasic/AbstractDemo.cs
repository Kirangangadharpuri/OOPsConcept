using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsBasic
{
    public abstract class AbstractDemo
    {
        public abstract void Name();
        public void LastName()
        {
            Console.WriteLine("Puri");
        }
    }

    public class Display : AbstractDemo
    {
        public override void Name()
        {
            Console.WriteLine("Kiran");
        }
    }
}
