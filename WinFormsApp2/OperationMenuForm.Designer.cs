namespace WinFormsApp2
{
    partial class OperationMenuForm
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(264, 88);
            label4.Name = "label4";
            label4.Size = new Size(101, 25);
            label4.TabIndex = 7;
            label4.Text = "ヒットポイント";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 88);
            label3.Name = "label3";
            label3.Size = new Size(48, 25);
            label3.TabIndex = 6;
            label3.Text = "職業";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 32);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 5;
            label2.Text = "ステータス";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 32);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 4;
            label1.Text = "名前";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(371, 88);
            label5.Name = "label5";
            label5.Size = new Size(134, 25);
            label5.TabIndex = 8;
            label5.Text = "ヒットポイントの値";
            // 
            // button1
            // 
            button1.Location = new Point(54, 161);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 9;
            button1.Text = "攻撃";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(264, 161);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 10;
            button2.Text = "防御";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(393, 301);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 11;
            button3.Text = "逃走";
            button3.UseVisualStyleBackColor = true;
            // 
            // OperationMenuForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OperationMenuForm";
            Text = "操作メニュー";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}