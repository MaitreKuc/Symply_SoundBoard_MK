using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Symply_SoundBoard_MK.SQL
{
    class SQLClass
    {
        private string path;
        private string source = @"Data Source=SQL\SoundBoard.db";
        private string txtbutton;
        private int lang;
        public void WriteSQL(string name, int row, int column, Label labelid)
        {
            using (SQLiteConnection conn = new SQLiteConnection(source))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    string strSql;
                    if (name=="Default")
                    {
                        strSql = "UPDATE [Profil] SET [Row]=" + row + ", [Column]="+ column + " WHERE Name_Profil='" + name + "';";
                    }
                    else
                    {
                        strSql = "INSERT INTO [Profil] ([Name_Profil],[Row],[Column]) VALUES('" + name + "', '" + row + "','" + column + "')";
                    }
                     

                    cmd.CommandText = strSql;
                    cmd.Connection = conn;

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    strSql = "SELECT Id FROM Profil WHERE Name_Profil='" + name + "'"; ;
                    cmd.CommandText = strSql;
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        labelid.Text = reader["Id"].ToString();
                    }
                    reader.Close();
                    conn.Close();
                }
            }
        }


        public void ReadSQL(TableLayoutPanel layout, Label labelrow, Label labelcol, Label labelid,MainForm fm, GenerateTableLayout build)
        {
            int col, row;

            using (SQLiteConnection conn = new SQLiteConnection(source))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())

                {
                    string strSql = "SELECT Id,Name_Profil,Row,Column FROM Profil WHERE Id='" + labelid.Text + "'";

                    cmd.CommandText = strSql;

                    cmd.Connection = conn;

                    conn.Open();

                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        col = Convert.ToInt32(reader["Column"].ToString());
                        row = Convert.ToInt32(reader["Row"].ToString());
                        labelrow.Text = row.ToString();
                        labelcol.Text = col.ToString();
                        labelid.Text = reader["Id"].ToString();
                        build.Generate(col, row, layout, fm);
                        
                    }

                    reader.Close();

                    conn.Close();
                }

            }

        }


        public string ReadSQLSound(int idprofil, string labelbutton)
        {
            path = "";
            using (SQLiteConnection conn = new SQLiteConnection(source))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())

                {
                    string strSql = "SELECT Audio_Path FROM Config_Button WHERE Id_Profil='" + idprofil + "' AND LabelButton='" + labelbutton + "'";

                    cmd.CommandText = strSql;

                    cmd.Connection = conn;

                    conn.Open();

                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        path=reader["Audio_Path"].ToString();
                    }

                    reader.Close();

                    conn.Close();
                }

            }
            return path;
        }

        public string LabelSQL(int idprofil, string labelbutton)
        {
            txtbutton = "";
            using (SQLiteConnection conn = new SQLiteConnection(source))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())

                {
                    string strSql = "SELECT TextButton FROM Config_Button WHERE Id_Profil=" + idprofil + " AND LabelButton='" + labelbutton + "'";

                    cmd.CommandText = strSql;

                    cmd.Connection = conn;

                    conn.Open();

                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        txtbutton = reader["TextButton"].ToString();
                    }

                    reader.Close();

                    conn.Close();
                }

            }
            return txtbutton;
        }

        public void WriteSQLSound(int idprofil, string audiopath, string labelbutton, string textbutton)
        {
            using (SQLiteConnection conn = new SQLiteConnection(source))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())

                {
                    string strSql = "INSERT INTO [Config_Button] ([Id_Profil],[Audio_Path],[LabelButton],[TextButton]) VALUES('" + idprofil + "', '" + audiopath + "','" + labelbutton + "','" + textbutton + "')";

                    cmd.CommandText = strSql;

                    cmd.Connection = conn;

                    conn.Open();

                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
            }
        }


        public void WriteLastProfil(int id)
        {
            using (SQLiteConnection conn = new SQLiteConnection(source))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    string strSql = "UPDATE [Last_Profil] SET [LastId]='" + id + "' WHERE Id=1";

                    cmd.CommandText = strSql;
                    cmd.Connection = conn;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void UpdateLabelButton(int idprofil, string labelbutton,string txtbutton)
        {
            using (SQLiteConnection conn = new SQLiteConnection(source))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    //SELECT TextButton FROM Config_Button WHERE Id_Profil=" + idprofil + " AND LabelButton='" + labelbutton + "'";
                    string strSql = "UPDATE [Config_Button] SET [TextButton]='" + txtbutton + "' WHERE Id_Profil="+ idprofil+ " AND LabelButton='" + labelbutton + "'";

                    cmd.CommandText = strSql;
                    cmd.Connection = conn;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }


        public void ReadLastProfil(ComboBox combo, Label labelid)
        {
            using (SQLiteConnection conn = new SQLiteConnection(source))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())

                {
                    string strSql = "SELECT LastId FROM Last_Profil WHERE Id=1 AND LastId<>0";

                    cmd.CommandText = strSql;

                    cmd.Connection = conn;

                    conn.Open();

                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        labelid.Text = reader["LastId"].ToString();
                        combo.SelectedIndex = combo.FindString(reader["LastId"].ToString());
                    }

                    reader.Close();

                    conn.Close();
                }

            }
            
        }


        public void ReadListProfil(ComboBox combo)
        {
            combo.Items.Clear();
            using (SQLiteConnection conn = new SQLiteConnection(source))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())

                {
                    string strSql = "SELECT Id,Name_Profil FROM Profil";

                    cmd.CommandText = strSql;

                    cmd.Connection = conn;

                    conn.Open();

                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        combo.Items.Add(reader["Id"].ToString() + "-" + reader["Name_Profil"].ToString());
                    }

                    reader.Close();

                    conn.Close();
                }

            }

        }


        public void DeleteProfile(int id)
        {
            using (SQLiteConnection conn = new SQLiteConnection(source))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    
                    string strSql = "DELETE FROM 'Profil' WHERE Id="+id+";";

                    cmd.CommandText = strSql;
                    cmd.Connection = conn;

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    strSql = "DELETE FROM 'Config_Button' WHERE Id_Profil=" + id + ";";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }


        public void UpdateLang(int lang)
        {
            using (SQLiteConnection conn = new SQLiteConnection(source))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    string strSql = "UPDATE [Lang] SET [LastLang]=" + lang + " WHERE Id=1;";

                    cmd.CommandText = strSql;
                    cmd.Connection = conn;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public int LastLang()
        {
            
            using (SQLiteConnection conn = new SQLiteConnection(source))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    string strSql = "SELECT [LastLang] FROM [LANG] WHERE Id=1;";

                    cmd.CommandText = strSql;
                    cmd.Connection = conn;

                    conn.Open();
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        lang = Convert.ToInt32(reader["LastLang"].ToString()); 
                    }

                    reader.Close();
                    conn.Close();
                }  
            }
            return lang;
        }
    }
}
