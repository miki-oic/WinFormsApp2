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
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(93, 264);
            button1.Name = "button1";
            button1.Size = new Size(108, 30);
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
            button2.Location = new Point(93, 339);
            button2.Name = "button2";
            button2.Size = new Size(108, 30);
            button2.TabIndex = 2;
            button2.Text = "防御";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 128);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // button3
            // 
            button3.Location = new Point(232, 264);
            button3.Name = "button3";
            button3.Size = new Size(108, 30);
            button3.TabIndex = 4;
            button3.Text = "呪文";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(232, 339);
            button4.Name = "button4";
            button4.Size = new Size(108, 30);
            button4.TabIndex = 5;
            button4.Text = "逃走";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(360, 339);
            button5.Name = "button5";
            button5.Size = new Size(108, 30);
            button5.TabIndex = 6;
            button5.Text = "解呪";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // MockForm_k
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "MockForm_k";
            Text = "MockForm_k";
            Load += MockForm_k_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private Label label1;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}