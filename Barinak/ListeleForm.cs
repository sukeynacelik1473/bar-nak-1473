using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barinak
{
    public partial class ListeleForm : Form
    {
        string baglanti = "Server=localhost;Database=barınak;Uid=root;Pwd=;";
        string yeniAd = null;
        public ListeleForm()
        {
            InitializeComponent();
        }


        public void DgwDoldur()
        {
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
                string sorgu = "SELECT * FROM hayvanlar;";
                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgwHayvanlar.DataSource = dt;

                dgwHayvanlar.Columns["engel_durumu"].Visible = false;



            }
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

        private void ListeleForm_Load(object sender, EventArgs e)
        {

            DgwDoldur();
            CmbDoldur();
        }

        private void dgwHayvanlar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwHayvanlar.SelectedRows.Count > 0)
            {
                txtAd.Text = dgwHayvanlar.SelectedRows[0].Cells["adi"].Value.ToString();
                txtYas.Text = dgwHayvanlar.SelectedRows[0].Cells["yas"].Value.ToString();
                cmbTur.SelectedValue = dgwHayvanlar.SelectedRows[0].Cells["cins"].Value.ToString();
                cbEngel.Checked = Convert.ToBoolean(dgwHayvanlar.SelectedRows[0].Cells["engel_durumu"].Value);

                string posterYol = Path.Combine(Environment.CurrentDirectory, "foto", dgwHayvanlar.SelectedRows[0].Cells["fotograf_adi"].Value.ToString());
                if (File.Exists(posterYol))
                {
                    pbResim.ImageLocation = posterYol;
                    pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pbResim.ImageLocation = null;
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgwHayvanlar.SelectedCells.Count > 0)
            {
                string sorgu = "UPDATE hayvanlar SET adi=@adi, yas = @yas, cins = @cins, engel_durumu= @engel, fotograf_adi = @resim WHERE id = @id";
                using (MySqlConnection baglan = new MySqlConnection(baglanti))
                {
                    baglan.Open();

                    MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                    cmd.Parameters.AddWithValue("@adi", txtAd.Text);
                    cmd.Parameters.AddWithValue("@yas", txtYas.Text);
                    cmd.Parameters.AddWithValue("@cins", cmbTur.SelectedValue);
                    cmd.Parameters.AddWithValue("@engel", cbEngel.Checked);
                    cmd.Parameters.AddWithValue("@resim", yeniAd);
                
                    int satirid = Convert.ToInt32(dgwHayvanlar.SelectedRows[0].Cells["id"].Value);
                    cmd.Parameters.AddWithValue("@id", satirid);

                    cmd.ExecuteNonQuery();

                    DgwDoldur();

                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgwHayvanlar.SelectedRows[0];

            int id = Convert.ToInt32(dr.Cells[0].Value);

            string posterYol = Path.Combine(Environment.CurrentDirectory, "foto", dgwHayvanlar.SelectedRows[0].Cells["fotograf_adi"].Value.ToString());


            DialogResult cevap = MessageBox.Show("Hayvan Kaydını silmek istediğinizden emin misiniz?",
                                                 "Kayıt Sil", MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);


            if (cevap == DialogResult.Yes)
            {

                using (MySqlConnection baglan = new MySqlConnection(baglanti))
                {
                    int satirid = Convert.ToInt32(dgwHayvanlar.SelectedRows[0].Cells["id"].Value);
                    baglan.Open();
                    string sorgu = "DELETE FROM hayvanlar WHERE id=@satirid;";
                    MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                    cmd.Parameters.AddWithValue("@satirid", satirid);
                    cmd.ExecuteNonQuery();


                    if (File.Exists(posterYol))
                    {

                        File.Delete(posterYol);
                    }
                    DgwDoldur();
                }
            }
        }
    }
}
