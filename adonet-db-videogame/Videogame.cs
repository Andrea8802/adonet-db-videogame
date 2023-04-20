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
        DateTime CreateAt { get; set; }
        DateTime UpdateAt { get; set; }

        public Videogame(long id, string name, string overview, DateTime releaseDate, DateTime createAt, DateTime updateAt)
        {
            Id = id;
            Name = name;
            Overview = overview;
            ReleaseDate = releaseDate;
            CreateAt = createAt;
            UpdateAt = updateAt;
        }
    }
}
