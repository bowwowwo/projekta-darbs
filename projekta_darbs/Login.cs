using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data.SQLite;

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

            try
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
                    string connectionString = "data source = C:\\Users\\arnolds\\source\repos\\projekta-darbs\\projekta_darbs\\db\\prog2atslgisnsys.db";

                    using (SQLiteConnection con = new SQLiteConnection(connectionString))
                    {
                        con.Open();
                        string query = "SELECT COUNT(*) FROM lietotajs WHERE Epasts=@Email AND Parole=@Password";

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

        private void label3_Click(object sender, EventArgs e) //"Neesi lietotājs?"
        {
            Register ShowForm_newUserForm = new Register();
            ShowForm_newUserForm.Show();

            this.Hide(); // * neaizver login tapec vajag pec tam atgriezties
        }

    }
}
