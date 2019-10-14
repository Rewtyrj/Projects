using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Tasks
{
    class Program
    {
        // Task 8_3 не работает.

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
            // WriteLine(Task3_1(ReadLine()));
            // Console.WriteLine(Task3_3(Input()));
            // Console.WriteLine(Task3_4(Console.ReadLine()));
            // Console.WriteLine(Task3_5(Convert.ToInt32(Console.ReadLine())));
            // Console.WriteLine(Task3_2(Convert.ToInt32(Console.ReadLine())));
            // Console.WriteLine(Task4_1(Console.ReadLine()));
            // Console.WriteLine(Task4_2(Input()));
            //  Console.WriteLine(Task4_3(Console.ReadLine()));
            // Console.WriteLine(Task4_4(Input()));
            //Console.WriteLine(Task4_5(Console.ReadLine()));
            //WriteLine(Task5_1(ReadLine()));
            // WriteLine(Task5_2(ReadLine()));
            // WriteLine(Task5_3(ReadLine()));
            // WriteLine(Task5_4(Input()));
            //WriteLine(Task5_5(ReadLine()));
            //WriteLine(Task6_1(Input()));
            //WriteLine(Task6_2(Input()));
            // WriteLine(Task6_3(Input()));
            //WriteLine(Task6_4(ReadLine()));
            // WriteLine(Task6_5(ReadLine()));
            //WriteLine(Task7_1(Input()));
            //WriteLine(Task7_2(ReadLine()));
            //WriteLine(Task7_3(Input()));
            //WriteLine(Task7_4(Input()));
            //WriteLine(Task7_5(ReadLine()));
            // WriteLine(Task8_1(ReadLine()));
            //WriteLine(Task8_2(ReadLine()));
            // WriteLine(Task8_3(ReadLine()));
            // WriteLine(Task8_4(Input()));
            // WriteLine(Task8_5(ReadLine()));
            // WriteLine(Task9_1(Input()));
            //WriteLine(Task9_2(ReadLine()));
            //WriteLine(Task9_3(ReadLine()));
            //WriteLine(Task9_4(Input()));
            WriteLine(Task9_5(ReadLine()));
        }

        static int[] Input()
        {

            Console.WriteLine("Enter input data");
            string input = Console.ReadLine();
            string[] str = input.Split(' ');
            int[] mas = new int[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                mas[i] = Convert.ToInt32(str[i]);
            }
            return mas;
        }
        static void Enia_195(int[] mas)
        {
            int rez = mas[1] * mas[2] * mas[0] * 2;
            Console.WriteLine("Необходимо " + rez + " нанограмм");
        }

        static void Guliver_773(int[] mas)
        {
            int rez = mas[0] ^ 2 * mas[1];
            Console.WriteLine("Необходимо " + rez + " матрасов");
        }

        static void Tel_108(int[] mas)
        {
            Console.WriteLine("Конечная цифра: " + mas[0]);
        }

        static void Game_004(int[] mas)
        {
            string rez = mas[0] + "9" + (9 - mas[0]);
            Console.WriteLine("Отгаданное число: " + rez);
        }

        static void Biser_903(int[] mas)
        {

            Console.WriteLine("Необходимо вытащить " + (mas[0] + 1) + " бусин");
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
        static string Task2_1(string st)
        {
            return st[st.Length - 1] + st + st[st.Length - 1];

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
            string st1 = "";// Обьявляем переменнуы для записи первых двух(или сколько угодно букв/ символов строки)
            for (int i = 0; i < 2; i++)// Заполняем переменную st1
            {
                st1 = st1 + Convert.ToString(st[i]);
            }

            return st1 + st + st1;
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
            string substr = "";
            substr = st[0] + "" + st[1];// создаем подстроку из из строки для сравнения. 
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
            string[] str = st.Split(' ');
            // Мы не спим только в том случае если будний день и если это не отпуск. Соответвенно во всех остльных случаях выводиться Тру, тоесть мы спим.             
            if (Convert.ToBoolean(str[0]) == true && Convert.ToBoolean(str[1]) == false)
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
            string[] str = st.Split(' ');
            if ((Convert.ToBoolean(str[2]) == true && (str[0][0] == '-' && str[1][0] == '-')) || (str[0][0] != str[1][0]))
            {
                return true;
            }
            return false;
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
            return ((Math.Abs(100 - x) <= 10) || (Math.Abs(200 - x) <= 10));
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
            return (mas[0] + mas[1] == 10 || mas[0] == 10 || mas[1] == 10);
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
            /* У нас проблемы если попугай говорит толко если это до 7 часов или после 20-ти. 
             Во всех остальных случах нам всё равно говорит ли попугай или молчит.*/
            string[] str = st.Split(' ');
            return ((20 < (Convert.ToInt32(str[1])) || (Convert.ToInt32(str[1])) < 7) && Convert.ToBoolean(str[0]) == true);
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
            return Math.Abs(21 - x);// Функция абс приводит значение к целому не отрицательному.
        }

        /*
    Warmup-1 > missingChar
	
	Given a non-empty string and an int n, return a new string where the char at index n has been removed. The value of n will be a valid index of a char in the original string (i.e. n will be in the range 0..str.length()-1 inclusive).
	
	
	missingChar("kitten", 1) → "ktten"
	missingChar("kitten", 0) → "itten"
	missingChar("kitten", 4) → "kittn"
	
	Expected	Run
	missingChar("kitten", 1) → "ktten"	"ktten"	OK
	missingChar("kitten", 0) → "itten"	"itten"	OK
	missingChar("kitten", 4) → "kittn"	"kittn"	OK
	missingChar("Hi", 0) → "i"	"i"	OK
	missingChar("Hi", 1) → "H"	"H"	OK
	missingChar("code", 0) → "ode"	"ode"	OK
	missingChar("code", 1) → "cde"	"cde"	OK
	missingChar("code", 2) → "coe"	"coe"	OK
	missingChar("code", 3) → "cod"	"cod"	OK
	missingChar("chocolate", 8) → "chocolat"	"chocolat"	OK

All Correct
*/

        static string Task4_1(string st)
        {
            string[] str = st.Split(' ');
            return str[0].Remove(Convert.ToInt32(str[1]), 1);// метод ремув удаляет количество символво начная с указаного в пермов аргументе. Можно реализовать перезаписью массива чар с пропуском указаного элемента.

        }


        /*
    Warmup-1 > hasTeen

	We'll say that a number is "teen" if it is in the range 13..19 inclusive. Given 3 int values, return true if 1 or more of them are teen.
	
	
	hasTeen(13, 20, 10) → true
	hasTeen(20, 19, 10) → true
	hasTeen(20, 10, 13) → true
	
	Expected	Run
	hasTeen(13, 20, 10) → true	true	OK
	hasTeen(20, 19, 10) → true	true	OK
	hasTeen(20, 10, 13) → true	true	OK
	hasTeen(1, 20, 12) → false	false	OK
	hasTeen(19, 20, 12) → true	true	OK
	hasTeen(12, 20, 19) → true	true	OK
	hasTeen(12, 9, 20) → false	false	OK
	hasTeen(12, 18, 20) → true	true	OK
	hasTeen(14, 2, 20) → true	true	OK
	hasTeen(4, 2, 20) → false	false	OK
	hasTeen(11, 22, 22) → false	false	OK
	
	All Correct
*/

        static bool Task4_2(int[] mas)
        {
            bool a = false;
            foreach (int x in mas)
            {
                if (13 <= x && x <= 19)
                    a = true;
            }
            return a;
        }

        /*
    Warmup-1 > mixStart
	
	Return true if the given string begins with "mix", except the 'm' can be anything, so "pix", "9ix" .. all count.
	
	
	mixStart("mix snacks") → true
	mixStart("pix snacks") → true
	mixStart("piz snacks") → false
	Expected	Run
	mixStart("mix snacks") → true	true	OK
	mixStart("pix snacks") → true	true	OK
	mixStart("piz snacks") → false	false	OK
	mixStart("nix") → true	true	OK
	mixStart("ni") → false	false	OK
	mixStart("n") → false	false	OK
	mixStart("") → false	false	OK

All Correct
*/

        static bool Task4_3(string st)
        {
            string[] str = st.Split(' ');
            return str[0][1] == 'i' && str[0][2] == 'x';// Метод который возравщает соответсвует ли конец строки указанному аргументу.
        }

        /*
    Warmup-1 > close10

	Given 2 int values, return whichever value is nearest to the value 10, or return 0 in the event of a tie. Note that Math.abs(n) returns the absolute value of a number.
	
	
	close10(8, 13) → 8
	close10(13, 8) → 8
	close10(13, 7) → 0
	
	Expected	Run
	close10(8, 13) → 8	8	OK
	close10(13, 8) → 8	8	OK
	close10(13, 7) → 0	0	OK
	close10(7, 13) → 0	0	OK
	close10(9, 13) → 9	9	OK
	close10(13, 8) → 8	8	OK
	close10(10, 12) → 10	10	OK
	close10(11, 10) → 10	10	OK
	close10(5, 21) → 5	5	OK
	close10(0, 20) → 0	0	OK
	close10(10, 10) → 0	0	OK
	
	All Correct
*/

        static int Task4_4(int[] mas)
        {

            if (Math.Abs(mas[0] - 10) == Math.Abs(mas[1] - 10))  // Проверка на одинаковость разницы
                return 0;

            if (Math.Abs(mas[0] - 10) < Math.Abs(mas[1] - 10)) // Возвращаем число чья абсолютная разность с 10-ю меньше. 

                return mas[0];

            return mas[1];
        }


        /*
         armup-1 > stringE

	Return true if the given string contains between 1 and 3 'e' chars.
	
	
	stringE("Hello") → true
	stringE("Heelle") → true
	stringE("Heelele") → false
	
	Expected	Run
	stringE("Hello") → true	true	OK
	stringE("Heelle") → true	true	OK
	stringE("Heelele") → false	false	OK
	stringE("Hll") → false	false	OK
	stringE("e") → true	true	OK
	stringE("") → false	false	OK

All Correct
*/

        static bool Task4_5(string st)
        {
            int count = 0;
            bool a = false;
            char[] ch = st.ToCharArray();  // массив символов
            for (int i = 0; i < ch.Length; i++) // Ищем в заданном диапазоне есть ли символ "е" и в зависмости от наличия выдаем тру фолс.
            {
                if (ch[i] == 'e')
                {

                    count++;

                }
            }
            if (count >= 1 && count <= 3)
            {
                a = true;
                Console.WriteLine(count);
            }
            return a;
        }


        /*
    Warmup-1 > everyNth
prev  |  next  |  chance
Given a non-empty string and an int N, return the string made starting with char 0, and then every Nth char of the string. 
So if N is 3, use char 0, 3, 6, ... and so on. N is 1 or more.


everyNth("Miracle", 2) → "Mrce"
everyNth("abcdefg", 2) → "aceg"
everyNth("abcdefg", 3) → "adg"

   Expected	Run
everyNth("Miracle", 2) → "Mrce"	"Mrce"	OK
everyNth("abcdefg", 2) → "aceg"	"aceg"	OK
everyNth("abcdefg", 3) → "adg"	"adg"	OK
everyNth("Chocolate", 3) → "Cca"	"Cca"	OK
everyNth("Chocolates", 3) → "Ccas"	"Ccas"	OK
everyNth("Chocolates", 4) → "Coe"	"Coe"	OK
everyNth("Chocolates", 100) → "C"	"C"	OK

All Correct

     */

        static string Task5_1(string input)
        {
            //Разбиваем на подстроки входную строку на две подстроки, на обробатываемую строку и индекс.
            string[] subinput = input.Split('/');
            // Индекс конвертируем в инт.
            int index = Convert.ToInt32(subinput[1]);
            // Делаем запись в теле "Do" и последующую дозапись каждого кратного индексу
            //символа до конца обрабатываеимой строки.  
            string output = "";
            int i = 0;
            do
            {
                if (i % index == 0)
                {
                    output += subinput[0][i];
                }
                i++;
            }
            while (i < subinput[0].Length);
            // Возвращаем выходную строку.
            return output;
        }


        /*
    Warmup-1 > monkeyTrouble
prev  |  next  |  chance
We have two monkeys, a and b, and the parameters aSmile and bSmile indicate if each is smiling. We are in trouble if they are both smiling or if neither of them is smiling. Return true if we are in trouble.


monkeyTrouble(true, true) → true
monkeyTrouble(false, false) → true
monkeyTrouble(true, false) → false

Expected	Run
monkeyTrouble(true, true) → true	true	OK
monkeyTrouble(false, false) → true	true	OK
monkeyTrouble(true, false) → false	false	OK
monkeyTrouble(false, true) → false	false	OK

All Correct
     */

        static bool Task5_2(string str)
        {
            string[] substring = str.Split(' ');
            // Создаем булевый массив для хранения параметров считанных и переформатированных в тип бул что бы не быть зависимым
            // от регистра при сравненнии.
            bool[] parameter = new bool[substring.Length];
            int i = 0;
            foreach (string s in substring)
            {
                parameter[i] = Convert.ToBoolean(s);
                i++;
            }
            // Так как у нас проблемы только при одинаковых параметрах то выдаем тру(есть проблемы) при одинаковых параметрах.
            return parameter[0] == parameter[1];
        }

        /*
===================================================================
3333333333333333333333333333333333333333333333333333333333333333333
=================================================================== 
Given a string, return a new string where the first and last chars have been exchanged.


frontBack("code") → "eodc"
frontBack("a") → "a"
frontBack("ab") → "ba"

Expected	Run		
frontBack("code") → "eodc"	"eodc"	OK	
frontBack("a") → "a"	"a"	OK	
frontBack("ab") → "ba"	"ba"	OK	
frontBack("abc") → "cba"	"cba"	OK	
frontBack("") → ""	""	OK	
frontBack("Chocolate") → "ehocolatC"	"ehocolatC"	OK	
frontBack("aavJ") → "Java"	"Java"	OK	
frontBack("hello") → "oellh"	"oellh"	OK	

All Correct
 */

        static string Task5_3(string str)
        {
            // Создаём переменную для временного хранения символов при перестановке.
            char ch;
            // Строка в которую запишем массив чар для вывода.
            // Преобразуем строку в массив символов и по принципу пузырьковой сортировки меняем сиволы местами.
            char[] st = str.ToCharArray();
            ch = st[0];
            st[0] = st[st.Length - 1];
            st[st.Length - 1] = ch;
            // с помошью цикла записываем массив символов в строку
            /*foreach (char a in st)
            {
                str1 = str1 + a;
            }
            */

            return new string(st);
        }

        /*
    Warmup-1 > loneTeen
prev  |  next  |  chance
We'll say that a number is "teen" if it is in the range 13..19 inclusive. Given 2 int values, return true if one or the other is teen, but not both.


loneTeen(13, 99) → true
loneTeen(21, 19) → true
loneTeen(13, 13) → false

Expected	Run
loneTeen(13, 99) → true	true	OK
loneTeen(21, 19) → true	true	OK
loneTeen(13, 13) → false	false	OK
loneTeen(14, 20) → true	true	OK
loneTeen(20, 15) → true	true	OK
loneTeen(16, 17) → false	false	OK
loneTeen(16, 9) → true	true	OK
loneTeen(16, 18) → false	false	OK
loneTeen(13, 19) → false	false	OK
loneTeen(13, 20) → true	true	OK
loneTeen(6, 18) → true	true	OK
loneTeen(99, 13) → true	true	OK
loneTeen(99, 99) → false	false	OK

All Correct
     */

        static bool Task5_4(int[] mas)
        {
            //Двa счётчика.
            int a = 0;
            int b = 0;
            // С помошью цикла проходимся по массиву и если число соответсвует параметрам, то счётчик увеличивается.
            for (int i = 0; i < mas.Length; i++)
            {
                if ((mas[i] <= 19 && mas[i] >= 13))
                {
                    a++;
                }
                if ((mas[i] > 19 || mas[i] < 13))
                {
                    b++;
                }
            }
            // Если счётчик показал что оба числа не входят в один диапазон, то программа возращает тру, иначе фолс. 
            if ((a != 2) && (b != 2))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /*
    Warmup-1 > startOz
Given a string, return a string made of the first 2 chars (if present), however include first char only if it is 'o' and include the second only if it is 'z', so "ozymandias" yields "oz".


startOz("ozymandias") → "oz"
startOz("bzoo") → "z"
startOz("oxx") → "o

Expected	Run
startOz("ozymandias") → "oz"	"oz"	OK
startOz("bzoo") → "z"	"z"	OK
startOz("oxx") → "o"	"o"	OK
startOz("oz") → "oz"	"oz"	OK
startOz("ounce") → "o"	"o"	OK
startOz("o") → "o"	"o"	OK
startOz("abc") → ""	""	OK
startOz("") → ""	""	OK
startOz("zoo") → ""	""	OK
startOz("aztec") → "z"	"z"	OK
startOz("zzzz") → "z"	"z"	OK
startOz("oznic") → "oz"	"oz"	OK

All Correct
     */

        static string Task5_5(string str)
        {
            // массив чар, который служит шаблоном.
            char[] dict = { 'o', 'z' };
            // Выходная строка
            string strout = "";
            // Сверяем символы входной строкой с шаблоном пока не сравняться первые два символа. Если символ совпадает,
            // то записывается в выходную строку.
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == dict[i])
                    strout = strout + str[i];
                if (i == 1)
                    break;
            }

            return strout;
        }

        /*
    Warmup-1 > in3050
	
	Given 2 int values, return true if they are both in the range 30..40 inclusive, or they are both in the range 40..50 inclusive.
	
	
	in3050(30, 31) → true
	in3050(30, 41) → false
	in3050(40, 50) → true
	Expected	Run
	in3050(30, 31) → true	true	OK
	in3050(30, 41) → false	false	OK
	in3050(40, 50) → true	true	OK
	in3050(40, 51) → false	false	OK
	in3050(39, 50) → false	false	OK
	in3050(50, 39) → false	false	OK
	in3050(40, 39) → true	true	OK
	in3050(49, 48) → true	true	OK
	in3050(50, 40) → true	true	OK
	in3050(50, 51) → false	false	OK
	in3050(35, 36) → true	true	OK
	in3050(35, 45) → false	false	OK

All Correct
*/

        static bool Task6_1(int[] mas)
        {
            // Если оба числа в заданном диапазоне то возвращаем тру 
            if (30 <= mas[0] & mas[0] <= 40 && 30 <= mas[1] & mas[1] <= 40)
                return true;
            if (40 <= mas[0] & mas[0] <= 50 && 40 <= mas[1] & mas[1] <= 50)
                return true;
            // Если ни одно из условий не удовлетворяется, то возвращаем фолс.
            return false;
        }


        /*
    Warmup-1 > lastDigit
    Given two non-negative int values, return true if they have the same last digit, such as with 27 and 57. Note that the % "mod" operator computes remainders, so 17 % 10 is 7.
	
	
	lastDigit(7, 17) → true
	lastDigit(6, 17) → false
	lastDigit(3, 113) → true
	
	Expected	Run
	lastDigit(7, 17) → true	true	OK
	lastDigit(6, 17) → false	false	OK
	lastDigit(3, 113) → true	true	OK
	lastDigit(114, 113) → false	false	OK
	lastDigit(114, 4) → true	true	OK
	lastDigit(10, 0) → true	true	OK
	lastDigit(11, 0) → false	false	OK

All Correct
*/

        static bool Task6_2(int[] mas)
        {
            // При получении остаттка от деления на 10 получаем последнюю цифру числа. Возвращаем результат сравнения двух последний цифр.
            return mas[0] % 10 == mas[1] % 10;
        }

        /*
	Warmup-1 > sumDouble
	Given two int values, return their sum. Unless the two values are the same, then return double their sum.
	
	
	sumDouble(1, 2) → 3
	sumDouble(3, 2) → 5
	sumDouble(2, 2) → 8
	
	Expected	Run
	sumDouble(1, 2) → 3	3	OK
	sumDouble(3, 2) → 5	5	OK
	sumDouble(2, 2) → 8	8	OK
	sumDouble(-1, 0) → -1	-1	OK
	sumDouble(3, 3) → 12	12	OK
	sumDouble(0, 0) → 0	0	OK
	sumDouble(0, 1) → 1	1	OK
	sumDouble(3, 4) → 7	7	OK

All Correct
*/

        static int Task6_3(int[] mas)
        {
            //Если удовлетворяется условие, что числа одинаковы, то возвращаем двойную суму чисел. Если нет, то возращвем просто сумму.
            if (mas[0] == mas[1])
                return (mas[0] + mas[1]) * 2;
            return mas[0] + mas[1];

        }

        /*
	Warmup-1 > notString
	
	Given a string, return a new string where "not " has been added to the front. However, if the string already begins with "not", return the string unchanged. Note: use .equals() to compare 2 strings.
	
	
	notString("candy") → "not candy"
	notString("x") → "not x"
	notString("not bad") → "not bad"
	
	Expected	Run
	notString("candy") → "not candy"	"not candy"	OK
	notString("x") → "not x"	"not x"	OK
	notString("not bad") → "not bad"	"not bad"	OK
	notString("bad") → "not bad"	"not bad"	OK
	notString("not") → "not"	"not"	OK
	notString("is not") → "not is not"	"not is not"	OK
	notString("no") → "not no"	"not no"	OK
	
All Correc
*/

        static string Task6_4(string str)
        {
            // С помошью метода StartsWith() узнаем начинается ли строка с заданной в методе. Если нет, то приписываем к строке в начало "not".
            // Если условие не удовлетворяется, возвращаем ту же строку.
            if (!str.StartsWith("not"))
                return "not " + str;
            return str;

        }

        /*
    Warmup-1 > front3

	Given a string, we'll say that the front is the first 3 chars of the string. If the string length is less than 3, the front is whatever is there. Return a new string which is 3 copies of the front.
	
	
	front3("Java") → "JavJavJav"
	front3("Chocolate") → "ChoChoCho"
	front3("abc") → "abcabcabc"
	
	Expected	Run
	front3("Java") → "JavJavJav"	"JavJavJav"	OK
	front3("Chocolate") → "ChoChoCho"	"ChoChoCho"	OK
	front3("abc") → "abcabcabc"	"abcabcabc"	OK
	front3("abcXYZ") → "abcabcabc"	"abcabcabc"	OK
	front3("ab") → "ababab"	"ababab"	OK
	front3("a") → "aaa"	"aaa"	OK
	front3("") → ""	""	OK

All Correct
*/

        static string Task6_5(string str)
        {
            string strout = "";
            //Если строка длиннее 3-х символов, то удаляем все символы кроме первых трёх. 
            if (str.Length > 3)
                str = str.Remove(3, str.Length - 3);

            // После преобразования длинной строки или исходной но короткой запиываем её три раза в выходную строку.
            for (int i = 0; i < 3; i++)
            {

                strout += str;
            }
            return strout;
        }

        /*
Warmup-1 > in1020
prev  |  next  |  chance
Given 2 int values, return true if either of them is in the range 10..20 inclusive.


in1020(12, 99) → true
in1020(21, 12) → true
in1020(8, 99) → false

    Expected	Run
in1020(12, 99) → true	true	OK
in1020(21, 12) → true	true	OK
in1020(8, 99) → false	false	OK
in1020(99, 10) → true	true	OK
in1020(20, 20) → true	true	OK
in1020(21, 21) → false	false	OK
in1020(9, 9) → false	false	OK

All Correct
     */

        static bool Task7_1(int[] mas)
        {
            // Оператор условного логического и возвращает тру только если оба числа в диапазонах, тоесть ему на фход подается тру-тру.
            return ((10 <= mas[0] && mas[0] <= 20) && (10 <= mas[1] && mas[1] <= 20));
        }

        /*
    Warmup-1 > delDel
prev  |  next  |  chance
Given a string, if the string "del" appears starting at index 1, return a string where that "del" has been deleted. Otherwise, return the string unchanged.


delDel("adelbc") → "abc"
delDel("adelHello") → "aHello"
delDel("adedbc") → "adedbc"

Expected	Run
delDel("adelbc") → "abc"	"abc"	OK
delDel("adelHello") → "aHello"	"aHello"	OK
delDel("adedbc") → "adedbc"	"adedbc"	OK
delDel("abcdel") → "abcdel"	"abcdel"	OK
delDel("add") → "add"	"add"	OK
delDel("ad") → "ad"	"ad"	OK
delDel("a") → "a"	"a"	OK
delDel("") → ""	""	OK
delDel("del") → "del"	"del"	OK
delDel("adel") → "a"	"a"	OK
delDel("aadelbb") → "aadelbb"	"aadelbb"	OK

All Correct
     */

        static string Task7_2(string strIn)
        {
            // Метод индексоф возвращает индекс первого вождения символа иили подстроки
            int indDel = strIn.IndexOf("del");
            // Если индекс равен 1, то с помошью метода ремув аргументами которого являются  начальный символ и колчисевто символов для удаления,
            // редактируем строку. Если условие не удовлетворяется, то возвращаем изначальную строку.
            if (indDel == 1)
                return strIn.Remove(1, 3);
            return strIn;
        }

        /*
    Warmup-1 > intMax
prev  |  next  |  chance
Given three int values, a b c, return the largest.


intMax(1, 2, 3) → 3
intMax(1, 3, 2) → 3
intMax(3, 2, 1) → 3

Expected	Run
intMax(1, 2, 3) → 3	3	OK
intMax(1, 3, 2) → 3	3	OK
intMax(3, 2, 1) → 3	3	OK
intMax(9, 3, 3) → 9	9	OK
intMax(3, 9, 3) → 9	9	OK
intMax(3, 3, 9) → 9	9	OK
intMax(8, 2, 3) → 8	8	OK
intMax(-3, -1, -2) → -1	-1	OK
intMax(6, 2, 5) → 6	6	OK
intMax(5, 6, 2) → 6	6	OK
intMax(5, 2, 6) → 6	6	OK
All Correct
     */

        static int Task7_3(int[] mas)
        {
            // Сортируем массив и возвращаем последний элемент массива, который будет самым большим числом.
            Array.Sort(mas);
            return mas[mas.Length - 1];
        }

        /*
    Warmup-1 > max1020
 Given 2 positive int values, return the larger value that is in the range 10..20 inclusive, or return 0 if neither is in that range.


max1020(11, 19) → 19
max1020(19, 11) → 19
max1020(11, 9) → 11

Expected	Run
max1020(11, 19) → 19	19	OK
max1020(19, 11) → 19	19	OK
max1020(11, 9) → 11	11	OK
max1020(9, 21) → 0	0	OK
max1020(10, 21) → 10	10	OK
max1020(21, 10) → 10	10	OK
max1020(9, 11) → 11	11	OK
max1020(23, 10) → 10	10	OK
max1020(20, 10) → 20	20	OK
max1020(7, 20) → 20	20	OK
max1020(17, 16) → 17	17	OK

All Correct
     */


        static int Task7_4(int[] mas)
        {
            // Проверяем каждый елемент массива находится ли он в заданном диапазоне. Если нет то присваемваем ему значение 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (!(10 <= mas[i] && mas[i] <= 20))
                    mas[i] = 0;
            }
            // Сортируем массив и возращаем последний (самый болшой) елемент.
            Array.Sort(mas);
            return mas[mas.Length - 1];

        }

        /*Warmup-1 > endUp
prev  |  next  |  chance
Given a string, return a new string where the last 3 chars are now in upper case. If the string has less than 3 chars, uppercase whatever is there. Note that str.toUpperCase() returns the uppercase version of a string.


endUp("Hello") → "HeLLO"
endUp("hi there") → "hi thERE"
endUp("hi") → "HI"
Expected	Run
endUp("Hello") → "HeLLO"	"HeLLO"	OK
endUp("hi there") → "hi thERE"	"hi thERE"	OK
endUp("hi") → "HI"	"HI"	OK
endUp("woo hoo") → "woo HOO"	"woo HOO"	OK
endUp("xyz12") → "xyZ12"	"xyZ12"	OK
endUp("x") → "X"	"X"	OK
endUp("") → ""	""	OK

All Correct

     */

        static string Task7_5(string str)
        {
            string substr = "";
            // Если строка больше 3-х символов, то ...
            if (str.Length > 3)
            {
                // ... с помошью цикла записываем в подстроку полседние 3 символа... 
                for (int i = 3; i > 0; i--)
                {
                    substr += str[str.Length - i];
                }
                // ... и возвращаем исходную строку в которой с помошью метода "Replace()" заменена подстрока на туже подстроку только 
                // преобразованную в верхний регистр с помошью метода "ToUpper()".
                return str.Replace(substr, substr.ToUpper());
            }
            // Если условие не выполняется, то возращаем строку преобразованную методом "ToUpper()".
            return str.ToUpper();
        }

        /*
    Warmup-2 > stringTimes

	Given a string and a non-negative int n, return a larger
	string that is n copies of the original string.
	
	
	stringTimes("Hi", 2) → "HiHi"
	stringTimes("Hi", 3) → "HiHiHi"
	stringTimes("Hi", 1) → "Hi"
	
	Expected	Run
	stringTimes("Hi", 2) → "HiHi"	"HiHi"	OK
	stringTimes("Hi", 3) → "HiHiHi"	"HiHiHi"	OK
	stringTimes("Hi", 1) → "Hi"	"Hi"	OK
	stringTimes("Hi", 0) → ""	""	OK
	stringTimes("Hi", 5) → "HiHiHiHiHi"	"HiHiHiHiHi"	OK
	stringTimes("Oh Boy!", 2)
					→ "Oh Boy!Oh Boy!"	"Oh Boy!Oh Boy!"	OK
	stringTimes("x", 4) → "xxxx"	"xxxx"	OK
	stringTimes("", 4) → ""	""	OK
	stringTimes("code", 2) → "codecode"	"codecode"	OK
	stringTimes("code", 3) → "codecodecode"	"codecodecode"	OK
	
	All Correct
*/

        static string Task8_1(string str)
        {
            // Создаём массив строк в котором будет храниться строка и индекс повтора.
            string[] strMas = str.Split('/');
            // Строка в которой будет хранится выходное значение.
            string strOut = "";
            // С помошью цикла записываем в новую строку исходную строку,
            // указанное в индексе оличество раз.
            for (int i = 0; i < Convert.ToInt32(strMas[1]); i++)
            {
                strOut += strMas[0];
            }
            // Возвращаем выходное значение.
            return strOut;
        }

        /*
    Warmup-2 > doubleX

	Given a string, return true if the first instance of "x" in the
	string is immediately followed by another "x".
	
	
	doubleX("axxbb") → true
	doubleX("axaxax") → false
	doubleX("xxxxx") → true
	
	Expected	Run
	doubleX("axxbb") → true	true	OK
	doubleX("axaxax") → false	false	OK
	doubleX("xxxxx") → true	true	OK
	doubleX("xaxxx") → false	false	OK
	doubleX("aaaax") → false	false	OK
	doubleX("") → false	false	OK
	doubleX("abc") → false	false	OK
	doubleX("x") → false	false	OK
	doubleX("xx") → true	true	OK
	doubleX("xax") → false	false	OK
	doubleX("xaxx") → false	false	OK
	
	All Correct
*/

        static bool Task8_2(string str)
        {
            // Проверяем является ли символ "х" последним в строке, иначе сравнение не имеет смысла... 
            if (str.IndexOf('x') != str.Length - 1)
            {
                // Если смвол "х" не последний то мы сравниваем
                // является ли следующий от первого вхождения символа "х" таким же.
                return str[str.IndexOf('x') + 1] == 'x';
            }
            // ... и мы возвращаем фолс.
            return false;
        }

        /*
    Warmup-2 > last2
	
	Given a string, return the count of the number of times that a
	substring length 2 appears in the string and also as the last 
	2 chars of the string, so "hixxxhi" yields 1 (we won't count 
	the end substring).
	
	
	last2("hixxhi") → 1
	last2("xaxxaxaxx") → 1
	last2("axxxaaxx") → 2
	
	Expected	Run
	last2("hixxhi") → 1	1	OK
	last2("xaxxaxaxx") → 1	1	OK
	last2("axxxaaxx") → 2	2	OK
	last2("xxaxxaxxaxx") → 3	3	OK
	last2("xaxaxaxx") → 0	0	OK
	last2("xxxx") → 2	2	OK
	last2("13121312") → 1	1	OK
	last2("11212") → 1	1	OK
	last2("13121311") → 0	0	OK
	last2("1717171") → 2	2	OK
	last2("hi") → 0	0	OK
	last2("h") → 0	0	OK
	last2("") → 0	0	OK
	
	All Correct
*/

        static int Task8_3(string str)
        {
            // Переменная, хранящая сколько раз подстрока встречается в строке.
            int count = 0;
            // Так как подстрока, которую мы ищем состоит из 2-х символов, а исходную подстроку мы не учитываем,
            // то если строка меньше 4-х символов...(1)
            if (str.Length > 3)
            {
                // В подстроку записываем 2 последних символа.
                string strSub = str.Substring(str.Length - 2, 2);
                // С помошью цикла проверяем возвращает ли индекс метод поиска первого вхождения подстроки.
                // По умолчанию, если метод не находит строку, он возвращает "-1"
                while (str.IndexOf(strSub) != -1)
                {
                    // По ходу цикла который выполняется при нахождении подстроки итерируем счётчик,...(2)
                    count++;
                    //... (2) а после удаляем один символ начиная с индекса вхождения строки?.
                    str = str.Remove(str.IndexOf(strSub), 1);
                }
                // После того как программа выйдет из цикла возвращаем счётчик, но  со значением на 1 меньше,
                // так как исходную подстроку мы не считаем.
                return count - 1;
            }
            // (2)... мы возращаем "0", так как вхождений в строку подстроки
            // больше чем первого раза в исходной позиции не будет.
            return 0;
        }

        /*
    Warmup-2 > array123
	
	Given an array of ints, return true if the sequence of numbers
	1, 2, 3 appears in the array somewhere.
	
	
	array123([1, 1, 2, 3, 1]) → true
	array123([1, 1, 2, 4, 1]) → false
	array123([1, 1, 2, 1, 2, 3]) → true
	
	Expected	Run
	array123([1, 1, 2, 3, 1]) → true	true	OK
	array123([1, 1, 2, 4, 1]) → false	false	OK
	array123([1, 1, 2, 1, 2, 3]) → true	true	OK
	array123([1, 1, 2, 1, 2, 1]) → false	false	OK
	array123([1, 2, 3, 1, 2, 3]) → true	true	OK
	array123([1, 2, 3]) → true	true	OK
	array123([1, 1, 1]) → false	false	OK
	array123([1, 2]) → false	false	OK
	array123([1]) → false	false	OK
	array123([]) → false	false	OK
	
	All Correct
*/
        static bool Task8_4(int[] mas)
        {
            // Возвращаем результат наличия одновременно 1, 2 и 3 в массиве с помошью метода Exists(),
            // который показывает есть ли элемент в массиве.
            return (Array.Exists(mas, element => element == 1) && Array.Exists(mas, element => element == 2) && Array.Exists(mas, element => element == 3));
        }

        /*
    Warmup-2 > altPairs

	Given a string, return a string made of the chars at indexes
	0,1, 4,5, 8,9 ... so "kittens" yields "kien".
	
	
	altPairs("kitten") → "kien"
	altPairs("Chocolate") → "Chole"
	altPairs("CodingHorror") → "Congrr"
	
	Expected	Run
	altPairs("kitten") → "kien"	"kien"	OK
	altPairs("Chocolate") → "Chole"	"Chole"	OK
	altPairs("CodingHorror") → "Congrr"	"Congrr"	OK
	altPairs("yak") → "ya"	"ya"	OK
	altPairs("ya") → "ya"	"ya"	OK
	altPairs("y") → "y"	"y"	OK
	altPairs("") → ""	""	OK
	altPairs("ThisThatTheOther") → "ThThThth"	"ThThThth"	OK
	
	All Correct
*/

        static string Task8_5(string str)
        {
            // Выходная строка.
            string strOut = "";
            int i = 0;
            // Пока индекс меньше длинны строки... 
            while (i < str.Length)
            {
                // если индекс не равен концу строки, записываем подстроку
                // из двух символов, начиная с индекса...
                if (i != str.Length - 1)
                    strOut += str.Substring(i, 2);
                //... если индекс равен концу строки, то толко один символ.
                else
                    strOut += str.Substring(i, 1);
                // Увеличиваем индекс на 4, так как нам нужно записывать 
                //каждую 4-ю пару символов либо символ.
                i += 4;
            }
            // Возвращаем выходную строку.
            return strOut;

        }

        /*
    Warmup-2 > noTriples
	
	Given an array of ints, we'll say that a triple is a value 
	appearing 3 times in a row in the array. Return true if the 
	array does not contain any triples.
	
	
	noTriples([1, 1, 2, 2, 1]) → true
	noTriples([1, 1, 2, 2, 2, 1]) → false
	noTriples([1, 1, 1, 2, 2, 2, 1]) → false
	
	Expected	Run
	noTriples([1, 1, 2, 2, 1]) → true	true	OK
	noTriples([1, 1, 2, 2, 2, 1]) → false	false	OK
	noTriples([1, 1, 1, 2, 2, 2, 1]) → false	false	OK
	noTriples([1, 1, 2, 2, 1, 2, 1]) → true	true	OK
	noTriples([1, 2, 1]) → true	true	OK
	noTriples([1, 1, 1]) → false	false	OK
	noTriples([1, 1]) → true	true	OK
	noTriples([1]) → true	true	OK
	noTriples([]) → true	true	OK
	
	All Correct

*/

        static bool Task9_1(int[] mas)
        {
            // С помошью цикла проходимся по массиву и если три символа подря одинаковы, возвращаем фолс,
            // если мы выходим из цикла не удовлетворив условие возвращаем тру.
            for (int i = 0; i < mas.Length - 2; i++)
            {
                if (mas[i] == mas[i + 1] && mas[i + 1] == mas[i + 2])
                    return false;


            }
            return true;
        }

        /*
    Warmup-2 > frontTimes

    Given a string and a non-negative int n, we'll say that the 
    front of the string is the first 3 chars, or whatever is there 
    if the string is less than length 3. Return n copies of the 
    front;


    frontTimes("Chocolate", 2) → "ChoCho"
    frontTimes("Chocolate", 3) → "ChoChoCho"
    frontTimes("Abc", 3) → "AbcAbcAbc"

    Expected	Run
    frontTimes("Chocolate", 2) → "ChoCho"	"ChoCho"	OK
    frontTimes("Chocolate", 3) → "ChoChoCho"	"ChoChoCho"	OK
    frontTimes("Abc", 3) → "AbcAbcAbc"	"AbcAbcAbc"	OK
    frontTimes("Ab", 4) → "AbAbAbAb"	"AbAbAbAb"	OK
    frontTimes("A", 4) → "AAAA"	"AAAA"	OK
    frontTimes("", 4) → ""	""	OK
    frontTimes("Abc", 0) → ""	""	OK

    All Correc

    */

        static string Task9_2(string str)
        {
            string[] strMas = str.Split('/');
            string strout = "";
            //Если строка длиннее 3-х символов, то удаляем все символы кроме первых трёх. 
            if (strMas[0].Length > 3)
                strMas[0] = strMas[0].Remove(3, strMas[0].Length - 3);
            // После преобразования длинной строки или исходной но короткой запиываем её n раз в выходную строку.
            for (int i = 0; i < Convert.ToInt32(strMas[1]); i++)
            {
                strout += strMas[0];
            }
            return strout;
        }

        /*
    Warmup-2 > stringBits

    Given a string, return a new string made of every other char 
    starting with the first, so "Hello" yields "Hlo".


    stringBits("Hello") → "Hlo"
    stringBits("Hi") → "H"
    stringBits("Heeololeo") → "Hello"

    Expected	Run
    stringBits("Hello") → "Hlo"	"Hlo"	OK
    stringBits("Hi") → "H"	"H"	OK
    stringBits("Heeololeo") → "Hello"	"Hello"	OK
    stringBits("HiHiHi") → "HHH"	"HHH"	OK
    stringBits("") → ""	""	OK
    stringBits("Greetings") → "Getns"	"Getns"	OK
    stringBits("Chocoate") → "Coot"	"Coot"	OK
    stringBits("pi") → "p"	"p"	OK
    stringBits("Hello Kitten") → "HloKte"	"HloKte"	OK
    stringBits("hxaxpxpxy") → "happy"	"happy"	OK

    All Correc
    */

        static string Task9_3(string str)
        {

            string strOut = "";
            // Записываем в выходную строку только чётные символы входной строки.
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                    strOut += str[i];
            }
            return strOut;
        }

        /*
    Warmup-2 > arrayCount9

    Given an array of ints, return the number of 9's in the array.


    arrayCount9([1, 2, 9]) → 1
    arrayCount9([1, 9, 9]) → 2
    arrayCount9([1, 9, 9, 3, 9]) → 3

    Expected	Run
    arrayCount9([1, 2, 9]) → 1	1	OK
    arrayCount9([1, 9, 9]) → 2	2	OK
    arrayCount9([1, 9, 9, 3, 9]) → 3	3	OK
    arrayCount9([1, 2, 3]) → 0	0	OK
    arrayCount9([]) → 0	0	OK
    arrayCount9([4, 2, 4, 3, 1]) → 0	0	OK
    arrayCount9([9, 2, 4, 3, 1]) → 1	1	OK

    All Correct
    */

        static int Task9_4(int[] mas)
        {
            // Первый способ "ручной" с помошью цикла.
            /* int count = 0;
             foreach(int i in mas)
             {
                 if (i == 9)
                     count++;
             }
             return count;
             */
            // Второй способ с помошью метода клас Эррей. Метод ФайнОлл возвращает
            //массив чисел удволетворяющих условию предикта.
            return Array.FindAll(mas, x => x == 9).Length;
        }

        /*
    Warmup-2 > stringMatch

	Given 2 strings, a and b, return the number of the positions 
	where they contain the same length 2 substring. So "xxcaazz" 
	and "xxbaaz" yields 3, since the "xx", "aa", and "az" 
	substrings appear in the same place in both strings.
	
	
	stringMatch("xxcaazz", "xxbaaz") → 3
	stringMatch("abc", "abc") → 2
	stringMatch("abc", "axc") → 0
	
	Expected	Run
	stringMatch("xxcaazz", "xxbaaz") → 3	3	OK
	stringMatch("abc", "abc") → 2	2	OK
	stringMatch("abc", "axc") → 0	0	OK
	stringMatch("hello", "he") → 1	1	OK
	stringMatch("he", "hello") → 1	1	OK
	stringMatch("h", "hello") → 0	0	OK
	stringMatch("", "hello") → 0	0	OK
	stringMatch("aabbccdd", "abbbxxd") → 1	1	OK
	stringMatch("aaxxaaxx", "iaxxai") → 3	3	OK
	stringMatch("iaxxai", "aaxxaaxx") → 3	3	OK
	
	All Correct
*/

        static int Task9_5(string strIn)
        {    
            // Переменная хранящаю количество совпадений.
            int outcount = 0;
            string[] strMas = strIn.Split('/');
            // В цикле проверяются пары символов на предмет совпадения подстрок и икрементации счётчике, если совпадения есть.
            // К тому же предел цикла устанавливается длинной самой короткой строки, дабы избежать выхода за пределы массива.
            for (int i = 0; i < Math.Min(strMas[1].Length,strMas[0].Length) - 1; i++)
            {
                if (strMas[0][i] == strMas[1][i] && strMas[0][i + 1] == strMas[1][i + 1])
                {
                    outcount++;
                }              
            }
            return outcount;
        }

    }
}
