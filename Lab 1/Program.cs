using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Class1 Disc1 = new Class1();

            Disc1.setName();
            Disc1.setTimeLek();
            Disc1.setTimeLR();
            Disc1.setTimeSR();
            Disc1.setLek();
            Disc1.setLR();
            Disc1.setSR();

            Console.WriteLine(" Общее число часов, отводимое на дисциплину " + Disc1.nameDisc + " равно " + Disc1.Sum());
        }
    }
}
