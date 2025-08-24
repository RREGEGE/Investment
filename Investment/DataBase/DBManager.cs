using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Investment.DataBase
{
    public class DBManager
    {
        private const string ConnectionString =
        "Server=127.0.0.1;Port=3306;Database=myportfolio;Uid=root;Pwd=0000;";

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        // SHA256 해싱 함수
        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // 바이트 배열을 16진수 문자열로 변환
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        /// <summary>
        /// 회원가입 (INSERT) 함수
        /// -> 새로운 사용자 정보를 DB의 User 테이블에 삽입합니다.
        /// </summary>
        /// <returns>삽입 성공 시 true, 실패 시 false</returns>
        public bool RegisterUser(string userId, string username, string password, string phone)
        {
            string passwordHash = ComputeSha256Hash(password);

            string query =
                "INSERT INTO users (UserId, Username, PasswordHash, Phone) VALUES (@UserId, @Username, @PasswordHash, @Phone)";

            using (MySqlConnection connection = GetConnection())
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@PasswordHash", passwordHash);
                command.Parameters.AddWithValue("@Phone", phone);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show("MySQL 연결 오류가 발생했습니다: " + ex.Message, "연결 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("알 수 없는 오류가 발생했습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }


        public bool LoginUser(string userId, string password)
        {
            string passwordHash = ComputeSha256Hash(password);

            string query =
                "SELECT COUNT(*) FROM Users WHERE UserId = @UserId AND PasswordHash = @PasswordHash";

            using (MySqlConnection connection = GetConnection())
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@PasswordHash", passwordHash);

                try
                {
                    connection.Open();
                    long count = (long)command.ExecuteScalar();

                    return count == 1;
                }
                catch (MySqlException ex)
                {
                    System.Diagnostics.Debug.WriteLine($"DB Login Error: {ex.Message}");
                    return false;
                }
            }
        }

    }
}
