
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
                     new Movie(){Code=6,Title="Mr.Car and the Knights",Date="2023",Rate="8.7",Image="Resources\\Images\\NewMovie\\Mr. Car and the Knights Templar.jpg"},
                     new Movie(){Code=7,Title="The Flash",Date="2023",Rate="8.1",Image="Resources\\Images\\NewMovie\\The Flash.jpg"},
                     new Movie(){Code=7,Title="Sound of Freedom",Date="2023",Rate="6.8",Image="Resources\\Images\\NewMovie\\Sound of Freedom.jpg"},
                     new Movie(){Code=9,Title="Sonic Prime",Date="2022",Rate="10",Image="Resources\\Images\\NewMovie\\Sonic Prime.jpg"},
                     new Movie(){Code=10,Title="Celebrity Sex Tape",Date="2012",Rate="5",Image="Resources\\Images\\NewMovie\\Celebrity Sex Tape.jpg"},
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
                    new Movie(){Code=5,Title="Shrek 2",Date="2004",Rate="10",Image="Resources\\Images\\NewMovie\\Shrek 2.jpg"},
                    new Movie(){Code=4,Title="Rise of the Beasts ",Rate="5.66",Date="2023",Image="Resources\\Images\\Movies\\Rise of the Beasts .jpg"},
                    new Movie(){Code=4,Title="The Out-Laws",Rate="7",Date="2023",Image="Resources\\Images\\Movies\\The Out-Laws.jpg"},
                    new Movie(){Code=3,Title="Guardians of the Galaxy",Rate="8.1",Date="2023",Image="Resources\\Images\\Movies\\Guardians of the Galaxy.jpg"},
                    new Movie(){Code=11,Title="Insidious The Red Door",Rate="9.2",Date="2023",Image="Resources\\Images\\Movies\\Insidious The Red Door.jpg"},
                    
                };
            }

        }

    }
}
