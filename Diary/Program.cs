﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace Diary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            diary.AddRating(5);
            diary.AddRating(8.5f);
            diary.AddRating(4.7f);

            DiaryStatistic stats = diary.ComputeStatistics();

            Console.WriteLine("Średnia ocena: {0}", stats.AverageGrade);
            Console.WriteLine("Najwyższa ocena: {0}", stats.MaxGrade);
            Console.WriteLine("Najniższa ocena: {0}", stats.MinGrade);

            /*for (; ;)
            {
                Console.WriteLine("Podaj ocenę z zakresu 1 - 10");

                float rating;
                bool result = float.TryParse(Console.ReadLine(), out rating);

                if(rating == 11)
                {
                    break;
                }
                if(result)
                {
                    if(rating > 0 && rating <= 10)
                    {
                    diary.AddRating(rating);
                    }
                    else
                    {
                        Console.WriteLine("Niepoprawna liczba podaj liczbę z zakresy 1 - 10");
                    }
                }
                
            }
            Console.WriteLine("Średnia Twoich ocen to: " + diary.CalculateAverage());
            Console.WriteLine("Najwyższa ocena to: " + diary.GiveMaxRating());
            Console.WriteLine("Najniższa ocena to: " + diary.GiveMinRating());
            Console.ReadKey(); */


        }
    }

}
