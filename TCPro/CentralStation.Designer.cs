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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.excelDataGridView = new System.Windows.Forms.DataGridView();
            this.button_selectWorkbook = new System.Windows.Forms.Button();
            this.combo_sheets = new System.Windows.Forms.ComboBox();
            this.label_sheet = new System.Windows.Forms.Label();
            this.label_WBpath = new System.Windows.Forms.Label();
            this.button_loadSheet = new System.Windows.Forms.Button();
            this.workbookAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_extrapolation = new System.Windows.Forms.GroupBox();
            this.listBox_employees = new System.Windows.Forms.ListBox();
            this.listBox_clients = new System.Windows.Forms.ListBox();
            this.listBox_rooms = new System.Windows.Forms.ListBox();
            this.listBox_unresolvedItems = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelDataGridView)).BeginInit();
            this.groupBox_extrapolation.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.workbookAnalysisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1016, 24);
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
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(531, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(461, 215);
            this.dataGridView1.TabIndex = 1;
            // 
            // retrieve_data
            // 
            this.retrieve_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.retrieve_data.Location = new System.Drawing.Point(917, 342);
            this.retrieve_data.Name = "retrieve_data";
            this.retrieve_data.Size = new System.Drawing.Size(75, 23);
            this.retrieve_data.TabIndex = 2;
            this.retrieve_data.Text = "QUERY";
            this.retrieve_data.UseVisualStyleBackColor = true;
            this.retrieve_data.Click += new System.EventHandler(this.retrieve_data_Click);
            // 
            // sqlCommand_txt
            // 
            this.sqlCommand_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlCommand_txt.Location = new System.Drawing.Point(531, 342);
            this.sqlCommand_txt.Name = "sqlCommand_txt";
            this.sqlCommand_txt.Size = new System.Drawing.Size(380, 20);
            this.sqlCommand_txt.TabIndex = 3;
            // 
            // sqlCommandLabel
            // 
            this.sqlCommandLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlCommandLabel.AutoSize = true;
            this.sqlCommandLabel.Location = new System.Drawing.Point(528, 326);
            this.sqlCommandLabel.Name = "sqlCommandLabel";
            this.sqlCommandLabel.Size = new System.Drawing.Size(81, 13);
            this.sqlCommandLabel.TabIndex = 4;
            this.sqlCommandLabel.Text = "SQL Command:";
            // 
            // tableMenuList
            // 
            this.tableMenuList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableMenuList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableMenuList.FormattingEnabled = true;
            this.tableMenuList.Location = new System.Drawing.Point(531, 71);
            this.tableMenuList.Name = "tableMenuList";
            this.tableMenuList.Size = new System.Drawing.Size(121, 21);
            this.tableMenuList.TabIndex = 5;
            // 
            // Table_Label
            // 
            this.Table_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Table_Label.AutoSize = true;
            this.Table_Label.Location = new System.Drawing.Point(528, 55);
            this.Table_Label.Name = "Table_Label";
            this.Table_Label.Size = new System.Drawing.Size(37, 13);
            this.Table_Label.TabIndex = 6;
            this.Table_Label.Text = "Table:";
            // 
            // button_tableSelector
            // 
            this.button_tableSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_tableSelector.Location = new System.Drawing.Point(658, 69);
            this.button_tableSelector.Name = "button_tableSelector";
            this.button_tableSelector.Size = new System.Drawing.Size(75, 23);
            this.button_tableSelector.TabIndex = 7;
            this.button_tableSelector.Text = "Load Table";
            this.button_tableSelector.UseVisualStyleBackColor = true;
            this.button_tableSelector.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_clear
            // 
            this.button_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear.Location = new System.Drawing.Point(739, 69);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 23);
            this.button_clear.TabIndex = 8;
            this.button_clear.Text = "Clear Table";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Location = new System.Drawing.Point(512, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 339);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database";
            // 
            // excelDataGridView
            // 
            this.excelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.excelDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.excelDataGridView.Location = new System.Drawing.Point(0, 416);
            this.excelDataGridView.Name = "excelDataGridView";
            this.excelDataGridView.Size = new System.Drawing.Size(1016, 325);
            this.excelDataGridView.TabIndex = 10;
            // 
            // button_selectWorkbook
            // 
            this.button_selectWorkbook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_selectWorkbook.Location = new System.Drawing.Point(0, 387);
            this.button_selectWorkbook.Name = "button_selectWorkbook";
            this.button_selectWorkbook.Size = new System.Drawing.Size(120, 23);
            this.button_selectWorkbook.TabIndex = 11;
            this.button_selectWorkbook.Text = "Select Workbook";
            this.button_selectWorkbook.UseVisualStyleBackColor = true;
            this.button_selectWorkbook.Click += new System.EventHandler(this.button_openWorkbook_Click);
            // 
            // combo_sheets
            // 
            this.combo_sheets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.combo_sheets.FormattingEnabled = true;
            this.combo_sheets.Location = new System.Drawing.Point(293, 389);
            this.combo_sheets.Name = "combo_sheets";
            this.combo_sheets.Size = new System.Drawing.Size(121, 21);
            this.combo_sheets.TabIndex = 12;
            // 
            // label_sheet
            // 
            this.label_sheet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_sheet.AutoSize = true;
            this.label_sheet.Location = new System.Drawing.Point(252, 392);
            this.label_sheet.Name = "label_sheet";
            this.label_sheet.Size = new System.Drawing.Size(35, 13);
            this.label_sheet.TabIndex = 13;
            this.label_sheet.Text = "Sheet";
            // 
            // label_WBpath
            // 
            this.label_WBpath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_WBpath.AutoSize = true;
            this.label_WBpath.Location = new System.Drawing.Point(420, 392);
            this.label_WBpath.Name = "label_WBpath";
            this.label_WBpath.Size = new System.Drawing.Size(88, 13);
            this.label_WBpath.TabIndex = 14;
            this.label_WBpath.Text = "Workbook Path: ";
            // 
            // button_loadSheet
            // 
            this.button_loadSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_loadSheet.Enabled = false;
            this.button_loadSheet.Location = new System.Drawing.Point(126, 387);
            this.button_loadSheet.Name = "button_loadSheet";
            this.button_loadSheet.Size = new System.Drawing.Size(120, 23);
            this.button_loadSheet.TabIndex = 15;
            this.button_loadSheet.Text = "Load Sheet";
            this.button_loadSheet.UseVisualStyleBackColor = true;
            this.button_loadSheet.Click += new System.EventHandler(this.button_loadSheet_Click);
            // 
            // workbookAnalysisToolStripMenuItem
            // 
            this.workbookAnalysisToolStripMenuItem.Enabled = false;
            this.workbookAnalysisToolStripMenuItem.Name = "workbookAnalysisToolStripMenuItem";
            this.workbookAnalysisToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.workbookAnalysisToolStripMenuItem.Text = "Workbook Analysis";
            this.workbookAnalysisToolStripMenuItem.Click += new System.EventHandler(this.workbookAnalysisToolStripMenuItem_Click);
            // 
            // groupBox_extrapolation
            // 
            this.groupBox_extrapolation.Controls.Add(this.listBox_unresolvedItems);
            this.groupBox_extrapolation.Controls.Add(this.listBox_rooms);
            this.groupBox_extrapolation.Controls.Add(this.listBox_clients);
            this.groupBox_extrapolation.Controls.Add(this.listBox_employees);
            this.groupBox_extrapolation.Location = new System.Drawing.Point(12, 38);
            this.groupBox_extrapolation.Name = "groupBox_extrapolation";
            this.groupBox_extrapolation.Size = new System.Drawing.Size(487, 343);
            this.groupBox_extrapolation.TabIndex = 16;
            this.groupBox_extrapolation.TabStop = false;
            this.groupBox_extrapolation.Text = "Extrapolation";
            // 
            // listBox_employees
            // 
            this.listBox_employees.FormattingEnabled = true;
            this.listBox_employees.Location = new System.Drawing.Point(181, 31);
            this.listBox_employees.Name = "listBox_employees";
            this.listBox_employees.Size = new System.Drawing.Size(159, 160);
            this.listBox_employees.TabIndex = 0;
            // 
            // listBox_clients
            // 
            this.listBox_clients.FormattingEnabled = true;
            this.listBox_clients.Location = new System.Drawing.Point(6, 31);
            this.listBox_clients.Name = "listBox_clients";
            this.listBox_clients.Size = new System.Drawing.Size(159, 160);
            this.listBox_clients.TabIndex = 1;
            // 
            // listBox_rooms
            // 
            this.listBox_rooms.FormattingEnabled = true;
            this.listBox_rooms.Location = new System.Drawing.Point(359, 31);
            this.listBox_rooms.Name = "listBox_rooms";
            this.listBox_rooms.Size = new System.Drawing.Size(122, 160);
            this.listBox_rooms.TabIndex = 2;
            // 
            // listBox_unresolvedItems
            // 
            this.listBox_unresolvedItems.FormattingEnabled = true;
            this.listBox_unresolvedItems.Location = new System.Drawing.Point(7, 200);
            this.listBox_unresolvedItems.Name = "listBox_unresolvedItems";
            this.listBox_unresolvedItems.Size = new System.Drawing.Size(158, 134);
            this.listBox_unresolvedItems.TabIndex = 3;
            // 
            // CentralStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 741);
            this.Controls.Add(this.button_loadSheet);
            this.Controls.Add(this.label_WBpath);
            this.Controls.Add(this.label_sheet);
            this.Controls.Add(this.combo_sheets);
            this.Controls.Add(this.button_selectWorkbook);
            this.Controls.Add(this.excelDataGridView);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_tableSelector);
            this.Controls.Add(this.Table_Label);
            this.Controls.Add(this.tableMenuList);
            this.Controls.Add(this.sqlCommandLabel);
            this.Controls.Add(this.sqlCommand_txt);
            this.Controls.Add(this.retrieve_data);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_extrapolation);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CentralStation";
            this.Text = "CentralStation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CentralStation_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelDataGridView)).EndInit();
            this.groupBox_extrapolation.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView excelDataGridView;
        private System.Windows.Forms.Button button_selectWorkbook;
        private System.Windows.Forms.ComboBox combo_sheets;
        private System.Windows.Forms.Label label_sheet;
        private System.Windows.Forms.Label label_WBpath;
        private System.Windows.Forms.Button button_loadSheet;
        private System.Windows.Forms.ToolStripMenuItem workbookAnalysisToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_extrapolation;
        private System.Windows.Forms.ListBox listBox_unresolvedItems;
        private System.Windows.Forms.ListBox listBox_rooms;
        private System.Windows.Forms.ListBox listBox_clients;
        private System.Windows.Forms.ListBox listBox_employees;
    }
}