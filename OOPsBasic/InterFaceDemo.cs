using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsBasic
{
    public interface InterFaceDemo
    {
       void Tiger();
    }

    public interface AnimalSound
    {
        void Sound();
    }

    public class DisplaySound : InterFaceDemo, AnimalSound
    {
        public void Tiger()
        {
            Console.WriteLine("Animal is Tiger");
        }

        public void Sound()
        {
            Console.WriteLine("Tiger says : Raaaa");
        }
    }
}
