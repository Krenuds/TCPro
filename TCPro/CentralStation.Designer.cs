namespace TCPro
{
    partial class CentralStation
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.retrieve_data = new System.Windows.Forms.Button();
            this.sqlCommand_txt = new System.Windows.Forms.TextBox();
            this.sqlCommandLabel = new System.Windows.Forms.Label();
            this.tableMenuList = new System.Windows.Forms.ComboBox();
            this.Table_Label = new System.Windows.Forms.Label();
            this.button_tableSelector = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(633, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(162, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(461, 215);
            this.dataGridView1.TabIndex = 1;
            // 
            // retrieve_data
            // 
            this.retrieve_data.Location = new System.Drawing.Point(537, 254);
            this.retrieve_data.Name = "retrieve_data";
            this.retrieve_data.Size = new System.Drawing.Size(75, 23);
            this.retrieve_data.TabIndex = 2;
            this.retrieve_data.Text = "QUERY";
            this.retrieve_data.UseVisualStyleBackColor = true;
            this.retrieve_data.Click += new System.EventHandler(this.retrieve_data_Click);
            // 
            // sqlCommand_txt
            // 
            this.sqlCommand_txt.Location = new System.Drawing.Point(162, 257);
            this.sqlCommand_txt.Name = "sqlCommand_txt";
            this.sqlCommand_txt.Size = new System.Drawing.Size(369, 20);
            this.sqlCommand_txt.TabIndex = 3;
            // 
            // sqlCommandLabel
            // 
            this.sqlCommandLabel.AutoSize = true;
            this.sqlCommandLabel.Location = new System.Drawing.Point(75, 260);
            this.sqlCommandLabel.Name = "sqlCommandLabel";
            this.sqlCommandLabel.Size = new System.Drawing.Size(81, 13);
            this.sqlCommandLabel.TabIndex = 4;
            this.sqlCommandLabel.Text = "SQL Command:";
            // 
            // tableMenuList
            // 
            this.tableMenuList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableMenuList.FormattingEnabled = true;
            this.tableMenuList.Location = new System.Drawing.Point(12, 58);
            this.tableMenuList.Name = "tableMenuList";
            this.tableMenuList.Size = new System.Drawing.Size(121, 21);
            this.tableMenuList.TabIndex = 5;
            // 
            // Table_Label
            // 
            this.Table_Label.AutoSize = true;
            this.Table_Label.Location = new System.Drawing.Point(12, 42);
            this.Table_Label.Name = "Table_Label";
            this.Table_Label.Size = new System.Drawing.Size(37, 13);
            this.Table_Label.TabIndex = 6;
            this.Table_Label.Text = "Table:";
            // 
            // button_tableSelector
            // 
            this.button_tableSelector.Location = new System.Drawing.Point(12, 95);
            this.button_tableSelector.Name = "button_tableSelector";
            this.button_tableSelector.Size = new System.Drawing.Size(75, 23);
            this.button_tableSelector.TabIndex = 7;
            this.button_tableSelector.Text = "Load Table";
            this.button_tableSelector.UseVisualStyleBackColor = true;
            this.button_tableSelector.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(12, 124);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 23);
            this.button_clear.TabIndex = 8;
            this.button_clear.Text = "Clear Table";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // CentralStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 289);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_tableSelector);
            this.Controls.Add(this.Table_Label);
            this.Controls.Add(this.tableMenuList);
            this.Controls.Add(this.sqlCommandLabel);
            this.Controls.Add(this.sqlCommand_txt);
            this.Controls.Add(this.retrieve_data);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CentralStation";
            this.Text = "CentralStation";
            this.Load += new System.EventHandler(this.CentralStation_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button retrieve_data;
        private System.Windows.Forms.TextBox sqlCommand_txt;
        private System.Windows.Forms.Label sqlCommandLabel;
        private System.Windows.Forms.ComboBox tableMenuList;
        private System.Windows.Forms.Label Table_Label;
        private System.Windows.Forms.Button button_tableSelector;
        private System.Windows.Forms.Button button_clear;
    }
}