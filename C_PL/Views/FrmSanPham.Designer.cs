namespace C_PL.Views
{
    partial class FrmSanPham
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
            this.txt_masp = new System.Windows.Forms.TextBox();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.ptb_xoa = new System.Windows.Forms.PictureBox();
            this.ptb_sua = new System.Windows.Forms.PictureBox();
            this.ptb_them = new System.Windows.Forms.PictureBox();
            this.dtgrid_sp = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_xoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_sua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_them)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_sp)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(312, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên SP :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã SP :";
            // 
            // txt_masp
            // 
            this.txt_masp.Location = new System.Drawing.Point(34, 306);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.Size = new System.Drawing.Size(230, 27);
            this.txt_masp.TabIndex = 17;
            // 
            // txt_tensp
            // 
            this.txt_tensp.Location = new System.Drawing.Point(312, 306);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.Size = new System.Drawing.Size(209, 27);
            this.txt_tensp.TabIndex = 16;
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
            // dtgrid_sp
            // 
            this.dtgrid_sp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_sp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgrid_sp.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgrid_sp.Location = new System.Drawing.Point(0, 0);
            this.dtgrid_sp.Name = "dtgrid_sp";
            this.dtgrid_sp.RowHeadersWidth = 51;
            this.dtgrid_sp.RowTemplate.Height = 29;
            this.dtgrid_sp.Size = new System.Drawing.Size(554, 243);
            this.dtgrid_sp.TabIndex = 12;
            this.dtgrid_sp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_sp_CellClick);
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
            this.Column3.HeaderText = "Ma Sản phẩm";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tên sản phẩm ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_masp);
            this.Controls.Add(this.txt_tensp);
            this.Controls.Add(this.ptb_xoa);
            this.Controls.Add(this.ptb_sua);
            this.Controls.Add(this.ptb_them);
            this.Controls.Add(this.dtgrid_sp);
            this.Name = "FrmSanPham";
            this.Text = "FrmSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_xoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_sua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_them)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_sp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txt_masp;
        private TextBox txt_tensp;
        private PictureBox ptb_xoa;
        private PictureBox ptb_sua;
        private PictureBox ptb_them;
        private DataGridView dtgrid_sp;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}