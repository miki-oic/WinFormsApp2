namespace WinFormsApp2.MockForm
{
    partial class MockForm_k
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
            button1 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label1 = new Label();
            name1 = new Label();
            name2 = new Label();
            hp1 = new Label();
            hp2 = new Label();
            name = new Label();
            label7 = new Label();
            label8 = new Label();
            hp = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(6, 22);
            button1.Name = "button1";
            button1.Size = new Size(62, 30);
            button1.TabIndex = 0;
            button1.Text = "攻撃";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(553, 252);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(229, 184);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(6, 77);
            button2.Name = "button2";
            button2.Size = new Size(62, 30);
            button2.TabIndex = 2;
            button2.Text = "防御";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(74, 22);
            button3.Name = "button3";
            button3.Size = new Size(56, 30);
            button3.TabIndex = 4;
            button3.Text = "呪文";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(136, 77);
            button4.Name = "button4";
            button4.Size = new Size(60, 30);
            button4.TabIndex = 5;
            button4.Text = "逃走";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(74, 77);
            button5.Name = "button5";
            button5.Size = new Size(56, 30);
            button5.TabIndex = 6;
            button5.Text = "解呪";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(hp2);
            groupBox1.Controls.Add(hp1);
            groupBox1.Controls.Add(name2);
            groupBox1.Controls.Add(name1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 228);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "仲間";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(hp);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(name);
            groupBox2.Location = new Point(12, 252);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 186);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "ステータス";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button5);
            groupBox3.Location = new Point(218, 305);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(329, 131);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "コマンド";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "名前";
            // 
            // name1
            // 
            name1.AutoSize = true;
            name1.Location = new Point(6, 46);
            name1.Name = "name1";
            name1.Size = new Size(45, 15);
            name1.TabIndex = 1;
            name1.Text = "Player1";
            name1.Click += name1_Click;
            // 
            // name2
            // 
            name2.AutoSize = true;
            name2.Location = new Point(6, 75);
            name2.Name = "name2";
            name2.Size = new Size(45, 15);
            name2.TabIndex = 2;
            name2.Text = "Player2";
            // 
            // hp1
            // 
            hp1.AutoSize = true;
            hp1.Location = new Point(109, 46);
            hp1.Name = "hp1";
            hp1.Size = new Size(66, 15);
            hp1.TabIndex = 3;
            hp1.Text = "Player1_HP";
            // 
            // hp2
            // 
            hp2.AutoSize = true;
            hp2.Location = new Point(109, 75);
            hp2.Name = "hp2";
            hp2.Size = new Size(66, 15);
            hp2.TabIndex = 4;
            hp2.Text = "Player2_HP";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(6, 53);
            name.Name = "name";
            name.Size = new Size(39, 15);
            name.TabIndex = 5;
            name.Text = "Player";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 28);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 6;
            label7.Text = "名前";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(88, 28);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 7;
            label8.Text = "体力";
            // 
            // hp
            // 
            hp.AutoSize = true;
            hp.Location = new Point(88, 53);
            hp.Name = "hp";
            hp.Size = new Size(23, 15);
            hp.TabIndex = 5;
            hp.Text = "HP";
            // 
            // MockForm_k
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(listBox1);
            Name = "MockForm_k";
            Text = "MockForm_k";
            Load += MockForm_k_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label hp2;
        private Label hp1;
        private Label name2;
        private Label name1;
        private Label label1;
        private Label hp;
        private Label label8;
        private Label label7;
        private Label name;
    }
}