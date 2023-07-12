
using BrokDesignerPro_2.Models;
using System.Collections.Generic;

namespace BrokDesignerPro_2.Data
{
    public class CollectionMovie
    {
        public static List<Movie> Movies
        {
            get
            {
                return new List<Movie>()
                {
                    new Movie(){Code=1,Title="Asteroid City",Rate="7.6",Date="2023",Image="Images\\Movies\\Asteroid City.jpg"},
                    new Movie(){Code=2,Title="Barbie",Rate="9",Date="2023",Image="Images\\Movies\\Barbie.jpg"},
                    new Movie(){Code=3,Title="Guardians of the Galaxy",Rate="8.1",Date="2023",Image="Images\\Movies\\Guardians of the Galaxy.jpg"},
                    new Movie(){Code=4,Title="Rise of the Beasts ",Rate="5.66",Date="2023",Image="Images\\Movies\\Rise of the Beasts.jpg"},
                    new Movie(){Code=4,Title="Super Mario movie ",Rate="10",Date="2023",Image="Images\\Movies\\Super Mario movie.jpg"},
                    new Movie(){Code=4,Title="The Out-Laws",Rate="7",Date="2023",Image="Images\\Movies\\The Out-Laws.jpg"},
                };
            }
        }
    }
}
