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

            MySqlCommand command = new MySqlCommand("SELECT ID, ALBUM_TITLE, ARTIST, YEAR, IMAGE_NAME, DESCRIPTION FROM `albums`",
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

        internal int addOneAlbum(Album album)
        {

            MySqlConnection connection = new MySqlConnection
            (connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("INSERT INTO `albums`(`ALBUM_TITLE`, `ARTIST`, `YEAR`, `IMAGE_NAME`, `DESCRIPTION`) VALUES (@albumtitle,@artist,@year,@imageURL,@description)",connection);

            command.Parameters.AddWithValue("@albumtitle", album.AlbumName);
            command.Parameters.AddWithValue("@artist", album.ArtistName);
            command.Parameters.AddWithValue("@year", album.Year);
            command.Parameters.AddWithValue("@imageURL", album.ImageURL);
            command.Parameters.AddWithValue("@description", album.Description);
            int newRows = command.ExecuteNonQuery();
            connection.Close();

            return newRows;
        }

        public List<Track> getTracksForAlbum (int albumID)
        {
            List<Track> returnThese = new List<Track>();

            // SQL Connection 
            
            string connectionString = "datasource=localhost;port=3306;username=Albums;password=albums;database=albums;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            
            // Command 

            MySqlCommand command = new MySqlCommand();
            command.CommandText = ("SELECT ID, track_title, number, video_url, lyrics, albums_ID FROM TRACKS WHERE albums_ID = @albumsID");
            command.Parameters.AddWithValue("@albumsID", albumID);
            command.Connection = connection;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Track t = new Track()
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Number = reader.GetInt32(2),
                        Source = reader.GetString(3),
                        Lyrics = reader.GetString(4)
                    };
                    returnThese.Add(t);
                }
            }
            connection.Close();

            return returnThese;
        }


    }
}
