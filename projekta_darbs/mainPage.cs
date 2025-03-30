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
        // private string email = Globals.userEmail;
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
            PopulateComboBox();
            PopulateComboBox2();

            string adminQuery = "SELECT Loma FROM lietotajs WHERE Epasts=@Email";
            con.Close();

            /* using (SQLiteCommand cmd2 = new SQLiteCommand(adminQuery, con))

             using (SQLiteCommand cmd2 = new SQLiteCommand(adminQuery, con))
             {
                 //MessageBox.Show(email);
                 cmd2.Parameters.AddWithValue("@Email", email);
                 object result = cmd2.ExecuteScalar();
                 bool admin = Convert.ToBoolean(result);
                 if (admin == true)
                 {
                     //materialTabControl1.TabPages.Show(tabPage4);
                 }

             }*/

        }

        
        


        private void PopulateComboBox()
        {

            comboBox1.Items.Clear();
            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectRootDirectory = Path.GetFullPath(Path.Combine(exeDirectory, @"..\..\..\"));
            string dbFilePath = Path.Combine(projectRootDirectory, "db", "prog2atslgisnsys.db");
            string connectionString = @"data source =" + dbFilePath;

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT AtslegasID FROM Atslegas WHERE AtslegasID NOT IN (SELECT AtslegasID FROM IzdotasAtslegas)";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                comboBox1.Items.Add(reader["AtslegasID"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
        private void PopulateComboBox2()
        {

            comboBox2.Items.Clear();
            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;    // sql for login
            string projectRootDirectory = Path.GetFullPath(Path.Combine(exeDirectory, @"..\..\..\"));
            string dbFilePath = Path.Combine(projectRootDirectory, "db", "prog2atslgisnsys.db");
            string connectionString = @"data source =" + dbFilePath;


            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "Select AtslegasID From IzdotasAtslegas";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                comboBox2.Items.Add(reader["AtslegasID"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
            PopulateComboBox2();
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
                    string query = "SELECT AtslegasID, AtslegasKabinets FROM IzdotasAtslegas";
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

        private void button1_Click(object sender, EventArgs e)

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

       


     

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Izvēlies atslēgu, ko saņemt!");
                return;
            }

            string selectedAtslegasID = comboBox2.SelectedItem.ToString();
            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectRootDirectory = Path.GetFullPath(Path.Combine(exeDirectory, @"..\..\..\"));
            string dbFilePath = Path.Combine(projectRootDirectory, "db", "prog2atslgisnsys.db");
            string connectionString = @"data source =" + dbFilePath;

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Vai Atslega ir izdota
                    string checkQuery = "SELECT COUNT(*) FROM IzdotasAtslegas WHERE AtslegasID = @atslegasID";
                    int keyCount;

                    using (SQLiteCommand checkCmd = new SQLiteCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@atslegasID", selectedAtslegasID);
                        keyCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                    }

                    if (keyCount == 0)
                    {
                        MessageBox.Show("Šī atslēga nav izdota!");
                        return;
                    }

                    // Nonem atslegu no IzdotasAtslegas
                    string deleteQuery = "DELETE FROM IzdotasAtslegas WHERE AtslegasID = @atslegasID";

                    using (SQLiteCommand deleteCmd = new SQLiteCommand(deleteQuery, connection))
                    {
                        deleteCmd.Parameters.AddWithValue("@atslegasID", selectedAtslegasID);

                        int rowsAffected = deleteCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Atslēga saņemta!");
                            //tukso combobox
                            comboBox2.SelectedIndex = -1;
                            //atjauno combo boxes
                            PopulateComboBox2();
                            PopulateComboBox();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kļūda! " + ex.Message);
            }

        }



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void button3_Click_2(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Lūdzu izvēlies atslēgu!");
                return;
            }

            string selectedAtslegasID = comboBox1.SelectedItem.ToString();
            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectRootDirectory = Path.GetFullPath(Path.Combine(exeDirectory, @"..\..\..\"));
            string dbFilePath = Path.Combine(projectRootDirectory, "db", "prog2atslgisnsys.db");
            string connectionString = @"data source =" + dbFilePath;


            try
            {

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // dabu Atslegas Kabinetu
                    string kabinets = "";
                    string getKabinetsQuery = "SELECT AtslegasKabinets FROM Atslegas WHERE AtslegasID = @id";

                    using (SQLiteCommand getCmd = new SQLiteCommand(getKabinetsQuery, connection))
                    {
                        getCmd.Parameters.AddWithValue("@id", selectedAtslegasID);
                        kabinets = getCmd.ExecuteScalar()?.ToString() ?? "";
                    }

                    // ieliek izdotajas atslegas values
                    string insertQuery = @"INSERT INTO IzdotasAtslegas 
                                (AtslegasID, atslegasKabinets) 
                                VALUES 
                                (@atslegasID, @kabinets)";

                    using (SQLiteCommand insertCmd = new SQLiteCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@atslegasID", selectedAtslegasID);
                        insertCmd.Parameters.AddWithValue("@kabinets", kabinets);

                        int rowsAffected = insertCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Atslēga izdota!");
                            //tukso combobox
                            comboBox1.SelectedIndex = -1;
                            //atjauno combo boxes
                            PopulateComboBox();
                            PopulateComboBox2();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kļūda : " + ex.Message);
            }

        }
    }
}
