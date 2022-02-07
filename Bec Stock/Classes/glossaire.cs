using DevExpress.XtraGrid;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bec_Stock.Classes
{
    class glossaire
    {
        MySqlConnection con = null;
        MySqlCommand cmd = null;
       // Connection cnx;
        MySqlDataAdapter dt = null;
        MySqlDataReader dr = null;
        MySqlDataAdapter adpr = null;
        DataSet dste;
        private string server;
        private string database;
        private string uid;
        private string password;
        //clsDatebaseBackupRestor bd = new clsDatebaseBackupRestor();
        private string port;
        // private string str, code_isn;
        private static glossaire _instance = null;


        public static glossaire Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new glossaire();
                return _instance;
            }
        }


        public void InitializeConnection()
        {
            try
            {

                //server = "192.168.1.2";
                server = "localhost";
                database = "becdb";
                uid = "root";
                //uid = "root";
                password = "root";
                port = "3306";
                string co = "Server=" + server + ";UserId=" + uid + ";Port=" + port + ";Password=" + password + ";Database=" + database;
                con = new MySqlConnection(co);
                con.Open();

                if (!con.State.ToString().ToLower().Equals("open"))
                {
                    con.Open();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Impossible de se connecter a un serveur!! contactez Administrateur  si le probleme persiste /n" + ex);
                //Application.Exit();
            }
        }
        public void GetDatas(GridControl grid, string field, string table)
        {
            InitializeConnection();

            try
            {
                using (cmd = con.CreateCommand())
                {
                    cmd.CommandText = " SELECT " + field + " FROM " + table + "";
                    dt = new MySqlDataAdapter((MySqlCommand)cmd);
                    DataSet ds = new DataSet();
                    dt.Fill(ds);
                    grid.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }
    }
}
