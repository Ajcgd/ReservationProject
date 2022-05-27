using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Rezervace
{
    public static class LoginController
    {
        public static bool CheckLogin(string Username, string password)
        {
            string sql = @"select * from checkLogin(:Username, :password)";
            NpgsqlCommand cmd = new(sql);

            string passwordHash = ComputeHash(password);
            cmd.Parameters.AddWithValue("Username", Username);
            cmd.Parameters.AddWithValue("password", passwordHash);

            object? v = Controller.Conn.ExecuteQuery(cmd);
            return  v != null && (int)v == 1;
        }


        public static string ComputeHash(string toHash)
        {
            byte[] hash;

            using (SHA256 sha256 = SHA256.Create())
            {
                hash = sha256.ComputeHash(Encoding.ASCII.GetBytes(toHash));
            }

            return BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();
        }

        public static async Task<bool> Register(string Username, string password)
        {
            return await Controller.Conn.RegisterUser(Username, ComputeHash(password));
        }

        public static bool CheckUsernameExist(string Username)
        {
            try
            {
                var cmd = new NpgsqlCommand(@"SELECT COUNT(*) FROM user_credentials WHERE Username=($1) LIMIT 1")
                {
                    Parameters =
                    {
                        new() { Value = Username },
                    }
                };
                return Convert.ToInt64(Controller.Conn.ExecuteQuery(cmd)) == 1;
            } catch (Exception)
            {
                MessageBox.Show("DB error");
                return true;
            }
            
        }
    }
}
