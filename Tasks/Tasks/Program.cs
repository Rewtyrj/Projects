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
        // Task 5_4 поиграться с логичесикми операциясм, исключающее или.
      
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
            WriteLine(Task6_5(ReadLine()));
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

            return  new string(st);
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
            if ((a != 2)&&( b!=2))
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
            string strout="";
            //Если строка длиннее 3-х символов, то удаляем все символы кроме первых трёх. 
            if (str.Length > 3)                
            str = str.Remove(3, str.Length-3);
            // После преобразования длинной строки или исходной но короткой запиываем её три раза в выходную строку.
            for (int i = 0; i < 3; i++)
            {
                
               strout += str;
            }
            return strout;
        }
            
    }
}
