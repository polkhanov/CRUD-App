using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace BD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           
            
        }
        Main lg = new Main();
        private void button1_Click(object sender, EventArgs e)
        {
            lombard lb = new lombard();
            string query = "SELECT * FROM sellers WHERE username =@user AND password =@pass";
            SqlCommand cmd = new SqlCommand(query, lb.con);
            cmd.Parameters.Add(new SqlParameter("@user", username.Text));
            cmd.Parameters.Add(new SqlParameter("@pass", password.Text));
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                dr.Close();
                this.Visible = false;
                query = "SELECT NAME FROM sellers WHERE username = @user AND password = @pass";
                SqlCommand cmd1 = new SqlCommand(query, lb.con);
                cmd1.Parameters.Add(new SqlParameter("@user", username.Text));
                cmd1.Parameters.Add(new SqlParameter("@pass", password.Text));
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                    query = dr1[0].ToString();
                dr1.Close(); lg.cur_user.Text = lg.cur_user.Text + query;
                query = "SELECT NAME FROM sellers WHERE username = @user AND password = @pass";
                 cmd1 = new SqlCommand("SELECT id_seller FROM sellers WHERE username = @user AND password = @pass", lb.con);
                cmd1.Parameters.Add(new SqlParameter("@user", username.Text));
                cmd1.Parameters.Add(new SqlParameter("@pass", password.Text));
                dr1 = cmd1.ExecuteReader();
                while (dr1.Read()) lg.current_user = dr1[0].ToString();
                dr.Close(); lg.Show();
            }
            else
            {
                MessageBox.Show("Введенные логин/пароль неверны!");
            }
        }

        private void quit_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

 
    }
}
