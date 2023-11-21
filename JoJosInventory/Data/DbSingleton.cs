using JoJosInventory.Classes;
using Microsoft.VisualBasic;
using System.Data;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace JoJosInventory.Data
{
    public class DbSingleton
    {
        private static DbSingleton instance = null;
        private SqlConnection connection;
        private string connectionStringLocal;
        //********** LookUp Queries **********************************************
        public Base RawCategoryGetList()
        {            
            Base bs = new Base();
            bs.error = false;
            bs.message = "";
            List<string> resultListCategories = new List<string>();
            List<string> resultListSku = new List<string>();

            try
            {
                string sql = string.Format("SELECT * FROM[jojosInventory].[dbo].[RawCategories]");
                SqlCommand cmd = new SqlCommand(sql, connection);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        resultListCategories.Add(reader.GetString(1));
                        resultListSku.Add(reader.GetString(2));
                    }
                    List<List<string>> list = new List<List<string>>();
                    list.Add(resultListCategories);
                    list.Add(resultListSku);
                    bs.objet = list;
                }
            }
            catch (Exception ex)
            {
                bs.error = true;
                bs.message = ex.Message;
                //Console.WriteLine(ex.Message);
            }
            return bs;

        }
        //********** Base material Queries **********************************************
        public Base BaseMaterialEdit(int Id, string name, string sku, DateOnly? dueDate, string qty)
        {
            Base bs = new Base();
            bs.error = false;
            bs.message = "";
            try
            {
                string sql;
                if (dueDate == null)
                {
                    sql = string.Format("UPDATE [jojosInventory].[dbo].[RawMaterial] SET Name = '{0}', Sku = '{1}', DueDate = null, CurrentAmount = {2} WHERE Id = {3}", name, sku, qty, Id);
                }
                else
                {
                    string dd = dueDate.Value.Year.ToString() + "-" + dueDate.Value.Month.ToString() + "-" + dueDate.Value.Day.ToString();
                    sql = string.Format("UPDATE [jojosInventory].[dbo].[RawMaterial] SET Name = '{0}', Sku = '{1}', DueDate = '{2}', CurrentAmount = {3} WHERE Id = {4}", name, sku, dueDate.Value, qty, Id);
                }

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                bs.error = true;
                bs.message = ex.Message;
                //Console.WriteLine(ex.Message);
            }
            return bs;
        }

        public Base BaseMaterialAdd(string name, string sku, DateOnly? dueDate, string qty)
        {
            Base bs = new Base();
            bs.error = false;
            bs.message = "";
            try
            {
                string sql;
                if (dueDate == null)
                {
                    sql = string.Format("INSERT INTO [jojosInventory].[dbo].[RawMaterial] VALUES ('{0}','{1}',null,{2},0,0)", name, sku, qty);
                }else
                {
                    sql = string.Format("INSERT INTO [jojosInventory].[dbo].[RawMaterial] VALUES ('{0}','{1}','{2}',{3},0,0)", name, sku, dueDate.Value, qty);
                }
                
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                bs.error = true;
                bs.message = ex.Message;
                //Console.WriteLine(ex.Message);
            }
            return bs;
        }
            public Base BaseMaterialDelete(string list)
        {
            Base bs = new Base();
            bs.error = false;
            bs.message = "";
            try
            {
                string sql = string.Format("UPDATE [jojosInventory].[dbo].[RawMaterial] SET IsDelete = 1 WHERE Id in {0}",list);
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.ExecuteNonQuery();
                }                
            }
            catch (Exception ex)
            {
                bs.error = true; 
                bs.message=ex.Message;
                //Console.WriteLine(ex.Message);
            }
            return bs;
        }
        public Base BaseMaterialSearch(string? category, DateOnly? Duedate, string? SKU)
        {
            Base bs = new Base();            
            bs.error = false;
            bs.message = "";
            try
            {
                string sql = string.Format("SELECT Id, Name, Sku, DueDate, CurrentAmount, AmountLocked, (CurrentAmount - AmountLocked) AS QtyAvailable  FROM [jojosInventory].[dbo].[RawMaterial] WHERE IsDelete = 0");
                if (!String.IsNullOrEmpty(category)) { sql = sql + " AND Name like '%" + category + "%'"; }
                if (!(Duedate == null)) { sql = sql + " AND Duedate = '" + Duedate.Value + "'"; }
                if (!String.IsNullOrEmpty(SKU)) { sql = sql + " AND Sku like '%" + SKU + "%'"; }

                SqlCommand cmd = new SqlCommand(sql, connection);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    bs.objet = dataTable;
                }               
            }
            catch (Exception ex)
            {
                bs.error = true;
                bs.message = ex.Message;
                //Console.WriteLine(ex.Message);
            }
            return bs;

        }

        //********** Login Queries **********************************************
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
        //************************** Instance & connections *******************************************
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
