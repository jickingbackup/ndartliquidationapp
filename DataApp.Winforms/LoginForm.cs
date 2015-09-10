using DataApp.Core;
using DataApp.Core.Models;
using DataApp.Winforms.Factories;
using System;
using System.Windows.Forms;

namespace DataApp.Winforms
{
    public partial class LoginForm : Form
    {
        DataAppFacade db = DataAppFactory.Create();


        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            User user = null;
            string username = "";
            string password = "";

            username = usernametextBox.Text;
            password = passwordtextBox.Text;

            user = db.UserController.Login(username, password);

            if(user == null)
            {
                MessageBox.Show("Sorry,Invalid Credentials.");
                return;
            }

            //initilaize main form here
            //TODO: add it here.
            MessageBox.Show("Creating main form...");

            FormFactory.CreateMainForm().Show();
            this.Close();
        }
    }
}
