using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace projekta_darbs
{
    public partial class Register : MaterialForm
    {

        private string new_password;
        private string new_email;
        private string name;

        public Register()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple800, Primary.DeepPurple600, Primary.DeepPurple400, Accent.Blue200, TextShade.WHITE);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            new_email = textBox2.Text;
            new_password = textBox3.Text;


            try
            {
                if (String.IsNullOrEmpty(new_email))
                {
                    MessageBox.Show("E-pasta ievades lauks ir tukšs!");
                }
                else if (String.IsNullOrEmpty(new_password))
                {
                    MessageBox.Show("Paroles ievades lauks ir tukšs!");
                }
                else if (!new_email.Contains("@gmail.com") || !new_email.Contains("@edu.riga.lv"))
                {
                    MessageBox.Show("Nav derīgs e-pasts!");
                }
                else
                {
                    string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;    // sql for login
                    string projectRootDirectory = Path.GetFullPath(Path.Combine(exeDirectory, @"..\..\..\"));
                    string dbFilePath = Path.Combine(projectRootDirectory, "db", "prog2atslgisnsys.db");

                    string connectionString = @"data source =" + dbFilePath;
                    //MessageBox.Show(connectionString);

                    using (SQLiteConnection con = new SQLiteConnection(connectionString))
                    {
                        con.Open();
                        string query = "INSERT INTO lietotajs (Vards, Parole, Epasts) VALUES (@Name, @Password, @Email)";

                        using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Name", name);
                            cmd.Parameters.AddWithValue("@Password", new_password);
                            cmd.Parameters.AddWithValue("@Email", new_email);

                            int count = Convert.ToInt32(cmd.ExecuteScalar());

                            if (count > 0)
                                MessageBox.Show("Veiksmīga pieteikšanās!"); //vajag atgriezties pie login
                                
                            else
                                MessageBox.Show("Nepareizs e-pasts vai parole!");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Atgadījusies kļūda!");
            }
        }
    }
}
