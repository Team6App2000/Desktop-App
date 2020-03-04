using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }
       
        private void TestButton_Click(object sender, EventArgs e)
        {
            // generer en connection string for database
            MySql.Data.MySqlClient.MySqlConnection connection;
            string server = "256328.db.tornado-node.net";
            string database = "mysql256328";
            string uid = "mysql256328";
            string password = @"V\S|=Sv*D*Z3";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);

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

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            // generer en connection string for database
            MySql.Data.MySqlClient.MySqlConnection connection;
            string server = "256328.db.tornado-node.net";
            string database = "mysql256328";
            string uid = "mysql256328";
            string password = @"V\S|=Sv*D*Z3";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
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

        private void viewLikeThatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitProgramMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

