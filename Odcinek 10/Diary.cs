using System;
using System.Collections.Generic;
using System.Linq;


namespace Odcinek_10
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
        /// <summary>
        /// Dodawanie oceny.
        /// </summary>
        /// <param name="rating"></param>
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }
        /// <summary>
        /// Oblicza średnią ocen.
        /// </summary>
        /// <returns></returns>
        public float CalculateAverage()
        {
            float sum = 0, avg = 0;

            foreach (var rating in ratings)
            {
                sum += rating;
            }

            avg = sum / ratings.Count();

            return avg;
        }
        /// <summary>
        /// Pobierz najwyższą ocenę.
        /// </summary>
        /// <returns></returns>
        public float GiveMaxRating()
        {
            return ratings.Max();
        }
        /// <summary>
        /// Pobierz najniższą ocenę.
        /// </summary>
        /// <returns></returns>
        public float GiveMinRating()
        {
            return ratings.Min();
        }
    }
}
