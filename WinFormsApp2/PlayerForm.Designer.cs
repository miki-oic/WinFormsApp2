namespace WinFormsApp2
{
    partial class PlayerForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 46);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 0;
            label1.Text = "名前";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(414, 46);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 1;
            label2.Text = "職業";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 129);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 2;
            label3.Text = "ヒットポイント";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(129, 213);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 3;
            label4.Text = "ステータス";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 31);
            textBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(468, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(237, 126);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(237, 213);
            label5.Name = "label5";
            label5.Size = new Size(125, 25);
            label5.TabIndex = 7;
            label5.Text = "* 状態の表示 *";
            // 
            // PlayerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PlayerForm";
            Text = "Player";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label label5;
    }
}