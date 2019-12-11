using System;


namespace Gym
{
    class Program
    {
        static void Main(string[] args)
        {
            ManList trainerList = new ManList();

            while (true)
            {

                var check = Console.ReadKey();

                switch (check.Key)
                {
                    case ConsoleKey.Enter:

                        Console.Write("Enter Name:");
                        string Name = Console.ReadLine();
                        Console.Write("Excercise number:");
                        int Exercise = int.Parse(Console.ReadLine());
                        Man man = new Man(Name, Exercise);
                        trainerList.Add(man);
                        break;

                    case ConsoleKey.UpArrow:
                        trainerList.DoExercise();
                        trainerList.Print();
                        break;

                }
            }

        }
    }
}