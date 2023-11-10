namespace ATMapp
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-11, -9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 600);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(795, 9);
            label1.Name = "label1";
            label1.Size = new Size(97, 43);
            label1.TabIndex = 1;
            label1.Text = "ATM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(795, 52);
            label2.Name = "label2";
            label2.Size = new Size(153, 43);
            label2.TabIndex = 2;
            label2.Text = "SYSTEM";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(941, 296);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(941, 376);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 27);
            textBox2.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(885, 285);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(885, 364);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(941, 353);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 8;
            label3.Text = "PIN:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(941, 273);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 9;
            label4.Text = "ACC NUM:";
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(941, 421);
            button1.Name = "button1";
            button1.Size = new Size(182, 57);
            button1.TabIndex = 10;
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Purple;
            label5.Location = new Point(941, 490);
            label5.Name = "label5";
            label5.Size = new Size(144, 20);
            label5.TabIndex = 11;
            label5.Text = "Create New Account";
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.ForeColor = Color.Purple;
            button2.Location = new Point(1091, 484);
            button2.Name = "button2";
            button2.Size = new Size(94, 26);
            button2.TabIndex = 12;
            button2.Text = "SIGN UP";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Purple;
            button3.Location = new Point(1186, 9);
            button3.Name = "button3";
            button3.Size = new Size(31, 30);
            button3.TabIndex = 13;
            button3.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 587);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            Text = "login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label label5;
        private Button button2;
        private Button button3;
    }
}