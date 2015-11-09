using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BD
{
    class lombard
    {
        public SqlConnection con; // переменная подключения 
        public lombard() // конструктор подключения
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Lombard.mdf;Integrated Security=True;";
            con.Open();
            //MessageBox.Show(con.State.ToString());
        }
        public void run(string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            // cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
          //  while (dr.Read()) MessageBox.Show(dr[2].ToString());

        }
        public void exe(string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            // cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            //  while (dr.Read()) MessageBox.Show(dr[2].ToString());

        }
        int DateDif() // сравнение дат
        {
            int ret = 0;
            lombard lb = new lombard();
            string query = "SELECT DATEDIFF(dd,(SELECT date_contract FROM contract),(SELECT date_out FROM contract))";
            SqlCommand cmd = new SqlCommand(query, lb.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) ret = Convert.ToInt32(dr[0]);

            return ret;
        }
    }
}
