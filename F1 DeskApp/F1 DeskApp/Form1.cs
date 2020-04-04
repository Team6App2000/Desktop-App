using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace F1_DeskApp
{



    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Shown += Form1_Shown;

        }

        private void Form1_Shown(object sender, EventArgs e)

        {
            // Legger til tabeller fra database i drop-down meny
            MySql.Data.MySqlClient.MySqlConnection connection;
            connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["datab"].ConnectionString);
            string editQuery = @"SELECT table_name FROM information_schema.tables
                                WHERE table_schema = 'mysql256328'
                                LIMIT 0, 8;";
            MySqlCommand command = new MySqlCommand(editQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataSet comboboxSet = new DataSet();
            adapter.Fill(comboboxSet);
            for (int i = 0; i < comboboxSet.Tables[0].Rows.Count; i++)
            {
                TableSelect.Items.Add(comboboxSet.Tables[0].Rows[i][0].ToString());
            }
            TableSelect.Items.Remove("User");
            TableSelect.Items.Remove("Favorites");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // generates a connection string for the database
            MySql.Data.MySqlClient.MySqlConnection connection;
            string connectionString;

            connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["datab"].ConnectionString);

            // tester om databasetilkoblingen fungerer
            try
            {
                connection.Open();
                MessageBox.Show("Connection Successful");
                connection.Close();

            }
            catch (MySqlException)
            {
                MessageBox.Show("Database Connection Failed");
            }


        }



        private void Button2_Click(object sender, EventArgs e)
        {
            // Generates a connection string for the database
            MySql.Data.MySqlClient.MySqlConnection connection;
            string connectionString;
            connectionString = ConfigurationManager.ConnectionStrings["datab"].ConnectionString;
            connection = new MySqlConnection(connectionString);
            // The Query to be executed is grabbed from the text box
            try
            {

                string editQuery = "SELECT * FROM `" + TableSelect.Text + "` WHERE `" + ColumnSelect.Text + "` LIKE '" + SearchTerm.Text + "'";
                MySqlCommand command = new MySqlCommand(editQuery, connection);
                MySqlDataReader dataReader;
                connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.HasRows)
                {
                    DataTable readTable = new DataTable();
                    readTable.Load(dataReader);
                    dataGridView1.DataSource = readTable;
                }
                MessageBox.Show("Command Executed");
                connection.Close();
            }
            catch (MySqlException)
            {
                if (TableSelect.Text == "Select Table")
                {
                    MessageBox.Show("Please select a table");
                }

                else
                {
                    MessageBox.Show("Query execution failed");
                }

            }
        }



        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Handles the "TableSelect" drop-down menu
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Field descriptors stored in array to be updated
            List<string> descriptors = new List<string>();
            descriptors.Add("Field (unused)");
            descriptors.Add("Field (unused)");
            descriptors.Add("Field (unused)");
            descriptors.Add("Field (unused)");
            descriptors.Add("Field (unused)");
            descriptors.Add("Field (unused)");

            // Adds columns from selected table to drop-down menu
            MySql.Data.MySqlClient.MySqlConnection connection;
            connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["datab"].ConnectionString);
            string editQuery = @"SELECT COLUMN_NAME FROM information_schema.columns WHERE table_schema = 'mysql256328' AND table_name = '" + TableSelect.Text + "'";
            MySqlCommand command = new MySqlCommand(editQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataSet tablenameSet = new DataSet();
            ColumnSelect.Text = "Select Column";
            ColumnSelect.Items.Clear();
            tablenameSet.Clear();
            adapter.Fill(tablenameSet);
            EditField1.Enabled = true;
            for (int i = 0; i < tablenameSet.Tables[0].Rows.Count; i++)
            {
                if (i == 0)
                {
                    switch (tablenameSet.Tables[0].Rows[i][0].ToString())
                    {
                        case "DriverID":
                            EditField1.Enabled = false;
                            break;
                        case "RaceID":
                            EditField1.Enabled = false;
                            break;
                        case "FavoriteID":
                            EditField1.Enabled = false;
                            break;
                        case "EventID":
                            EditField1.Enabled = false;
                            break;
                        default:
                            break;

                    }

                }
                ColumnSelect.Items.Add(tablenameSet.Tables[0].Rows[i][0].ToString());
                descriptors[i] = tablenameSet.Tables[0].Rows[i][0].ToString();

            }
            Field1.Text = descriptors[0];
            Field2.Text = descriptors[1];
            Field3.Text = descriptors[2];
            Field4.Text = descriptors[3];
            Field5.Text = descriptors[4];
            Field6.Text = descriptors[5];

            // these handle eventual foreign key columns by removing their textbox and replacing it with a combobox of selectable values
            EditField2.Visible = true;
            EditField3.Visible = true;
            EditField4.Visible = true;
            ForeignKeyBox2.Visible = false;
            ForeignKeyBox2.Visible = false;
            ForeignKeyBox2.Visible = false;

            // TODO: add ForeignKeyBox table fills here, make sure AUTO_INCREMENT columns are not added to INSERT/UPDATE statements below, add UPDATE/DELETE
            if (Field2.Text == "EventID" || Field2.Text == "RaceID")
            {
                EditField2.Visible = false;
                ForeignKeyBox2.Visible = true;
            }
            if(Field3.Text == "EventID")
            {
             
            }
            if (Field4.Text == "TeamName")
            {

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void helloWorldLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            List<string> EditFieldValues = new List<string>();
            EditFieldValues.Add(EditField1.Text);
            EditFieldValues.Add(EditField2.Text);
            EditFieldValues.Add(EditField3.Text);
            EditFieldValues.Add(EditField4.Text);
            EditFieldValues.Add(EditField5.Text);
            EditFieldValues.Add(EditField6.Text);

            MySql.Data.MySqlClient.MySqlConnection connection;
            connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["datab"].ConnectionString);
            string editQuery = @"INSERT INTO `" + TableSelect.Text + "` VALUES (";
            editQuery += @"'" + EditFieldValues[0];
            for (int i = 1; i < ColumnSelect.Items.Count; i++)
            {
                editQuery += @"', '" + EditFieldValues[i];
            }
            editQuery += "')";
            MySqlCommand command = new MySqlCommand(editQuery, connection);
            MySqlDataReader dataReader;
            try
            {
                MessageBox.Show(editQuery);
                connection.Open();
                dataReader = command.ExecuteReader();
                MessageBox.Show("Command Executed");
                connection.Close();

            }
            catch (MySqlException)
            {
            }
        }
    }
}

