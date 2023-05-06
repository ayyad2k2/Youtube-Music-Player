using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheapSpotify
{
    internal class AlbumsDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=Albums;password=albums;database=albums;";
        public List<Album> getAllAlbums()
        {
            List<Album> returnThese = new List<Album>();

            MySqlConnection connection = new MySqlConnection 
                (connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM albums",
                connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album a = new Album()
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5)
                    };
                    returnThese.Add(a);
                }
            }
                connection.Close();

            return returnThese;
        }


    }
}
