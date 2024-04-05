using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Melody
{
    internal class UsersDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=melody;";

        public List<User> getAllUsers()
        {
            //start with an empty list
            List<User> returnThese = new List<User>();

            //connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //define the sql statement to fetch all users
            MySqlCommand command = new MySqlCommand("SELECT * FROM USER", connection);

            using(MySqlDataReader reader = command.ExecuteReader())
            {
                while(reader.Read())
                {
                    User u = new User
                    {
                        UserId = reader.GetInt32(0),
                        UserName = reader.GetString(1),
                        UserMail = reader.GetString(2),
                        UserPassword = reader.GetString(3),
                    };
                    returnThese.Add(u);
                }
            }
            connection.Close();

            return returnThese;
        }

        internal int addOneUser(User user)
        {
            
            //connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //define the sql statement to fetch all users
            MySqlCommand command = new MySqlCommand("INSERT INTO `user`(`UserName`, `E-mail`, `Password` ) VALUES (@username, @usermail, @userpassword )", connection);

            command.Parameters.AddWithValue("@username", user.UserName);
            command.Parameters.AddWithValue("@usermail", user.UserMail);
            command.Parameters.AddWithValue("@userpassword", user.UserPassword);
           


            int newRows = command.ExecuteNonQuery();

            connection.Close();

            return newRows;
        }

        public List<UserProfile> getAllUserProfile()
        {
            //start with an empty list
            List<UserProfile> returnThese = new List<UserProfile>();

            //connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //define the sql statement to fetch all users
            MySqlCommand command = new MySqlCommand("SELECT * FROM USERPROFILE", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    UserProfile u = new UserProfile
                    {
                        idUserProfile = reader.GetInt32(0),
                        ProfileDescription = reader.GetString(1)
                    };
                    returnThese.Add(u);
                }
            }
            connection.Close();

            return returnThese;
        }

        public List<Payment> getAllPayment()
        {
            //start with an empty list
            List<Payment> returnThese = new List<Payment>();

            //connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //define the sql statement to fetch all users
            MySqlCommand command = new MySqlCommand("SELECT * FROM PAYMENT", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Payment p = new Payment
                    {
                        idPayment = reader.GetInt32(0),
                        CardOwner = reader.GetString(1),
                        CardNumber = reader.GetInt32(2),
                        CVV = reader.GetInt32(3),
                    };
                    returnThese.Add(p);
                }
            }
            connection.Close();

            return returnThese;
        }

        public List<LikedSong> getAllLikedSong()
        {
            //start with an empty list
            List<LikedSong> returnThese = new List<LikedSong>();

            //connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //define the sql statement to fetch all users
            MySqlCommand command = new MySqlCommand("SELECT * FROM LIKEDSONG", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    LikedSong l = new LikedSong
                    {
                        idLikedSong = reader.GetInt32(0)
                    };
                    returnThese.Add(l);
                }
            }
            connection.Close();

            return returnThese;
        }

        public List<LikedAlbum> getAllLikedAlbum()
        {
            //start with an empty list
            List<LikedAlbum> returnThese = new List<LikedAlbum>();

            //connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //define the sql statement to fetch all users
            MySqlCommand command = new MySqlCommand("SELECT * FROM LIKEDALBUM", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    LikedAlbum l = new LikedAlbum
                    {
                        idLikedAlbum = reader.GetInt32(0)
                    };
                    returnThese.Add(l);
                }
            }
            connection.Close();

            return returnThese;
        }

        public List<LikedArtist> getAllLikedArtist()
        {
            //start with an empty list
            List<LikedArtist> returnThese = new List<LikedArtist>();

            //connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //define the sql statement to fetch all users
            MySqlCommand command = new MySqlCommand("SELECT * FROM LIKEDARTIST", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    LikedArtist l = new LikedArtist
                    {
                        idLikedArtist = reader.GetInt32(0)
                    };
                    returnThese.Add(l);
                }
            }
            connection.Close();

            return returnThese;
        }


        public List<User> updateUser(string newpassword,int id)
        {
            //start with an empty list
            List<User> returnThese = new List<User>();

            //connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "UPDATE `user` SET `Password`='@newpassword' WHERE UserId=@id";
            command.Parameters.AddWithValue("@newpassword", newpassword);
            command.Parameters.AddWithValue("@id", id);
            command.Connection = connection;



            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    User u = new User
                    {
                        UserId = reader.GetInt32(0),
                        UserName = reader.GetString(1),
                        UserMail = reader.GetString(2),
                        UserPassword = reader.GetString(3),
                    };
                    returnThese.Add(u);
                }
            }
            connection.Close();

            return returnThese;
        }
        public List<User> deleteUser(int id)
        {
            //start with an empty list
            List<User> returnThese = new List<User>();

            //connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "DELETE FROM `user` WHERE UserId=@id";
            command.Parameters.AddWithValue("@id", id);
            command.Connection = connection;



            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    User u = new User
                    {
                        UserId = reader.GetInt32(0),
                        UserName = reader.GetString(1),
                        UserMail = reader.GetString(2),
                        UserPassword = reader.GetString(3),
                    };
                    returnThese.Add(u);
                }
            }
            connection.Close();

            return returnThese;
        }






    }


}
