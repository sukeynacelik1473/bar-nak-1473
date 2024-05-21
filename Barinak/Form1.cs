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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YeniEkleForm yeniEkleForm = new YeniEkleForm();
            yeniEkleForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListeleForm listeleForm = new ListeleForm();
            listeleForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("foto"))
            {
                Directory.CreateDirectory("foto");
            }
        }
    }
}
