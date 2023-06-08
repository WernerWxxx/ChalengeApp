using ChalengeApp;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;

namespace ChalengeApp
{
    public class Employee
    {

        public List<float> grades = new List<float>();

        public Employee(string Name, string Surname)
        {
            this.Name = Name;
            this.Surname = Surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid grade value - niewłaściwa wartość");
            }
        }
        public void AddGrade(string grade)  // Parsowanie 
        {
            if (float.TryParse(grade, out float result))
            {

                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average = statistics.Average / this.grades.Count;

            return statistics;

        }
        public Statistics GetStatisticsWithForEach()
        {
            // Implementacja Obiektu   3:20 min//
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;


            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average = statistics.Average + grade;
            }
            statistics.Average = statistics.Average / this.grades.Count;

            return statistics;
        }

        public Statistics GetStatisticsWithFor()
        {
            // Implementacja Obiektu   3:20 min//
            var statistics = new Statistics();

            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;

            int i;

            for (i = 0; i < this.grades.Count; i++)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[i]);
                statistics.Min = Math.Min(statistics.Min, this.grades[i]);
                statistics.Average += this.grades[i];
            }
            //statistics.Average = statistics.Average / this.grades.Count;
            statistics.Average /= this.grades.Count;

            return statistics;
        }

        public Statistics GetStatisticsWithWhile()
        {
            // Implementacja Obiektu   3:20 min//
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var index = 0;
            while (index < this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
                index++;
            }
            statistics.Average = statistics.Average / this.grades.Count;
            //
            return statistics;
        }
        public Statistics GetStatisticsWithDoWhile()
        {
            // Implementacja Obiektu   3:20 min//
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            var index = 0;
            do
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
                index++;
            } while (index < grades.Count);

            statistics.Average = statistics.Average / this.grades.Count;
            //}
            return statistics;
        }
    }
}