namespace C_PL.Views
{
    partial class FrmChucVu
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
            this.dtgrid_chucvu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_macv = new System.Windows.Forms.TextBox();
            this.txt_tencv = new System.Windows.Forms.TextBox();
            this.ptb_add = new System.Windows.Forms.PictureBox();
            this.ptb_update = new System.Windows.Forms.PictureBox();
            this.ptb_delete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_chucvu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_delete)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrid_chucvu
            // 
            this.dtgrid_chucvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_chucvu.Location = new System.Drawing.Point(41, 134);
            this.dtgrid_chucvu.Name = "dtgrid_chucvu";
            this.dtgrid_chucvu.RowHeadersWidth = 51;
            this.dtgrid_chucvu.RowTemplate.Height = 29;
            this.dtgrid_chucvu.Size = new System.Drawing.Size(507, 188);
            this.dtgrid_chucvu.TabIndex = 0;
            this.dtgrid_chucvu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_chucvu_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ma CV :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(425, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ten CV :";
            // 
            // txt_macv
            // 
            this.txt_macv.Location = new System.Drawing.Point(132, 58);
            this.txt_macv.Name = "txt_macv";
            this.txt_macv.Size = new System.Drawing.Size(252, 27);
            this.txt_macv.TabIndex = 3;
            // 
            // txt_tencv
            // 
            this.txt_tencv.Location = new System.Drawing.Point(526, 58);
            this.txt_tencv.Name = "txt_tencv";
            this.txt_tencv.Size = new System.Drawing.Size(252, 27);
            this.txt_tencv.TabIndex = 4;
            // 
            // ptb_add
            // 
            this.ptb_add.Image = global::C_PL.Properties.Resources.plus;
            this.ptb_add.Location = new System.Drawing.Point(52, 354);
            this.ptb_add.Name = "ptb_add";
            this.ptb_add.Size = new System.Drawing.Size(59, 52);
            this.ptb_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_add.TabIndex = 5;
            this.ptb_add.TabStop = false;
            this.ptb_add.Click += new System.EventHandler(this.ptb_add_Click);
            // 
            // ptb_update
            // 
            this.ptb_update.Image = global::C_PL.Properties.Resources.update;
            this.ptb_update.Location = new System.Drawing.Point(155, 354);
            this.ptb_update.Name = "ptb_update";
            this.ptb_update.Size = new System.Drawing.Size(59, 52);
            this.ptb_update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_update.TabIndex = 6;
            this.ptb_update.TabStop = false;
            this.ptb_update.Click += new System.EventHandler(this.ptb_update_Click);
            // 
            // ptb_delete
            // 
            this.ptb_delete.Image = global::C_PL.Properties.Resources.delete;
            this.ptb_delete.Location = new System.Drawing.Point(270, 354);
            this.ptb_delete.Name = "ptb_delete";
            this.ptb_delete.Size = new System.Drawing.Size(59, 52);
            this.ptb_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_delete.TabIndex = 7;
            this.ptb_delete.TabStop = false;
            this.ptb_delete.Click += new System.EventHandler(this.ptb_delete_Click);
            // 
            // FrmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ptb_delete);
            this.Controls.Add(this.ptb_update);
            this.Controls.Add(this.ptb_add);
            this.Controls.Add(this.txt_tencv);
            this.Controls.Add(this.txt_macv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgrid_chucvu);
            this.Name = "FrmChucVu";
            this.Text = "FrmChucVu";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_chucvu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_delete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgrid_chucvu;
        private Label label1;
        private Label label2;
        private TextBox txt_macv;
        private TextBox txt_tencv;
        private PictureBox ptb_add;
        private PictureBox ptb_update;
        private PictureBox ptb_delete;
    }
}