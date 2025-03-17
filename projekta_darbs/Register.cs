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
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

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
                else if (!new_email.Contains("@"))
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
                        string checkEmailQuery = "SELECT COUNT(*) FROM lietotajs WHERE Epasts = @Email";
                        using (SQLiteCommand cmd = new SQLiteCommand(checkEmailQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@Email", new_email);
                            int emailCount = Convert.ToInt32(cmd.ExecuteScalar());

                            if (emailCount > 0)
                            {
                                MessageBox.Show("E-pasts jau tiek lietots citā lietotājā!");
                            }
                            else
                            {
                                string query = "INSERT INTO lietotajs (Vards, Parole, Epasts) VALUES (@Name, @Password, @Email)";
                                string hashedpassword = HashPassword(textBox3.Text);

                                using (SQLiteCommand cmd2 = new SQLiteCommand(query, con))
                                {
                                    cmd.Parameters.AddWithValue("@Name", name);
                                    cmd.Parameters.AddWithValue("@Password", hashedpassword);
                                    cmd.Parameters.AddWithValue("@Email", new_email);

                                    int rowsAffected = cmd2.ExecuteNonQuery(); // Returns the number of rows inserted

                                    if (rowsAffected > 0)
                                    {
                                        DialogResult result = MessageBox.Show("Veiksmīga pieteikšanās!", "Pieteikšanās", MessageBoxButtons.OK);
                                        
                                        if (result == DialogResult.OK)
                                        {
                                            this.Hide();
                                            Login loginform = new Login();
                                            loginform.Show();

                                        }
                                    }
                                }




                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Atgadījusies kļūda!");
            }

        }
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hashBytes);
            }
        }
    } 
}
