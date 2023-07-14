
using BrokDesignerPro_2.Models;
using System.Collections.Generic;

namespace BrokDesignerPro_2.Data
{
    public class Data
    {
        private List<Movie> _movie;
        private List<Movie> _newMovie;
        public Data()
        {
            _movie = new List<Movie>();
            _newMovie = new List<Movie>();
        }


        public List<Movie> NewMovie
        {
            get
            {
                return new()
                {

                };
            }
        }


        public List<Movie> Movies
        {
            get
            {
                return new()
                {
                    new Movie(){Code=1,Title="Asteroid City",Rate="7.6",Date="2023",Image="Resources\\Images\\Movies\\Asteroid City.jpg"},
                    new Movie(){Code=2,Title="Barbie",Rate="9",Date="2023",Image="Resources\\Images\\Movies\\Barbie.jpg"},
                    new Movie(){Code=3,Title="Guardians of the Galaxy",Rate="8.1",Date="2023",Image="Resources\\Images\\Movies\\Guardians of the Galaxy.jpg"},
                    new Movie(){Code=4,Title="Rise of the Beasts ",Rate="5.66",Date="2023",Image="Resources\\Images\\Movies\\Rise of the Beasts .jpg"},
                    new Movie(){Code=4,Title="The Out-Laws",Rate="7",Date="2023",Image="Resources\\Images\\Movies\\The Out-Laws.jpg"},
                };
            }

        }

    }
}
