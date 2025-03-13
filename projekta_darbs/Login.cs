using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data.SQLite;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace projekta_darbs
{
    public partial class Login : MaterialForm
    {
        private string email;
        private string password;

        public Login()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple800, Primary.DeepPurple600, Primary.DeepPurple400, Accent.Blue200, TextShade.WHITE);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

            email = textBox1.Text;
            password = textBox2.Text;

            try // checks if entered info is correct /or usable
            {
                if (String.IsNullOrEmpty(email))
                {
                    MessageBox.Show("E-pasta ievades lauks ir tukšs!");
                }
                else if (String.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Paroles ievades lauks ir tukšs!");
                }
                else if (!email.Contains("@gmail.com") || !email.Contains("@edu.riga.lv"))
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
                        string query = "SELECT COUNT(*) FROM lietotajs WHERE Epasts=@Email AND Parole=@Password";
                        string MD5parole = encrypt(textBox2.Text);
                     
                        using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.Parameters.AddWithValue("@Password", password);

                            int count = Convert.ToInt32(cmd.ExecuteScalar());

                            if (count > 0)
                                MessageBox.Show("Veiksmīga pieteikšanās!");
                            else
                                MessageBox.Show("Nepareizs e-pasts vai parole!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nepareizi ievadīta parole vai e-pasts!");
            }
        }
        public string encrypt(string decrypted) // encrypts password
        {
            string hash = "pavasaris2025";
            byte[] data = UTF8Encoding.UTF8.GetBytes(decrypted);
            MD5 md5 = MD5.Create();
            TripleDES tripDES = TripleDES.Create();
            tripDES.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripDES.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripDES.CreateEncryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

            return Convert.ToBase64String(result);

        }
        public string decrypt(string encrypted)  // decrypts password
        {
            return "";
        }

        private void label3_Click(object sender, EventArgs e) //"Neesi lietotājs?"
        {
            Register ShowForm_newUserForm = new Register();
            ShowForm_newUserForm.Show();

            this.Hide(); // * neaizver login tapec vajag pec tam atgriezties
        }
    }
}
