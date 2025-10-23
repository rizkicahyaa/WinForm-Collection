namespace WinformCollection
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNim = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtKelas = new System.Windows.Forms.TextBox();
            this.txtNilai = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwMahasiswa = new System.Windows.Forms.ListView();
            this.btnTampilkanData = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nilai";
            // 
            // txtNim
            // 
            this.txtNim.Location = new System.Drawing.Point(115, 36);
            this.txtNim.Name = "txtNim";
            this.txtNim.Size = new System.Drawing.Size(181, 26);
            this.txtNim.TabIndex = 4;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(115, 87);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(296, 26);
            this.txtNama.TabIndex = 5;
            // 
            // txtKelas
            // 
            this.txtKelas.Location = new System.Drawing.Point(115, 138);
            this.txtKelas.Name = "txtKelas";
            this.txtKelas.Size = new System.Drawing.Size(181, 26);
            this.txtKelas.TabIndex = 6;
            // 
            // txtNilai
            // 
            this.txtNilai.Location = new System.Drawing.Point(115, 189);
            this.txtNilai.Name = "txtNilai";
            this.txtNilai.Size = new System.Drawing.Size(181, 26);
            this.txtNilai.TabIndex = 7;
            this.txtNilai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNilai_KeyPress);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(50, 261);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(107, 38);
            this.btnSimpan.TabIndex = 8;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(179, 261);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(107, 38);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHapus);
            this.groupBox1.Controls.Add(this.btnTampilkanData);
            this.groupBox1.Controls.Add(this.lvwMahasiswa);
            this.groupBox1.Location = new System.Drawing.Point(473, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 501);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[ Daftar Mahasiswa ]";
            // 
            // lvwMahasiswa
            // 
            this.lvwMahasiswa.HideSelection = false;
            this.lvwMahasiswa.Location = new System.Drawing.Point(6, 85);
            this.lvwMahasiswa.Name = "lvwMahasiswa";
            this.lvwMahasiswa.Size = new System.Drawing.Size(701, 410);
            this.lvwMahasiswa.TabIndex = 0;
            this.lvwMahasiswa.UseCompatibleStateImageBehavior = false;
            this.lvwMahasiswa.SelectedIndexChanged += new System.EventHandler(this.lvwMahasiswa_SelectedIndexChanged);
            // 
            // btnTampilkanData
            // 
            this.btnTampilkanData.Location = new System.Drawing.Point(6, 36);
            this.btnTampilkanData.Name = "btnTampilkanData";
            this.btnTampilkanData.Size = new System.Drawing.Size(155, 38);
            this.btnTampilkanData.TabIndex = 11;
            this.btnTampilkanData.Text = "Tampilkan Data";
            this.btnTampilkanData.UseVisualStyleBackColor = true;
            this.btnTampilkanData.Click += new System.EventHandler(this.btnTampilkanData_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(185, 36);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(107, 38);
            this.btnHapus.TabIndex = 12;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 604);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtNilai);
            this.Controls.Add(this.txtKelas);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikasi Input Data Mahasiswa";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNim;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtKelas;
        private System.Windows.Forms.TextBox txtNilai;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwMahasiswa;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnTampilkanData;
    }
}

