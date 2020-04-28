using System;
using System.Collections.Generic;
using System.Linq;


namespace Diary
{
    class Diary
    {
        // stan (zmienne - pola)
        List<float> ratings;

        // zachowania
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }
    }
}
