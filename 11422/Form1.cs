using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _11422
{
    public partial class lbCaptainHome : Form
    {
        public lbCaptainHome()
        {
            InitializeComponent();
        }
        public static string sqlconnection = "server=localhost;uid=root;pwd=;database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlconnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqladapter;
        public string sqlQuery;
        string HomeManager;
        string AwayManager;
        string HomeCapt;
        string AwayCapt;
        string Stadium;
        string Capacity;

        private void FormPraktikum_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT team_name FROM team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqladapter = new MySqlDataAdapter(sqlCommand);
            DataSet ds = new DataSet();
            sqladapter.Fill(ds, "USE_team");
            int size = ds.Tables[0].Rows.Count;
            string[] namaTeam = new string[size];
            int i = 0;
            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                namaTeam[i] = dr["team_name"].ToString();
                i++;
            }
            cbAway.Items.AddRange(namaTeam);
            cbHome.Items.AddRange(namaTeam);

            DataTable dataTable = new DataTable();
            sqlQuery = "SELECT t.team_name FROM team t";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqladapter = new MySqlDataAdapter(sqlCommand);
            sqladapter.Fill(dataTable);
        }

        private void cbHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            string getTeam = cbHome.SelectedItem.ToString();
            DataTable dtManagerHome = new DataTable();
            sqlQuery = "SELECT manager_name FROM manager m LEFT JOIN team t ON m.manager_id = t.manager_id WHERE t.team_name = '" + getTeam + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqladapter = new MySqlDataAdapter(sqlCommand);
            sqladapter.Fill(dtManagerHome);
            HomeManager = dtManagerHome.Rows[0][0].ToString();

            DataTable dtCaptHome = new DataTable();
            sqlQuery = "SELECT p.player_name FROM player p LEFT JOIN team t ON t.team_id = p.team_id WHERE t.team_name = '" + getTeam + "' AND t.captain_id = p.player_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqladapter = new MySqlDataAdapter(sqlCommand);
            sqladapter.Fill(dtCaptHome);
            HomeCapt = dtCaptHome.Rows[0][0].ToString();

            DataTable dtStadium = new DataTable();
            sqlQuery = "SELECT home_stadium FROM team WHERE team_name = '" + getTeam + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqladapter = new MySqlDataAdapter(sqlCommand);
            sqladapter.Fill(dtStadium);
            Stadium = dtStadium.Rows[0][0].ToString();

            DataTable dtCapacity = new DataTable();
            sqlQuery = "SELECT capacity FROM team WHERE team_name = '" + getTeam + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqladapter = new MySqlDataAdapter(sqlCommand);
            sqladapter.Fill(dtCapacity);
            Capacity = dtCapacity.Rows[0][0].ToString();

            lbCaptHome.Text = "Captain : " + HomeCapt;
            lbManagerHome.Text = "Manager : " + HomeManager;
            lbStadium.Text = "Stadium : " + Stadium;
            lbCapacity.Text = "Capacity : " + Capacity;
        }

        private void cbAway_SelectedIndexChanged(object sender, EventArgs e)
        {
            string getTeam2 = cbAway.SelectedItem.ToString();
            DataTable dtManagerAway = new DataTable();
            sqlQuery = "SELECT manager_name FROM manager m LEFT JOIN team t ON m.manager_id = t.manager_id WHERE t.team_name = '" + getTeam2 + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqladapter = new MySqlDataAdapter(sqlCommand);
            sqladapter.Fill(dtManagerAway);
            AwayManager = dtManagerAway.Rows[0][0].ToString();

            DataTable dtCaptAway = new DataTable();
            sqlQuery = "SELECT p.player_name FROM player p LEFT JOIN team t ON t.team_id = p.team_id WHERE t.team_name = '" + getTeam2 + "' AND t.captain_id = p.player_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqladapter = new MySqlDataAdapter(sqlCommand);
            sqladapter.Fill(dtCaptAway);
            AwayCapt = dtCaptAway.Rows[0][0].ToString();

            lbCaptainAway.Text = "Captain : " + AwayCapt;
            lbManagerAway.Text = "Manager : " + AwayManager;
        }
    }
}
