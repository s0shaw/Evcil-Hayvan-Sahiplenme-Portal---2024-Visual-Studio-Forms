using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetAdoptionForm
{
    public partial class Form1 : Form
    {
        private const string AdminUsername = "admin";
        private const string AdminPassword = "admin";

        public static string AdopterName;
        public static string AdopteeName;

        public Form1()
        {
            InitializeComponent();
        }

        private void rbtn_admin_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void rbtn_adoptee_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbtn_adopter_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (rbtn_admin.Checked)
            {
                string username = lgn_username.Text;
                string password = lgn_password.Text;

                if (username == AdminUsername && password == AdminPassword)
                {
                    AdminForm adminForm = new AdminForm();
                    this.Hide();
                    adminForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid admin credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rbtn_adopter.Checked)
            {
                if (!string.IsNullOrEmpty(lgn_username.Text))
                {
                    AdopterName = lgn_username.Text; // Adopter adını al
                    AdopterForm adopterForm = new AdopterForm();
                    this.Hide();
                    adopterForm.Show();
                }
                else
                {
                    MessageBox.Show("Lütfen Ad Soyad bilgisini giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (rbtn_adoptee.Checked) // Adoptee rolü seçilirse
            {
                if (!string.IsNullOrEmpty(lgn_username.Text))
                {
                    string userName = lgn_username.Text; // Kullanıcı adını al
                    AdopteeForm adopteeForm = new AdopteeForm(); // AdopteeForm'a geçiş
                    this.Hide();
                    adopteeForm.Show();
                }
                else
                {
                    MessageBox.Show("Lütfen isim soyisim bilgisini giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a role and provide credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
