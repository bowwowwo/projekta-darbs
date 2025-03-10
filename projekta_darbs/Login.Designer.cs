namespace projekta_darbs
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            button1 = new Button();
            label3 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(56, 139);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(192, 23);
            textBox2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 121);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 3;
            label2.Text = "Tava parole";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.BackColor = Color.FromArgb(255, 167, 37);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(57, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(311, 346);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.HighlightText;
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(56, 243);
            label5.Name = "label5";
            label5.Size = new Size(148, 15);
            label5.TabIndex = 8;
            label5.Text = "Aizmirsi paroli vai e-pastu?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.HighlightText;
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(56, 214);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 7;
            label4.Text = "Neesi lietotājs?";
            // 
            // button1
            // 
            button1.Location = new Point(173, 182);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Ienākt";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 19);
            label3.Name = "label3";
            label3.Size = new Size(158, 15);
            label3.TabIndex = 5;
            label3.Text = "Atslēgu izsniegšanas sistēma";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 69);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 4;
            label1.Text = "Tavs e-pasts";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(106, 156, 137);
            ClientSize = new Size(434, 421);
            Controls.Add(groupBox1);
            Name = "Login";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private GroupBox groupBox1;
        private Label label1;
        private Button button1;
        private Label label3;
        private Label label5;
        private Label label4;
    }
}
