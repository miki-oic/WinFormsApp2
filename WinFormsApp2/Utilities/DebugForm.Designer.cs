namespace WinFormsApp2.Utilities
{
    partial class DebugForm
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
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(560, 290);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(228, 154);
            listBox1.TabIndex = 0;
            // 
            // playerLabel1
            // 
            playerLabel1.AutoSize = true;
            playerLabel1.Location = new Point(4, 9);
            playerLabel1.Name = "playerLabel1";
            playerLabel1.Size = new Size(45, 15);
            playerLabel1.TabIndex = 2;
            playerLabel1.Text = "Player1";
            playerLabel1.Click += playerLabel1_Click;
            // 
            // playerLabel2
            // 
            playerLabel2.AutoSize = true;
            playerLabel2.Location = new Point(4, 52);
            playerLabel2.Name = "playerLabel2";
            playerLabel2.Size = new Size(45, 15);
            playerLabel2.TabIndex = 3;
            playerLabel2.Text = "Player2";
            playerLabel2.Click += playerLabel2_Click;
            // 
            // HPLabel1
            // 
            HPLabel1.AutoSize = true;
            HPLabel1.Location = new Point(100, 9);
            HPLabel1.Margin = new Padding(3, 0, 10, 0);
            HPLabel1.Name = "HPLabel1";
            HPLabel1.Size = new Size(23, 15);
            HPLabel1.TabIndex = 4;
            HPLabel1.Text = "HP";
            // 
            // HPLabel2
            // 
            HPLabel2.AutoSize = true;
            HPLabel2.Location = new Point(100, 52);
            HPLabel2.Name = "HPLabel2";
            HPLabel2.Size = new Size(23, 15);
            HPLabel2.TabIndex = 5;
            HPLabel2.Text = "HP";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 10);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(31, 15);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "名前";
            // 
            // jobLabel
            // 
            jobLabel.AutoSize = true;
            jobLabel.Location = new Point(153, 10);
            jobLabel.Name = "jobLabel";
            jobLabel.Size = new Size(31, 15);
            jobLabel.TabIndex = 8;
            jobLabel.Text = "職業";
            // 
            // HPLabel
            // 
            HPLabel.AutoSize = true;
            HPLabel.Location = new Point(20, 53);
            HPLabel.Name = "HPLabel";
            HPLabel.Size = new Size(23, 15);
            HPLabel.TabIndex = 9;
            HPLabel.Text = "HP";
            // 
            // attackButton
            // 
            attackButton.Location = new Point(20, 80);
            attackButton.Name = "attackButton";
            attackButton.Size = new Size(77, 28);
            attackButton.TabIndex = 10;
            attackButton.Text = "攻撃";
            attackButton.UseVisualStyleBackColor = true;
            attackButton.Click += attackButton_Click;
            // 
            // guridButton
            // 
            guridButton.Location = new Point(20, 125);
            guridButton.Name = "guridButton";
            guridButton.Size = new Size(77, 28);
            guridButton.TabIndex = 11;
            guridButton.Text = "防御";
            guridButton.UseVisualStyleBackColor = true;
            guridButton.Click += guridButton_Click;
            // 
            // nameInputLabel
            // 
            nameInputLabel.AutoSize = true;
            nameInputLabel.Location = new Point(61, 10);
            nameInputLabel.Name = "nameInputLabel";
            nameInputLabel.Size = new Size(45, 15);
            nameInputLabel.TabIndex = 12;
            nameInputLabel.Text = "player1";
            nameInputLabel.Click += nameInputLabel_Click;
            // 
            // jobInputLabel
            // 
            jobInputLabel.AutoSize = true;
            jobInputLabel.Location = new Point(224, 10);
            jobInputLabel.Name = "jobInputLabel";
            jobInputLabel.Size = new Size(24, 15);
            jobInputLabel.TabIndex = 13;
            jobInputLabel.Text = "job";
            // 
            // hpInputLabel
            // 
            hpInputLabel.AutoSize = true;
            hpInputLabel.Location = new Point(61, 53);
            hpInputLabel.Name = "hpInputLabel";
            hpInputLabel.Size = new Size(49, 15);
            hpInputLabel.TabIndex = 14;
            hpInputLabel.Text = "hitPoint";
            // 
            // panel1
            // 
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(hpInputLabel);
            panel1.Controls.Add(nameInputLabel);
            panel1.Controls.Add(guridButton);
            panel1.Controls.Add(jobInputLabel);
            panel1.Controls.Add(attackButton);
            panel1.Controls.Add(jobLabel);
            panel1.Controls.Add(HPLabel);
            panel1.Location = new Point(12, 276);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 168);
            panel1.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.Controls.Add(playerLabel1);
            panel2.Controls.Add(playerLabel2);
            panel2.Controls.Add(HPLabel2);
            panel2.Controls.Add(HPLabel1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 230);
            panel2.TabIndex = 16;
            // 
            // DebugForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "DebugForm";
            Text = "DebugForm";
            Load += DebugForm_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}