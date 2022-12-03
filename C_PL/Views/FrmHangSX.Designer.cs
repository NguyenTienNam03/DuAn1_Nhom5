namespace C_PL.Views
{
    partial class FrmHangSX
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
            this.dt_nhsx = new System.Windows.Forms.DataGridView();
            this.ptb_them = new System.Windows.Forms.PictureBox();
            this.ptb_sua = new System.Windows.Forms.PictureBox();
            this.ptb_xoa = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dt_nhsx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_them)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_sua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_xoa)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_nhsx
            // 
            this.dt_nhsx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_nhsx.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3});
            this.dt_nhsx.Dock = System.Windows.Forms.DockStyle.Top;
            this.dt_nhsx.Location = new System.Drawing.Point(0, 0);
            this.dt_nhsx.Name = "dt_nhsx";
            this.dt_nhsx.RowHeadersWidth = 51;
            this.dt_nhsx.RowTemplate.Height = 29;
            this.dt_nhsx.Size = new System.Drawing.Size(549, 243);
            this.dt_nhsx.TabIndex = 0;
            this.dt_nhsx.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_nhsx_CellClick);
            // 
            // ptb_them
            // 
            this.ptb_them.Image = global::C_PL.Properties.Resources.plus;
            this.ptb_them.Location = new System.Drawing.Point(57, 355);
            this.ptb_them.Name = "ptb_them";
            this.ptb_them.Size = new System.Drawing.Size(62, 62);
            this.ptb_them.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_them.TabIndex = 1;
            this.ptb_them.TabStop = false;
            this.ptb_them.Click += new System.EventHandler(this.ptb_them_Click);
            // 
            // ptb_sua
            // 
            this.ptb_sua.Image = global::C_PL.Properties.Resources.update;
            this.ptb_sua.Location = new System.Drawing.Point(175, 355);
            this.ptb_sua.Name = "ptb_sua";
            this.ptb_sua.Size = new System.Drawing.Size(62, 62);
            this.ptb_sua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_sua.TabIndex = 2;
            this.ptb_sua.TabStop = false;
            this.ptb_sua.Click += new System.EventHandler(this.ptb_sua_Click);
            // 
            // ptb_xoa
            // 
            this.ptb_xoa.Image = global::C_PL.Properties.Resources.delete;
            this.ptb_xoa.Location = new System.Drawing.Point(303, 355);
            this.ptb_xoa.Name = "ptb_xoa";
            this.ptb_xoa.Size = new System.Drawing.Size(62, 62);
            this.ptb_xoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_xoa.TabIndex = 3;
            this.ptb_xoa.TabStop = false;
            this.ptb_xoa.Click += new System.EventHandler(this.ptb_xoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(303, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên HSX :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã HSX :";
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(25, 285);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(230, 27);
            this.txt_ma.TabIndex = 13;
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(303, 285);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(234, 27);
            this.txt_ten.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ID";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã Hãng SX";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên Hãng SX";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // FrmHangSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 475);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.ptb_xoa);
            this.Controls.Add(this.ptb_sua);
            this.Controls.Add(this.ptb_them);
            this.Controls.Add(this.dt_nhsx);
            this.Name = "FrmHangSX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHangSX";
            ((System.ComponentModel.ISupportInitialize)(this.dt_nhsx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_them)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_sua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_xoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dt_nhsx;
        private PictureBox ptb_them;
        private PictureBox ptb_sua;
        private PictureBox ptb_xoa;
        private Label label2;
        private Label label1;
        private TextBox txt_ma;
        private TextBox txt_ten;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}