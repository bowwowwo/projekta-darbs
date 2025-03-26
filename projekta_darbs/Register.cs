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
        private string Loma = "false";

        public Register()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple800, Primary.DeepPurple600, Primary.DeepPurple400, Accent.Blue200, TextShade.WHITE);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            new_email = textBox2.Text;
            new_password = textBox3.Text;
            label4.ForeColor = System.Drawing.Color.Red;


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
                else if (new_password.Length < 8)
                {
                    label4.Show();
                }
                else if (!new_password.Any(char.IsUpper))
                {
                    label4.Show();
                }
                else if (!simboli(new_password))
                {
                    label4.Show();
                }
                else if (textBox3.Text != textBox4.Text)
                {
                    MessageBox.Show("Ievadītās paroles nav vienādas!");
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
                                MessageBox.Show("E-pasts jau ir reģistrēts!");
                            }
                            else
                            {
                                string query = "INSERT INTO lietotajs (Vards, Parole, Epasts, Loma) VALUES (@Name, @Password, @Email, @Loma)";
                                string hashedpassword = HashPassword(textBox3.Text);

                                using (SQLiteCommand cmd2 = new SQLiteCommand(query, con))
                                {
                                    cmd2.Parameters.AddWithValue("@Name", name);
                                    cmd2.Parameters.AddWithValue("@Password", hashedpassword);
                                    cmd2.Parameters.AddWithValue("@Email", new_email);
                                    cmd2.Parameters.AddWithValue("@Loma", Loma);

                                    int rowsAffected = cmd2.ExecuteNonQuery(); // Returns the number of rows inserted

                                    if (rowsAffected > 0)
                                    {
                                        DialogResult result = MessageBox.Show("Veiksmīga pieteikšanās!", "Pieteikšanās", MessageBoxButtons.OK);

                                        if (result == DialogResult.OK)
                                        {
                                            this.Close();
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

        static bool simboli(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetterOrDigit(c))
                    return true;
            }
            return false;
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            Login backToLogin = new Login();
            backToLogin.Show();

            this.Hide();
            this.Closed += (s, args) => Application.Exit();
        }
    }
}
