using System.Data.SqlClient;

namespace adonet_db_videogame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    string strConnessione = "Server=localhost;Database=adonet-db-videogame;Trusted_Connection=True;";

            //    using (SqlConnection connessione = new SqlConnection(strConnessione))
            //    {
            //        try
            //        {
            //            connessione.Open();
            //            Console.WriteLine("Connection Opened!");

            //            string query = "SELECT * FROM videogames";

            //            using (SqlCommand cmd = new SqlCommand(query, connessione))
            //            using (SqlDataReader reader = cmd.ExecuteReader())
            //            {
            //                while (reader.Read())
            //                {
            //                    long id = (long)reader["id"];
            //                    string name = (string)reader["name"];
            //                    string overview = (string)reader["overview"];
            //                    DateTime releaseAt = (DateTime)reader["release_date"];
            //                    DateTime createdAt = (DateTime)reader["created_at"];
            //                    DateTime updatedAt = (DateTime)reader["updated_at"];

            //                    Videogame newVideogame = new Videogame(id, name, overview, releaseAt, createdAt, updatedAt);
            //                    Console.WriteLine(releaseAt.ToString(), createdAt.ToString(), updatedAt.ToString());
            //                }


            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine(ex.Message);
            //        }
            //    }

            VideogameManager.CancellaVideogioco(2);
            //VideogameManager.RicercaPerId(350);
            //VideogameManager.RicercaPerNome("lorem");
            //VideogameManager.InserisciVideogame(Console.ReadLine(), Console.ReadLine(), DateTime.Parse(Console.ReadLine()), DateTime.Parse(Console.ReadLine()), DateTime.Parse(Console.ReadLine()));

        }
    }
}