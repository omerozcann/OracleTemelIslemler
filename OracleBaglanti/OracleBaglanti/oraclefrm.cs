using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace OracleBaglanti
{
    public partial class oraclefrm : Form
    {
        public oraclefrm()
        {
            InitializeComponent();
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            OracleConnection oracon = new OracleConnection();
            oracon.ConnectionString = "Data Source = localhost; User Id = TEST2; Password = 12345678;";
            oracon.Open();
            String sql = "insert into KAYIT(ADI,EPOSTA) VALUES('" + adsoyadtxt.Text + "','" + epostatxt.Text + "')";
            OracleCommand oracom = new OracleCommand();
            oracom.Connection = oracon;
            oracom.CommandText = sql;
            oracom.ExecuteNonQuery();
            oracon.Close();
        }

        private void listelebtn_Click(object sender, EventArgs e)
        {
            OracleConnection oracon = new OracleConnection();
            oracon.ConnectionString = "Data Source = localhost; User Id = TEST2; Password = 12345678;";
            oracon.Open();
            String sql = "select * from KAYIT";
            DataSet ds = new DataSet();
            OracleDataAdapter oradata = new OracleDataAdapter(sql, oracon);
            oradata.Fill(ds);
            tablegrd.DataSource = ds.Tables[0];
            oracon.Close();
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            OracleConnection oracon = new OracleConnection();
            oracon.ConnectionString = "Data Source = localhost; User Id = TEST2; Password = 12345678;";
            oracon.Open();
            String sql = "delete from KAYIT where ID=" + tablegrd.Rows[tablegrd.SelectedRows[0].Index].Cells[0].Value;
            OracleCommand oracom = new OracleCommand();
            oracom.Connection = oracon;
            oracom.CommandText = sql;
            oracom.ExecuteNonQuery();
            oracon.Close();
        }
    }
}
