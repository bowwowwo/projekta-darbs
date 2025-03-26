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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Text;
using System.Data.SqlClient;

namespace projekta_darbs
{


    public partial class mainPage : MaterialForm
    {
        private bool admin = false;
        private object result;
        private string email = Globals.userEmail;
        private string name;

        public mainPage()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple800, Primary.DeepPurple600, Primary.DeepPurple400, Accent.Blue200, TextShade.WHITE);
            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;    // sql for login
            string projectRootDirectory = Path.GetFullPath(Path.Combine(exeDirectory, @"..\..\..\"));
            string dbFilePath = Path.Combine(projectRootDirectory, "db", "prog2atslgisnsys.db");
            string connectionString = @"data source =" + dbFilePath;
            SQLiteConnection con = new SQLiteConnection(connectionString);
            con.Open();
            string query = "SELECT * FROM Atslegas";
            SQLiteDataAdapter da = new SQLiteDataAdapter(query, con);
            DataTable dt = new DataTable();

            string adminQuery = "SELECT Loma FROM lietotajs WHERE Epasts=@Email";

            using (SQLiteCommand cmd2 = new SQLiteCommand(adminQuery, con))
            {
                MessageBox.Show(email);
                cmd2.Parameters.AddWithValue("@Email", email);
                object result = cmd2.ExecuteScalar();
                bool admin = Convert.ToBoolean(result);
                if (admin == true)
                {
                    //materialTabControl1.TabPages.Show(tabPage4);
                }

            }

            da.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectRootDirectory = Path.GetFullPath(Path.Combine(exeDirectory, @"..\..\..\"));
            string dbFilePath = Path.Combine(projectRootDirectory, "db", "prog2atslgisnsys.db");
            string connectionString = @"data source =" + dbFilePath;

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM IzdotasAtslegas";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(query, con);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Atgadījusies kļūda!" + ex);
            }



        }
        private void button2_Click(object sender, EventArgs e)

        {
            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectRootDirectory = Path.GetFullPath(Path.Combine(exeDirectory, @"..\..\..\"));
            string dbFilePath = Path.Combine(projectRootDirectory, "db", "prog2atslgisnsys.db");

            string connectionString = @"data source =" + dbFilePath;

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT AtslegasID, AtslegasKabinets FROM Atslegas WHERE AtslegasID NOT IN (SELECT AtslegasID FROM IzdotasAtslegas)";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(query, con);
                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    dataGridView2.DataSource = dt;
                    con.Close();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Atgadījusies kļūda!" + ex);
            }

        }





        private void button3_Click(object sender, EventArgs e)
        {

        }

      
    }
}
