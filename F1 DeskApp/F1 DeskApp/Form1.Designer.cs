namespace F1_DeskApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.helloWorldLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TableSelect = new System.Windows.Forms.ComboBox();
            this.SearchTerm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ColumnSelect = new System.Windows.Forms.ComboBox();
            this.EditField1 = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DeleteColumnSelect = new System.Windows.Forms.ComboBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Field1 = new System.Windows.Forms.Label();
            this.ForeignKeyBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Field6 = new System.Windows.Forms.Label();
            this.Field5 = new System.Windows.Forms.Label();
            this.Field4 = new System.Windows.Forms.Label();
            this.ForeignKeyBox2 = new System.Windows.Forms.ComboBox();
            this.Field3 = new System.Windows.Forms.Label();
            this.ForeignKeyBox3 = new System.Windows.Forms.ComboBox();
            this.Field2 = new System.Windows.Forms.Label();
            this.EditField6 = new System.Windows.Forms.TextBox();
            this.ForeignKeyBox4 = new System.Windows.Forms.ComboBox();
            this.EditField5 = new System.Windows.Forms.TextBox();
            this.EditField3 = new System.Windows.Forms.TextBox();
            this.EditField4 = new System.Windows.Forms.TextBox();
            this.EditField2 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.UpdateField6 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UpdateField5 = new System.Windows.Forms.Label();
            this.UpdateField4 = new System.Windows.Forms.Label();
            this.UpdateField1 = new System.Windows.Forms.Label();
            this.UpdateEditField1 = new System.Windows.Forms.TextBox();
            this.UpdateField3 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.UpdateField2 = new System.Windows.Forms.Label();
            this.UpdateEditField6 = new System.Windows.Forms.TextBox();
            this.UpdateEditField5 = new System.Windows.Forms.TextBox();
            this.UpdateEditField3 = new System.Windows.Forms.TextBox();
            this.UpdateEditField4 = new System.Windows.Forms.TextBox();
            this.UpdateEditField2 = new System.Windows.Forms.TextBox();
            this.UpdateForeignKeyBox1 = new System.Windows.Forms.ComboBox();
            this.UpdateForeignKeyBox2 = new System.Windows.Forms.ComboBox();
            this.UpdateForeignKeyBox3 = new System.Windows.Forms.ComboBox();
            this.UpdateForeignKeyBox4 = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DeleteValueBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // helloWorldLabel
            // 
            this.helloWorldLabel.AutoSize = true;
            this.helloWorldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloWorldLabel.Location = new System.Drawing.Point(120, 12);
            this.helloWorldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.helloWorldLabel.Name = "helloWorldLabel";
            this.helloWorldLabel.Size = new System.Drawing.Size(227, 26);
            this.helloWorldLabel.TabIndex = 3;
            this.helloWorldLabel.Text = "F1 Database Manager";
            this.helloWorldLabel.Click += new System.EventHandler(this.helloWorldLabel_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 189);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(485, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(631, 518);
            this.dataGridView1.TabIndex = 6;
            // 
            // TableSelect
            // 
            this.TableSelect.FormattingEnabled = true;
            this.TableSelect.Location = new System.Drawing.Point(168, 51);
            this.TableSelect.Name = "TableSelect";
            this.TableSelect.Size = new System.Drawing.Size(121, 21);
            this.TableSelect.TabIndex = 8;
            this.TableSelect.Text = "Select Table";
            this.TableSelect.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // SearchTerm
            // 
            this.SearchTerm.Location = new System.Drawing.Point(152, 154);
            this.SearchTerm.Name = "SearchTerm";
            this.SearchTerm.Size = new System.Drawing.Size(121, 20);
            this.SearchTerm.TabIndex = 9;
            this.SearchTerm.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Search Term";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ColumnSelect
            // 
            this.ColumnSelect.FormattingEnabled = true;
            this.ColumnSelect.Location = new System.Drawing.Point(152, 111);
            this.ColumnSelect.Name = "ColumnSelect";
            this.ColumnSelect.Size = new System.Drawing.Size(121, 21);
            this.ColumnSelect.TabIndex = 13;
            this.ColumnSelect.Text = "Select Column";
            this.ColumnSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // EditField1
            // 
            this.EditField1.Location = new System.Drawing.Point(214, 106);
            this.EditField1.Name = "EditField1";
            this.EditField1.Size = new System.Drawing.Size(131, 20);
            this.EditField1.TabIndex = 15;
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(172, 269);
            this.InsertButton.Margin = new System.Windows.Forms.Padding(2);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(121, 36);
            this.InsertButton.TabIndex = 18;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 31);
            this.label2.TabIndex = 19;
            this.label2.Text = "Search";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 31);
            this.label3.TabIndex = 20;
            this.label3.Text = "Insert";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(166, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 31);
            this.label4.TabIndex = 25;
            this.label4.Text = "Delete";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // DeleteColumnSelect
            // 
            this.DeleteColumnSelect.FormattingEnabled = true;
            this.DeleteColumnSelect.Location = new System.Drawing.Point(154, 111);
            this.DeleteColumnSelect.Name = "DeleteColumnSelect";
            this.DeleteColumnSelect.Size = new System.Drawing.Size(121, 21);
            this.DeleteColumnSelect.TabIndex = 24;
            this.DeleteColumnSelect.Text = "Select Column";
            this.DeleteColumnSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_2);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(154, 189);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(121, 36);
            this.DeleteButton.TabIndex = 21;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // Field1
            // 
            this.Field1.AutoSize = true;
            this.Field1.Location = new System.Drawing.Point(109, 109);
            this.Field1.Name = "Field1";
            this.Field1.Size = new System.Drawing.Size(73, 13);
            this.Field1.TabIndex = 27;
            this.Field1.Text = "Field (unused)";
            // 
            // ForeignKeyBox1
            // 
            this.ForeignKeyBox1.FormattingEnabled = true;
            this.ForeignKeyBox1.Location = new System.Drawing.Point(214, 106);
            this.ForeignKeyBox1.Name = "ForeignKeyBox1";
            this.ForeignKeyBox1.Size = new System.Drawing.Size(131, 21);
            this.ForeignKeyBox1.TabIndex = 36;
            this.ForeignKeyBox1.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 78);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(467, 452);
            this.tabControl1.TabIndex = 37;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.Field6);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.Field5);
            this.tabPage2.Controls.Add(this.ForeignKeyBox1);
            this.tabPage2.Controls.Add(this.Field4);
            this.tabPage2.Controls.Add(this.Field1);
            this.tabPage2.Controls.Add(this.ForeignKeyBox2);
            this.tabPage2.Controls.Add(this.EditField1);
            this.tabPage2.Controls.Add(this.Field3);
            this.tabPage2.Controls.Add(this.InsertButton);
            this.tabPage2.Controls.Add(this.ForeignKeyBox3);
            this.tabPage2.Controls.Add(this.Field2);
            this.tabPage2.Controls.Add(this.EditField6);
            this.tabPage2.Controls.Add(this.ForeignKeyBox4);
            this.tabPage2.Controls.Add(this.EditField5);
            this.tabPage2.Controls.Add(this.EditField3);
            this.tabPage2.Controls.Add(this.EditField4);
            this.tabPage2.Controls.Add(this.EditField2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(459, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Insert";
            // 
            // Field6
            // 
            this.Field6.AutoSize = true;
            this.Field6.Location = new System.Drawing.Point(109, 239);
            this.Field6.Name = "Field6";
            this.Field6.Size = new System.Drawing.Size(73, 13);
            this.Field6.TabIndex = 47;
            this.Field6.Text = "Field (unused)";
            // 
            // Field5
            // 
            this.Field5.AutoSize = true;
            this.Field5.Location = new System.Drawing.Point(109, 213);
            this.Field5.Name = "Field5";
            this.Field5.Size = new System.Drawing.Size(73, 13);
            this.Field5.TabIndex = 46;
            this.Field5.Text = "Field (unused)";
            // 
            // Field4
            // 
            this.Field4.AutoSize = true;
            this.Field4.Location = new System.Drawing.Point(109, 187);
            this.Field4.Name = "Field4";
            this.Field4.Size = new System.Drawing.Size(73, 13);
            this.Field4.TabIndex = 45;
            this.Field4.Text = "Field (unused)";
            // 
            // ForeignKeyBox2
            // 
            this.ForeignKeyBox2.FormattingEnabled = true;
            this.ForeignKeyBox2.Location = new System.Drawing.Point(214, 132);
            this.ForeignKeyBox2.Name = "ForeignKeyBox2";
            this.ForeignKeyBox2.Size = new System.Drawing.Size(131, 21);
            this.ForeignKeyBox2.TabIndex = 48;
            this.ForeignKeyBox2.Visible = false;
            // 
            // Field3
            // 
            this.Field3.AutoSize = true;
            this.Field3.Location = new System.Drawing.Point(109, 161);
            this.Field3.Name = "Field3";
            this.Field3.Size = new System.Drawing.Size(73, 13);
            this.Field3.TabIndex = 44;
            this.Field3.Text = "Field (unused)";
            // 
            // ForeignKeyBox3
            // 
            this.ForeignKeyBox3.FormattingEnabled = true;
            this.ForeignKeyBox3.Location = new System.Drawing.Point(214, 158);
            this.ForeignKeyBox3.Name = "ForeignKeyBox3";
            this.ForeignKeyBox3.Size = new System.Drawing.Size(131, 21);
            this.ForeignKeyBox3.TabIndex = 49;
            this.ForeignKeyBox3.Visible = false;
            // 
            // Field2
            // 
            this.Field2.AutoSize = true;
            this.Field2.Location = new System.Drawing.Point(109, 135);
            this.Field2.Name = "Field2";
            this.Field2.Size = new System.Drawing.Size(73, 13);
            this.Field2.TabIndex = 43;
            this.Field2.Text = "Field (unused)";
            // 
            // EditField6
            // 
            this.EditField6.Location = new System.Drawing.Point(214, 236);
            this.EditField6.Name = "EditField6";
            this.EditField6.Size = new System.Drawing.Size(131, 20);
            this.EditField6.TabIndex = 42;
            // 
            // ForeignKeyBox4
            // 
            this.ForeignKeyBox4.FormattingEnabled = true;
            this.ForeignKeyBox4.Location = new System.Drawing.Point(214, 183);
            this.ForeignKeyBox4.Name = "ForeignKeyBox4";
            this.ForeignKeyBox4.Size = new System.Drawing.Size(131, 21);
            this.ForeignKeyBox4.TabIndex = 50;
            this.ForeignKeyBox4.Visible = false;
            // 
            // EditField5
            // 
            this.EditField5.Location = new System.Drawing.Point(214, 210);
            this.EditField5.Name = "EditField5";
            this.EditField5.Size = new System.Drawing.Size(131, 20);
            this.EditField5.TabIndex = 41;
            // 
            // EditField3
            // 
            this.EditField3.Location = new System.Drawing.Point(214, 158);
            this.EditField3.Name = "EditField3";
            this.EditField3.Size = new System.Drawing.Size(131, 20);
            this.EditField3.TabIndex = 38;
            // 
            // EditField4
            // 
            this.EditField4.Location = new System.Drawing.Point(214, 184);
            this.EditField4.Name = "EditField4";
            this.EditField4.Size = new System.Drawing.Size(131, 20);
            this.EditField4.TabIndex = 40;
            // 
            // EditField2
            // 
            this.EditField2.Location = new System.Drawing.Point(214, 132);
            this.EditField2.Name = "EditField2";
            this.EditField2.Size = new System.Drawing.Size(131, 20);
            this.EditField2.TabIndex = 39;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.UpdateField6);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.UpdateField5);
            this.tabPage4.Controls.Add(this.UpdateField4);
            this.tabPage4.Controls.Add(this.UpdateField1);
            this.tabPage4.Controls.Add(this.UpdateEditField1);
            this.tabPage4.Controls.Add(this.UpdateField3);
            this.tabPage4.Controls.Add(this.UpdateButton);
            this.tabPage4.Controls.Add(this.UpdateField2);
            this.tabPage4.Controls.Add(this.UpdateEditField6);
            this.tabPage4.Controls.Add(this.UpdateEditField5);
            this.tabPage4.Controls.Add(this.UpdateEditField3);
            this.tabPage4.Controls.Add(this.UpdateEditField2);
            this.tabPage4.Controls.Add(this.UpdateForeignKeyBox1);
            this.tabPage4.Controls.Add(this.UpdateForeignKeyBox2);
            this.tabPage4.Controls.Add(this.UpdateForeignKeyBox3);
            this.tabPage4.Controls.Add(this.UpdateEditField4);
            this.tabPage4.Controls.Add(this.UpdateForeignKeyBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(459, 426);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Update";
            // 
            // UpdateField6
            // 
            this.UpdateField6.AutoSize = true;
            this.UpdateField6.Location = new System.Drawing.Point(110, 239);
            this.UpdateField6.Name = "UpdateField6";
            this.UpdateField6.Size = new System.Drawing.Size(73, 13);
            this.UpdateField6.TabIndex = 65;
            this.UpdateField6.Text = "Field (unused)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(176, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 31);
            this.label6.TabIndex = 53;
            this.label6.Text = "Update";
            // 
            // UpdateField5
            // 
            this.UpdateField5.AutoSize = true;
            this.UpdateField5.Location = new System.Drawing.Point(110, 213);
            this.UpdateField5.Name = "UpdateField5";
            this.UpdateField5.Size = new System.Drawing.Size(73, 13);
            this.UpdateField5.TabIndex = 64;
            this.UpdateField5.Text = "Field (unused)";
            // 
            // UpdateField4
            // 
            this.UpdateField4.AutoSize = true;
            this.UpdateField4.Location = new System.Drawing.Point(110, 187);
            this.UpdateField4.Name = "UpdateField4";
            this.UpdateField4.Size = new System.Drawing.Size(73, 13);
            this.UpdateField4.TabIndex = 63;
            this.UpdateField4.Text = "Field (unused)";
            // 
            // UpdateField1
            // 
            this.UpdateField1.AutoSize = true;
            this.UpdateField1.Location = new System.Drawing.Point(110, 109);
            this.UpdateField1.Name = "UpdateField1";
            this.UpdateField1.Size = new System.Drawing.Size(73, 13);
            this.UpdateField1.TabIndex = 54;
            this.UpdateField1.Text = "Field (unused)";
            // 
            // UpdateEditField1
            // 
            this.UpdateEditField1.Location = new System.Drawing.Point(215, 106);
            this.UpdateEditField1.Name = "UpdateEditField1";
            this.UpdateEditField1.Size = new System.Drawing.Size(131, 20);
            this.UpdateEditField1.TabIndex = 51;
            // 
            // UpdateField3
            // 
            this.UpdateField3.AutoSize = true;
            this.UpdateField3.Location = new System.Drawing.Point(110, 161);
            this.UpdateField3.Name = "UpdateField3";
            this.UpdateField3.Size = new System.Drawing.Size(73, 13);
            this.UpdateField3.TabIndex = 62;
            this.UpdateField3.Text = "Field (unused)";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(173, 269);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(121, 36);
            this.UpdateButton.TabIndex = 52;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // UpdateField2
            // 
            this.UpdateField2.AutoSize = true;
            this.UpdateField2.Location = new System.Drawing.Point(110, 135);
            this.UpdateField2.Name = "UpdateField2";
            this.UpdateField2.Size = new System.Drawing.Size(73, 13);
            this.UpdateField2.TabIndex = 61;
            this.UpdateField2.Text = "Field (unused)";
            // 
            // UpdateEditField6
            // 
            this.UpdateEditField6.Location = new System.Drawing.Point(215, 236);
            this.UpdateEditField6.Name = "UpdateEditField6";
            this.UpdateEditField6.Size = new System.Drawing.Size(131, 20);
            this.UpdateEditField6.TabIndex = 60;
            // 
            // UpdateEditField5
            // 
            this.UpdateEditField5.Location = new System.Drawing.Point(215, 210);
            this.UpdateEditField5.Name = "UpdateEditField5";
            this.UpdateEditField5.Size = new System.Drawing.Size(131, 20);
            this.UpdateEditField5.TabIndex = 59;
            // 
            // UpdateEditField3
            // 
            this.UpdateEditField3.Location = new System.Drawing.Point(215, 158);
            this.UpdateEditField3.Name = "UpdateEditField3";
            this.UpdateEditField3.Size = new System.Drawing.Size(131, 20);
            this.UpdateEditField3.TabIndex = 56;
            // 
            // UpdateEditField4
            // 
            this.UpdateEditField4.Location = new System.Drawing.Point(215, 184);
            this.UpdateEditField4.Name = "UpdateEditField4";
            this.UpdateEditField4.Size = new System.Drawing.Size(131, 20);
            this.UpdateEditField4.TabIndex = 58;
            // 
            // UpdateEditField2
            // 
            this.UpdateEditField2.Location = new System.Drawing.Point(215, 132);
            this.UpdateEditField2.Name = "UpdateEditField2";
            this.UpdateEditField2.Size = new System.Drawing.Size(131, 20);
            this.UpdateEditField2.TabIndex = 57;
            // 
            // UpdateForeignKeyBox1
            // 
            this.UpdateForeignKeyBox1.FormattingEnabled = true;
            this.UpdateForeignKeyBox1.Location = new System.Drawing.Point(215, 106);
            this.UpdateForeignKeyBox1.Name = "UpdateForeignKeyBox1";
            this.UpdateForeignKeyBox1.Size = new System.Drawing.Size(131, 21);
            this.UpdateForeignKeyBox1.TabIndex = 55;
            this.UpdateForeignKeyBox1.Visible = false;
            // 
            // UpdateForeignKeyBox2
            // 
            this.UpdateForeignKeyBox2.FormattingEnabled = true;
            this.UpdateForeignKeyBox2.Location = new System.Drawing.Point(215, 132);
            this.UpdateForeignKeyBox2.Name = "UpdateForeignKeyBox2";
            this.UpdateForeignKeyBox2.Size = new System.Drawing.Size(131, 21);
            this.UpdateForeignKeyBox2.TabIndex = 66;
            this.UpdateForeignKeyBox2.Visible = false;
            // 
            // UpdateForeignKeyBox3
            // 
            this.UpdateForeignKeyBox3.FormattingEnabled = true;
            this.UpdateForeignKeyBox3.Location = new System.Drawing.Point(215, 158);
            this.UpdateForeignKeyBox3.Name = "UpdateForeignKeyBox3";
            this.UpdateForeignKeyBox3.Size = new System.Drawing.Size(131, 21);
            this.UpdateForeignKeyBox3.TabIndex = 67;
            this.UpdateForeignKeyBox3.Visible = false;
            // 
            // UpdateForeignKeyBox4
            // 
            this.UpdateForeignKeyBox4.FormattingEnabled = true;
            this.UpdateForeignKeyBox4.Location = new System.Drawing.Point(215, 183);
            this.UpdateForeignKeyBox4.Name = "UpdateForeignKeyBox4";
            this.UpdateForeignKeyBox4.Size = new System.Drawing.Size(131, 21);
            this.UpdateForeignKeyBox4.TabIndex = 68;
            this.UpdateForeignKeyBox4.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.SearchTerm);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ColumnSelect);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(459, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.DeleteValueBox);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.DeleteColumnSelect);
            this.tabPage3.Controls.Add(this.DeleteButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(459, 426);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete";
            // 
            // DeleteValueBox
            // 
            this.DeleteValueBox.FormattingEnabled = true;
            this.DeleteValueBox.Location = new System.Drawing.Point(154, 138);
            this.DeleteValueBox.Name = "DeleteValueBox";
            this.DeleteValueBox.Size = new System.Drawing.Size(121, 21);
            this.DeleteValueBox.TabIndex = 26;
            this.DeleteValueBox.Text = "Select Value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 539);
            this.Controls.Add(this.TableSelect);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.helloWorldLabel);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "F1 Desktop App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label helloWorldLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox TableSelect;
        private System.Windows.Forms.TextBox SearchTerm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ColumnSelect;
        private System.Windows.Forms.TextBox EditField1;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DeleteColumnSelect;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label Field1;
        private System.Windows.Forms.ComboBox ForeignKeyBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label Field6;
        private System.Windows.Forms.Label Field5;
        private System.Windows.Forms.Label Field4;
        private System.Windows.Forms.ComboBox ForeignKeyBox2;
        private System.Windows.Forms.Label Field3;
        private System.Windows.Forms.ComboBox ForeignKeyBox3;
        private System.Windows.Forms.Label Field2;
        private System.Windows.Forms.TextBox EditField6;
        private System.Windows.Forms.ComboBox ForeignKeyBox4;
        private System.Windows.Forms.TextBox EditField5;
        private System.Windows.Forms.TextBox EditField3;
        private System.Windows.Forms.TextBox EditField4;
        private System.Windows.Forms.TextBox EditField2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label UpdateField6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label UpdateField5;
        private System.Windows.Forms.Label UpdateField4;
        private System.Windows.Forms.Label UpdateField1;
        private System.Windows.Forms.TextBox UpdateEditField1;
        private System.Windows.Forms.Label UpdateField3;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label UpdateField2;
        private System.Windows.Forms.TextBox UpdateEditField6;
        private System.Windows.Forms.TextBox UpdateEditField5;
        private System.Windows.Forms.TextBox UpdateEditField3;
        private System.Windows.Forms.TextBox UpdateEditField4;
        private System.Windows.Forms.TextBox UpdateEditField2;
        private System.Windows.Forms.ComboBox UpdateForeignKeyBox1;
        private System.Windows.Forms.ComboBox UpdateForeignKeyBox2;
        private System.Windows.Forms.ComboBox UpdateForeignKeyBox3;
        private System.Windows.Forms.ComboBox UpdateForeignKeyBox4;
        private System.Windows.Forms.ComboBox DeleteValueBox;
    }
}

