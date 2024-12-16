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
    public partial class AdopteeForm : Form
    {
        private readonly string connectionString = "Server=DESKTOP-0E1A2NU\\SQLEXPRESS;Database=PetAdoptionDB;Integrated Security=True;";

        public AdopteeForm()
        {
            InitializeComponent();
            LoadApprovedRequests(); // Form yüklendiğinde onaylı kayıtları yükle
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            // Geri dönme işlemi
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void LoadApprovedRequests()
        {
            clb_adopteeRequests.Items.Clear(); // Listeyi temizle

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT FullName, City, PetName, PetType, Breed FROM AdopterRequests WHERE Approved = 1";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string request = $"İsim Soyisim: {reader["FullName"]}, Şehir: {reader["City"]}, " +
                                         $"Pet İsmi: {reader["PetName"]}, Tür: {reader["PetType"]}, Cins: {reader["Breed"]}";
                        clb_adopteeRequests.Items.Add(request, false);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Onaylı kayıtlar yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            // Refresh butonuna basıldığında onaylı kayıtları yeniden yükle
            LoadApprovedRequests();
        }

        private void btn_istek_Click(object sender, EventArgs e)
        {
            // Kullanıcı girişlerinin boş olup olmadığını kontrol et
            if (string.IsNullOrEmpty(guna2TextBox1.Text) ||
                string.IsNullOrEmpty(guna2TextBox3.Text) ||
                string.IsNullOrEmpty(guna2TextBox2.Text))
            {
                MessageBox.Show("Lütfen tüm bilgileri eksiksiz doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // CheckedListBox'tan seçili öğeleri kontrol et
            string petDetails = string.Empty;

            foreach (object item in clb_adopteeRequests.CheckedItems)
            {
                petDetails = item.ToString();
                break; // İlk seçili öğeyi al
            }

            if (string.IsNullOrEmpty(petDetails))
            {
                MessageBox.Show("Lütfen bir hayvan seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO AdopteeRequests (FullName, Phone, City, PetDetails) " +
                                   "VALUES (@FullName, @Phone, @City, @PetDetails)";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@FullName", guna2TextBox1.Text);
                    command.Parameters.AddWithValue("@Phone", guna2TextBox3.Text);
                    command.Parameters.AddWithValue("@City", guna2TextBox2.Text);
                    command.Parameters.AddWithValue("@PetDetails", petDetails);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // TextBox'ları temizle
                    guna2TextBox1.Clear();
                    guna2TextBox3.Clear();
                    guna2TextBox2.Clear();

                    // CheckedListBox'taki işareti kaldır
                    clb_adopteeRequests.ClearSelected();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanına kaydedilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
