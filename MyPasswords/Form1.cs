using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;
using System.IO;
using System.Globalization;

namespace MyPasswords
{
    public partial class Form1 : Form
    {
        SQLiteConnection con;
        string[] _Url = new string[3];
        DataSet ds { get; set; }
        string path { get; set; }
        int _IndexRows { get; set; }
        public Form1()
        {
            string connection = @"Data Source=" + Directory.GetCurrentDirectory() + @"\Database\mypasswords.db;" + "Version=3;UTF8Encoding=True;Pooling=true;FailIfMissing=false;Compress=True;";
            con = new SQLiteConnection(connection);

            InitializeComponent();
            if (!File.Exists(Directory.GetCurrentDirectory() + "\\Database\\mypasswords.db"))
            {
                SQLiteConnection.CreateFile(Directory.GetCurrentDirectory() + @"\Database\mypasswords.db");
                string qury = "CREATE TABLE IF NOT EXISTS Link(ID integer NOT NULL PRIMARY KEY AUTOINCREMENT, name varchar(100),url varchar(400),username varchar(50),password varchar(100), description varchar(250));";
                SQLiteCommand cmd = new SQLiteCommand() { CommandType = CommandType.Text,
                                                        Connection = con,
                                                        CommandText = qury};
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                cmd.Dispose();
            }

            db_dir.Text = Directory.GetCurrentDirectory() + @"\Database\mypasswords.db";
        }
        private void FillDataGridView() {
            try
            {
                if (string.IsNullOrEmpty(txt_Search.Text))
                {
                    ds = null;
                    ds = new DataSet();
                    SQLiteDataAdapter da = new SQLiteDataAdapter("select ID,name,url,username,password, description from Link", con);
                    da.Fill(ds);
                    DataColumnCollection col = ds.Tables[0].Columns;
                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {

                        dataGridView1.Rows.Add(ds.Tables[0].Rows[i].ItemArray[col.IndexOf("ID")].ToString(),
                                            ds.Tables[0].Rows[i].ItemArray[col.IndexOf("name")].ToString(),
                                            ds.Tables[0].Rows[i].ItemArray[col.IndexOf("url")].ToString(),
                                            ds.Tables[0].Rows[i].ItemArray[col.IndexOf("username")].ToString(),
                                            ds.Tables[0].Rows[i].ItemArray[col.IndexOf("password")].ToString(),
                                            ds.Tables[0].Rows[i].ItemArray[col.IndexOf("description")].ToString());
                    }
                    try
                    {
                        tsl_count.Text = ds.Tables[0].Rows.Count.ToString();
                    }
                    catch
                    {
                        this.Invoke((MethodInvoker)delegate ()
                        {
                            tsl_count.Text = ds.Tables[0].Rows.Count.ToString();
                        });
                    }
                }
                else {
                    txt_Search_TextChanged(null, null);
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                comBox_SearchType.SelectedIndex = 0;
                ChangeLang();
                FillDataGridView();
            }
            catch(SQLiteException ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideToolStripMenuItem_Click(null, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.ShowDialog();
                StreamReader sr = new StreamReader(op.FileName);
                path = sr.ReadToEnd();
                sr.Close();
                textBox2.Text = path;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            
        }
        private void OpenBrowser(string Address) {
            try
            {
                string browserName = "iexplore.exe";
                using (Microsoft.Win32.RegistryKey userChoiceKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\Shell\Associations\UrlAssociations\http\UserChoice"))
                {
                    if (userChoiceKey != null)
                    {
                        string[] name = userChoiceKey.GetValueNames();
                        foreach (string item in name)
                        {
                            if (item.ToLower().Contains("progid"))
                            {
                                object progIdValue = userChoiceKey.GetValue(item);
                                if (progIdValue != null)
                                {
                                    if (progIdValue.ToString().ToLower().Contains("chrome"))
                                        browserName = "chrome.exe";
                                    else if (progIdValue.ToString().ToLower().Contains("firefox"))
                                        browserName = "firefox.exe";
                                    else if (progIdValue.ToString().ToLower().Contains("safari"))
                                        browserName = "safari.exe";
                                    else if (progIdValue.ToString().ToLower().Contains("opera"))
                                        browserName = "opera.exe";
                                    else if (progIdValue.ToString().ToLower().Contains("msedge"))
                                        browserName = "msedge.exe";
                                    else if (progIdValue.ToString().ToLower().Contains("yandex"))
                                        browserName = "browser.exe";
                                }
                            }
                        }

                    }
                }
                System.Diagnostics.Process.Start(browserName,Address);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                if (String.IsNullOrEmpty(path))
                    button3_Click(null, null);
                this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                textBox2.Text = path;
                string[] data = path.Split(new[] { "\r\n" }, StringSplitOptions.None);
                DataSet ds = new DataSet();
                SQLiteDataAdapter da = new SQLiteDataAdapter("select * from Link",con);
                da.Fill(ds);
                da.Dispose();
               
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i].Split(',')[0] == "name" || String.IsNullOrEmpty(data[i].Split(',')[0]))
                        continue;
                    DataRow dr = ds.Tables[0].Select("url = '"+ data[i].Split(',')[1] + "' and password = '"+ data[i].Split(',')[3] + "'").FirstOrDefault();
                    if (dr == null)
                    {
                        string _insert = "INSERT INTO Link(name,url,username,password) VALUES ('"+ data[i].Split(',')[0] + "','"+ data[i].Split(',')[1] + "','"+ data[i].Split(',')[2] + "','"+ data[i].Split(',')[3] + "');";
                        if(con.State != ConnectionState.Open) con.Open();
                        new SQLiteCommand() { CommandType = CommandType.Text, Connection = con, CommandText = _insert }.ExecuteNonQuery();
                    }
                }
                if(con.State == ConnectionState.Open) con.Close();
                ds = null;
                FillDataGridView();
                this.Cursor = System.Windows.Forms.Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        private void ChangeLang() {
            CultureInfo languagee = new CultureInfo(CultureInfo.InstalledUICulture.Name);
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(languagee);
        }
        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            ChangeLang();
            try
            {
                if (string.IsNullOrEmpty(txt_Search.Text))
                {
                    FillDataGridView();
                    txt_Search.Select();
                    return;
                }
                else
                {
                    
                    switch (comBox_SearchType.SelectedIndex)
                    {
                        case 0:
                            DataSet ds_name = new DataSet();
                            SQLiteDataAdapter da = new SQLiteDataAdapter("select ID,name,url,username,password ,description from Link where name like '%" + txt_Search.Text + "%'", con);
                            da.Fill(ds_name);
                            da.Dispose();
                            DataColumnCollection col = ds_name.Tables[0].Columns;
                            dataGridView1.Rows.Clear();
                            for (int i = 0; i < ds_name.Tables[0].Rows.Count; i++)
                            {
                                dataGridView1.Rows.Add(ds_name.Tables[0].Rows[i].ItemArray[col.IndexOf("ID")].ToString(),
                                    ds_name.Tables[0].Rows[i].ItemArray[col.IndexOf("name")].ToString(),
                                    ds_name.Tables[0].Rows[i].ItemArray[col.IndexOf("url")].ToString(),
                                    ds_name.Tables[0].Rows[i].ItemArray[col.IndexOf("username")].ToString(),
                                    ds_name.Tables[0].Rows[i].ItemArray[col.IndexOf("password")].ToString(),
                                    ds_name.Tables[0].Rows[i].ItemArray[col.IndexOf("description")].ToString());
                            }
                            tsl_count.Text = ds_name.Tables[0].Rows.Count.ToString();
                            break;

                        case 1:
                            DataSet ds_username = new DataSet();
                            SQLiteDataAdapter daa = new SQLiteDataAdapter("select ID,name,url,username,password ,description from Link description username like '%" + txt_Search.Text + "%'", con);
                            daa.Fill(ds_username);
                            daa.Dispose();
                            DataColumnCollection coll = ds_username.Tables[0].Columns;
                            dataGridView1.Rows.Clear();
                            for (int i = 0; i < ds_username.Tables[0].Rows.Count; i++)
                            {
                                dataGridView1.Rows.Add(ds_username.Tables[0].Rows[i].ItemArray[coll.IndexOf("ID")].ToString(),
                                    ds_username.Tables[0].Rows[i].ItemArray[coll.IndexOf("name")].ToString(),
                                    ds_username.Tables[0].Rows[i].ItemArray[coll.IndexOf("url")].ToString(),
                                     ds_username.Tables[0].Rows[i].ItemArray[coll.IndexOf("username")].ToString(),
                                     ds_username.Tables[0].Rows[i].ItemArray[coll.IndexOf("password")].ToString(),
                                     ds_username.Tables[0].Rows[i].ItemArray[coll.IndexOf("description")].ToString());
                            }
                            tsl_count.Text = ds_username.Tables[0].Rows.Count.ToString();
                            break;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int __database_rows_id { get; set; }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id_rows.Text = "Rows ID : " + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_link.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_username.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_password.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                try
                {
                    if (!string.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString()))
                        txt_Description.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    else
                        txt_Description.Text = string.Empty;
                }
                catch
                {
                    txt_Description.Text = string.Empty;
                }
                
               __database_rows_id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                _IndexRows = e.RowIndex;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!String.IsNullOrEmpty(_Url[0]))
            //{
            //    OpenBrowser(_Url[0]);
            //}
        }

        private void setUserNameInClipBordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_Url[0]))
            {
                Clipboard.SetText(_Url[1]+","+_Url[2]);
                OpenBrowser(_Url[0]);
            }
        }

