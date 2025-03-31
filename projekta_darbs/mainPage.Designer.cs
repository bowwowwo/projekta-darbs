namespace projekta_darbs
{
    partial class mainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPage));
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            textBox1 = new TextBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            tabPage2 = new TabPage();
            comboBox2 = new ComboBox();
            button4 = new Button();
            button1 = new Button();
            button3 = new Button();
            comboBox1 = new ComboBox();
            button2 = new Button();
            dataGridView2 = new DataGridView();
            imageList1 = new ImageList(components);
            materialTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Depth = 0;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(6, 67);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(929, 502);
            materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(materialLabel2);
            tabPage1.Controls.Add(materialLabel1);
            tabPage1.ImageKey = "icons8-log-24.png";
            tabPage1.Location = new Point(4, 39);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(921, 459);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Atslēgu žurnāls";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = SystemColors.Info;
            textBox1.Location = new Point(113, 38);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(802, 415);
            textBox1.TabIndex = 5;
            // 
            // materialLabel2
            // 
            materialLabel2.Anchor = AnchorStyles.None;
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(113, 16);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(5, 19);
            materialLabel2.TabIndex = 4;
            materialLabel2.Text = " ";
            // 
            // materialLabel1
            // 
            materialLabel1.Anchor = AnchorStyles.None;
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(483, 16);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(55, 19);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Žurnāls";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(comboBox2);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.ImageKey = "icons8-key-30.png";
            tabPage2.Location = new Point(4, 39);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(921, 459);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Saņemt/nodot atslēgu";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.None;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(135, 162);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(184, 23);
            comboBox2.TabIndex = 8;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Location = new Point(135, 191);
            button4.Name = "button4";
            button4.Size = new Size(184, 31);
            button4.TabIndex = 7;
            button4.Text = "Nodot atslēgu";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(381, 312);
            button1.Name = "button1";
            button1.Size = new Size(148, 86);
            button1.TabIndex = 6;
            button1.Text = "Atslēgas noliktavā";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Location = new Point(135, 88);
            button3.Name = "button3";
            button3.Size = new Size(184, 31);
            button3.TabIndex = 5;
            button3.Text = "Saņemt atslēgu";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(135, 59);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(184, 23);
            comboBox1.TabIndex = 4;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(642, 312);
            button2.Name = "button2";
            button2.Size = new Size(148, 86);
            button2.TabIndex = 3;
            button2.Text = "Izdotās atslēgas";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(381, 6);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(409, 269);
            dataGridView2.TabIndex = 1;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-key-30.png");
            imageList1.Images.SetKeyName(1, "icons8-log-24.png");
            imageList1.Images.SetKeyName(2, "icons8-file-explorer-32.png");
            imageList1.Images.SetKeyName(3, "icons8-admin-24.png");
            // 
            // mainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 575);
            Controls.Add(materialTabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Name = "mainPage";
            Text = "Atslegas";
            materialTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ImageList imageList1;
        private DataGridView dataGridView2;
        private Button button2;
        private ComboBox comboBox1;
        private Button button3;
        private ComboBox comboBox2;
        private Button button4;
        private Button button1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private TextBox textBox1;
    }
}