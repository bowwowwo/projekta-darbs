namespace projekta_darbs
{
    partial class Register
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
            textBox1 = new TextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(98, 137);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 23);
            textBox1.TabIndex = 1;
            // 
            // materialLabel1
            // 
            materialLabel1.Anchor = AnchorStyles.None;
            materialLabel1.AutoSize = true;
            materialLabel1.BackColor = SystemColors.ButtonFace;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.ForeColor = SystemColors.ControlText;
            materialLabel1.Location = new Point(153, 90);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(121, 19);
            materialLabel1.TabIndex = 10;
            materialLabel1.Text = "Jauns lietotājs/a";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(98, 189);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(240, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Location = new Point(98, 243);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(240, 23);
            textBox3.TabIndex = 12;
            textBox3.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.Location = new Point(98, 117);
            label1.Name = "label1";
            label1.Size = new Size(45, 17);
            label1.TabIndex = 13;
            label1.Text = "Vārds";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.Location = new Point(98, 169);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 14;
            label2.Text = "E-pasts";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.Location = new Point(98, 223);
            label3.Name = "label3";
            label3.Size = new Size(48, 17);
            label3.TabIndex = 15;
            label3.Text = "Parole";
            // 
            // materialButton1
            // 
            materialButton1.Anchor = AnchorStyles.None;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Cursor = Cursors.Hand;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(155, 378);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(119, 36);
            materialButton1.TabIndex = 16;
            materialButton1.Text = "Reģistrēties";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 8F);
            label4.ForeColor = Color.LightCoral;
            label4.Location = new Point(79, 336);
            label4.Name = "label4";
            label4.Size = new Size(233, 26);
            label4.TabIndex = 17;
            label4.Text = "     Parolei jābūt vismaz 8 rakstzīmes garai\r\nun jāsatur vismaz 1 lielais burts un 1 simbols\r\n";
            label4.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Location = new Point(98, 301);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(240, 23);
            textBox4.TabIndex = 18;
            textBox4.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonFace;
            label5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label5.Location = new Point(98, 281);
            label5.Name = "label5";
            label5.Size = new Size(111, 17);
            label5.TabIndex = 19;
            label5.Text = "Atkārtojiet paroli";
            // 
            // materialButton2
            // 
            materialButton2.Anchor = AnchorStyles.None;
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(293, 449);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(140, 36);
            materialButton2.TabIndex = 20;
            materialButton2.Text = "Doties atpakaļ";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += materialButton2_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 494);
            Controls.Add(materialButton2);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(materialButton1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(materialLabel1);
            Controls.Add(textBox1);
            Name = "Register";
            Text = "Reģistrēties";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private MaterialSkin.Controls.MaterialButton materialButton2;
    }
}