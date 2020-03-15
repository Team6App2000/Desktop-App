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

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection connection;
            connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["datab"].ConnectionString);
            string editQuery = @"SELECT table_name FROM information_schema.tables
                                WHERE table_schema = 'mysql256328'
                                LIMIT 0, 8;;";
            MySqlCommand command = new MySqlCommand(editQuery, connection);
            MySqlDataReader dataReader;
            connection.Open();
            dataReader = command.ExecuteReader();
            while (dataReader.HasRows)
            {
                DataTable readTable = new DataTable();
                readTable.Load(dataReader);
                comboBox1.DataSource = readTable;
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            // generer en connection string for database
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

            connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["datab"].ConnectionString);
            string editQuery = @"SELECT table_name FROM information_schema.tables
                                WHERE table_schema = 'mysql256328'
                                LIMIT 0, 8;;";
            MySqlCommand command = new MySqlCommand(editQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataSet comboboxSet = new DataSet();
            adapter.Fill(comboboxSet);
            for(int i = 0; i < comboboxSet.Tables[0].Rows.Count; i++)
                {
                comboBox1.Items.Add(comboboxSet.Tables[0].Rows[i][0].ToString());
                }
            }



        private void Button2_Click(object sender, EventArgs e)
        {
            // generer en connection string for database
            MySql.Data.MySqlClient.MySqlConnection connection;
            string connectionString;
            connectionString = ConfigurationManager.ConnectionStrings["datab"].ConnectionString;
            connection = new MySqlConnection(connectionString);
            // The Query to be executed is grabbed from the text box
            try
            {

                string editQuery = textBox1.Text;
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
                MessageBox.Show("Query execution failed");
            }
        }



        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
    }

