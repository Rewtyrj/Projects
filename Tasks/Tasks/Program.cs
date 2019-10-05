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

            //int [] mas  = Input();
            // Enia_195(mas);
            //Guliver_773(mas);
            //Tel_108(mas);
            //Game_004(mas);
            // Biser_903(mas);
            // BackAround();
            //Console.WriteLine(Task2_1(Console.ReadLine()));
            //  Console.WriteLine(Task2_2(Convert.ToInt32(Console.ReadLine())));
            // Console.WriteLine(Task2_3(Console.ReadLine()));
            // Console.WriteLine(Task2_3(Console.ReadLine()));
            Console.WriteLine(Task2_4(Console.ReadLine()));


        }

       static int[]Input()
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
            int rez = mas[0]^2 * mas[1];
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

        /*
        Warmup-1 > backAround 
               Given a string, take the last char and return a new string with the
                last char added at the front and back, so "cat" yields "tcatt".
                The original string will be length 1 or more.


            ackAround("cat") → "tcatt"
            ackAround("Hello") → "oHelloo"
            ackAround("a") → "aaa"

            xpected	Run
            ackAround("cat")    → "tcatt"	"tcatt"	    OK
            ackAround("Hello")  → "oHelloo"	"oHelloo"	OK
            ackAround("a")      → "aaa"	"aaa"	        OK
            ackAround("abc")    → "cabcc"	"cabcc"     OK
            ackAround("read")    → "dreadd"	"dreadd"	OK
            ackAround("boo")     → "obooo"	"obooo"	    OK

            All Correct
         */
        static string  Task2_1(string st)
        {
            return st[st.Length-1] + st + st[st.Length-1];
            
        }

        /*
            Warmup-1 > or35
        Return true if the given non-negative number is a multiple of 3 or
        a multiple of 5. Use the % "mod" operator -- see Introduction to Mod


        or35(3) → true
        or35(10) → true
        or35(8) → false
        Expected	Run
        or35(3) → true	true	OK
        or35(10) → true	true	OK
        or35(8) → false	false	OK
        or35(15) → true	true	OK
        or35(5) → true	true	OK
        or35(9) → true	true	OK
        or35(4) → false	false	OK
        or35(7) → false	false	OK
        or35(6) → true	true	OK
        or35(17) → false	false	OK
        or35(18) → true	true	OK
        or35(29) → false	false	OK
        or35(20) → true	true	OK
        or35(21) → true	true	OK
        or35(22) → false	false	OK
        or35(45) → true	true	OK
        or35(99) → true	true	OK
        or35(100) → true	true	OK
        or35(101) → false	false	OK
        or35(121) → false	false	OK
        or35(122) → false	false	OK
        or35(123) → true	true	OK

        All Correct
     */
        
        static bool Task2_2(int x)
        {
            bool a = (x % 5 == 0 || x % 3 == 0); // Присваиваем булевой переменной значение сравнения остатка от деления с "0" используя лолическое "или" для двух условий.
            return a;
        }
        /*
            Warmup-1 > front22
        Given a string, take the first 2 chars and return the string with
        the 2 chars added at both the front and back, so "kitten" yields
        "kikittenki". If the string length is less than 2, use whatever
         chars are there.


        front22("kitten") → "kikittenki"
        front22("Ha") → "HaHaHa"
        front22("abc") → "ababcab"


        Expected	Run
        front22("kitten") → "kikittenki"	"kikittenki"	OK
        front22("Ha") → "HaHaHa"	"HaHaHa"	OK
        front22("abc") → "ababcab"	"ababcab"	OK
        front22("ab") → "ababab"	"ababab"	OK
        front22("a") → "aaa"	"aaa"	OK
        front22("") → ""	""	OK
        front22("Logic") → "LoLogicLo"	"LoLogicLo"	OK
        All Correct
        */

        static string Task2_3(string st)
        {
            string  st1="";// Обьявляем переменнуы для записи первых двух(или сколько угодно букв/ символов строки)
            for (int i = 0; i < 2; i++)// Заполняем переменную st1
            {
                st1 = st1 + Convert.ToString(st[i]);
            }

            return st1+st+st1;
        }

         /*
            Given a string, return true if the string starts with "hi"
            and false otherwise.


        startHi("hi there") → true
        startHi("hi") → true
        startHi("hello hi") → false

        Expected	Run
        startHi("hi there") → true	true	OK
        startHi("hi") → true	true	OK
        startHi("hello hi") → false	false	OK
        startHi("he") → false	false	OK
        startHi("h") → false	false	OK
        startHi("") → false	false	OK
        startHi("ho hi") → false	false	OK
        startHi("hi ho") → true	true	OK

        All Correct */

        static bool Task2_4(string st)
        {
            string substr="";
            substr = st[0] +""+ st[1];// создаем подстроку из из строки для сравнения. 
            //bool a = st.StartsWith(substr); // Использованеи встроенного метода который определяет начинаеться ли строка с определенной подстроки
            bool a = substr == "hi";  
            return a;
        }

        /*
   Warmup-1 > sleepIn
       The parameter weekday is true if it is a weekday, and the parameter
        vacation is true if we are on vacation. We sleep in if it is not
        a weekday or we're on vacation. Return true if we sleep in.


   sleepIn(false, false) → true
   sleepIn(true, false) → false
   sleepIn(false, true) → true

       Expected	Run
   sleepIn(false, false) → true	true	OK
   sleepIn(true, false) → false	false	OK
   sleepIn(false, true) → true	true	OK
   sleepIn(true, true) → true	true	OK

   All Correct
    */

      
    }
}
