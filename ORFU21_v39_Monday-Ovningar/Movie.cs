using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORFU21_v39_Monday_Ovningar
{
    class Movie
    {
        private string _title;
        private int _views;

        public Movie() : this ("The Room", 0)
        {
        }

        public Movie(string title, int views) 
        {
            _title = title;
            _views = views;
        }

        public void AddView()
        {
            _views++;
        }
        public void AddView(int param1)
        {
            _views += param1;
        }

        public void GetMovieInfo() => Console.WriteLine($"The movie is called {_title} and has been seen {_views} times.");
    }
}
