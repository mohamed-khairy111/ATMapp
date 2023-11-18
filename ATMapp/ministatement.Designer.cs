namespace ATMapp
{
    partial class ministatement
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ministatement));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button6 = new Button();
            lbltext = new Label();
            MinistatementDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            pictureBox1 = new PictureBox();
            button8 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MinistatementDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(lbltext);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 79);
            panel1.TabIndex = 5;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(91, 0, 150);
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(778, 3);
            button6.Name = "button6";
            button6.Size = new Size(30, 29);
            button6.TabIndex = 16;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // lbltext
            // 
            lbltext.AutoSize = true;
            lbltext.BackColor = Color.FromArgb(91, 0, 150);
            lbltext.FlatStyle = FlatStyle.Flat;
            lbltext.Font = new Font("Microsoft JhengHei UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbltext.ForeColor = Color.White;
            lbltext.Location = new Point(262, 9);
            lbltext.Name = "lbltext";
            lbltext.Size = new Size(314, 43);
            lbltext.TabIndex = 2;
            lbltext.Text = "MINI STATEMENT";
            // 
            // MinistatementDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            MinistatementDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            MinistatementDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            MinistatementDGV.ColumnHeadersHeight = 4;
            MinistatementDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            MinistatementDGV.DefaultCellStyle = dataGridViewCellStyle3;
            MinistatementDGV.GridColor = Color.FromArgb(231, 229, 255);
            MinistatementDGV.Location = new Point(0, 71);
            MinistatementDGV.Name = "MinistatementDGV";
            MinistatementDGV.RowHeadersVisible = false;
            MinistatementDGV.RowHeadersWidth = 51;
            MinistatementDGV.RowTemplate.Height = 29;
            MinistatementDGV.Size = new Size(813, 237);
            MinistatementDGV.TabIndex = 6;
            MinistatementDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            MinistatementDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            MinistatementDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            MinistatementDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            MinistatementDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            MinistatementDGV.ThemeStyle.BackColor = Color.White;
            MinistatementDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            MinistatementDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            MinistatementDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            MinistatementDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MinistatementDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            MinistatementDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            MinistatementDGV.ThemeStyle.HeaderStyle.Height = 4;
            MinistatementDGV.ThemeStyle.ReadOnly = false;
            MinistatementDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            MinistatementDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            MinistatementDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MinistatementDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            MinistatementDGV.ThemeStyle.RowsStyle.Height = 29;
            MinistatementDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            MinistatementDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            MinistatementDGV.CellContentClick += guna2DataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(658, 314);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button8
            // 
            button8.BackColor = Color.Indigo;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(12, 427);
            button8.Name = "button8";
            button8.Size = new Size(151, 39);
            button8.TabIndex = 25;
            button8.Text = "BACK";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 200;
            timer1.Tick += timer1_Tick;
            // 
            // ministatement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 478);
            Controls.Add(button8);
            Controls.Add(pictureBox1);
            Controls.Add(MinistatementDGV);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ministatement";
            Text = "ministatement";
            Load += ministatement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MinistatementDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button6;
        private Label lbltext;
        private Guna.UI2.WinForms.Guna2DataGridView MinistatementDGV;
        private PictureBox pictureBox1;
        private Button button8;
        private System.Windows.Forms.Timer timer1;
    }
}