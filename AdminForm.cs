using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project11
{
    public partial class AdminForm : Form
    {
        
        public AdminForm()
        {
            InitializeComponent();
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            // Optional: Initialization code
        }
        private void btnlogina_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            
            string username = txtid.Text;
            string password = txtPass.Text;
            bool adminvalid=login.IsAdminValid(username, password);
            if (adminvalid)
            {
                MessageBox.Show("Admin login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserProfileForm form = new UserProfileForm();
                form.Show();

            }
            else
            {
                MessageBox.Show("Invalid admin username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("WELCOME TO ADMIN PAGE");
        }

        private void AdminForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
