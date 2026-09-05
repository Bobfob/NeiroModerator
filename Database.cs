using MySql.Data.MySqlClient;
using System.Data;

namespace NeiroModerator
{
    internal class Database
    {
        private const string conString =
            "server = 45.129.186.91; port = 3307; database = golubev_isp44_main;" +
            "uid = Golubev-ISP44; pwd = Jm74Vq2Nf8Rz5KcX9dLp;" +
            "sslmode = None; allowpublickeyretrieval = True;";

        public static int Authenticate(string login, string password)
        {
            using MySqlConnection m_conn = new MySqlConnection(conString);

            m_conn.Open();

            string users_query =
                "SELECT idUser FROM Users " +
                "WHERE Login = @login " +
                "AND PasswordHash = @password " +
                "LIMIT 1";

            using MySqlCommand m_cmd = new MySqlCommand(users_query, m_conn);

            m_cmd.Parameters.AddWithValue("@login", login);
            m_cmd.Parameters.AddWithValue("@password", password);

            object? result = m_cmd.ExecuteScalar();

            if (result is null)
            {
                return 0;
            }

            return Convert.ToInt32(result);
        }

        public static void AddHistory(string message, string status, int confidence)
        {
            using MySqlConnection connection = new MySqlConnection(conString);

            connection.Open();

            string sql =
                "INSERT INTO ModerationHistory " +
                "(UserID, Message, Status, Confidence) " +
                "VALUES (@userId, @message, @status, @confidence);";

            using MySqlCommand command = new MySqlCommand(sql, connection);

            command.Parameters.AddWithValue("@userId", Session.UserID);
            command.Parameters.AddWithValue("@message", message);
            command.Parameters.AddWithValue("@status", status);
            command.Parameters.AddWithValue("@confidence", confidence);

            command.ExecuteNonQuery();
        }

        public static DataTable GetHistory()
        {
            using MySqlConnection connection = new MySqlConnection(conString);

            connection.Open();

            string sql =
                "SELECT idModerationHistory, Message, Status, Confidence, CreatedAt " +
                "FROM ModerationHistory " +
                "WHERE UserID = @userId " +
                "ORDER BY CreatedAt DESC;";

            using MySqlCommand command = new MySqlCommand(sql, connection);

            command.Parameters.AddWithValue("@userId", Session.UserID);

            DataTable table = new DataTable();

            using MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            adapter.Fill(table);
            return table;
        }

        public static void DeleteHistory(int historyId)
        {
            using MySqlConnection connection = new MySqlConnection(conString);

            connection.Open();

            string sql =
                "DELETE FROM ModerationHistory " +
                "WHERE idModerationHistory = @historyId AND UserID = @userId;";

            using MySqlCommand command = new MySqlCommand(sql, connection);

            command.Parameters.AddWithValue("@historyId", historyId);
            command.Parameters.AddWithValue("@userId", Session.UserID);
            command.ExecuteNonQuery();
        }

        public static void DeleteAllHistory()
        {
            using MySqlConnection connection = new MySqlConnection(conString);

            connection.Open();

            string sql =
                "DELETE FROM ModerationHistory " +
                "WHERE UserID = @userId;";

            using MySqlCommand command = new MySqlCommand(sql, connection);

            command.Parameters.AddWithValue("@userId", Session.UserID);
            command.ExecuteNonQuery();
        }
    }
}
