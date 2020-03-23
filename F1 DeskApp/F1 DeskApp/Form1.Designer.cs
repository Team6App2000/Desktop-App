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
            this.button1 = new System.Windows.Forms.Button();
            this.helloWorldLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TableSelect = new System.Windows.Forms.ComboBox();
            this.SearchTerm = new System.Windows.Forms.TextBox();
            this.EditField3 = new System.Windows.Forms.TextBox();
            this.EditField2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ColumnSelect = new System.Windows.Forms.ComboBox();
            this.EditField4 = new System.Windows.Forms.TextBox();
            this.EditField1 = new System.Windows.Forms.TextBox();
            this.EditField5 = new System.Windows.Forms.TextBox();
            this.EditField6 = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Field1 = new System.Windows.Forms.Label();
            this.Field2 = new System.Windows.Forms.Label();
            this.Field3 = new System.Windows.Forms.Label();
            this.Field4 = new System.Windows.Forms.Label();
            this.Field5 = new System.Windows.Forms.Label();
            this.Field6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 502);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Test DB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // helloWorldLabel
            // 
            this.helloWorldLabel.AutoSize = true;
            this.helloWorldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloWorldLabel.Location = new System.Drawing.Point(146, 12);
            this.helloWorldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.helloWorldLabel.Name = "helloWorldLabel";
            this.helloWorldLabel.Size = new System.Drawing.Size(131, 26);
            this.helloWorldLabel.TabIndex = 3;
            this.helloWorldLabel.Text = "Hello World!";
            this.helloWorldLabel.Click += new System.EventHandler(this.helloWorldLabel_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(270, 233);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 483);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 50);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(417, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(719, 522);
            this.dataGridView1.TabIndex = 6;
            // 
            // TableSelect
            // 
            this.TableSelect.FormattingEnabled = true;
            this.TableSelect.Location = new System.Drawing.Point(151, 51);
            this.TableSelect.Name = "TableSelect";
            this.TableSelect.Size = new System.Drawing.Size(121, 21);
            this.TableSelect.TabIndex = 8;
            this.TableSelect.Text = "Select Table";
            this.TableSelect.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // SearchTerm
            // 
            this.SearchTerm.Location = new System.Drawing.Point(270, 198);
            this.SearchTerm.Name = "SearchTerm";
            this.SearchTerm.Size = new System.Drawing.Size(121, 20);
            this.SearchTerm.TabIndex = 9;
            this.SearchTerm.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // EditField3
            // 
            this.EditField3.Location = new System.Drawing.Point(127, 208);
            this.EditField3.Name = "EditField3";
            this.EditField3.Size = new System.Drawing.Size(100, 20);
            this.EditField3.TabIndex = 10;
            // 
            // EditField2
            // 
            this.EditField2.Location = new System.Drawing.Point(127, 182);
            this.EditField2.Name = "EditField2";
            this.EditField2.Size = new System.Drawing.Size(100, 20);
            this.EditField2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Search Term";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ColumnSelect
            // 
            this.ColumnSelect.FormattingEnabled = true;
            this.ColumnSelect.Location = new System.Drawing.Point(270, 155);
            this.ColumnSelect.Name = "ColumnSelect";
            this.ColumnSelect.Size = new System.Drawing.Size(121, 21);
            this.ColumnSelect.TabIndex = 13;
            this.ColumnSelect.Text = "Select Column";
            this.ColumnSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // EditField4
            // 
            this.EditField4.Location = new System.Drawing.Point(127, 234);
            this.EditField4.Name = "EditField4";
            this.EditField4.Size = new System.Drawing.Size(100, 20);
            this.EditField4.TabIndex = 14;
            // 
            // EditField1
            // 
            this.EditField1.Location = new System.Drawing.Point(127, 156);
            this.EditField1.Name = "EditField1";
            this.EditField1.Size = new System.Drawing.Size(100, 20);
            this.EditField1.TabIndex = 15;
            // 
            // EditField5
            // 
            this.EditField5.Location = new System.Drawing.Point(127, 260);
            this.EditField5.Name = "EditField5";
            this.EditField5.Size = new System.Drawing.Size(100, 20);
            this.EditField5.TabIndex = 16;
            // 
            // EditField6
            // 
            this.EditField6.Location = new System.Drawing.Point(127, 286);
            this.EditField6.Name = "EditField6";
            this.EditField6.Size = new System.Drawing.Size(100, 20);
            this.EditField6.TabIndex = 17;
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(64, 346);
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
            this.label2.Location = new System.Drawing.Point(282, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 31);
            this.label2.TabIndex = 19;
            this.label2.Text = "Search";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 31);
            this.label3.TabIndex = 20;
            this.label3.Text = "Insert/Update";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(282, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 31);
            this.label4.TabIndex = 25;
            this.label4.Text = "Delete";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(270, 346);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.Text = "Select Column";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_2);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(270, 389);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(121, 20);
            this.textBox8.TabIndex = 22;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(270, 424);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 36);
            this.button4.TabIndex = 21;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(64, 424);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 36);
            this.button5.TabIndex = 26;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Field1
            // 
            this.Field1.AutoSize = true;
            this.Field1.Location = new System.Drawing.Point(22, 159);
            this.Field1.Name = "Field1";
            this.Field1.Size = new System.Drawing.Size(73, 13);
            this.Field1.TabIndex = 27;
            this.Field1.Text = "Field (unused)";
            // 
            // Field2
            // 
            this.Field2.AutoSize = true;
            this.Field2.Location = new System.Drawing.Point(22, 185);
            this.Field2.Name = "Field2";
            this.Field2.Size = new System.Drawing.Size(73, 13);
            this.Field2.TabIndex = 28;
            this.Field2.Text = "Field (unused)";
            // 
            // Field3
            // 
            this.Field3.AutoSize = true;
            this.Field3.Location = new System.Drawing.Point(22, 211);
            this.Field3.Name = "Field3";
            this.Field3.Size = new System.Drawing.Size(73, 13);
            this.Field3.TabIndex = 29;
            this.Field3.Text = "Field (unused)";
            // 
            // Field4
            // 
            this.Field4.AutoSize = true;
            this.Field4.Location = new System.Drawing.Point(22, 237);
            this.Field4.Name = "Field4";
            this.Field4.Size = new System.Drawing.Size(73, 13);
            this.Field4.TabIndex = 30;
            this.Field4.Text = "Field (unused)";
            // 
            // Field5
            // 
            this.Field5.AutoSize = true;
            this.Field5.Location = new System.Drawing.Point(22, 263);
            this.Field5.Name = "Field5";
            this.Field5.Size = new System.Drawing.Size(73, 13);
            this.Field5.TabIndex = 31;
            this.Field5.Text = "Field (unused)";
            // 
            // Field6
            // 
            this.Field6.AutoSize = true;
            this.Field6.Location = new System.Drawing.Point(22, 289);
            this.Field6.Name = "Field6";
            this.Field6.Size = new System.Drawing.Size(73, 13);
            this.Field6.TabIndex = 32;
            this.Field6.Text = "Field (unused)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 545);
            this.Controls.Add(this.Field6);
            this.Controls.Add(this.Field5);
            this.Controls.Add(this.Field4);
            this.Controls.Add(this.Field3);
            this.Controls.Add(this.Field2);
            this.Controls.Add(this.Field1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.EditField6);
            this.Controls.Add(this.EditField5);
            this.Controls.Add(this.EditField1);
            this.Controls.Add(this.EditField4);
            this.Controls.Add(this.ColumnSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditField2);
            this.Controls.Add(this.EditField3);
            this.Controls.Add(this.SearchTerm);
            this.Controls.Add(this.TableSelect);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.helloWorldLabel);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "DeskApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label helloWorldLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox TableSelect;
        private System.Windows.Forms.TextBox SearchTerm;
        private System.Windows.Forms.TextBox EditField3;
        private System.Windows.Forms.TextBox EditField2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ColumnSelect;
        private System.Windows.Forms.TextBox EditField4;
        private System.Windows.Forms.TextBox EditField1;
        private System.Windows.Forms.TextBox EditField5;
        private System.Windows.Forms.TextBox EditField6;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label Field1;
        private System.Windows.Forms.Label Field2;
        private System.Windows.Forms.Label Field3;
        private System.Windows.Forms.Label Field4;
        private System.Windows.Forms.Label Field5;
        private System.Windows.Forms.Label Field6;
    }
}

