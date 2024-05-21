using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Barinak
{
    public partial class YeniEkleForm : Form
    {
        string baglanti = "Server=localhost;Database=barınak;Uid=root;Pwd=;";
        string yeniAd = null;

        public YeniEkleForm()
        {
            InitializeComponent();
        }

        private void CmbDoldur()
        {
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
                string sorgu = "SELECT DISTINCT cins FROM hayvanlar;";
                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbTur.DataSource = dt;

                cmbTur.DisplayMember = "cins";
                cmbTur.ValueMember = "cins";


            }
        }

        private void YeniEkleForm_Load(object sender, EventArgs e)
        {

            CmbDoldur();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();

                string sorgu = "INSERT INTO hayvanlar VALUES(NULL,@adi,@yas,@cins,@engel,@foto);";
                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                cmd.Parameters.AddWithValue("@adi", txtAd.Text);
                cmd.Parameters.AddWithValue("@yas", Convert.ToInt32(txtYas.Text));
                cmd.Parameters.AddWithValue("@cins", cmbTur.SelectedValue);
                cmd.Parameters.AddWithValue("@engel", cbEngel.Checked);
                cmd.Parameters.AddWithValue("@foto", yeniAd);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Kayıt Eklendi");
                    this.Close();

                }

            }
        }

        private void pbResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";


            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                string kaynakYol = openFileDialog.FileName;
                yeniAd = Guid.NewGuid().ToString() + Path.GetExtension(kaynakYol);
                string hedefYol = Path.Combine(Environment.CurrentDirectory, "foto", yeniAd);

                File.Copy(kaynakYol, hedefYol);

                pbResim.ImageLocation = hedefYol;
                pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
