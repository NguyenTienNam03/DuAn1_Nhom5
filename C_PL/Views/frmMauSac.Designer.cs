namespace C_PL.Views
{
    partial class frmMauSac
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mamau = new System.Windows.Forms.TextBox();
            this.txt_mau = new System.Windows.Forms.TextBox();
            this.ptb_xoa = new System.Windows.Forms.PictureBox();
            this.ptb_sua = new System.Windows.Forms.PictureBox();
            this.ptb_them = new System.Windows.Forms.PictureBox();
            this.dt_mausac = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_xoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_sua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_them)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_mausac)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(312, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Màu sắc :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã màu :";
            // 
            // txt_mamau
            // 
            this.txt_mamau.Location = new System.Drawing.Point(34, 306);
            this.txt_mamau.Name = "txt_mamau";
            this.txt_mamau.Size = new System.Drawing.Size(230, 27);
            this.txt_mamau.TabIndex = 17;
            // 
            // txt_mau
            // 
            this.txt_mau.Location = new System.Drawing.Point(312, 306);
            this.txt_mau.Name = "txt_mau";
            this.txt_mau.Size = new System.Drawing.Size(209, 27);
            this.txt_mau.TabIndex = 16;
            // 
            // ptb_xoa
            // 
            this.ptb_xoa.Image = global::C_PL.Properties.Resources.delete;
            this.ptb_xoa.Location = new System.Drawing.Point(207, 375);
            this.ptb_xoa.Name = "ptb_xoa";
            this.ptb_xoa.Size = new System.Drawing.Size(51, 51);
            this.ptb_xoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_xoa.TabIndex = 15;
            this.ptb_xoa.TabStop = false;
            this.ptb_xoa.Click += new System.EventHandler(this.ptb_xoa_Click);
            // 
            // ptb_sua
            // 
            this.ptb_sua.Image = global::C_PL.Properties.Resources.update;
            this.ptb_sua.Location = new System.Drawing.Point(110, 375);
            this.ptb_sua.Name = "ptb_sua";
            this.ptb_sua.Size = new System.Drawing.Size(49, 51);
            this.ptb_sua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_sua.TabIndex = 14;
            this.ptb_sua.TabStop = false;
            this.ptb_sua.Click += new System.EventHandler(this.ptb_sua_Click);
            // 
            // ptb_them
            // 
            this.ptb_them.Image = global::C_PL.Properties.Resources.plus;
            this.ptb_them.Location = new System.Drawing.Point(28, 375);
            this.ptb_them.Name = "ptb_them";
            this.ptb_them.Size = new System.Drawing.Size(47, 51);
            this.ptb_them.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_them.TabIndex = 13;
            this.ptb_them.TabStop = false;
            this.ptb_them.Click += new System.EventHandler(this.ptb_them_Click);
            // 
            // dt_mausac
            // 
            this.dt_mausac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_mausac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dt_mausac.Dock = System.Windows.Forms.DockStyle.Top;
            this.dt_mausac.Location = new System.Drawing.Point(0, 0);
            this.dt_mausac.Name = "dt_mausac";
            this.dt_mausac.RowHeadersWidth = 51;
            this.dt_mausac.RowTemplate.Height = 29;
            this.dt_mausac.Size = new System.Drawing.Size(554, 243);
            this.dt_mausac.TabIndex = 12;
            this.dt_mausac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_mausac_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ma Màu sắc";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Màu sắc";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // frmMauSac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_mamau);
            this.Controls.Add(this.txt_mau);
            this.Controls.Add(this.ptb_xoa);
            this.Controls.Add(this.ptb_sua);
            this.Controls.Add(this.ptb_them);
            this.Controls.Add(this.dt_mausac);
            this.Name = "frmMauSac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMauSac";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_xoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_sua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_them)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_mausac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txt_mamau;
        private TextBox txt_mau;
        private PictureBox ptb_xoa;
        private PictureBox ptb_sua;
        private PictureBox ptb_them;
        private DataGridView dt_mausac;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}