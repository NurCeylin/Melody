using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melody
{
    internal class NumHolderDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=melody;";
        public List<UserNum> getUserNum()
        {
            
            //start with an empty list
            List<UserNum> returnThese = new List<UserNum>();

            //connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //define the sql statement to fetch all users
            MySqlCommand command = new MySqlCommand();
  
            command.CommandText = "SELECT COUNT(UserId) AS 'UserNum' FROM USER";
            
            command.Connection = connection;

            MySqlDataReader reader = command.ExecuteReader();
   

            while (reader.Read())
                {
                    UserNum n = new UserNum
                    {
                        Num = reader.GetInt32(0)
                    };
                    returnThese.Add(n);
                }
            
            connection.Close();

            return returnThese;
        }
        public List<ArtistNum> getArtistNum()
        {

            //start with an empty list
            List<ArtistNum> returnThese = new List<ArtistNum>();

            //connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //define the sql statement to fetch all users
            MySqlCommand command = new MySqlCommand();

            command.CommandText = "SELECT COUNT(idArtist) AS 'ArtistNum' FROM ARTIST";
            
            command.Connection = connection;
        
            MySqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                ArtistNum n = new ArtistNum
                {
                    Num = reader.GetInt32(0)
                };
                returnThese.Add(n);
            }

            connection.Close();

            return returnThese;
        }
        public List<AlbumNum> getAlbumNum()
        {

            //start with an empty list
            List<AlbumNum> returnThese = new List<AlbumNum>();

            //connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //define the sql statement to fetch all users
            MySqlCommand command = new MySqlCommand();

            command.CommandText = "SELECT COUNT(idAlbum) AS 'AlbumNum' FROM ALBUM";

            command.Connection = connection;

            MySqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                AlbumNum n = new AlbumNum
                {
                    Num = reader.GetInt32(0)
                };
                returnThese.Add(n);
            }

            connection.Close();

            return returnThese;
        }
        public List<SongNum> getSongNum()
        {
            //start with an empty list
            List<SongNum> returnThese = new List<SongNum>();

            //connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //define the sql statement to fetch all users
            MySqlCommand command = new MySqlCommand();

            command.CommandText = "SELECT COUNT(idSong) AS 'SongNum' FROM SONG";

            command.Connection = connection;

            MySqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                SongNum n = new SongNum
                {
                    Num = reader.GetInt32(0)
                };
                returnThese.Add(n);
            }

            connection.Close();

            return returnThese;
        }


    }
}
