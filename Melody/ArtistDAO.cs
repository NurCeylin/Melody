using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melody
{
    internal class ArtistDAO
    {

        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=melody;";

        public List<Artist> getAllArtists()
        {
            //start with an empty list
            List<Artist> returnThese = new List<Artist>();

            //connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //define the sql statement to fetch all users
            MySqlCommand command = new MySqlCommand("SELECT*FROM ARTIST", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Artist a = new Artist
                    {
                        idArtist = reader.GetInt32(0),
                        ArtistName = reader.GetString(1),
                        ArtistImgName = reader.GetString(2)


                    };
                    returnThese.Add(a);
                }
            }
            connection.Close();

            return returnThese;
        }

        public List<Album> getAllAlbums()
        {
            //start with an empty list
            List<Album> returnThese = new List<Album>();

            //connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //define the sql statement to fetch all users
            MySqlCommand command = new MySqlCommand("SELECT * FROM ALBUM", connection);
         

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album a = new Album
                    {
                        idAlbum = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        AlbumImgName = reader.GetString(2)
                    };
                    returnThese.Add(a);
                }
            }
            connection.Close();

            return returnThese;
        }

        public List<Album> getAlbums(int idArtist)
        {
            //start with an empty list
            List<Album> returnThese = new List<Album>();

            //connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //define the sql statement to fetch all users
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM ALBUM WHERE artist_idArtist = @idartist";
            command.Parameters.AddWithValue("@idartist", idArtist);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album a = new Album
                    {
                        idAlbum = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        AlbumImgName = reader.GetString(2)
                    };
                    returnThese.Add(a);
                }
            }
            connection.Close();

            return returnThese;
        }

        public List<Song> getAllSongs()
        {
            //start with an empty list
            List<Song> returnThese = new List<Song>();

            //connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //define the sql statement to fetch all users
            MySqlCommand command = new MySqlCommand("SELECT * FROM SONG", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Song s = new Song
                    {
                        idSong = reader.GetInt32(0),
                        SongName = reader.GetString(1)
                    };
                    returnThese.Add(s);
                }
            }
            connection.Close();

            return returnThese;
        }

        public List<Song> getSongs(int idAlbum)
        {
            //start with an empty list
            List<Song> returnThese = new List<Song>();

            //connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //define the sql statement to fetch all users
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM SONG WHERE album_idAlbum = @idalbum";
            command.Parameters.AddWithValue("@idalbum", idAlbum);
            command.Connection = connection;



            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Song s = new Song
                    {
                        idSong = reader.GetInt32(0),
                        SongName = reader.GetString(1)
                    };
                    returnThese.Add(s);
                }
            }
            connection.Close();

            return returnThese;
        }

        public List<Song> getAllSongsASC()
        {
            //start with an empty list
            List<Song> returnThese = new List<Song>();

            //connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //define the sql statement to fetch all users
            MySqlCommand command = new MySqlCommand("SELECT * FROM SONG ORDER BY SongName ASC", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Song s = new Song
                    {
                        idSong = reader.GetInt32(0),
                        SongName = reader.GetString(1)
                    };
                    returnThese.Add(s);
                }
            }
            connection.Close();

            return returnThese;
        }

        public List<Song> getAllSongsDSC()
        {
            //start with an empty list
            List<Song> returnThese = new List<Song>();

            //connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //define the sql statement to fetch all users
            MySqlCommand command = new MySqlCommand("SELECT * FROM SONG ORDER BY SongName DESC", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Song s = new Song
                    {
                        idSong = reader.GetInt32(0),
                        SongName = reader.GetString(1)
                    };
                    returnThese.Add(s);
                }
            }
            connection.Close();

            return returnThese;
        }
        public List<Album> getAllAlbumsASC()
        {
            //start with an empty list
            List<Album> returnThese = new List<Album>();

            //connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //define the sql statement to fetch all users
            MySqlCommand command = new MySqlCommand("SELECT * FROM ALBUM ORDER BY AlbumName ASC", connection);


            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album a = new Album
                    {
                        idAlbum = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        AlbumImgName = reader.GetString(2)
                    };
                    returnThese.Add(a);
                }
            }
            connection.Close();

            return returnThese;
        }

        public List<Album> getAllAlbumsDESC()
        {
            //start with an empty list
            List<Album> returnThese = new List<Album>();

            //connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //define the sql statement to fetch all users
            MySqlCommand command = new MySqlCommand("SELECT * FROM ALBUM ORDER BY AlbumName DESC", connection);


            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album a = new Album
                    {
                        idAlbum = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        AlbumImgName = reader.GetString(2)
                    };
                    returnThese.Add(a);
                }
            }
            connection.Close();

            return returnThese;
        }

        public List<Artist> getAllArtistsASC()
        {
            //start with an empty list
            List<Artist> returnThese = new List<Artist>();

            //connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //define the sql statement to fetch all users
            MySqlCommand command = new MySqlCommand("SELECT * FROM ARTIST ORDER BY ArtistName ASC", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Artist a = new Artist
                    {
                        idArtist = reader.GetInt32(0),
                        ArtistName = reader.GetString(1),
                        ArtistImgName = reader.GetString(2)


                    };
                    returnThese.Add(a);
                }
            }
            connection.Close();

            return returnThese;
        }

        public List<Artist> getAllArtistsDESC()
        {
            //start with an empty list
            List<Artist> returnThese = new List<Artist>();

            //connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //define the sql statement to fetch all users
            MySqlCommand command = new MySqlCommand("SELECT * FROM ARTIST ORDER BY ArtistName DESC", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Artist a = new Artist
                    {
                        idArtist = reader.GetInt32(0),
                        ArtistName = reader.GetString(1),
                        ArtistImgName = reader.GetString(2)


                    };
                    returnThese.Add(a);
                }
            }
            connection.Close();

            return returnThese;
        }

    }

}

