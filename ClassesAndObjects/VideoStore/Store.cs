using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    class Store
    {
        private List<Video> _inventory;

        public Store()
        {
            _inventory = new List<Video>();
        }
        public void AddVideo(string title)
        {
            _inventory.Add(new Video(title));
        }

        public void  VideoStore()
        {
            _inventory = new List<Video>();
        }

        public void Checkout(string title)
        {
            foreach (var video in _inventory)
            {
                if (video.Title == title)
                {
                    video.Checkout();
                }
                if (video.Title == title && video.Available() != true)
                {
                    Console.WriteLine("Not available!");
                }
            }
        }

        public void ReturnVideo(string title)
        {
            foreach (var video in _inventory)
            {
                if (video.Title == title && video.Available())
                {
                    video.Returned();
                }
                if (video.Title == title && video.Available() != true)
                {
                    Console.WriteLine("Cant return not rented video!");
                }
            }
        }

        public void TakeUserRating(double rating, string title)
        {
            foreach (var video in _inventory)
            {
                if (video.Title == title)
                {
                    video.ReceivingRating(rating);
                }
            }
        }

        public void ListInventory()
        {
            foreach (var video in _inventory)
            {
                Console.WriteLine(video.ToString());
            }
        }
    }
}