        private void setUserNameInBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_Url[0]))
            {
                OpenBrowser(_Url[0] + "?username=" + _Url[1] + "&password=" + _Url[2]);
            }
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void deleteRowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (_IndexRows != -1)
                {
                    string mess = "Are You Delete name \n"+dataGridView1.Rows[_IndexRows].Cells[1].Value.ToString();
                    mess += "\n Passwords \n"+ dataGridView1.Rows[_IndexRows].Cells[4].Value.ToString();
                    if (MessageBox.Show(mess,"Deleteing... ",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        SQLiteCommand cmd = new SQLiteCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete from Link where ID = "+ dataGridView1.Rows[_IndexRows].Cells[0].Value.ToString();
                        cmd.CommandTimeout = 20;
                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        FillDataGridView();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void deleteRowsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            deleteRowsToolStripMenuItem_Click(null, null);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void p_insert_new_rows_VisibleChanged(object sender, EventArgs e)
        {
          
        }

        private void insertNewRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
          
        }
        private void ClearTextBox() {
            txt_name.Clear();
            txt_link.Clear(); 
            txt_password.Clear(); 
            txt_username.Clear();
            txt_Description.Clear();
        }
        private void bt_insert_Click(object sender, EventArgs e)
        {
            string _select = "select * from Link where name = '"+ txt_name.Text + "' and url = '"+ txt_link.Text + "' and username = '"+ txt_username.Text + "' and password = '"+ txt_password.Text + "'";
            SQLiteCommand cmd = new SQLiteCommand() { CommandText = _select , CommandType = CommandType.Text , Connection = con};
            con.Open();
            if (!cmd.ExecuteReader().HasRows)
            {
                string insert = string.Empty;
                if(!string.IsNullOrEmpty(txt_Description.Text))
                    insert = "insert into Link(name,url,username,password,description) values('" + txt_name.Text + "','" + txt_link.Text + "','" + txt_username.Text + "','" + txt_password.Text + "','" + txt_Description.Text + "');";
                else
                 insert = "insert into Link(name,url,username,password) values('" + txt_name.Text + "','" + txt_link.Text + "','" + txt_username.Text + "','" + txt_password.Text + "');";
                if (con.State != ConnectionState.Open) 
                    con.Open();
                new SQLiteCommand() {CommandText = insert , Connection = con , CommandType = CommandType.Text }.ExecuteNonQuery();
                con.Close();
                FillDataGridView();
                txt_Search.Clear(); txt_Search.Text = txt_name.Text;
                ClearTextBox();

                MessageBox.Show("Insert New Record Successful...");
            }
            else
            {
                txt_Search.Text = txt_name.Text;
                MessageBox.Show("Data Has Rows .... ");
            }        
            
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            try
            {
                string _update = "update Link set name = '" + txt_name.Text + "' , url = '" + txt_link.Text + "' , username = '" + txt_username.Text + "' , password = '" + txt_password.Text + "' ,description = '"+txt_Description.Text+"' where ID = '" + __database_rows_id.ToString()+"'";
                if (con.State != ConnectionState.Open) con.Open();
                new SQLiteCommand() {CommandText = _update , CommandType = CommandType.Text , Connection = con }.ExecuteNonQuery();
                con.Close();
                FillDataGridView();
                txt_Search.Text = txt_name.Text;
                ClearTextBox();
                MessageBox.Show("Update Successful...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string _message = "Are You Delete \n"+txt_name.Text+"\n"+txt_link.Text+"\n"+txt_username.Text+"\n"+txt_password.Text;
                if (DialogResult.Yes == MessageBox.Show(_message, "", MessageBoxButtons.YesNo) ) 
                {
                    string _del = "DELETE FROM Link where ID = '" + __database_rows_id.ToString()+"'";
                    if (con.State != ConnectionState.Open) con.Open();
                    new SQLiteCommand() {Connection = con , CommandText = _del , CommandType = CommandType.Text }.ExecuteNonQuery();
                    con.Close();
                    ClearTextBox();
                    FillDataGridView();
                    MessageBox.Show("Delete Successful...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bu_clipbord_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txt_username.Text);
        }

        private void bu_browser_Click(object sender, EventArgs e)
        {
            try
            {
                string browserName = "iexplore.exe";
                using (Microsoft.Win32.RegistryKey userChoiceKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\Shell\Associations\UrlAssociations\http\UserChoice"))
                {
                    if (userChoiceKey != null)
                    {
                        string[] name = userChoiceKey.GetValueNames();
                        foreach (string item in name)
                        {
                            if (item.ToLower().Contains("progid"))
                            {
                                object progIdValue = userChoiceKey.GetValue(item);
                                if (progIdValue != null)
                                {
                                    if (progIdValue.ToString().ToLower().Contains("chrome"))
                                        browserName = "chrome.exe";
                                    else if (progIdValue.ToString().ToLower().Contains("firefox"))
                                        browserName = "firefox.exe";
                                    else if (progIdValue.ToString().ToLower().Contains("safari"))
                                        browserName = "safari.exe";
                                    else if (progIdValue.ToString().ToLower().Contains("opera"))
                                        browserName = "opera.exe";
                                    else if (progIdValue.ToString().ToLower().Contains("msedge"))
                                        browserName = "msedge.exe";
                                    else if (progIdValue.ToString().ToLower().Contains("yandex"))
                                        browserName = "browser.exe";
                                }
                            }
                        }

                    }
                }
                System.Diagnostics.Process.Start(browserName, txt_link.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(txt_password.Text);
        }

        private void bt_Auto_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txt_username.Text);
            timer_auto_clipbord.Enabled = true;
        }

        private void timer_auto_clipbord_Tick(object sender, EventArgs e)
        {
            Clipboard.SetText(txt_password.Text);
            timer_auto_clipbord.Enabled = false;
        }

        private void db_dir_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(db_dir.Text);
        }

        private void comBox_SearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Search.Text))
                txt_Search_TextChanged(null, null);
        }

        private void txt_Description_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                ChangeLang();
            }
            catch 
            {
            }
        }

        private void txt_Description_MouseHover(object sender, EventArgs e)
        {
            try
            {
                CultureInfo c = new CultureInfo("Fa-IR");
                Application.CurrentInputLanguage = InputLanguage.FromCulture(c);
            }
            catch
            {
            }
        }
    }
}
