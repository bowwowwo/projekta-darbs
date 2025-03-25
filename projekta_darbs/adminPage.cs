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

namespace projekta_darbs
{
    public partial class adminPage : MaterialForm
    {
        
    



        public adminPage()
        {


            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple800, Primary.DeepPurple600, Primary.DeepPurple400, Accent.Blue200, TextShade.WHITE);

           
        }
        string AtslegasID;
        string AtslegasKabinets;


        private void adminPage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            AtslegasID = textBox1.Text;
            AtslegasKabinets = textBox2.Text;

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
            MessageBox.Show("pielikam atslegu");
            con.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;    // sql for login
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
    }
}
