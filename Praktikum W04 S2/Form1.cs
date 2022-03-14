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
    public partial class FormPenambahanData : Form
    {
        public FormPenambahanData()
        {
            InitializeComponent();
        }
        private void txtBoxTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        public DataTable kumpulanData = new DataTable();
        private void FormPenambahanData_Load(object sender, EventArgs e)
        {
            kumpulanData.Columns.Add("Nama");
            kumpulanData.Columns.Add("Alamat");
            kumpulanData.Columns.Add("Telp");
        }
        public void btnSimpan_Click(object sender, EventArgs e)
        {
            kumpulanData.Rows.Add(txtBoxNama.Text, txtBoxAlamat.Text, txtBoxTelp.Text);
            txtBoxNama.Clear();
            txtBoxAlamat.Clear();
            txtBoxTelp.Clear();
            if (kumpulanData.Rows.Count >= 10)
            {
                MessageBox.Show("Data telah penuh!");
            }
        }
        private void btnLihatData_Click(object sender, EventArgs e)
        {
            FormTampilanData newForm = new FormTampilanData(kumpulanData);
            newForm.ShowDialog();
            this.Show();
        }
    }
}
