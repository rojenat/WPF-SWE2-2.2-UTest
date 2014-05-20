using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WPF_SWE2_Phase1.Mock_Layer;
namespace Test_On_Pharmacy_Management_System
{
    [TestFixture, RequiresSTA]
    class Test_On_Logic_Functions
    {
        public  UserLogic user_test=new UserLogic();
        
        [Test]
        public void test_on_userLogin_parameters()
        {
            bool actual = user_test.Login_Logic("Zabady", "123");
            Assert.IsTrue(actual);
        }
    }
}
