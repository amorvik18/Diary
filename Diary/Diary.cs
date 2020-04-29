using System;
using System.Collections.Generic;
using System.Linq;


namespace Diary
{
    class Diary
    {
        public Diary()
        {
            ratings = new List<float>(); // inicjalizacja pól
        }
        // stan (zmienne - pola)
        List<float> ratings = new List<float>();

        // zachowania
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }
        /// <summary>
        /// Oblicza wszystkie statystki.
        /// </summary>
        /// <returns></returns>
        internal DiaryStatistic ComputeStatistics()
        {
            DiaryStatistic stats = new DiaryStatistic();

            float sum = 0f;

            foreach (var rating in ratings)
            {
                sum += rating;
            }

            stats.AverageGrade = sum / ratings.Count();
            stats.MaxGrade = ratings.Max();
            stats.MaxGrade = ratings.Min();
            

            return stats; 
        }
    
    }
}
