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
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            label3 = new Label();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            label4 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.Location = new Point(100, 188);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 3;
            label2.Text = "Tava parole";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(100, 206);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(240, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(100, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.Location = new Point(100, 134);
            label1.Name = "label1";
            label1.Size = new Size(86, 17);
            label1.TabIndex = 4;
            label1.Text = "Tavs e-pasts";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.BackColor = SystemColors.ButtonFace;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.ForeColor = SystemColors.ControlText;
            materialLabel1.Location = new Point(115, 83);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(211, 19);
            materialLabel1.TabIndex = 9;
            materialLabel1.Text = "Atslēgu izsniegšanas sistēma";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Roboto", 9F);
            label3.Location = new Point(100, 294);
            label3.Name = "label3";
            label3.Size = new Size(89, 14);
            label3.TabIndex = 12;
            label3.Text = "Neesi lietotājs?";
            label3.Click += label3_Click;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Cursor = Cursors.Hand;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(268, 254);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(72, 36);
            materialButton1.TabIndex = 13;
            materialButton1.Text = "Ienākt";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Roboto", 9F);
            label4.Location = new Point(100, 330);
            label4.Name = "label4";
            label4.Size = new Size(153, 14);
            label4.TabIndex = 14;
            label4.Text = "Aizmirsi paroli vai e-pastu?";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(106, 156, 137);
            ClientSize = new Size(440, 421);
            Controls.Add(label4);
            Controls.Add(materialButton1);
            Controls.Add(label3);
            Controls.Add(materialLabel1);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(label2);
            DrawerBackgroundWithAccent = true;
            Name = "Login";
            Text = "Ielogoties";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Label label3;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private Label label4;
    }
}
