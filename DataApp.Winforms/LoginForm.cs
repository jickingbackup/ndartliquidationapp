using DataApp.Core;
using DataApp.Core.Models;
using System;
using System.Windows.Forms;

namespace DataApp.Winforms
{
    public partial class LoginForm : Form
    {
        DataAppCore db = DataAppFactory.Create();
        MainForm mainform = null;

        public LoginForm(MainForm form)
        {
            InitializeComponent();
            this.mainform = form;
        }

        #region CUSTOM CODE
        private void Login()
        {
            User user = null;
            string username = "";
            string password = "";

            username = usernametextBox.Text;
            password = passwordtextBox.Text;

            user = db.UserController.Login(username, password);

            if (user == null)
            {
                MessageBox.Show("Sorry,Bad login.");
                return;
            }

            //initilaize main form here
            //TODO: add it here.
            mainform.Show();
            this.Close();
        } 
        #endregion

        #region EVENTS
        private void loginButton_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Closing Application...");
            mainform.Close();
        }
        #endregion
    }
}
