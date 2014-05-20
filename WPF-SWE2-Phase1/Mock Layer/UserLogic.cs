using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_SWE2_Phase1.Mock_Layer
{
    public partial class UserLogic
    {


        public bool Login_Logic(string name, string password)
        {


            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(password))
            {
                return true;
            }
            else

                return false;

        }



        //    public bool add_user_logic(string name, string password, bool role)
        //    {

        //}
    }
}