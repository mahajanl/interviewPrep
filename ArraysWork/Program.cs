using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] vacaSpots = { "Cancun", "Cozumel", "OKC", "Massachusetts", "Rhode Island" };

            //Console.WriteLine(vacaSpots[1] + " " + vacaSpots[vacaSpots.Length - 1]);

            //int[] agesKids = { 2, 4, 6, 8, 1, 5 };

            //foreach (int age in agesKids)
            //{
            //    Console.WriteLine(age);
            //}

            //for (int i = 0; i < agesKids.Length; i++)
            //{
            //    Console.WriteLine(agesKids[i]);
            //}

            //char[] bunchOChars = new char[7];
            //bunchOChars[0] = 's';
            //bunchOChars[1] = 'd';
            //bunchOChars[2] = 'f';
            //bunchOChars[3] = 'h';
            //bunchOChars[4] = 'x';
            //bunchOChars[5] = 'm';
            //bunchOChars[6] = 'q';

            //Console.WriteLine(bunchOChars);
            //Console.WriteLine(bunchOChars[bunchOChars.Length - 1]);
            //Array.Reverse(bunchOChars);

            //string myWords = "schwepps ginger ale";
            //char[] myWordsArray = myWords.ToCharArray();
            //Array.Reverse(myWordsArray);
            //string reverseWordsArray = new string(myWordsArray);
            //Console.WriteLine(myWordsArray);

            //string chickenSoup = "chicken noodle soup";
            //char[] chickenSoupArray = chickenSoup.ToCharArray();
            //Array.Reverse(chickenSoupArray);
            //string reverseChickenSoupArray = new string(chickenSoupArray);
            //Console.WriteLine(reverseChickenSoupArray);

            //string numbers = "298464039840948";
            //char[] numbersArray = numbers.ToCharArray();
            //Array.Reverse(numbersArray);
            //string reverseNumbersArray = new string(numbersArray);
            //Console.WriteLine(numbersArray);

            //Console.WriteLine(Array.IndexOf(numbersArray, '6'));


            //FIZZBUZZ

            //Console.WriteLine("If you enter a number for me, I'll fizzbuzz through to it!");
            //Console.WriteLine("\nThis wil be the most fun if you choose a number higher than 15.");
            //int endNum = int.Parse(Console.ReadLine());

            //for (int i=1; i<= endNum; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        Console.WriteLine("Fizzbuzz");
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else
            //    { Console.WriteLine(i); }
            //}

            //FIBONACCI

            //function f(n) = f(n-1) + f(n-2)
            //12 = 0 + 1 + 1+ 2 +3 +5 + 8+13

            Console.WriteLine("Give me a number and I'll fibonacci it up for you!");
            int numberFib = int.Parse(Console.ReadLine());

            for (int i=0; i<=numberFib; i++)
                if (i>=0)
                {
                    Console.WriteLine(0 + (i-1) +(i-1));
                }




        }

        public static int Fibonacci(int num)
        {
            if (num == 0)
                return 0;
            else
            {

            }
        }
    }
}
