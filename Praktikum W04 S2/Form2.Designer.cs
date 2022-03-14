
namespace Praktikum_W04_S2
{
    partial class FormTampilanData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNama = new System.Windows.Forms.Label();
            this.txtBoxTampilanNama = new System.Windows.Forms.TextBox();
            this.txtBoxTampilanAlamat = new System.Windows.Forms.TextBox();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.txtBoxTampilanTelp = new System.Windows.Forms.TextBox();
            this.lblTelp = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            this.btnPrevData = new System.Windows.Forms.Button();
            this.btnNextData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(57, 54);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(49, 17);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama:";
            // 
            // txtBoxTampilanNama
            // 
            this.txtBoxTampilanNama.Location = new System.Drawing.Point(113, 54);
            this.txtBoxTampilanNama.Name = "txtBoxTampilanNama";
            this.txtBoxTampilanNama.ReadOnly = true;
            this.txtBoxTampilanNama.Size = new System.Drawing.Size(254, 22);
            this.txtBoxTampilanNama.TabIndex = 1;
            // 
            // txtBoxTampilanAlamat
            // 
            this.txtBoxTampilanAlamat.Location = new System.Drawing.Point(113, 102);
            this.txtBoxTampilanAlamat.Name = "txtBoxTampilanAlamat";
            this.txtBoxTampilanAlamat.ReadOnly = true;
            this.txtBoxTampilanAlamat.Size = new System.Drawing.Size(254, 22);
            this.txtBoxTampilanAlamat.TabIndex = 3;
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(57, 102);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(55, 17);
            this.lblAlamat.TabIndex = 2;
            this.lblAlamat.Text = "Alamat:";
            // 
            // txtBoxTampilanTelp
            // 
            this.txtBoxTampilanTelp.Location = new System.Drawing.Point(113, 154);
            this.txtBoxTampilanTelp.Name = "txtBoxTampilanTelp";
            this.txtBoxTampilanTelp.ReadOnly = true;
            this.txtBoxTampilanTelp.Size = new System.Drawing.Size(254, 22);
            this.txtBoxTampilanTelp.TabIndex = 5;
            // 
            // lblTelp
            // 
            this.lblTelp.AutoSize = true;
            this.lblTelp.Location = new System.Drawing.Point(57, 154);
            this.lblTelp.Name = "lblTelp";
            this.lblTelp.Size = new System.Drawing.Size(40, 17);
            this.lblTelp.TabIndex = 4;
            this.lblTelp.Text = "Telp:";
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(60, 210);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(75, 35);
            this.btnKembali.TabIndex = 6;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // btnPrevData
            // 
            this.btnPrevData.Location = new System.Drawing.Point(164, 210);
            this.btnPrevData.Name = "btnPrevData";
            this.btnPrevData.Size = new System.Drawing.Size(101, 35);
            this.btnPrevData.TabIndex = 7;
            this.btnPrevData.Text = "Prev Data";
            this.btnPrevData.UseVisualStyleBackColor = true;
            this.btnPrevData.Click += new System.EventHandler(this.btnPrevData_Click);
            // 
            // btnNextData
            // 
            this.btnNextData.Location = new System.Drawing.Point(296, 210);
            this.btnNextData.Name = "btnNextData";
            this.btnNextData.Size = new System.Drawing.Size(101, 35);
            this.btnNextData.TabIndex = 8;
            this.btnNextData.Text = "Next Data";
            this.btnNextData.UseVisualStyleBackColor = true;
            this.btnNextData.Click += new System.EventHandler(this.btnNextData_Click);
            // 
            // FormTampilanData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNextData);
            this.Controls.Add(this.btnPrevData);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.txtBoxTampilanTelp);
            this.Controls.Add(this.lblTelp);
            this.Controls.Add(this.txtBoxTampilanAlamat);
            this.Controls.Add(this.lblAlamat);
            this.Controls.Add(this.txtBoxTampilanNama);
            this.Controls.Add(this.lblNama);
            this.Name = "FormTampilanData";
            this.Text = "Form Tampilan Data";
            this.Load += new System.EventHandler(this.FormTampilanData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtBoxTampilanNama;
        private System.Windows.Forms.TextBox txtBoxTampilanAlamat;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.TextBox txtBoxTampilanTelp;
        private System.Windows.Forms.Label lblTelp;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Button btnPrevData;
        private System.Windows.Forms.Button btnNextData;
    }
}