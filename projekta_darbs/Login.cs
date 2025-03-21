﻿using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data.SQLite;
using System.Drawing;
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
            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;    // sql for login
            string projectRootDirectory = Path.GetFullPath(Path.Combine(exeDirectory, @"..\..\..\"));
            string dbFilePath = Path.Combine(projectRootDirectory, "db", "prog2atslgisnsys.db");

            string connectionString = @"data source =" + dbFilePath;

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
                else if (!email.Contains("@"))
                {
                    MessageBox.Show("Nav derīgs e-pasts!");
                }
                else
                {
                    using (SQLiteConnection con = new SQLiteConnection(connectionString))
                    {
                        con.Open();

                        // Check if email exists in the database
                        string checkEmailQuery = "SELECT COUNT(*) FROM lietotajs WHERE Epasts=@Email";
                        using (SQLiteCommand cmd = new SQLiteCommand(checkEmailQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@Email", email);
                            int emailCount = Convert.ToInt32(cmd.ExecuteScalar());

                            if (emailCount > 0)
                            {
                                MessageBox.Show("E-pasts jau eksistē!");
                            }
                            else
                            {
                                string query = "SELECT COUNT(*) FROM lietotajs WHERE Epasts=@Email AND Parole=@Password";
                                string hashparole = HashPassword(textBox2.Text);

                                using (SQLiteCommand cmd2 = new SQLiteCommand(query, con))
                                {
                                    cmd.Parameters.AddWithValue("@Email", email);
                                    cmd.Parameters.AddWithValue("@Password", hashparole);

                                    int count = Convert.ToInt32(cmd2.ExecuteScalar());

                                    if (count > 0)
                                        MessageBox.Show("Veiksmīga pieteikšanās!");
                                    else
                                        MessageBox.Show("Nepareizs e-pasts vai parole!");

                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nepareizi ievadīta parole vai e-pasts!");
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

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
