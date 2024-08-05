using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project.Products;
namespace Project11
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            PerformUserLogin();

        }
        private void PerformUserLogin()
        {
            string username = txtid.Text;
            string password = txtPass.Text;

            if (UserManager.GetInstance().ValidateUser(username, password, out bool isAdmin))
            {
                MessageBox.Show("User login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserProfileForm userProfileForm = new UserProfileForm();
                userProfileForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            string username = txtid.Text;
            string password = txtPass.Text;

            // Admin login logic
            if (IsAdminValid(username, password))
            {
                MessageBox.Show("Admin login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid admin username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool IsAdminValid(string username, string password)
        {
            // Replace with proper admin validation logic
            return username == "admin" && password == "adminpassword";
        }

        private void linkRegister_LinkClicked_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogadmin_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
           
            this.Hide();

            // Admin login logic
            
        }
    }
}
