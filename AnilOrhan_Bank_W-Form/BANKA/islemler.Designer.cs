namespace BANKA
{
    partial class islemler
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
            this.components = new System.ComponentModel.Container();
            this.btn_parayatirma = new System.Windows.Forms.Button();
            this.btn_paracekme = new System.Windows.Forms.Button();
            this.btn_paragonderme = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mUSTERIIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAKIYEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLBAKIYEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bANKDataSet = new BANKA.BANKDataSet();
            this.btn_bakiye = new System.Windows.Forms.Button();
            this.tBL_BAKIYETableAdapter = new BANKA.BANKDataSetTableAdapters.TBL_BAKIYETableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_yatir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_gonder = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLBAKIYEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANKDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_parayatirma
            // 
            this.btn_parayatirma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_parayatirma.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_parayatirma.Location = new System.Drawing.Point(34, 98);
            this.btn_parayatirma.Name = "btn_parayatirma";
            this.btn_parayatirma.Size = new System.Drawing.Size(216, 48);
            this.btn_parayatirma.TabIndex = 0;
            this.btn_parayatirma.Text = "PARA YATIRMA ";
            this.btn_parayatirma.UseVisualStyleBackColor = false;
            this.btn_parayatirma.Click += new System.EventHandler(this.btn_parayatirma_Click);
            // 
            // btn_paracekme
            // 
            this.btn_paracekme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_paracekme.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_paracekme.Location = new System.Drawing.Point(34, 169);
            this.btn_paracekme.Name = "btn_paracekme";
            this.btn_paracekme.Size = new System.Drawing.Size(216, 53);
            this.btn_paracekme.TabIndex = 0;
            this.btn_paracekme.Text = "PARA ÇEKME";
            this.btn_paracekme.UseVisualStyleBackColor = false;
            this.btn_paracekme.Click += new System.EventHandler(this.btn_paracekme_Click);
            // 
            // btn_paragonderme
            // 
            this.btn_paragonderme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_paragonderme.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_paragonderme.Location = new System.Drawing.Point(34, 247);
            this.btn_paragonderme.Name = "btn_paragonderme";
            this.btn_paragonderme.Size = new System.Drawing.Size(216, 57);
            this.btn_paragonderme.TabIndex = 0;
            this.btn_paragonderme.Text = "PARA GÖNDERME İŞLEMİ";
            this.btn_paragonderme.UseVisualStyleBackColor = false;
            this.btn_paragonderme.Click += new System.EventHandler(this.btn_paragonderme_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_cikis.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.Location = new System.Drawing.Point(34, 320);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(216, 52);
            this.btn_cikis.TabIndex = 0;
            this.btn_cikis.Text = "ÇIKIŞ";
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mUSTERIIDDataGridViewTextBoxColumn,
            this.bAKIYEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLBAKIYEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(381, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(386, 60);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mUSTERIIDDataGridViewTextBoxColumn
            // 
            this.mUSTERIIDDataGridViewTextBoxColumn.DataPropertyName = "MUSTERIID";
            this.mUSTERIIDDataGridViewTextBoxColumn.HeaderText = "MUSTERIID";
            this.mUSTERIIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mUSTERIIDDataGridViewTextBoxColumn.Name = "mUSTERIIDDataGridViewTextBoxColumn";
            // 
            // bAKIYEDataGridViewTextBoxColumn
            // 
            this.bAKIYEDataGridViewTextBoxColumn.DataPropertyName = "BAKIYE";
            this.bAKIYEDataGridViewTextBoxColumn.HeaderText = "BAKIYE";
            this.bAKIYEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bAKIYEDataGridViewTextBoxColumn.Name = "bAKIYEDataGridViewTextBoxColumn";
            // 
            // tBLBAKIYEBindingSource
            // 
            this.tBLBAKIYEBindingSource.DataMember = "TBL_BAKIYE";
            this.tBLBAKIYEBindingSource.DataSource = this.bANKDataSet;
            // 
            // bANKDataSet
            // 
            this.bANKDataSet.DataSetName = "BANKDataSet";
            this.bANKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_bakiye
            // 
            this.btn_bakiye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_bakiye.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_bakiye.Location = new System.Drawing.Point(34, 26);
            this.btn_bakiye.Name = "btn_bakiye";
            this.btn_bakiye.Size = new System.Drawing.Size(216, 51);
            this.btn_bakiye.TabIndex = 0;
            this.btn_bakiye.Text = "BAKİYE GÜNCELLEME";
            this.btn_bakiye.UseVisualStyleBackColor = false;
            this.btn_bakiye.Click += new System.EventHandler(this.btn_bakiye_Click);
            // 
            // tBL_BAKIYETableAdapter
            // 
            this.tBL_BAKIYETableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(626, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "0";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(483, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "GÜNCEL BAKİYENİZ";
            // 
            // btn_yatir
            // 
            this.btn_yatir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_yatir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yatir.Location = new System.Drawing.Point(281, 119);
            this.btn_yatir.Name = "btn_yatir";
            this.btn_yatir.Size = new System.Drawing.Size(75, 23);
            this.btn_yatir.TabIndex = 7;
            this.btn_yatir.Text = "YATIR";
            this.btn_yatir.UseVisualStyleBackColor = false;
            this.btn_yatir.Visible = false;
            this.btn_yatir.Click += new System.EventHandler(this.btn_yatir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(280, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "ÇEK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(271, 163);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 10;
            this.textBox2.Visible = false;
            // 
            // btn_gonder
            // 
            this.btn_gonder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_gonder.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gonder.Location = new System.Drawing.Point(534, 290);
            this.btn_gonder.Name = "btn_gonder";
            this.btn_gonder.Size = new System.Drawing.Size(106, 42);
            this.btn_gonder.TabIndex = 11;
            this.btn_gonder.Text = "GÖNDER";
            this.btn_gonder.UseVisualStyleBackColor = false;
            this.btn_gonder.Visible = false;
            this.btn_gonder.Click += new System.EventHandler(this.btn_gonder_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(264, 282);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 12;
            this.textBox3.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(264, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(376, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Para Göndermek İstediğiniz Kişinin TC Kimlik No Girin";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(261, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Göndermek istediğiniz Miktarı Girin";
            this.label4.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(264, 336);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 15;
            this.textBox4.Visible = false;
            // 
            // islemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(771, 388);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btn_gonder);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_yatir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_paragonderme);
            this.Controls.Add(this.btn_paracekme);
            this.Controls.Add(this.btn_bakiye);
            this.Controls.Add(this.btn_parayatirma);
            this.Name = "islemler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "islemler";
            this.Load += new System.EventHandler(this.islemler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLBAKIYEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANKDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_parayatirma;
        private System.Windows.Forms.Button btn_paracekme;
        private System.Windows.Forms.Button btn_paragonderme;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_bakiye;
        private BANKDataSet bANKDataSet;
        private System.Windows.Forms.BindingSource tBLBAKIYEBindingSource;
        private BANKDataSetTableAdapters.TBL_BAKIYETableAdapter tBL_BAKIYETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUSTERIIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bAKIYEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_yatir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_gonder;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
    }
}