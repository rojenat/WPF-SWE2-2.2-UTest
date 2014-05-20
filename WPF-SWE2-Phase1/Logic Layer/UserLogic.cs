using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_SWE2_Phase1.Logic_Layer
{
    public partial class UserLogic
    {
       private Account account;
       private PharmacyFinalEntities dbLogic = new PharmacyFinalEntities();

        public bool Login_Logic(string name, string password)
        {
            try
            {
                MainWindow.user = dbLogic.Accounts.Single(acc => acc.Name == name && acc.Password == password);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool add_user_logic(string name, string password, bool role)
        {
            account.Name = name;
            account.Password = password;
            account.Role = role;
            try
            {
                MainWindow.db.Accounts.Add(account);
                MainWindow.db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}