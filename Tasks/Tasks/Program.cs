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
            // Console.WriteLine(Task2_4(Console.ReadLine()));
            //  Console.WriteLine(Task2_5(Console.ReadLine()));
            //Console.WriteLine(Task3_1(Console.ReadLine()));
            //Console.WriteLine(Task3_3(Input()));
            //Console.WriteLine(Task3_4(Console.ReadLine()));
            //Console.WriteLine(Task3_5(Convert.ToInt32(Console.ReadLine())));
            Console.WriteLine(Task3_2(Convert.ToInt32(Console.ReadLine())));
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

      static bool Task2_5(string st) 
        { 
            string [] str = st.Split(' ');            
            if (Convert.ToBoolean(str[0]) == true && Convert.ToBoolean(str[1]) == false)// Мы не спим только в том случае если будний день и если это не отпуск. Соответвенно во всех остльных случаях выводиться Тру, тоесть мы спим. 
                return false;
            else
                return true;
        }

        /*
				Warmup-1 > posNeg
		prev  |  next  |  chance
		Given 2 int values, return true if one is negative and one is positive. Except if the parameter "negative" is true, then return true only if both are negative.
		
		
		posNeg(1, -1, false) → true
		posNeg(-1, 1, false) → true
		posNeg(-4, -5, true) → true
		
		
		Expected	Run
		posNeg(1, -1, false) → true	true	OK
		posNeg(-1, 1, false) → true	true	OK
		posNeg(-4, -5, true) → true	true	OK
		posNeg(-4, -5, false) → false	false	OK
		posNeg(-4, 5, false) → true	true	OK
		posNeg(-4, 5, true) → false	false	OK
		posNeg(1, 1, false) → false	false	OK
		posNeg(-1, -1, false) → false	false	OK
		posNeg(1, -1, true) → false	false	OK
		posNeg(-1, 1, true) → false	false	OK
		posNeg(1, 1, true) → false	false	OK
		posNeg(-1, -1, true) → true	true	OK
		posNeg(5, -5, false) → true	true	OK
		posNeg(-6, 6, false) → true	true	OK
		posNeg(-5, -6, false) → false	false	OK
		posNeg(-2, -1, false) → false	false	OK
		posNeg(1, 2, false) → false	false	OK
		posNeg(-5, 6, true) → false	false	OK
		posNeg(-5, -5, true) → true	true	OK
		
		All Correct
     */

        static bool Task3_1(string st)
        {
            string [] str = st.Split(' ');
            bool a=false;           
                if (Convert.ToBoolean(str[2])==true||(str[0][0]!=str[1][0]))
                {
                    a = true;                    
                }                                    
            return a;
        }

        /*   Given an int n, return true if it is within 10 of 100 or 200. Note: Math.abs(num) computes the absolute value of a number.


           nearHundred(93) → true
           nearHundred(90) → true
           nearHundred(89) → false

           Expected Run

           nearHundred(93) → true	true	OK
           nearHundred(90) → true	true	OK
           nearHundred(89) → false	false	OK
           nearHundred(110) → true	true	OK
           nearHundred(111) → false	false	OK
           nearHundred(121) → false	false	OK
           nearHundred(-101) → false	false	OK
           nearHundred(-209) → false	false	OK
           nearHundred(190) → true	true	OK
           nearHundred(209) → true	true	OK
           nearHundred(0) → false	false	OK
           nearHundred(5) → false	false	OK
           nearHundred(-50) → false	false	OK
           nearHundred(191) → true	true	OK
           nearHundred(189) → false	false	OK
           nearHundred(200) → true	true	OK
           nearHundred(210) → true	true	OK
           nearHundred(211) → false	false	OK
           nearHundred(290) → false	false	OK

           All Correct
        */

        static bool Task3_2(int x)
        {
            return ((Math.Abs(100-x)<=10) || (Math.Abs(200 - x) <= 10));
        }
        /*
    Warmup-1 > makes10

	Given 2 ints, a and b, return true if one if them is 10 or if their sum is 10.


	makes10(9, 10) → true
	makes10(9, 9) → false
	makes10(1, 9) → true

	Expected	Run
	makes10(9, 10) → true	true	OK
	makes10(9, 9) → false	false	OK
	makes10(1, 9) → true	true	OK
	makes10(10, 1) → true	true	OK
	makes10(10, 10) → true	true	OK
	makes10(8, 2) → true	true	OK
	makes10(8, 3) → false	false	OK
	makes10(10, 42) → true	true	OK
	makes10(12, -2) → true	true	OK

All Correct
     */

        static bool Task3_3(int[] mas)
        {
            return (mas[0] + mas[1] == 10||mas[0]==10||mas[1]==10);              
        }

        /*
    Warmup-1 > parrotTrouble

		We have a loud talking parrot. The "hour" parameter is the current hour time in the range 0..23. We are in trouble if the parrot is talking and the hour is before 7 or after 20. Return true if we are in trouble.
		
		
		parrotTrouble(true, 6) → true
		parrotTrouble(true, 7) → false
		parrotTrouble(false, 6) → false
		
		Expected	Run
		parrotTrouble(true, 6) → true	true	OK
		parrotTrouble(true, 7) → false	false	OK
		parrotTrouble(false, 6) → false	false	OK
		parrotTrouble(true, 21) → true	true	OK
		parrotTrouble(false, 21) → false	false	OK
		parrotTrouble(false, 20) → false	false	OK
		parrotTrouble(true, 23) → true	true	OK
		parrotTrouble(false, 23) → false	false	OK
		parrotTrouble(true, 20) → false	false	OK
		parrotTrouble(false, 12) → false	false	OK
		
		All Correct
     */

        static bool Task3_4(string st)
        {
            string[] str = st.Split(' ');
            return ((20 < (Convert.ToInt32(str[1]))||(Convert.ToInt32(str[1]))<7)&&Convert.ToBoolean(str[0])==true);// У нас проблемы если попугай говорит толко если это до 7 часов или после 20-ти. во всех остальных случах нам всё равно говорит ли попугай или молчит.
        }

        /*
   Warmup-1 > diff21

       Given an int n, return the absolute difference between n and 21, except return double the absolute difference if n is over 21.


       diff21(19) → 2
       diff21(10) → 11
       diff21(21) → 0

       Expected	Run
       diff21(19) → 2	2	OK
       diff21(10) → 11	11	OK
       diff21(21) → 0	0	OK
       diff21(22) → 2	2	OK
       diff21(25) → 8	8	OK
       diff21(30) → 18	18	OK
       diff21(0) → 21	21	OK
       diff21(1) → 20	20	OK
       diff21(2) → 19	19	OK
       diff21(-1) → 22	22	OK
       diff21(-2) → 23	23	OK
       diff21(50) → 58	58	OK

       All Correct
    */

        static int Task3_5(int x)
        {
            return Math.Abs(21-x);// Функция абс приводит значение к целому не отрицательному.
        }


    }
}
