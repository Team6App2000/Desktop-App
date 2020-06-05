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
                                LIMIT 0, 13;";
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
            TableSelect.Items.Remove("CircuitsTest");
            TableSelect.Items.Remove("ConstructorsTest");
            TableSelect.Items.Remove("DriversTest");
            TableSelect.Items.Remove("RacesTest");
            TableSelect.Items.Remove("ResultsTest");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

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
            EditField1.Clear();
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
            DeleteColumnSelect.Text = "Select Column";
            DeleteColumnSelect.Items.Clear();
            tablenameSet.Clear();
            adapter.Fill(tablenameSet);
            EditField1.Enabled = true;
            for (int i = 0; i < tablenameSet.Tables[0].Rows.Count; i++)
            {
                if (i == 0)
                {
                    //disables editing in custom values for columns that use AUTO_INCREMENT
                    switch (tablenameSet.Tables[0].Rows[i][0].ToString())
                    {
                        case "DriverID":
                            if (TableSelect.Text != "Results")
                            {
                                EditField1.Enabled = false;
                            }
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
                DeleteColumnSelect.Items.Add(tablenameSet.Tables[0].Rows[i][0].ToString());
                descriptors[i] = tablenameSet.Tables[0].Rows[i][0].ToString();

            }
            Field1.Text = descriptors[0];
            Field2.Text = descriptors[1];
            Field3.Text = descriptors[2];
            Field4.Text = descriptors[3];
            Field5.Text = descriptors[4];
            Field6.Text = descriptors[5];

            UpdateField1.Text = descriptors[0];
            UpdateField2.Text = descriptors[1];
            UpdateField3.Text = descriptors[2];
            UpdateField4.Text = descriptors[3];
            UpdateField5.Text = descriptors[4];
            UpdateField6.Text = descriptors[5];

            // Reset every field to its default state before further action is taken
            EditField1.Enabled = true;
            EditField2.Enabled = true;
            EditField3.Enabled = true;
            EditField4.Enabled = true;
            EditField5.Enabled = true;
            EditField6.Enabled = true;
            UpdateEditField1.Enabled = true;
            UpdateEditField2.Enabled = true;
            UpdateEditField3.Enabled = true;
            UpdateEditField4.Enabled = true;
            UpdateEditField5.Enabled = true;
            UpdateEditField6.Enabled = true;
            UpdateButton.Enabled = true;
            EditField1.Visible = true;
            EditField2.Visible = true;
            EditField3.Visible = true;
            EditField4.Visible = true;
            UpdateEditField1.Visible = true;
            UpdateEditField2.Visible = true;
            UpdateEditField3.Visible = true;
            UpdateEditField4.Visible = true;
            ForeignKeyBox1.Visible = false;
            ForeignKeyBox2.Visible = false;
            ForeignKeyBox3.Visible = false;
            ForeignKeyBox4.Visible = false;
            UpdateForeignKeyBox1.Visible = false;
            UpdateForeignKeyBox2.Visible = false;
            UpdateForeignKeyBox3.Visible = false;
            UpdateForeignKeyBox4.Visible = false;

            // The Update function relies on a combobox filled with primary key values as a means of selecting which row to edit
            if(TableSelect.Text != "Teams") {
                UpdateEditField1.Visible = false;
                UpdateForeignKeyBox1.Visible = true;
                connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["datab"].ConnectionString);
                string UpdateKeyBox1Query;
                if (TableSelect.Text == "Results")
                {
                    connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["datab"].ConnectionString);
                    UpdateKeyBox1Query = @"SELECT " + Field1.Text + " FROM Drivers";

                }
                else
                {

                    UpdateKeyBox1Query = @"SELECT " + Field1.Text + " FROM " + TableSelect.Text;
                }
                
                MySqlCommand UpdateKeyBox1Command = new MySqlCommand(UpdateKeyBox1Query, connection);
                MySqlDataAdapter UpdateKeyBox1Adapter = new MySqlDataAdapter(UpdateKeyBox1Command);
                DataSet UpdateKeyBox1DataSet = new DataSet();
                UpdateForeignKeyBox1.Text = "Select " + Field1.Text;
                UpdateForeignKeyBox1.Items.Clear();
                UpdateKeyBox1DataSet.Clear();
                UpdateKeyBox1Adapter.Fill(UpdateKeyBox1DataSet);
                for (int i = 0; i < UpdateKeyBox1DataSet.Tables[0].Rows.Count; i++)
                {
                    UpdateForeignKeyBox1.Items.Add(UpdateKeyBox1DataSet.Tables[0].Rows[i][0].ToString());
                    descriptors[i] = UpdateKeyBox1DataSet.Tables[0].Rows[i][0].ToString();
                }
            }

            // these handle eventual foreign key columns in the insert section by removing their textbox and replacing it with a combobox of selectable values
            if (Field1.Text == "DriverID" && TableSelect.Text == "Results")
            {
                EditField1.Visible = false;
                ForeignKeyBox1.Visible = true;
                connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["datab"].ConnectionString);
                string FKeyBox1Query = @"SELECT " + Field1.Text + " FROM Drivers" ;
                MySqlCommand FKeyBox1Command = new MySqlCommand(FKeyBox1Query, connection);
                MySqlDataAdapter FKeyBox1Adapter = new MySqlDataAdapter(FKeyBox1Command);
                DataSet FkeyBox1DataSet = new DataSet();
                ForeignKeyBox1.Text = "Select " + Field1.Text;
                ForeignKeyBox1.Items.Clear();
                FkeyBox1DataSet.Clear();
                FKeyBox1Adapter.Fill(FkeyBox1DataSet);
                for (int i = 0; i < FkeyBox1DataSet.Tables[0].Rows.Count; i++)
                {
                    ForeignKeyBox1.Items.Add(FkeyBox1DataSet.Tables[0].Rows[i][0].ToString());
                    descriptors[i] = FkeyBox1DataSet.Tables[0].Rows[i][0].ToString();
                }


            }

            if (Field2.Text == "EventID" || Field2.Text == "RaceID")
            {
                EditField2.Visible = false;
                UpdateEditField2.Visible = false;
                ForeignKeyBox2.Visible = true;
                UpdateForeignKeyBox2.Visible = true;
                connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["datab"].ConnectionString);
                string FKeyBox2Query;

                if (Field2.Text == "EventID")
                {
                    FKeyBox2Query = @"SELECT " + Field2.Text + " FROM Events";
                }

                else
                {
                    FKeyBox2Query = @"SELECT " + Field2.Text + " FROM Races";

                }
                MySqlCommand FKeyBox2Command = new MySqlCommand(FKeyBox2Query, connection);
                MySqlDataAdapter FKeyBox2Adapter = new MySqlDataAdapter(FKeyBox2Command);
                DataSet FkeyBox2DataSet = new DataSet();
                ForeignKeyBox2.Text = "Select " +Field2.Text;
                UpdateForeignKeyBox2.Text = "Select " + Field2.Text;
                ForeignKeyBox2.Items.Clear();
                UpdateForeignKeyBox2.Items.Clear();
                FkeyBox2DataSet.Clear();
                FKeyBox2Adapter.Fill(FkeyBox2DataSet);
                for (int i = 0; i < FkeyBox2DataSet.Tables[0].Rows.Count; i++)
                {
                    ForeignKeyBox2.Items.Add(FkeyBox2DataSet.Tables[0].Rows[i][0].ToString());
                    UpdateForeignKeyBox2.Items.Add(FkeyBox2DataSet.Tables[0].Rows[i][0].ToString());
                    descriptors[i] = FkeyBox2DataSet.Tables[0].Rows[i][0].ToString();
                }


            }
            if(Field3.Text == "EventID")
            {
                EditField3.Visible = false;
                UpdateEditField3.Visible = false;
                ForeignKeyBox3.Visible = true;
                UpdateForeignKeyBox3.Visible = true;
                connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["datab"].ConnectionString);
                string FKeyBox3Query = @"SELECT " + Field3.Text + " FROM Events";
                MySqlCommand FKeyBox3Command = new MySqlCommand(FKeyBox3Query, connection);
                MySqlDataAdapter FKeyBox3Adapter = new MySqlDataAdapter(FKeyBox3Command);
                DataSet FkeyBox3DataSet = new DataSet();
                ForeignKeyBox3.Text = "Select " + Field3.Text;
                UpdateForeignKeyBox3.Text = "Select " + Field3.Text;
                ForeignKeyBox3.Items.Clear();
                UpdateForeignKeyBox3.Items.Clear();
                FkeyBox3DataSet.Clear();
                FKeyBox3Adapter.Fill(FkeyBox3DataSet);
                for (int i = 0; i < FkeyBox3DataSet.Tables[0].Rows.Count; i++)
                {
                    ForeignKeyBox3.Items.Add(FkeyBox3DataSet.Tables[0].Rows[i][0].ToString());
                    UpdateForeignKeyBox3.Items.Add(FkeyBox3DataSet.Tables[0].Rows[i][0].ToString());
                    descriptors[i] = FkeyBox3DataSet.Tables[0].Rows[i][0].ToString();
                }
               
            }
            if (Field4.Text == "TeamName")
            {
                EditField4.Visible = false;
                UpdateEditField4.Visible = false;
                ForeignKeyBox4.Visible = true;
                UpdateForeignKeyBox4.Visible = true;
                connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["datab"].ConnectionString);
                string FKeyBox4Query = @"SELECT " + Field4.Text + " FROM Teams";
                MySqlCommand FKeyBox4Command = new MySqlCommand(FKeyBox4Query, connection);
                MySqlDataAdapter FKeyBox4Adapter = new MySqlDataAdapter(FKeyBox4Command);
                DataSet FkeyBox4DataSet = new DataSet();
                ForeignKeyBox4.Text = "Select " + Field4.Text;
                UpdateForeignKeyBox4.Text = "Select " + Field4.Text;
                ForeignKeyBox4.Items.Clear();
                UpdateForeignKeyBox4.Items.Clear();
                FkeyBox4DataSet.Clear();
                FKeyBox4Adapter.Fill(FkeyBox4DataSet);
                for (int i = 0; i < FkeyBox4DataSet.Tables[0].Rows.Count; i++)
                {
                    ForeignKeyBox4.Items.Add(FkeyBox4DataSet.Tables[0].Rows[i][0].ToString());
                    UpdateForeignKeyBox4.Items.Add(FkeyBox4DataSet.Tables[0].Rows[i][0].ToString());
                    descriptors[i] = FkeyBox4DataSet.Tables[0].Rows[i][0].ToString();
                }
            }
            // Since Teams only consists of a single primary key value, updating its values is disabled

            if(TableSelect.Text == "Teams") 
            { 
                UpdateEditField1.Enabled = false;
                UpdateEditField2.Enabled = false;
                UpdateEditField3.Enabled = false;
                UpdateEditField4.Enabled = false;
                UpdateEditField5.Enabled = false;
                UpdateEditField6.Enabled = false;
                UpdateButton.Enabled = false;
            }

            // For QoL, disable fields unused in the current query
            if(UpdateField1.Text == "Field (unused)")
            {
                UpdateEditField1.Enabled = false;
            }
            if (UpdateField2.Text == "Field (unused)")
            {
                UpdateEditField2.Enabled = false;
            }
            if (UpdateField3.Text == "Field (unused)")
            {
                UpdateEditField3.Enabled = false;
            }
            if (UpdateField4.Text == "Field (unused)")
            {
                UpdateEditField4.Enabled = false;
            }
            if (UpdateField5.Text == "Field (unused)")
            {
                UpdateEditField5.Enabled = false;
            }
            if (UpdateField6.Text == "Field (unused)")
            {
                UpdateEditField6.Enabled = false;
            }
            if (Field1.Text == "Field (unused)")
            {
                EditField1.Enabled = false;
            }
            if (Field2.Text == "Field (unused)")
            {
                EditField2.Enabled = false;
            }
            if (Field3.Text == "Field (unused)")
            {
                EditField3.Enabled = false;
            }
            if (Field4.Text == "Field (unused)")
            {
                EditField4.Enabled = false;
            }
            if (Field5.Text == "Field (unused)")
            {
                EditField5.Enabled = false;
            }
            if (Field6.Text == "Field (unused)")
            {
                EditField6.Enabled = false;
            }

        }

        // Fills values into DeleteValueSelect when a column is selected
        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection connection;
            connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["datab"].ConnectionString);
            string DeleteBoxQuery = @"SELECT " + DeleteColumnSelect.Text + " FROM " + TableSelect.Text;
            MySqlCommand DeleteBoxCommand = new MySqlCommand(DeleteBoxQuery, connection);
            MySqlDataAdapter DeleteBoxAdapter = new MySqlDataAdapter(DeleteBoxCommand);
            DataSet DeleteBoxDataSet = new DataSet();
            DeleteValueBox.Items.Clear();
            DeleteValueBox.Text = "Select " + DeleteColumnSelect.Text;
            DeleteBoxDataSet.Clear();
            DeleteBoxAdapter.Fill(DeleteBoxDataSet);
            for (int i = 0; i < DeleteBoxDataSet.Tables[0].Rows.Count; i++)
            {
                DeleteValueBox.Items.Add(DeleteBoxDataSet.Tables[0].Rows[i][0].ToString()); 
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



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        //Deletes a row from the database depending on the selected column and value
        private void button4_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection connection;
            connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["datab"].ConnectionString);
            string editQuery = "DELETE FROM `" + TableSelect.Text + "` WHERE `" + DeleteColumnSelect.Text + "` = '" + DeleteValueBox.Text +"'";
            MySqlCommand command = new MySqlCommand(editQuery, connection);
            MySqlDataReader dataReader;
            try
            {
                //MessageBox.Show(editQuery);
                connection.Open();
                dataReader = command.ExecuteReader();
                MessageBox.Show("Command Executed");
                connection.Close();

            }
            catch (MySqlException)
            {
            }

        }

        private void InsertButton_Click(object sender, EventArgs e)
            // Inserts data into the database based on values of editable fields
        {
            List<string> EditFieldValues = new List<string>();
            // If the textbox is not visible(presumably due to being a foreign key), replace the value with the corresponding foreign key dropdown menu
            EditFieldValues.Clear();  
            if(EditField1.Visible == true) 
            {
                EditFieldValues.Add(EditField1.Text);
            }
            else
            {
                EditFieldValues.Add(ForeignKeyBox1.Text);
            }

            if (EditField2.Visible)
            {
                EditFieldValues.Add(EditField2.Text);
            }

            else
            {
                EditFieldValues.Add(ForeignKeyBox2.Text);
            }

            if(EditField3.Visible)
            {
                EditFieldValues.Add(EditField3.Text);
            }

            else
            {
                EditFieldValues.Add(ForeignKeyBox3.Text);
            }

            if (EditField4.Visible)
            {
                EditFieldValues.Add(EditField4.Text);
            }

            else
            {
                EditFieldValues.Add(ForeignKeyBox4.Text);
            }

            EditFieldValues.Add(EditField5.Text);
            EditFieldValues.Add(EditField6.Text);

            MySql.Data.MySqlClient.MySqlConnection connection;
            connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["datab"].ConnectionString);
            //Accounts for AUTO_INCREMENT by skipping the first value when its related EditField is disabled
            string autoIncrementCompensation = "";
            if(EditField1.Enabled == false)
            {
                autoIncrementCompensation += "(" + ColumnSelect.Items[1].ToString();
                for (int i = 2; i < ColumnSelect.Items.Count; i++)
                {
                    autoIncrementCompensation += ", " + ColumnSelect.Items[i].ToString();
                }
                autoIncrementCompensation += ")";
            }
            //if the first value doesn't use AUTO_INCREMENT, the first value is included
            else
            {
                autoIncrementCompensation += "(" + ColumnSelect.Items[0].ToString();
                for (int i = 1; i < ColumnSelect.Items.Count; i++)
                {
                    autoIncrementCompensation += ", " + ColumnSelect.Items[i].ToString();
                }
                autoIncrementCompensation += ")";
            }
            //SQL Query starts here
            string editQuery = @"INSERT INTO `" + TableSelect.Text + "`" + autoIncrementCompensation + " VALUES (";
            
            //Skipping the first value for AUTO_INCREMENT is also implemented here
            if(EditField1.Enabled == true) { 
                editQuery += @"'" + EditFieldValues[0];
                for (int i = 1; i < ColumnSelect.Items.Count; i++)
                {
                    editQuery += @"', '" + EditFieldValues[i];
                }
            }
            else
            {
                editQuery += @"'" + EditFieldValues[1];
                for (int i = 2; i < ColumnSelect.Items.Count; i++)
                {
                    editQuery += @"', '" + EditFieldValues[i];
                }
            }
            
            editQuery += "')";
            //SQL Query ends here

            MySqlCommand command = new MySqlCommand(editQuery, connection);
            MySqlDataReader dataReader;
            try
            {
                //MessageBox.Show(editQuery);
                connection.Open();
                dataReader = command.ExecuteReader();
                MessageBox.Show("Command Executed");
                connection.Close();

            }
            catch (MySqlException)
            {
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            //Updates values based on fields in the "Update" section
            List<string> UpdateFieldValues = new List<string>();
            // If the textbox is not visible(presumably due to being a foreign key), replace the value with the corresponding foreign key dropdown menu
            UpdateFieldValues.Clear();
            if (UpdateEditField1.Visible == true)
            {
                UpdateFieldValues.Add(UpdateEditField1.Text);
            }
            else
            {
                UpdateFieldValues.Add(UpdateForeignKeyBox1.Text);
            }

            if (UpdateEditField2.Visible)
            {
                UpdateFieldValues.Add(UpdateEditField2.Text);
            }

            else
            {
                UpdateFieldValues.Add(UpdateForeignKeyBox2.Text);
            }

            if (UpdateEditField3.Visible)
            {
                UpdateFieldValues.Add(UpdateEditField3.Text);
            }

            else
            {
                UpdateFieldValues.Add(UpdateForeignKeyBox3.Text);
            }

            if (UpdateEditField4.Visible)
            {
                UpdateFieldValues.Add(UpdateEditField4.Text);
            }

            else
            {
                UpdateFieldValues.Add(UpdateForeignKeyBox4.Text);
            }

            UpdateFieldValues.Add(UpdateEditField5.Text);
            UpdateFieldValues.Add(UpdateEditField6.Text);

            List<string> Updatedescriptors = new List<string>();
            Updatedescriptors.Add(UpdateField1.Text);
            Updatedescriptors.Add(UpdateField2.Text);
            Updatedescriptors.Add(UpdateField3.Text);
            Updatedescriptors.Add(UpdateField4.Text);
            Updatedescriptors.Add(UpdateField5.Text);
            Updatedescriptors.Add(UpdateField6.Text);

            MySql.Data.MySqlClient.MySqlConnection connection;
            connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["datab"].ConnectionString);
            //SQL Query starts here
            string editQuery = @"UPDATE `" + TableSelect.Text + "`" + " SET ";
            editQuery += @"`" + Updatedescriptors[1] + "` = '" + UpdateFieldValues[1];
            for (int i = 2; i < ColumnSelect.Items.Count; i++)
            {
                editQuery += @"', `"+ Updatedescriptors[i] + "` = '" + UpdateFieldValues[i];
            }
            editQuery += "' WHERE `" + Updatedescriptors[0] + "` = '" + UpdateFieldValues[0] +"'";
            //SQL Query ends here

            MySqlCommand command = new MySqlCommand(editQuery, connection);
            MySqlDataReader dataReader;
            try
            {
                //MessageBox.Show(editQuery);
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

