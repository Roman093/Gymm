using System;
using System.Collections.Generic;


namespace Gym
{
    class ManList
    {
        public List<Man> Gym1 = new List<Man>();
        private List<Man> Gym2 = new List<Man>();



        public void Add(Man NewSportsman)
        {
            Gym1.Add(NewSportsman);
        }

        public void DoExercise()
        {
            EnotherGym(Gym1, Gym2);
            Exercise_Underground(Gym1);
            Delete(Gym2);
            Exercise_Underground(Gym2);

        }

        public void Print()
        {
            Print_Underground(Gym1);
            Print_Underground(Gym2);

            Console.WriteLine("============================");
        }

        private void EnotherGym(List<Man> FromGym, List<Man> ToGym)
        {
            foreach (var x in FromGym)
            {
                if (x.Exercise_Left == 0)
                {
                    x.CurentGymNumber++;
                    x.Exercise_Left = x.Exercise;
                    ToGym.Add(x);
                    FromGym.Remove(x);
                    EnotherGym(FromGym, ToGym);
                    break;
                }

            }
        }

        private void Delete(List<Man> FromGym)
        {
            foreach (var x in FromGym)
            {
                if (x.Exercise_Left == 0)
                {
                    FromGym.Remove(x);
                    Delete(FromGym);
                    break;
                }

            }
        }

        private void Exercise_Underground(List<Man> mans)
        {
            foreach (var x in mans)
            {
                x.Exercise_Left--;
            }
        }

        private void Print_Underground(List<Man> mans)
        {
            foreach (var x in mans)
            {
                Console.WriteLine($"Gym Number: {x.CurentGymNumber}, Name: {x.Name}, Approach: {x.Exercise_Left}");
            }
        }

    }

    class Man
{
        public Man (string name, int exercise)
        {
            CurentGymNumber = 1;
            Name = name;
            Exercise = exercise;
            Exercise_Left = exercise;
        }
        public int CurentGymNumber { get; set; }
        public string Name { get; private set; }
        public int Exercise { get; private set; }
        public int Exercise_Left { get; set; }
    }
}