using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace SuperMemory.Model.DB.Common
{
    public class CDbBase
    {
        public CDbBase()
        {
            connStr.DataSource = datasource;
            conn.ConnectionString = connStr.ToString();
        }

        protected void open()
        {
            conn.Open();
        }

        protected void close()
        {
            conn.Close();
        }
        protected string  bool2intStr(bool bIn)
        {
            if (bIn)
            {
                return "1";
            }
            return "0";
        }

        protected void exeNonQuerSql(string sql)
        {
            try
            {
                open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText = sql;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                close();
            }catch(SQLiteException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        protected DataTable loadEntsDtBySql(string sql)
        {
            DataTable ret = new DataTable("mytable");

            try
            {
                open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText = sql;
                cmd.Connection = conn;

                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(ret);

                close();

                return ret;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return ret;
            }
        }


        #region ×Ö¶ÎÃÇ£º
        private string datasource = Application.StartupPath + "\\db\\data.db";//"File:\\" + Application.StartupPath + "\\db\\data.db";
        private SQLiteConnection conn = new SQLiteConnection();
        private SQLiteConnectionStringBuilder connStr = new SQLiteConnectionStringBuilder();
        #endregion
    }
}
