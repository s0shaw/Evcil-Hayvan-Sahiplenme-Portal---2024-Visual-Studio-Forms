using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetAdoptionForm
{
    public partial class AdopterForm : Form
    {
        private readonly string connectionString = "Server=DESKTOP-0E1A2NU\\SQLEXPRESS;Database=PetAdoptionDB;Integrated Security=True;";

        public AdopterForm()
        {
            InitializeComponent();
        }

        private void kryptonLabel6_Click(object sender, EventArgs e)
        {
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "INSERT INTO AdopterRequests (FullName, City, Phone, PetName, PetType, Breed, Age, Neutered) " +
                                       "VALUES (@FullName, @City, @Phone, @PetName, @PetType, @Breed, @Age, @Neutered)";
                        SqlCommand command = new SqlCommand(query, connection);

                        // Yaş alanının sayı olduğunu kontrol et
                        int age;
                        if (!int.TryParse(guna2TextBox2.Text, out age))
                        {
                            MessageBox.Show("Yaş alanına geçerli bir sayı giriniz.");
                            return;
                        }

                        // Parametreleri ekle
                        command.Parameters.AddWithValue("@FullName", guna2TextBox1.Text);
                        command.Parameters.AddWithValue("@City", guna2TextBox5.Text);
                        command.Parameters.AddWithValue("@Phone", guna2TextBox4.Text);
                        command.Parameters.AddWithValue("@PetName", guna2TextBox8.Text);
                        command.Parameters.AddWithValue("@PetType", guna2TextBox7.Text); // Type yerine PetType
                        command.Parameters.AddWithValue("@Breed", guna2TextBox6.Text);
                        command.Parameters.AddWithValue("@Age", age);
                        command.Parameters.AddWithValue("@Neutered", guna2TextBox3.Text);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Bilgiler başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veritabanına kaydedilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            
        }

        private void btn_back2_Click(object sender, EventArgs e)
        {
            // Geri dönme işlemi
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
