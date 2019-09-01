using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise4
{
    class Movie
    {
        private string _title;
        private string _studio;
        private string _rating;

        public void _Movie(string title, string studio, string rating)
        {
            _title = title;
            _studio = studio;
            _rating = rating;
        }

        public void SetRatingPG(string title, string studio)
        {
            _title = title;
            _studio = studio;
            _rating = "PG";
        }

        public string ReturnRating()
        {
            return _rating;
        }

        public string ReturnTitle()
        {
            return _title;
        }
    }
}
