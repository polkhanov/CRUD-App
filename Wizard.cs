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

namespace BD
{
    public partial class Wizard : Form
    {
        public Wizard()
        {
            InitializeComponent();
        }

        private void Wizard_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lombardDataSet.category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.lombardDataSet.category);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lombardDataSet.sellers". При необходимости она может быть перемещена или удалена.
            this.sellersTableAdapter.Fill(this.lombardDataSet.sellers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lombardDataSet.clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.lombardDataSet.clients);

        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0) client_contr.Visible = true;
            else { create_client_panel.Visible = true; client_timer.Enabled = true; }
           
        }

        private void create_client_reg_Click(object sender, EventArgs e)
        {
            lombard lb = new lombard();
            SqlCommand cmd = lb.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO clients values('" + name_cl_reg.Text + "','" + db_client_reg.Value +"','"
                + adres_client_reg.Text + "','" + passport_client_reg.Text + "','" + phone_client_reg.Text + "')"; MessageBox.Show(cmd.CommandText); cmd.ExecuteNonQuery(); Main Mn = new Main(); Mn.lombardDataSet.AcceptChanges(); DataSet dt = Mn.lombardDataSet; 
                 Mn.contract_datagrid.DataSource = dt;  Mn.items_datagrid.DataSource = dt; 
                 Mn.clients_datagrid.DataSource = dt;  Mn.sale_datagrid.DataSource = dt; Mn.sellers_datagrid.DataSource = dt;
                 lb.con.Close(); create_client_panel.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (name_cl_reg.TextLength > 0 && adres_client_reg.TextLength > 0 && phone_client_reg.TextLength > 0
                && passport_client_reg.TextLength > 0) create_client_reg.Visible = true;
            else create_client_reg.Visible = false;
        }

        private void contract_timer_Tick(object sender, EventArgs e)
        {
            if (sell_or_not.SelectedIndex == 0)
            {
                true_sell.Visible = true; create_contract.Top = 371;
            if (client_contr.SelectedIndex > -1 && price_out_contr.TextLength > 0
                && seller_contract.SelectedIndex > -1 && (date_in_conrt.Value < date_out_contr.Value)) create_contract.Visible = true;
            else create_contract.Visible = false;
            }
            if (sell_or_not.SelectedIndex == 1)
            {
                create_contract.Top = 222;
                true_sell.Visible = false; if (client_contr.SelectedIndex > -1
&& seller_contract.SelectedIndex > -1) create_contract.Visible = true;
                else create_contract.Visible = false;
            }
            
        }
        String status_id = "1";
        private void create_contract_Click(object sender, EventArgs e)
        {
            String client_id = "",seller_id = "";
            lombard lb = new lombard();
            SqlCommand cmd = lb.con.CreateCommand();// SqlCommand cmd2 = lb.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select id_client from clients where name ='"+client_contr.Text+"'";
            SqlDataReader dr1 = cmd.ExecuteReader(); 
            while (dr1.Read()) client_id = dr1[0].ToString(); dr1.Close();
            cmd.CommandText = "select id_seller from sellers where name ='" + seller_contract.Text + "'";
            dr1 = cmd.ExecuteReader();
            while (dr1.Read()) seller_id = dr1[0].ToString();
            dr1.Close();
            if (sell_or_not.SelectedIndex == 0)
            {status_id = "1";
                cmd.CommandText = "INSERT INTO contract values('" + client_id + "','" + date_in_conrt.Value + "','"
                     + date_out_contr.Value + "','" + price_out_contr.Text + "','" + seller_id + "')";
            }
            if (sell_or_not.SelectedIndex == 1) { cmd.CommandText = "INSERT INTO contract(client_id,date_contract,seller_id) values('" + client_id + "','" + date_in_conrt.Value + "','" + seller_id + "')"; status_id = "3"; }
            MessageBox.Show(cmd.CommandText); 
            cmd.ExecuteNonQuery(); Main Mn = new Main(); Mn.lombardDataSet.AcceptChanges(); lb.con.Close(); 
            item_timer.Enabled = true; item_create_panel.Visible = true;
        }

        private void item_timer_Tick(object sender, EventArgs e)
        {
            if (name_item_reg.TextLength > 0 && count_item_reg.TextLength > 0 && price_item_reg.TextLength > 0) create_item.Visible = true;
            else create_item.Visible = false;
        }

        private void count_item_reg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;  
        }

        private void price_item_reg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;  
        }

        private void create_item_Click(object sender, EventArgs e)
        {
            lombard lb = new lombard(); String id_contract = "", category_id = "";
            SqlCommand cmd = lb.con.CreateCommand();// SqlCommand cmd2 = lb.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select top 1 * from contract ORDER BY id_contract DESC";
            SqlDataReader dr1 = cmd.ExecuteReader();
            while (dr1.Read()) id_contract = dr1[0].ToString(); dr1.Close();
            cmd.CommandText = "select id_category from category where category ='" + category_item_reg.Text + "'";
            dr1 = cmd.ExecuteReader();
            while (dr1.Read()) category_id = dr1[0].ToString(); dr1.Close();
            cmd.CommandText = "INSERT INTO items values('" + category_id + "','" + name_item_reg.Text + "','"
                 + count_item_reg.Text + "','" + description_item_reg.Text + "','" + price_item_reg.Text + "','" + id_contract + "','" + status_id + "')";
            MessageBox.Show(cmd.CommandText);
            cmd.ExecuteNonQuery(); Main Mn = new Main(); Mn.lombardDataSet.AcceptChanges(); lb.con.Close(); this.Close();
        }



        
    }
}
