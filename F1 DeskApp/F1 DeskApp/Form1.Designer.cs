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
            this.TestButton = new System.Windows.Forms.Button();
            this.helloWorldLabel = new System.Windows.Forms.Label();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.doThisMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.doThatMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMeLikeThisMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLikeThatMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.yesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.changeItMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.noIChangedMyMindMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.opsAgainRedoItMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlzMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.quitProgramMenu = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(196, 66);
            this.TestButton.Margin = new System.Windows.Forms.Padding(2);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(126, 32);
            this.TestButton.TabIndex = 2;
            this.TestButton.Text = "Test DB";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // helloWorldLabel
            // 
            this.helloWorldLabel.AutoSize = true;
            this.helloWorldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloWorldLabel.Location = new System.Drawing.Point(191, 16);
            this.helloWorldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.helloWorldLabel.Name = "helloWorldLabel";
            this.helloWorldLabel.Size = new System.Drawing.Size(131, 26);
            this.helloWorldLabel.TabIndex = 3;
            this.helloWorldLabel.Text = "Hello World!";
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Location = new System.Drawing.Point(196, 208);
            this.ExecuteButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(126, 36);
            this.ExecuteButton.TabIndex = 4;
            this.ExecuteButton.Text = "Execute";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 153);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 50);
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
            this.dataGridView1.Size = new System.Drawing.Size(719, 424);
            this.dataGridView1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Write your SQL query here";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMenu,
            this.viewMeMenu,
            this.yesMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1148, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuMenu
            // 
            this.MenuMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doThisMenu,
            this.doThatMenu,
            this.quitProgramMenu});
            this.MenuMenu.Name = "MenuMenu";
            this.MenuMenu.Size = new System.Drawing.Size(50, 20);
            this.MenuMenu.Text = "Menu";
            // 
            // doThisMenu
            // 
            this.doThisMenu.Name = "doThisMenu";
            this.doThisMenu.Size = new System.Drawing.Size(180, 22);
            this.doThisMenu.Text = "Do this";
            // 
            // doThatMenu
            // 
            this.doThatMenu.Name = "doThatMenu";
            this.doThatMenu.Size = new System.Drawing.Size(180, 22);
            this.doThatMenu.Text = "Do that";
            // 
            // viewMeMenu
            // 
            this.viewMeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewMeLikeThisMenu,
            this.viewLikeThatMenu});
            this.viewMeMenu.Name = "viewMeMenu";
            this.viewMeMenu.Size = new System.Drawing.Size(64, 20);
            this.viewMeMenu.Text = "View me";
            // 
            // viewMeLikeThisMenu
            // 
            this.viewMeLikeThisMenu.Name = "viewMeLikeThisMenu";
            this.viewMeLikeThisMenu.Size = new System.Drawing.Size(164, 22);
            this.viewMeLikeThisMenu.Text = "View me like this";
            // 
            // viewLikeThatMenu
            // 
            this.viewLikeThatMenu.Name = "viewLikeThatMenu";
            this.viewLikeThatMenu.Size = new System.Drawing.Size(164, 22);
            this.viewLikeThatMenu.Text = "View me like that";
            this.viewLikeThatMenu.Click += new System.EventHandler(this.viewLikeThatToolStripMenuItem_Click);
            // 
            // yesMenu
            // 
            this.yesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeItMenu,
            this.noIChangedMyMindMenu,
            this.opsAgainRedoItMenu,
            this.ctrlzMenu});
            this.yesMenu.Name = "yesMenu";
            this.yesMenu.Size = new System.Drawing.Size(36, 20);
            this.yesMenu.Text = "Yes";
            // 
            // changeItMenu
            // 
            this.changeItMenu.Name = "changeItMenu";
            this.changeItMenu.Size = new System.Drawing.Size(197, 22);
            this.changeItMenu.Text = "change it";
            // 
            // noIChangedMyMindMenu
            // 
            this.noIChangedMyMindMenu.Name = "noIChangedMyMindMenu";
            this.noIChangedMyMindMenu.Size = new System.Drawing.Size(197, 22);
            this.noIChangedMyMindMenu.Text = "no, i changed my mind";
            // 
            // opsAgainRedoItMenu
            // 
            this.opsAgainRedoItMenu.Name = "opsAgainRedoItMenu";
            this.opsAgainRedoItMenu.Size = new System.Drawing.Size(197, 22);
            this.opsAgainRedoItMenu.Text = "ops, again, re-do it";
            // 
            // ctrlzMenu
            // 
            this.ctrlzMenu.Name = "ctrlzMenu";
            this.ctrlzMenu.Size = new System.Drawing.Size(197, 22);
            this.ctrlzMenu.Text = "ctrl+z";
            // 
            // quitProgramMenu
            // 
            this.quitProgramMenu.Name = "quitProgramMenu";
            this.quitProgramMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitProgramMenu.Size = new System.Drawing.Size(189, 22);
            this.quitProgramMenu.Text = "Quit Program";
            this.quitProgramMenu.Click += new System.EventHandler(this.quitProgramMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 448);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.helloWorldLabel);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "DeskApp";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Label helloWorldLabel;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuMenu;
        private System.Windows.Forms.ToolStripMenuItem doThisMenu;
        private System.Windows.Forms.ToolStripMenuItem doThatMenu;
        private System.Windows.Forms.ToolStripMenuItem viewMeMenu;
        private System.Windows.Forms.ToolStripMenuItem viewMeLikeThisMenu;
        private System.Windows.Forms.ToolStripMenuItem viewLikeThatMenu;
        private System.Windows.Forms.ToolStripMenuItem yesMenu;
        private System.Windows.Forms.ToolStripMenuItem changeItMenu;
        private System.Windows.Forms.ToolStripMenuItem noIChangedMyMindMenu;
        private System.Windows.Forms.ToolStripMenuItem opsAgainRedoItMenu;
        private System.Windows.Forms.ToolStripMenuItem ctrlzMenu;
        private System.Windows.Forms.ToolStripMenuItem quitProgramMenu;
    }
}

