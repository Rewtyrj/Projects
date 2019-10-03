using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Enia_195
{
    class Program
    {
        static void Main(string[] args)
        {
            Create_input();
        }
        static void Create_input()
        {
            Console.WriteLine("Введите chisla:/n");
           string x = Console.ReadLine();
            try
            {
                using (StreamWriter sw =new StreamWriter("@input.txt", true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(x);
                    Console.WriteLine("Файл записан!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
            
    }
}
