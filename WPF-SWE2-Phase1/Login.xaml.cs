using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Configuration;

namespace WPF_SWE2_Phase1.Logic_Layer
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        private PharmacyFinalEntities db = new PharmacyFinalEntities();
        bool check;
        public Login()
        {
            InitializeComponent();
            dataGrid.ItemsSource = db.Accounts.ToList();
           
        

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           UserLogic user1 = new UserLogic();
           check = user1.Login_Logic(mytext1.Text, mytext2.Text);
           if (check == true)
           {
                if (MainWindow.user.Role == true)
                {
                    Admin adminPage = new Admin();
                    this.NavigationService.Navigate(adminPage);
                }
                else
                {
                    UserLogic userPage = new UserLogic();
                    this.NavigationService.Navigate(userPage);
                }
           }
            else
                MessageBox.Show("Wrong username or password");
       
         
            //ConnectionStringSettings connection =  ConfigurationManager.ConnectionStrings["PharmacyFinalEntities"];
            //MessageBox.Show(connection.IsReadOnly().ToString());

            //try
            //{
            //    MainWindow.user = db.Accounts.Single(acc => acc.Name == mytext1.Text && acc.Password == mytext2.Text);

               
          
        }
    }
}

