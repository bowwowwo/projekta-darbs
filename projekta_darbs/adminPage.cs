using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace projekta_darbs
{
    public partial class adminPage : MaterialForm
    {

        public adminPage()
        {


            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple800, Primary.DeepPurple600, Primary.DeepPurple400, Accent.Blue200, TextShade.WHITE);
        }

        private string AtslegasID;
        private string AtslegasKabinets;


        private void materialButton1_Click(object sender, EventArgs e)
        {
            AtslegasID = materialTextBox1.Text;
            AtslegasKabinets = materialTextBox2.Text;

            try
            {
                if (String.IsNullOrEmpty(AtslegasID))
                {
                    MessageBox.Show("Ievadiet atslēgas ID!");
                }
                else if (String.IsNullOrEmpty(AtslegasKabinets))
                {
                    MessageBox.Show("Ievadiet atslēgas kabinetu!");
                }
                else
                {
                    string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;    // sql for login
                    string projectRootDirectory = Path.GetFullPath(Path.Combine(exeDirectory, @"..\..\..\"));
                    string dbFilePath = Path.Combine(projectRootDirectory, "db", "prog2atslgisnsys.db");
                    string connectionString = @"data source =" + dbFilePath;
                    SQLiteConnection con = new SQLiteConnection(connectionString);
                    con.Open();
                    string query = "INSERT INTO Atslegas (AtslegasID, AtslegasKabinets) VALUES (@AtslegasID, @AtslegasKabinets)";
                    using (SQLiteCommand cmd2 = new SQLiteCommand(query, con))
                    {
                        cmd2.Parameters.AddWithValue("@AtslegasID", AtslegasID);
                        cmd2.Parameters.AddWithValue("@AtslegasKabinets", AtslegasKabinets);
                        cmd2.ExecuteNonQuery();
                    }
                    MessageBox.Show("Atslēga tika pievienota datubāzei!");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Atgadījusies kļūda!");
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string projectRootDirectory = Path.GetFullPath(Path.Combine(exeDirectory, @"..\..\..\"));
                string dbFilePath = Path.Combine(projectRootDirectory, "db", "prog2atslgisnsys.db");
                string connectionString = @"data source =" + dbFilePath;
                SQLiteConnection con = new SQLiteConnection(connectionString);
                con.Open();
                string query = "SELECT * FROM Atslegas";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, con);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dataGridView2.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Atgadījusies kļūda!");
            }
        }
    }
}
