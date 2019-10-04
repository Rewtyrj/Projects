using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            int [] mas  = pr.Input();
            // Enia_195(mas);
            // Guliver_773(mas);
            //Tel_108(mas);
            //Game_004(mas);
            Biser_903(mas);
        }

     public int[]Input()
        {
            
            Console.WriteLine("Enter input data"); 
            string input = Console.ReadLine();
            string [] str = input.Split(' ');
            int[] mas = new int [str.Length];
                for(int i=0;i<str.Length; i++)
                {
                    mas[i] = Convert.ToInt32(str[i]);
            }
            
            return mas;
        }  
        static void Enia_195(int[] mas)
        {
            int rez = mas[1] * mas[2] * mas[0] * 2;
           Console.WriteLine("Необходимо "+rez+" нанограмм");
        }

        static void Guliver_773(int[] mas)
        {
            int rez = mas[0] * mas[1] * mas[0];
            Console.WriteLine("Необходимо " + rez + " матрасов");
        }

        static void Tel_108(int[] mas)
        {
            Console.WriteLine("Конечная цифра: "+mas[0]);
        }

        static void Game_004(int[] mas)
        {
            string rez = mas[0] + "9" + (9 - mas[0]);
            Console.WriteLine("Отгаданное число: "+rez);
        }

        static void Biser_903(int[] mas)
        {
            
            Console.WriteLine("Необходимо вытащить "+(mas[0] + 1)+" бусин");
        }

    }
}
