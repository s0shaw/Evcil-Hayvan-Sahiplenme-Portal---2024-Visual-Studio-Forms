using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PetAdoptionForm
{
    public partial class AdminForm : Form
    {
        private readonly string connectionString = "Server=DESKTOP-0E1A2NU\\SQLEXPRESS;Database=PetAdoptionDB;Integrated Security=True;";

        public AdminForm()
        {
            InitializeComponent();
            LoadRequests(); // Adopter isteklerini yükle
            LoadAdopteeRequests(); // AdopteeRequests verilerini yükle
            LoadAdoptionChart();
        }

        private void LoadRequests()
        {
            list_requests.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM AdopterRequests";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string request = $"İsim Soyisim: {reader["FullName"]}, " +
                                         $"Şehir: {reader["City"]}, " +
                                         $"Tel No: {reader["Phone"]}, " +
                                         $"İsim: {reader["PetName"]}, " +
                                         $"Tür: {reader["PetType"]}, " +
                                         $"Cins: {reader["Breed"]}, " +
                                         $"Yaş: {reader["Age"]}, " +
                                         $"Kısırlık: {reader["Neutered"]}";
                        list_requests.Items.Add(request);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanından veriler yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadAdopteeRequests()
        {
            list_request2.Items.Clear(); // Listeyi temizle

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Id, FullName, Phone, City, PetDetails FROM AdopteeRequests";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Her bir satırı ListBox'a ekle
                        string request = $"ID: {reader["Id"]}, İsim: {reader["FullName"]}, Tel: {reader["Phone"]}, Şehir: {reader["City"]}, Detay: {reader["PetDetails"]}";
                        list_request2.Items.Add(request);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veriler yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
           
        }

        private int ExtractIdFromRequest(string request)
        {
            // ID bilgisini ayıklamak için
            string[] parts = request.Split(',');
            string idPart = parts[0].Replace("ID: ", "").Trim();
            return int.Parse(idPart);
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (list_requests.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen onaylamak istediğiniz kaydı seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçili öğeyi al
            string selectedRequest = list_requests.SelectedItem.ToString();
            string fullName = selectedRequest.Split(',')[0].Replace("İsim Soyisim: ", "").Trim();

            // Veritabanında "Approved" sütununu güncelle
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE AdopterRequests SET Approved = 1 WHERE FullName = @FullName";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FullName", fullName);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Kayıt onaylandı ve sahiplendirilmeye hazır!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Listeden kaldır
                        list_requests.Items.RemoveAt(list_requests.SelectedIndex);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayıt onaylanırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            // Geri dönme işlemi
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            LoadAdoptionChart();
        }

        private void LoadAdoptionChart()
        {
            chart1.Series.Clear(); // Grafik serilerini temizle

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL sorgusu: Türlere göre onaylanmış hayvanların sayısını getir
                    string query = "SELECT PetType, COUNT(*) AS AnimalCount FROM AdopterRequests WHERE Approved = 1 GROUP BY PetType";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    // Yeni bir grafik serisi oluştur
                    var series = new System.Windows.Forms.DataVisualization.Charting.Series
                    {
                        Name = "Sahiplendirilen Hayvan Türleri",
                        ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
                    };

                    while (reader.Read())
                    {
                        string petType = reader["PetType"].ToString();
                        int count = Convert.ToInt32(reader["AnimalCount"]);

                        // Seriye veri ekle
                        series.Points.AddXY(petType, count);
                    }

                    chart1.Series.Add(series); // Grafiğe seriyi ekle
                    chart1.Titles.Clear();
                    chart1.Titles.Add("Türlere Göre Sahiplendirilen Hayvan Sayısı");

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Grafik verileri yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void btn_refuse_Click(object sender, EventArgs e)
        {
            if (list_requests.SelectedIndex == -1) // Hiçbir öğe seçili değilse
            {
                MessageBox.Show("Lütfen silmek istediğiniz kaydı seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçili öğeyi al
            string selectedRequest = list_requests.SelectedItem.ToString();

            // FullName alanını ayıklamak için
            string fullName = selectedRequest.Split(',')[0].Replace("İsim Soyisim: ", "").Trim();

            // Veritabanından silme işlemi
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM AdopterRequests WHERE FullName = @FullName";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FullName", fullName);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Kayıt başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Listeden kaldır
                        list_requests.Items.RemoveAt(list_requests.SelectedIndex);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt silinemedi. Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_accept2_Click(object sender, EventArgs e)
        {
            if (list_request2.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir kayıt seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedRequest = list_request2.SelectedItem.ToString();
            int id = ExtractIdFromRequest(selectedRequest);

            var result = MessageBox.Show("Bu hayvanı sahiplendirmek ve tüm tablolardan silmek istediğinize emin misiniz?",
                                         "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        // Silme sorgusu
                        string query = "DELETE FROM AdopterRequests WHERE Id = @Id; DELETE FROM AdopteeRequests WHERE Id = @Id;";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Id", id);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Kayıt sahiplendirildi ve tüm tablolardan kaldırıldı.",
                                        "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Listeleri yenile
                        LoadAdopteeRequests();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("İşlem sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_refuse2_Click(object sender, EventArgs e)
        {
            if (list_request2.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir kayıt seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedRequest = list_request2.SelectedItem.ToString();
            int id = ExtractIdFromRequest(selectedRequest);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM AdopteeRequests WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Kayıt reddedildi ve listeden kaldırıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadAdopteeRequests(); // Listeyi yenile
                }
                catch (Exception ex)
                {
                    MessageBox.Show("İşlem sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
