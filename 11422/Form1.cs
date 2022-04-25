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
        public string team1;
        public string team2;

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
            team1 = getTeam;
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
            team2 = getTeam2;
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

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (cbHome.SelectedItem == null || cbAway.SelectedItem == null)
            {
                MessageBox.Show("Please select a value");
            }
            else
            {
                string MId;
                DataTable dtMatchid= new DataTable();
                sqlQuery = "select  m.match_id, date_format(m.match_date, '%d %M %Y'), concat(m.goal_home, ' - ', m.goal_away) from `match` m left join team t on t.team_id = m.team_home left join team t2 on t2.team_id = m.team_away where t.team_name = '" + team1 + "' and t2.team_name = '" + team2 + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqladapter = new MySqlDataAdapter(sqlCommand);
                sqladapter.Fill(dtMatchid);
                MId = dtMatchid.Rows[0][0].ToString();
                lbTanggal.Text = "Tanggal : "+ dtMatchid.Rows[0][1].ToString();
                lbSkor.Text = "Skor : " + dtMatchid.Rows[0][2].ToString();

                DataTable dtDetail = new DataTable();
                sqlQuery = "select d.`minute`, if(d.`type` = 'GW', if(p.team_id = m.team_away, p.player_name, '') ,if(p.team_id = m.team_home, p.player_name, '')) as 'Player Name 1', if(d.`type` = 'GW', if(p.team_id = m.team_away, 'Own Goal', '') ,if(p.team_id = m.team_home, if(d.`type` = 'CY', 'Yellow Card', if(d.`type` = 'CR', 'Red Card', if(d.`type` = 'GO', 'Goal', if(d.`type` = 'GP', 'Goal Penalty', if(d.`type` = 'PM', 'Penalty Miss', ''))))) , '')) as 'Tipe 1', if(d.`type` = 'GW', if(p.team_id = m.team_home, p.player_name, '') ,if(p.team_id = m.team_away, p.player_name, '')) as 'Player Name 2', if(d.`type` = 'GW', if(p.team_id = m.team_home, 'Own Goal', '') ,if(p.team_id = m.team_away, if(d.`type` = 'CY', 'Yellow Card', if(d.`type` = 'CR', 'Red Card', if(d.`type` = 'GO', 'Goal', if(d.`type` = 'GP', 'Goal Penalty', if(d.`type` = 'PM', 'Penalty Miss', ''))))), '')) as 'Tipe 2' from dmatch d, `match` m , player p where d.match_id = '"+ MId +"' and d.match_id = m.match_id and p.player_id = d.player_id";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqladapter = new MySqlDataAdapter(sqlCommand);
                sqladapter.Fill(dtDetail);
                MatchDetail.DataSource = dtDetail;
            }
        }
    }
}
