using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace adonet_db_videogame
{
    internal class VideogameManager
    {
        public static void InserisciVideogame(string name, string overview, DateTime releaseDate, DateTime createdAt, DateTime updatedAt)
        {
            string strConnessione = "Server=localhost;Database=adonet-db-videogame;Trusted_Connection=True;";

            using (SqlConnection connessione = new SqlConnection(strConnessione))
            {
                try
                {
                    connessione.Open();
                    Console.WriteLine("Connection Opened!");
                    string query = "INSERT INTO videogames(name, overview, release_date, created_at, updated_at, software_house_id) " +
                        "VALUES (@name, @overview, @releaseDate, @createdAt, @updatedAt, @sh_id)";

                    SqlCommand cmd = new SqlCommand(query, connessione);
                    cmd.Parameters.Add(new SqlParameter("@name", name));
                    cmd.Parameters.Add(new SqlParameter("@overview", overview));
                    cmd.Parameters.Add(new SqlParameter("@releaseDate", releaseDate));
                    cmd.Parameters.Add(new SqlParameter("@createdAt", createdAt));
                    cmd.Parameters.Add(new SqlParameter("@updatedAt", updatedAt));
                    cmd.Parameters.Add(new SqlParameter("@sh_id", 1));

                    int videogameRaw = cmd.ExecuteNonQuery();
                        if(videogameRaw == 1)
                    {
                        Console.WriteLine("Dato Caricato!");
                    }
                    else
                    {
                        Console.WriteLine("Dato non caricato!");
                    }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static void RicercaPerID(long id)
        {
            string strConnessione = "Server=localhost;Database=adonet-db-videogame;Trusted_Connection=True;";

            using (SqlConnection connessione = new SqlConnection(strConnessione))
            {
                try
                {
                    connessione.Open();
                    Console.WriteLine("Connection Opened!");
                    string query = "SELECT * FROM videogames WHERE id = @id";

                    SqlCommand cmd = new SqlCommand(query, connessione);
                    cmd.Parameters.Add(new SqlParameter("@id", id));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) {
                            Console.WriteLine(reader["name"]);
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
