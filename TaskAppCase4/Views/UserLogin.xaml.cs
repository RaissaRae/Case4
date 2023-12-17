using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
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

namespace TaskAppCase4.Views
{
    /// <summary>
    /// Interaction logic for UserLogin.xaml
    /// </summary>
    public partial class UserLogin : Window
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            var Username = UsernameText.Text;
            var Password = PasswordText.Password;

            using (Entites.DataContext context = new Entites.DataContext())
            {
                bool userfound = context.Users.Any(user => user.UserName == Username && user.Password == Password);

                if (userfound)
                {
                    GrantAccess();
                    Close();
                }
                else
                {
                    MessageBox.Show("User not found!");
                }
            }

        }

        public void GrantAccess()
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
