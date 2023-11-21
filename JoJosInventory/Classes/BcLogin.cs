using JoJosInventory.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace JoJosInventory.Classes
{
    public class BcLogin
    {
        private static BcLogin instance = null;
        public string Username { get; set; }
        public string Email { get; set; }
        DbSingleton myDb = DbSingleton.Instance;

        public bool SetNewPassword(string id, string password)
        { 
            return myDb.SetNewPassword(id, password);
        }

        public string CheckReset(string email, string code)
        {
            return myDb.CheckReset(email, code);
        }
        public bool ForgotPassword(string email)
        {
            Random random = new Random();
            int code = random.Next(100000, 1000000);
            bool f = myDb.ForgotPassword(email, code.ToString());
            if (f) Classes.UtilityClass.SendEmail(email, "Recovery code", code.ToString());

            return f;
        }
        
        public bool Login(string username, string password)
        {
            return myDb.Login(username, password);            
        }
        private BcLogin()
        {            
        }

        public static BcLogin Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BcLogin();
                }
                return instance;
            }
        }

    }
}

