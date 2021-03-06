﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_SWE2_Phase1.Logic_Layer
{
    /// <summary>
    /// Interaction logic for AddUser.xaml
    /// </summary>
    public partial class AddUser : Page
    {
        public AddUser()
        {
            InitializeComponent();
            userTextBlock.Text = "Welcome: " + MainWindow.user.Name + "\nRole: Admin";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Account account = new Account();
            //account.Name = this.textBox1.Text;
            //account.Password = this.PasswordTextField.Password;
            //account.Role = (bool)AdminRadioBtn.IsChecked;

            //MessageBox.Show(account.Name + "\n" + account.Password + "\n" + account.Role);

            //MainWindow.db.Accounts.Add(account);
            //MainWindow.db.SaveChanges();

            UserLogic addUser = new UserLogic();

            if (addUser.add_user_logic(textBox1.Text, PasswordTextField.Password, (bool)AdminRadioBtn.IsChecked))
                dataGrid.ItemsSource = MainWindow.db.Accounts.ToList();
            else
                MessageBox.Show("Error adding user, please fill all the fields.");


        }
    }
}
