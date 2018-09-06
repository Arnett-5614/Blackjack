using System;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] cards = new int[10];
            int[] AllowedValues = new int[] { };
            Random rand = new Random();

            int GetRandomNumber()
            {
                return AllowedValues[rand.Next(AllowedValues.Length)];
            }

            void myButton_Click(object sender, EventArgs e)
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.WriteLine(GetRandomNumber());
                }
            }


        }

    }
}
