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
using System.Reflection.Emit;

namespace projekta_darbs
{


    public partial class mainPage : MaterialForm
    {
        private bool admin = false;
        private object result;
        private string email = Global.g_email;
        string name;

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
            con.Close();

            con.Open();
            string nameQuery = "SELECT Vards FROM lietotajs WHERE Epasts=@Email";
            using (SQLiteCommand cmd = new SQLiteCommand(nameQuery, con))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    name = result.ToString();
                }
            }

            materialLabel2.Text = $"Ielogojies, kā {name}!";
        }

        protected override void OnFormClosing(FormClosingEventArgs e) //make it close
        {
            e.Cancel = false;
            base.OnFormClosing(e);
        }

        private void PopulateComboBox() // aizpilda data combo box ar atslegu info
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
        private void PopulateComboBox2() // aizpilda otro combo box ar info no atslēgām
        {

            comboBox2.Items.Clear();
            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;    // sql file path conn
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

        private void button2_Click(object sender, EventArgs e)  //izdotās atslēgas

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

        private void button3_Click(object sender, EventArgs e) // saņemt atslēgu
        {

            string logKabinets;

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
                        logKabinets = kabinets;
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
                textBox1.AppendText($"{DateTime.Now}: {name} paņēma atslēgu {logKabinets}. kabinetam.{Environment.NewLine}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kļūda : " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e) //atslēgas noliktavā

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

        private void button4_Click(object sender, EventArgs e) //nodot atslēgu
        {

            string logKabinets = "";

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

                    //pievieno atslegas izdosanu log
                    string selectQuery = "SELECT AtslegasKabinets FROM IzdotasAtslegas WHERE AtslegasID = @atslegasID";
                    using (SQLiteCommand cmd = new SQLiteCommand(selectQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@atslegasID", selectedAtslegasID);
                        var result = cmd.ExecuteScalar();
                        MessageBox.Show(result.ToString());
                        if (result != null)
                        {
                            logKabinets = result.ToString();

                        }
                        textBox1.AppendText($"{DateTime.Now}: {name} nodeva atslēgu {logKabinets}. kabinetam.{Environment.NewLine}");
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

    }
}
