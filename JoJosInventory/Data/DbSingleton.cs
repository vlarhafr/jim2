using JoJosInventory.Classes;
using System.Data.SqlClient;

namespace JoJosInventory.Data
{
    public class DbSingleton
    {
        private static DbSingleton instance = null;
        private SqlConnection connection;
        private string connectionStringLocal;  
        
        public bool SetNewPassword(string id, string password)
        {           
            try
            {
                password = UtilityClass.CreateMD5(password);
                string sql = string.Format("UPDATE [jojosInventory].[dbo].[Users] SET Password ='{0}', ResetPasswordRequired = 0 WHERE id = {1}", password, id);
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.ExecuteNonQuery();
                }
                return true;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return false;

        }

        public string CheckReset(string email, string code)
        {
            string id = "0";
            string query = string.Format("SELECT *  FROM [jojosInventory].[dbo].[Users] WHERE IsActive = 1 AND IsDelete = 0 AND email = '{0}' AND code = '{1}'", email, code);
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {                        
                        return reader[0].ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return id;
        }
        
        public bool ForgotPassword(string email, string code)
        {
            string id = "0"; 
            string query = string.Format("SELECT id FROM [jojosInventory].[dbo].[Users] WHERE IsActive = 1 AND IsDelete = 0 AND email = '{0}'", email);
            SqlCommand command = new SqlCommand(query, connection);
            
            try
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = reader[0].ToString();
                        break;
                    }
                    if (id == "0") return false;
                }
                string sql = string.Format("UPDATE [jojosInventory].[dbo].[Users] SET code ='{0}', ResetPasswordRequired = 1 WHERE id = {1}",code,id);
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.ExecuteNonQuery();
                }
                return true;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return false;

        }

        public bool Login(string user, string password)
        {            
            password = UtilityClass.CreateMD5(password);
            string query = string.Format("SELECT *  FROM [jojosInventory].[dbo].[Users] WHERE IsActive = 1 AND IsDelete = 0 AND UserName = '{0}' AND Password = '{1}'",user,password);
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        BcLogin login = BcLogin.Instance;
                        login.Username = reader[1].ToString();
                        login.Email = reader[3].ToString();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);                
            }
            return false;

        }
        //*********************************************************************
        private DbSingleton()
        {
        }

        public static DbSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DbSingleton();
                }
                return instance;
            }
        }

        public void CreateConnection(string connectionString)
        {
            connectionStringLocal = connectionString;

            //using (connection = new SqlConnection(connectionStringLocal))
            connection = new SqlConnection(connectionStringLocal);
                //{
                try
                {
                    connection.Open();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error al conectarse a la base de datos: " + e.Message);
                }
            //}
        }

        public void CloseConnection()
        {            
            {
                try
                {            
                    if (connection.State.Equals(System.Data.ConnectionState.Open))connection.Close();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Error al conectarse a la base de datos: " + e.Message);
                }
            }
        }

    }
}
