using System;

namespace VarSolution1
{
    class Program
    {
        static void Main(string[] args)
        {
            int levels = 640;
            decimal damage = 987.98m;
            double expOnKill = 300.10;
            float damOverTime = 25.35f;
            string name = "James";
            bool alive = true;
            char rating = 'A';

            Console.WriteLine($"In the game remnant there are {levels}! At an average of {expOnKill} it sure can take a while to level up! On average marksman rifles deal {damage} and some deal {damOverTime} over time! My characters name is {name}. He is {rating} hunter! His Shot is {alive} ");
            Console.WriteLine("objective complete");
        
        }
    }
}
