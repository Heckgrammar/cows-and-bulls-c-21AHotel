using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowsAndBulls
{
    internal class Program
    {
        static void Main(string[] args)
        {
                        int[] num = new int[4] { 0, 0, 0, 0 };
            Random rnd = new Random();
            while (num[0] == num[1] | num[0] == num[2] | num[0] == num[3] | num[1] == num[2] || num[1] == num[3] | num[2] == num[3])
            {
                num[0] = rnd.Next(1, 10);
                num[1] = rnd.Next(0, 10);
                num[2] = rnd.Next(0, 10);
                num[3] = rnd.Next(0, 10);
            }
            int[] guess1 = new int[4] { 0, 0, 0, 0 };
            Console.WriteLine("Please enter your guess ");
            if (numOfGuesses > 0)
            {
                Console.Write("again ");
            }
            string guess2 = Console.ReadLine();
            var guessDigits = guess2.Split(' ');

            int guessDigits1 = Convert.ToInt16(guessDigits[0]);
            int guessDigits2 = Convert.ToInt16(guessDigits[1]);
            int guessDigits3 = Convert.ToInt16(guessDigits[2]);
            int guessDigits4 = Convert.ToInt16(guessDigits[3]);

            int[] guess3 = { guessDigits1, guessDigits2, guessDigits3, guessDigits4};

            bool correct = false;

            if (num[0] == guess3[0] | num[1] == guess3[1] | num[2] == guess3[2] | num[3] == guess3[3])
            {
                correct = true;
            }

            int cows = 0;

            if (guess3[0] != num[0] && guess3[0] == guess3[1] | guess3[0] == num[2]| guess3[0] == num[3])
            {
                cows = cows + 1;
            }
            if (guess3[1] != num[1] && guess3[1] == num[0] | guess3[1] == num[2] | guess3[1] == num[3])
            {
                cows = cows + 1;
            }
            if (guess3[2] != num[2] && guess3[2] == num[0] | guess3[2] == num[1] | guess3[2] == num[3])
            {
                cows = cows + 1;
            }
            if (guess3[3] != num[3] && guess3[3] == num[0] | guess3[3] != num[1] | guess3[3] == num[2])
            {
                cows = cows + 1;
            }

            int bulls = 0;
            if (guess3[0] == num[0])
            {
                bulls = bulls + 1;
            }
            if (guess3[1] == num[1])
            {
                bulls = bulls + 1;
            }
            if (guess3[2] == num[2])
            {
                bulls = bulls + 1;
            }
            if (guess3[3] == num[3])
            {
                bulls = bulls + 1;
            }
            Console.WriteLine("Cows:" + cows);
            Console.WriteLine("Bulls:" + bulls);
            Console.ReadLine();
        }
    }
}
