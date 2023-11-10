namespace ATMapp
{
    partial class Deposite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposite));
            panel1 = new Panel();
            button6 = new Button();
            lbltext = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
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
            panel1.Size = new Size(689, 79);
            panel1.TabIndex = 2;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(91, 0, 150);
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Location = new Point(648, 3);
            button6.Name = "button6";
            button6.Size = new Size(30, 29);
            button6.TabIndex = 16;
            button6.UseVisualStyleBackColor = false;
            // 
            // lbltext
            // 
            lbltext.AutoSize = true;
            lbltext.BackColor = Color.FromArgb(91, 0, 150);
            lbltext.FlatStyle = FlatStyle.Flat;
            lbltext.Font = new Font("Microsoft JhengHei UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbltext.ForeColor = Color.White;
            lbltext.Location = new Point(256, 9);
            lbltext.Name = "lbltext";
            lbltext.Size = new Size(182, 43);
            lbltext.TabIndex = 2;
            lbltext.Text = "DEPOSITE";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(174, 140);
            label2.Name = "label2";
            label2.Size = new Size(167, 38);
            label2.TabIndex = 6;
            label2.Text = "AMOUNT:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(347, 140);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(178, 27);
            textBox2.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Indigo;
            button1.Location = new Point(12, 269);
            button1.Name = "button1";
            button1.Size = new Size(182, 57);
            button1.TabIndex = 13;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Indigo;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(256, 269);
            button2.Name = "button2";
            button2.Size = new Size(182, 57);
            button2.TabIndex = 14;
            button2.Text = "DEPOSITE";
            button2.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 200;
            timer1.Tick += timer1_Tick;
            // 
            // Deposite
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 338);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Deposite";
            Text = "Deposite";
            Load += Deposite_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button6;
        private Label lbltext;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}