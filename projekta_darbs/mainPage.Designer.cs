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
            dataGridView3 = new DataGridView();
            tabPage2 = new TabPage();
            button3 = new Button();
            comboBox1 = new ComboBox();
            button2 = new Button();
            dataGridView2 = new DataGridView();
            tabPage3 = new TabPage();
            comboBox2 = new ComboBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            imageList1 = new ImageList(components);
            materialTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Controls.Add(tabPage3);
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
            tabPage1.Controls.Add(dataGridView3);
            tabPage1.ImageIndex = 0;
            tabPage1.Location = new Point(4, 39);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(921, 459);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Visas atslegas";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(299, 13);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(323, 433);
            dataGridView3.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.ImageKey = "icons8-log-24.png";
            tabPage2.Location = new Point(4, 39);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(921, 459);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Atslegas noliktava";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(138, 357);
            button3.Name = "button3";
            button3.Size = new Size(184, 31);
            button3.TabIndex = 5;
            button3.Text = "Izdot atslegu";
            button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(138, 302);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(184, 23);
            comboBox1.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(399, 302);
            button2.Name = "button2";
            button2.Size = new Size(148, 86);
            button2.TabIndex = 3;
            button2.Text = "Atjaunot Datu Bazi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(138, 15);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(409, 269);
            dataGridView2.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(comboBox2);
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(dataGridView1);
            tabPage3.ImageKey = "icons8-file-explorer-32.png";
            tabPage3.Location = new Point(4, 39);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(921, 459);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Izdotas atslegas";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(47, 113);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(712, 157);
            button1.Name = "button1";
            button1.Size = new Size(135, 81);
            button1.TabIndex = 4;
            button1.Text = "Atjaunot Datu Bazi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(299, 13);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(323, 433);
            dataGridView1.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ImageList imageList1;
        private TabPage tabPage3;
        private DataGridView dataGridView3;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button3;
    }
}