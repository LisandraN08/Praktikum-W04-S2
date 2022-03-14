using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Praktikum_W04_S2
{

    public partial class FormTampilanData : Form
    {
        DataTable kumpulanData = new DataTable();
        public FormTampilanData(DataTable table)
        {
            InitializeComponent();
            kumpulanData = table;
        }
        private void FormTampilanData_Load(object sender, System.EventArgs e)
        {
            if (kumpulanData.Rows.Count == 0)
            {
                txtBoxTampilanNama.Text = "<data kosong>";
                txtBoxTampilanAlamat.Text = "<data kosong>";
                txtBoxTampilanTelp.Text = "<data kosong>";
            }
            else 
            {
                txtBoxTampilanNama.Text = kumpulanData.Rows[0][0].ToString();
                txtBoxTampilanAlamat.Text = kumpulanData.Rows[0][1].ToString();
                txtBoxTampilanTelp.Text = kumpulanData.Rows[0][2].ToString();
            }
        }
        int statusRow = 0;
        private void btnNextData_Click(object sender, System.EventArgs e)
        {
            if (statusRow == kumpulanData.Rows.Count - 1)
            {
                MessageBox.Show("Data sudah data terakhir");
            }
            else 
            {
                statusRow += 1;
                txtBoxTampilanNama.Text = kumpulanData.Rows[statusRow][0].ToString();
                txtBoxTampilanAlamat.Text = kumpulanData.Rows[statusRow][1].ToString();
                txtBoxTampilanTelp.Text = kumpulanData.Rows[statusRow][2].ToString();
            }
        }
        private void btnPrevData_Click(object sender, EventArgs e)
        {
            if (statusRow <= 0)
            {
                MessageBox.Show("Data sudah data pertama");
            }
            else 
            {
                statusRow -= 1;
                txtBoxTampilanNama.Text = kumpulanData.Rows[statusRow][0].ToString();
                txtBoxTampilanAlamat.Text = kumpulanData.Rows[statusRow][1].ToString();
                txtBoxTampilanTelp.Text = kumpulanData.Rows[statusRow][2].ToString();
            }
        }
        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
