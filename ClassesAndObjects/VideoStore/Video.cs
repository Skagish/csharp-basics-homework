using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    class Video
    {
        private bool _isAvailable;
        private string _title;
        private List<double> _ratingList;

        public Video(string title)
        {
            _title = title;
            _isAvailable = true;
            _ratingList = new List<double>();
        }

        public void Checkout()
        {
            _isAvailable = false;
        }

        public void Returned()
        {
            _isAvailable = true;
        }

        public void ReceivingRating(double rating)
        {
            _ratingList.Add(rating);
        }

        public string Title
        {
            get { return _title; }
        }

        public double AverageRating()
        {
            double sum = 0;
            foreach (var rating in _ratingList)
            {
                sum += rating;
            }

            return sum / _ratingList.Count;
        }

        public bool Available()
        {
            return _isAvailable;
        }

        public override string ToString()
        {
            return $"{_title} {AverageRating()} {_isAvailable}";
        }
    }
}
