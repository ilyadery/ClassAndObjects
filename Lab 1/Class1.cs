using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Class1
    {
        public string nameDisc; 
        public int countLek;       
        public int countLR; 
        public int countSR; 
        int TimeLek;		
        int TimeLR;  
        int TimeSR;   

        public Class1()
        {
        nameDisc = ""; 
        countLek = 0;
        countLR = 0;
        countSR = 0;
        }

        public Class1(string name, int lek, int lr, int sr)
        {
            nameDisc = name; countLek = lek; countLR = lr; countSR = sr;
        }

        public int Sum()
        {
            return countLek * TimeLek + countLR * TimeLR + countSR * TimeSR;
        }

        public void setName()
        {
            
            Console.Write("Введите название дисциплины: ");
            nameDisc = Convert.ToString(Console.ReadLine());
        }

        public void setLek()
        {
          
            Console.Write("Введите к-во лекций 1: ");
            countLek = Convert.ToInt32(Console.ReadLine());
        }
   
        public void setLR()
        {
          
            Console.Write("Введите к-во лекций 2: ");
            countLR = Convert.ToInt32(Console.ReadLine());
        }

        public void setSR()
        {
          
            Console.Write("Введите к-во лекций 3: ");
            countSR = Convert.ToInt32(Console.ReadLine());
        }

        public void setTimeLek()
        {

            Console.Write("Введите к-во часов 1: ");
            TimeLek = Convert.ToInt32(Console.ReadLine());
        }

        public void setTimeLR()
        {

            Console.Write("Введите к-во часов 2: ");
            TimeLR = Convert.ToInt32(Console.ReadLine());
        }

        public void setTimeSR()
        {

            Console.Write("Введите к-во часов 3: ");
            TimeSR = Convert.ToInt32(Console.ReadLine());
        }
    }
}
