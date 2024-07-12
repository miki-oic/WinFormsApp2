namespace WinFormsApp2.Debug
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
            listBox1 = new ListBox();
            listView1 = new ListView();
            playerLabel1 = new Label();
            playerLabel2 = new Label();
            HPLabel1 = new Label();
            HPLabel2 = new Label();
            listView2 = new ListView();
            nameLabel = new Label();
            jobLabel = new Label();
            HPLabel = new Label();
            attackButton = new Button();
            guridButton = new Button();
            nameInputLabel = new Label();
            jobInputLabel = new Label();
            hpInputLabel = new Label();
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
            // listView1
            // 
            listView1.Location = new Point(1, 1);
            listView1.Name = "listView1";
            listView1.Size = new Size(141, 214);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // playerLabel1
            // 
            playerLabel1.AutoSize = true;
            playerLabel1.Location = new Point(12, 9);
            playerLabel1.Name = "playerLabel1";
            playerLabel1.Size = new Size(45, 15);
            playerLabel1.TabIndex = 2;
            playerLabel1.Text = "Player1";
            // 
            // playerLabel2
            // 
            playerLabel2.AutoSize = true;
            playerLabel2.Location = new Point(12, 52);
            playerLabel2.Name = "playerLabel2";
            playerLabel2.Size = new Size(45, 15);
            playerLabel2.TabIndex = 3;
            playerLabel2.Text = "Player2";
            // 
            // HPLabel1
            // 
            HPLabel1.AutoSize = true;
            HPLabel1.Location = new Point(81, 9);
            HPLabel1.Name = "HPLabel1";
            HPLabel1.Size = new Size(23, 15);
            HPLabel1.TabIndex = 4;
            HPLabel1.Text = "HP";
            // 
            // HPLabel2
            // 
            HPLabel2.AutoSize = true;
            HPLabel2.Location = new Point(81, 52);
            HPLabel2.Name = "HPLabel2";
            HPLabel2.Size = new Size(23, 15);
            HPLabel2.TabIndex = 5;
            HPLabel2.Text = "HP";
            // 
            // listView2
            // 
            listView2.Location = new Point(1, 290);
            listView2.Name = "listView2";
            listView2.Size = new Size(283, 162);
            listView2.TabIndex = 6;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 302);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(31, 15);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "名前";
            // 
            // jobLabel
            // 
            jobLabel.AutoSize = true;
            jobLabel.Location = new Point(149, 302);
            jobLabel.Name = "jobLabel";
            jobLabel.Size = new Size(31, 15);
            jobLabel.TabIndex = 8;
            jobLabel.Text = "職業";
            // 
            // HPLabel
            // 
            HPLabel.AutoSize = true;
            HPLabel.Location = new Point(12, 338);
            HPLabel.Name = "HPLabel";
            HPLabel.Size = new Size(23, 15);
            HPLabel.TabIndex = 9;
            HPLabel.Text = "HP";
            // 
            // attackButton
            // 
            attackButton.Location = new Point(12, 365);
            attackButton.Name = "attackButton";
            attackButton.Size = new Size(77, 28);
            attackButton.TabIndex = 10;
            attackButton.Text = "攻撃";
            attackButton.UseVisualStyleBackColor = true;
            // 
            // guridButton
            // 
            guridButton.Location = new Point(12, 410);
            guridButton.Name = "guridButton";
            guridButton.Size = new Size(77, 28);
            guridButton.TabIndex = 11;
            guridButton.Text = "防御";
            guridButton.UseVisualStyleBackColor = true;
            // 
            // nameInputLabel
            // 
            nameInputLabel.AutoSize = true;
            nameInputLabel.Location = new Point(66, 302);
            nameInputLabel.Name = "nameInputLabel";
            nameInputLabel.Size = new Size(45, 15);
            nameInputLabel.TabIndex = 12;
            nameInputLabel.Text = "player1";
            // 
            // jobInputLabel
            // 
            jobInputLabel.AutoSize = true;
            jobInputLabel.Location = new Point(205, 302);
            jobInputLabel.Name = "jobInputLabel";
            jobInputLabel.Size = new Size(24, 15);
            jobInputLabel.TabIndex = 13;
            jobInputLabel.Text = "job";
            // 
            // hpInputLabel
            // 
            hpInputLabel.AutoSize = true;
            hpInputLabel.Location = new Point(66, 338);
            hpInputLabel.Name = "hpInputLabel";
            hpInputLabel.Size = new Size(49, 15);
            hpInputLabel.TabIndex = 14;
            hpInputLabel.Text = "hitPoint";
            // 
            // DebugForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(hpInputLabel);
            Controls.Add(jobInputLabel);
            Controls.Add(nameInputLabel);
            Controls.Add(guridButton);
            Controls.Add(attackButton);
            Controls.Add(HPLabel);
            Controls.Add(jobLabel);
            Controls.Add(nameLabel);
            Controls.Add(listView2);
            Controls.Add(HPLabel2);
            Controls.Add(HPLabel1);
            Controls.Add(playerLabel2);
            Controls.Add(playerLabel1);
            Controls.Add(listView1);
            Controls.Add(listBox1);
            Name = "DebugForm";
            Text = "DebugForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListView listView1;
        private Label playerLabel1;
        private Label playerLabel2;
        private Label HPLabel1;
        private Label HPLabel2;
        private ListView listView2;
        private Label nameLabel;
        private Label jobLabel;
        private Label HPLabel;
        private Button attackButton;
        private Button guridButton;
        private Label nameInputLabel;
        private Label jobInputLabel;
        private Label hpInputLabel;
    }
}