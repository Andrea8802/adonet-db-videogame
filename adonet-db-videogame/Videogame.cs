using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonet_db_videogame
{
    internal class Videogame
    {
        long Id { get; set; }
        string Name { get; set; }
        string Overview { get; set; }
        DateTime ReleaseDate { get; set; }
        long SoftwareHouse { get; set; }

        public Videogame(string name, string overview, DateTime releaseDate, long softwareHouse)
        {
            Name = name;
            Overview = overview;
            ReleaseDate = releaseDate;
            SoftwareHouse = softwareHouse;
        }
    }
}
