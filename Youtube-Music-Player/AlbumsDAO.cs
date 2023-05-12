using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

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

            MySqlCommand command = new MySqlCommand("SELECT ID, ALBUM_TITLE as `Album Title`, ARTIST as `Artist`, YEAR as `release date`, IMAGE_NAME as `Image`, DESCRIPTION as `Description` FROM `albums`",
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
        public List<Album> searchTitles(String searchTerm)
        {
            List<Album> returnThese = new List<Album>();

            string connectionString = "datasource=localhost;port=3306;username=Albums;password=albums;database=albums;";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();


            MySqlCommand command = new MySqlCommand();
            command.CommandText = ("SELECT ID, ALBUM_TITLE, ARTIST, YEAR, IMAGE_NAME, DESCRIPTION FROM ALBUMS WHERE ALBUM_TITLE LIKE @search");
            command.Parameters.AddWithValue("@search", searchTerm);
            command.Connection = connection;
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
