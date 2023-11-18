namespace ATMapp
{
    partial class account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(account));
            pictureBox1 = new PictureBox();
            AccNumTb = new TextBox();
            AccNametb = new TextBox();
            FanameTb = new TextBox();
            Addresstb = new TextBox();
            pintb = new TextBox();
            PhoneTb = new TextBox();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            educationcb = new ComboBox();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            lbltext = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-6, -9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 600);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // AccNumTb
            // 
            AccNumTb.Location = new Point(852, 162);
            AccNumTb.Name = "AccNumTb";
            AccNumTb.Size = new Size(182, 27);
            AccNumTb.TabIndex = 5;
            // 
            // AccNametb
            // 
            AccNametb.Location = new Point(852, 242);
            AccNametb.Name = "AccNametb";
            AccNametb.Size = new Size(182, 27);
            AccNametb.TabIndex = 6;
            // 
            // FanameTb
            // 
            FanameTb.Location = new Point(852, 332);
            FanameTb.Name = "FanameTb";
            FanameTb.Size = new Size(182, 27);
            FanameTb.TabIndex = 7;
            FanameTb.TextChanged += FanameTb_TextChanged;
            // 
            // Addresstb
            // 
            Addresstb.Location = new Point(852, 388);
            Addresstb.Multiline = true;
            Addresstb.Name = "Addresstb";
            Addresstb.Size = new Size(182, 115);
            Addresstb.TabIndex = 8;
            // 
            // pintb
            // 
            pintb.Location = new Point(1130, 162);
            pintb.Name = "pintb";
            pintb.PasswordChar = '*';
            pintb.Size = new Size(182, 27);
            pintb.TabIndex = 9;
            // 
            // PhoneTb
            // 
            PhoneTb.Location = new Point(1130, 332);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(182, 27);
            PhoneTb.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(852, 139);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 13;
            label4.Text = "ACC NUM:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1130, 139);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 14;
            label1.Text = "PIN:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(852, 219);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 15;
            label2.Text = "NAME:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(852, 309);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 16;
            label3.Text = "FNAME:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1130, 219);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 17;
            label5.Text = "EDUCATION:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(852, 365);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 18;
            label6.Text = "ADDRESS:";
            // 
            // educationcb
            // 
            educationcb.FormattingEnabled = true;
            educationcb.Items.AddRange(new object[] { "Non Graduate", "Under Graduate", "Post Graduate" });
            educationcb.Location = new Point(1130, 242);
            educationcb.Name = "educationcb";
            educationcb.Size = new Size(182, 28);
            educationcb.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1130, 309);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 20;
            label7.Text = "PHONE:";
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1157, 398);
            button1.Name = "button1";
            button1.Size = new Size(131, 31);
            button1.TabIndex = 21;
            button1.Text = "SIGN UP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Purple;
            button2.Location = new Point(1200, 451);
            button2.Name = "button2";
            button2.Size = new Size(112, 29);
            button2.TabIndex = 22;
            button2.Text = "LOG OUT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lbltext
            // 
            lbltext.AutoSize = true;
            lbltext.Font = new Font("Microsoft JhengHei UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbltext.Location = new Point(941, 25);
            lbltext.Name = "lbltext";
            lbltext.Size = new Size(282, 43);
            lbltext.TabIndex = 23;
            lbltext.Text = "NEW ACCOUNT";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 200;
            timer1.Tick += timer1_Tick;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Purple;
            button3.Location = new Point(1298, 12);
            button3.Name = "button3";
            button3.Size = new Size(25, 30);
            button3.TabIndex = 24;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1335, 585);
            Controls.Add(button3);
            Controls.Add(lbltext);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(educationcb);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(PhoneTb);
            Controls.Add(pintb);
            Controls.Add(Addresstb);
            Controls.Add(FanameTb);
            Controls.Add(AccNametb);
            Controls.Add(AccNumTb);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "account";
            Text = "account";
            Load += account_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox AccNumTb;
        private TextBox AccNametb;
        private TextBox FanameTb;
        private TextBox Addresstb;
        private TextBox pintb;
        private TextBox PhoneTb;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private ComboBox educationcb;
        private Label label7;
        private Button button1;
        private Button button2;
        private Label lbltext;
        private System.Windows.Forms.Timer timer1;
        private Button button3;
    }
}