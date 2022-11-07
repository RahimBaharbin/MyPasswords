namespace MyPasswords
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.datagrid_cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setUserNameInClipBordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setUserNameInBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteRowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Form_cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.insertNewRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsl_count_info = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsl_count = new System.Windows.Forms.ToolStripStatusLabel();
            this.id_rows = new System.Windows.Forms.ToolStripStatusLabel();
            this.db_dir = new System.Windows.Forms.ToolStripStatusLabel();
            this.bt_insert = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_link = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comBox_SearchType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bu_browser = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_Auto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bu_clipbord = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timer_auto_clipbord = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.datagrid_cms.SuspendLayout();
            this.Form_cms.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRANSansWeb", 8.749999F);
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Text";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.link,
            this.username,
            this.password,
            this.Description});
            this.dataGridView1.ContextMenuStrip = this.datagrid_cms;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(753, 272);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // datagrid_cms
            // 
            this.datagrid_cms.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagrid_cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator3,
            this.deleteRowsToolStripMenuItem});
            this.datagrid_cms.Name = "datagrid_cms";
            this.datagrid_cms.Size = new System.Drawing.Size(159, 58);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setUserNameInClipBordToolStripMenuItem,
            this.setUserNameInBrowserToolStripMenuItem});
            this.openToolStripMenuItem.Image = global::MyPasswords.Properties.Resources.browser;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.openToolStripMenuItem.Text = "Open Browser";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // setUserNameInClipBordToolStripMenuItem
            // 
            this.setUserNameInClipBordToolStripMenuItem.Image = global::MyPasswords.Properties.Resources.clipbord;
            this.setUserNameInClipBordToolStripMenuItem.Name = "setUserNameInClipBordToolStripMenuItem";
            this.setUserNameInClipBordToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.setUserNameInClipBordToolStripMenuItem.Text = "ClipBord";
            this.setUserNameInClipBordToolStripMenuItem.Click += new System.EventHandler(this.setUserNameInClipBordToolStripMenuItem_Click);
            // 
            // setUserNameInBrowserToolStripMenuItem
            // 
            this.setUserNameInBrowserToolStripMenuItem.Image = global::MyPasswords.Properties.Resources.browser;
            this.setUserNameInBrowserToolStripMenuItem.Name = "setUserNameInBrowserToolStripMenuItem";
            this.setUserNameInBrowserToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.setUserNameInBrowserToolStripMenuItem.Text = "Browser";
            this.setUserNameInBrowserToolStripMenuItem.Click += new System.EventHandler(this.setUserNameInBrowserToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(155, 6);
            // 
            // deleteRowsToolStripMenuItem
            // 
            this.deleteRowsToolStripMenuItem.Image = global::MyPasswords.Properties.Resources.delete;
            this.deleteRowsToolStripMenuItem.Name = "deleteRowsToolStripMenuItem";
            this.deleteRowsToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.deleteRowsToolStripMenuItem.Text = "Delete Rows";
            this.deleteRowsToolStripMenuItem.Click += new System.EventHandler(this.deleteRowsToolStripMenuItem_Click_1);
            // 
            // txt_Search
            // 
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Search.Font = new System.Drawing.Font("IRANSansWeb", 8.749999F);
            this.txt_Search.ForeColor = System.Drawing.Color.Red;
            this.txt_Search.Location = new System.Drawing.Point(95, 16);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(216, 20);
            this.txt_Search.TabIndex = 3;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(3, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 29);
            this.button3.TabIndex = 6;
            this.button3.Text = "Open File";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Default;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Location = new System.Drawing.Point(260, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 29);
            this.button5.TabIndex = 9;
            this.button5.Text = "Save To Database";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form_cms
            // 
            this.Form_cms.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form_cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertNewRecordToolStripMenuItem,
            this.toolStripSeparator4,
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.Form_cms.Name = "Form_cms";
            this.Form_cms.Size = new System.Drawing.Size(184, 118);
            // 
            // insertNewRecordToolStripMenuItem
            // 
            this.insertNewRecordToolStripMenuItem.Image = global::MyPasswords.Properties.Resources.Insert;
            this.insertNewRecordToolStripMenuItem.Name = "insertNewRecordToolStripMenuItem";
            this.insertNewRecordToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.insertNewRecordToolStripMenuItem.Text = "Insert New Record";
            this.insertNewRecordToolStripMenuItem.Click += new System.EventHandler(this.insertNewRecordToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(180, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::MyPasswords.Properties.Resources.reload;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(183, 24);
            this.toolStripMenuItem1.Text = "Reloding";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(180, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.hideToolStripMenuItem});
            this.saveToolStripMenuItem.Image = global::MyPasswords.Properties.Resources.save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Image = global::MyPasswords.Properties.Resources.show;
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Image = global::MyPasswords.Properties.Resources.hide;
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.hideToolStripMenuItem.Text = "Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(180, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("IRANSansWeb", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl_count_info,
            this.toolStripStatusLabel1,
            this.tsl_count,
            this.id_rows,
            this.db_dir});
            this.statusStrip1.Location = new System.Drawing.Point(0, 656);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(753, 25);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsl_count_info
            // 
            this.tsl_count_info.Name = "tsl_count_info";
            this.tsl_count_info.Size = new System.Drawing.Size(101, 20);
            this.tsl_count_info.Text = "Records Count : ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 20);
            // 
            // tsl_count
            // 
            this.tsl_count.Name = "tsl_count";
            this.tsl_count.Size = new System.Drawing.Size(16, 20);
            this.tsl_count.Text = "0";
            // 
            // id_rows
            // 
            this.id_rows.Name = "id_rows";
            this.id_rows.Size = new System.Drawing.Size(65, 20);
            this.id_rows.Text = "Rows ID : ";
            // 
            // db_dir
            // 
            this.db_dir.Font = new System.Drawing.Font("IRANSansWeb", 6.999999F);
            this.db_dir.Name = "db_dir";
            this.db_dir.Padding = new System.Windows.Forms.Padding(20, 0, 5, 0);
            this.db_dir.Size = new System.Drawing.Size(62, 20);
            this.db_dir.Text = "db_dir";
            this.db_dir.Click += new System.EventHandler(this.db_dir_Click);
            // 
            // bt_insert
            // 
            this.bt_insert.Font = new System.Drawing.Font("IRANSansWeb", 8.749999F);
            this.bt_insert.Location = new System.Drawing.Point(11, 76);
            this.bt_insert.Name = "bt_insert";
            this.bt_insert.Size = new System.Drawing.Size(89, 30);
            this.bt_insert.TabIndex = 17;
            this.bt_insert.Text = "Insert ";
            this.bt_insert.UseVisualStyleBackColor = true;
            this.bt_insert.Click += new System.EventHandler(this.bt_insert_Click);
            // 
            // txt_username
            // 
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Font = new System.Drawing.Font("IRANSansWeb", 8.749999F);
            this.txt_username.ForeColor = System.Drawing.Color.Red;
            this.txt_username.Location = new System.Drawing.Point(426, 33);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(158, 20);
            this.txt_username.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "User Name";
            // 
            // txt_password
            // 
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("IRANSansWeb", 8.749999F);
            this.txt_password.ForeColor = System.Drawing.Color.Red;
            this.txt_password.Location = new System.Drawing.Point(590, 33);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(151, 20);
            this.txt_password.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(591, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Passwords";
            // 
            // txt_link
            // 
            this.txt_link.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_link.Font = new System.Drawing.Font("IRANSansWeb", 8.749999F);
            this.txt_link.ForeColor = System.Drawing.Color.Red;
            this.txt_link.Location = new System.Drawing.Point(154, 33);
            this.txt_link.Multiline = true;
            this.txt_link.Name = "txt_link";
            this.txt_link.Size = new System.Drawing.Size(266, 20);
            this.txt_link.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Login Link";
            // 
            // txt_name
            // 
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name.Font = new System.Drawing.Font("IRANSansWeb", 8.749999F);
            this.txt_name.ForeColor = System.Drawing.Color.Red;
            this.txt_name.Location = new System.Drawing.Point(5, 33);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(143, 20);
            this.txt_name.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("IRANSansWeb", 8.749999F);
            this.textBox2.Location = new System.Drawing.Point(3, 45);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(379, 168);
            this.textBox2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comBox_SearchType);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_Search);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bu_browser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 45);
            this.panel1.TabIndex = 17;
            // 
            // comBox_SearchType
            // 
            this.comBox_SearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBox_SearchType.Font = new System.Drawing.Font("IRANSansWeb", 7.749999F);
            this.comBox_SearchType.FormattingEnabled = true;
            this.comBox_SearchType.Items.AddRange(new object[] {
            "By Url",
            "By UserName"});
            this.comBox_SearchType.Location = new System.Drawing.Point(455, 14);
            this.comBox_SearchType.Name = "comBox_SearchType";
            this.comBox_SearchType.Size = new System.Drawing.Size(121, 24);
            this.comBox_SearchType.TabIndex = 23;
            this.comBox_SearchType.SelectedIndexChanged += new System.EventHandler(this.comBox_SearchType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("IRANSansWeb", 8.749999F);
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(369, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Search Type";
            // 
            // bu_browser
            // 
            this.bu_browser.Font = new System.Drawing.Font("IRANSansWeb", 8.749999F);
            this.bu_browser.Location = new System.Drawing.Point(608, 11);
            this.bu_browser.Name = "bu_browser";
            this.bu_browser.Size = new System.Drawing.Size(117, 30);
            this.bu_browser.TabIndex = 21;
            this.bu_browser.Text = "Open Browser";
            this.bu_browser.UseVisualStyleBackColor = true;
            this.bu_browser.Click += new System.EventHandler(this.bu_browser_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 272);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bt_Auto);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.bu_clipbord);
            this.panel3.Controls.Add(this.bt_delete);
            this.panel3.Controls.Add(this.bt_update);
            this.panel3.Controls.Add(this.bt_insert);
            this.panel3.Controls.Add(this.txt_name);
            this.panel3.Controls.Add(this.txt_username);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txt_password);
            this.panel3.Controls.Add(this.txt_link);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 317);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(753, 119);
            this.panel3.TabIndex = 19;
            // 
            // bt_Auto
            // 
            this.bt_Auto.Font = new System.Drawing.Font("IRANSansWeb", 8.749999F);
            this.bt_Auto.Location = new System.Drawing.Point(624, 76);
            this.bt_Auto.Name = "bt_Auto";
            this.bt_Auto.Size = new System.Drawing.Size(114, 30);
            this.bt_Auto.TabIndex = 23;
            this.bt_Auto.Text = "Auto ClipBord";
            this.bt_Auto.UseVisualStyleBackColor = true;
            this.bt_Auto.Click += new System.EventHandler(this.bt_Auto_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("IRANSansWeb", 8.749999F);
            this.button1.Location = new System.Drawing.Point(491, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 30);
            this.button1.TabIndex = 22;
            this.button1.Text = "ClipBord Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bu_clipbord
            // 
            this.bu_clipbord.Font = new System.Drawing.Font("IRANSansWeb", 8.749999F);
            this.bu_clipbord.Location = new System.Drawing.Point(354, 76);
            this.bu_clipbord.Name = "bu_clipbord";
            this.bu_clipbord.Size = new System.Drawing.Size(131, 30);
            this.bu_clipbord.TabIndex = 20;
            this.bu_clipbord.Text = "ClipBord UserName";
            this.bu_clipbord.UseVisualStyleBackColor = true;
            this.bu_clipbord.Click += new System.EventHandler(this.bu_clipbord_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Font = new System.Drawing.Font("IRANSansWeb", 8.749999F);
            this.bt_delete.Location = new System.Drawing.Point(201, 76);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(89, 30);
            this.bt_delete.TabIndex = 19;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_update
            // 
            this.bt_update.Font = new System.Drawing.Font("IRANSansWeb", 8.749999F);
            this.bt_update.Location = new System.Drawing.Point(106, 76);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(89, 30);
            this.bt_update.TabIndex = 18;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 436);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(385, 220);
            this.panel4.TabIndex = 20;
            // 
            // timer_auto_clipbord
            // 
            this.timer_auto_clipbord.Interval = 4000;
            this.timer_auto_clipbord.Tick += new System.EventHandler(this.timer_auto_clipbord_Tick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txt_Description);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(391, 436);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(362, 220);
            this.panel5.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 22);
            this.label7.TabIndex = 24;
            this.label7.Text = "Description";
            // 
            // txt_Description
            // 
            this.txt_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Description.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_Description.Location = new System.Drawing.Point(0, 45);
            this.txt_Description.MaxLength = 250;
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(362, 175);
            this.txt_Description.TabIndex = 25;
            this.txt_Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Description.MouseLeave += new System.EventHandler(this.txt_Description_MouseLeave);
            this.txt_Description.MouseHover += new System.EventHandler(this.txt_Description_MouseHover);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 46;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("IRANSansWeb", 8.75F);
            this.name.DefaultCellStyle = dataGridViewCellStyle17;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // link
            // 
            this.link.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("IRANSansWeb", 8.75F);
            this.link.DefaultCellStyle = dataGridViewCellStyle18;
            this.link.HeaderText = "Login Link";
            this.link.Name = "link";
            this.link.ReadOnly = true;
            // 
            // username
            // 
            this.username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("IRANSansWeb", 8.75F);
            this.username.DefaultCellStyle = dataGridViewCellStyle19;
            this.username.HeaderText = "User Name";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // password
            // 
            this.password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("IRANSansWeb", 8.75F);
            this.password.DefaultCellStyle = dataGridViewCellStyle20;
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Visible = false;
            this.Description.Width = 105;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 681);
            this.ContextMenuStrip = this.Form_cms;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("IRANSansWeb", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Internet Password";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.datagrid_cms.ResumeLayout(false);
            this.Form_cms.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ContextMenuStrip Form_cms;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip datagrid_cms;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setUserNameInClipBordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setUserNameInBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsl_count_info;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsl_count;
        private System.Windows.Forms.ToolStripMenuItem deleteRowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem insertNewRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_link;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_insert;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStripStatusLabel id_rows;
        private System.Windows.Forms.Button bu_clipbord;
        private System.Windows.Forms.Button bu_browser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_Auto;
        private System.Windows.Forms.Timer timer_auto_clipbord;
        private System.Windows.Forms.ToolStripStatusLabel db_dir;
        private System.Windows.Forms.ComboBox comBox_SearchType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn link;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}

