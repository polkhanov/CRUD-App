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
using System.Resources;

namespace BD
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public String current_user, user_lvl;
        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lombardDataSet.category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.lombardDataSet.category);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lombardDataSet2.status". При необходимости она может быть перемещена или удалена.
            this.statusTableAdapter.Fill(this.lombardDataSet2.status);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lombardDataSet1.sellers". При необходимости она может быть перемещена или удалена.
            this.sellersTableAdapter.Fill(this.lombardDataSet1.sellers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lombardDataSet.contract". При необходимости она может быть перемещена или удалена.
            this.contractTableAdapter.Fill(this.lombardDataSet.contract);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lombardDataSet.clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.lombardDataSet.clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lombardDataSet1.items". При необходимости она может быть перемещена или удалена.
 
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lombardDataSet.sale". При необходимости она может быть перемещена или удалена.
            this.saleTableAdapter.Fill(this.lombardDataSet.sale);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lombardDataSet1.sellers". При необходимости она может быть перемещена или удалена.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lombardDataSet.items". При необходимости она может быть перемещена или удалена.
            this.itemsTableAdapter.Fill(this.lombardDataSet.items);
           foreach (DataGridViewRow row in contract_datagrid.Rows)//Проход по всем строкам ДатаГрида
           {
               //MessageBox.Show(row.Cells["date_out"].Value.ToString());
               if (row.Cells["date_out"].Value.ToString() == "") break;
             //  MessageBox.Show(row.Cells["date_out"].Value.ToString());
               DateTime dt = (DateTime)row.Cells["date_out"].Value;

                if (dt < DateTime.Now) row.DefaultCellStyle.BackColor = Color.Red;
            }
            
        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {   
        }

        private void tabDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search_Show(tabDate.SelectedIndex);
            DataGridView DG = null; sell_item.Visible = false;
            switch (tabDate.SelectedIndex)
            {
                case 0:
                    DG = contract_datagrid; break;
                case 1:
                    DG = items_datagrid;sell_item.Visible=true; break;
                case 2:
                    DG = clients_datagrid; break;
                case 3:
                    DG = sale_datagrid; break;
                case 4:
                    DG = sellers_datagrid; break;
            }
            if (!DG.ReadOnly) edit_button.BackgroundImage = BD.Properties.Resources.change_hover;
            else edit_button.BackgroundImage = BD.Properties.Resources.change;
        }
        void Search_Show(int i)
        {
            search_contracts.Visible = false;
            search_items.Visible = false;
            search_clients.Visible = false;
            search_sale.Visible = false;
            search_sellers.Visible = false; 
            switch (i)
            {
                case 0: search_contracts.Visible = true; break;
                case 1: search_items.Visible = true; break;
                case 2: search_clients.Visible = true; break;
                case 3: search_sale.Visible = true; break;
                case 4: search_sellers.Visible = true; break;
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (search_panel.Visible == false)
            {
                search_button.BackgroundImage = BD.Properties.Resources._23_hover;
                search_panel.Visible = true;
            }
            else 
            {
                search_button.BackgroundImage = BD.Properties.Resources._23;
                search_panel.Visible = false;
            }
        }
        void Change(DataGridView DG,SqlCommand cmd) // функция изменения таблицы
        {
            string value = DG.CurrentCell.Value.ToString(); //значение
            string cell = DG.Columns[DG.CurrentCell.ColumnIndex].DataPropertyName; //имя ячейки
            string row = DG[0, DG.CurrentCell.RowIndex].Value.ToString(); // айди строки
            //cmd.CommandText = "UPDATE contract SET " + cell + "=" + value + " WHERE " + row + "";
            //contract_datagrid[contract_datagrid.CurrentCell.RowIndex, 0].State = DataGridViewElementStates.Frozen;
            switch (tabDate.SelectedIndex)
            {
                case 0: cmd.CommandText = "UPDATE contract SET " + cell + "='" + value + "' WHERE id_contract='" + row + "'";
                    cmd.ExecuteNonQuery(); lombardDataSet.AcceptChanges(); MessageBox.Show(cmd.CommandText); break;
                case 1: cmd.CommandText = "UPDATE items SET " + cell + "='" + value + "' WHERE id_item='" + row + "'";
                    cmd.ExecuteNonQuery(); lombardDataSet.AcceptChanges(); MessageBox.Show(cmd.CommandText); break;
                case 2: cmd.CommandText = "UPDATE clients SET " + cell + "='" + value + "' WHERE id_client='" + row + "'";
                    cmd.ExecuteNonQuery(); lombardDataSet.AcceptChanges(); MessageBox.Show(cmd.CommandText); break;
                case 3: cmd.CommandText = "UPDATE sale SET " + cell + "='" + value + "' WHERE id_sale='" + row + "'";
                    cmd.ExecuteNonQuery(); lombardDataSet.AcceptChanges(); MessageBox.Show(cmd.CommandText); break;
                case 4: cmd.CommandText = "UPDATE sellers SET " + cell + "='" + value + "' WHERE id_seller='" + row + "'";
                    MessageBox.Show(cmd.CommandText);
                    cmd.ExecuteNonQuery(); lombardDataSet.AcceptChanges(); break;

            } DG.ReadOnly = true; DG.ReadOnly = false;
        }
        void Like() // функция поиска по таблице
        {
            lombard lb = new lombard();
            SqlCommand cmd = lb.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            switch (tabDate.SelectedIndex)
            {
                //case 0: cmd.CommandText = "select * from contract where clients.name like('" + search_namesl_contract.Text + "%') AND price_out like('%" + search_priceOut_contract.Text + "%') AND date_contract like('%" + search_datein_contract.Text + "%') AND sellers.name like('%" + search_namesl_contract.Text + "%')"; break;
                case 0: cmd.CommandText = "select * from contract where  price_out like('%" + search_priceOut_contract.Text + "%')AND client_id IN(select id_client from clients where name like('" + search_namecl_contract.Text + "%'))  AND date_contract like('%" + search_datein_contract.Text + "%') AND  seller_id IN (select id_seller from sellers where name like('%" + search_namesl_contract.Text + "%'))"; break;
                case 1: search_items.Visible = true; break;
                case 2: cmd.CommandText = "select * from clients where name like('" + search_name_cl.Text + "%') AND adress like('%" + search_adress_cl.Text + "%')"; break;
                case 3: search_sale.Visible = true; break;
                case 4: cmd.CommandText = "select * from sellers where name like('" + search_name_sellers.Text + "%') AND post like('%" + search_post_sellers.Text + "%') AND lvl like('%" + search_lvl_sellers.Text + "%')"; break;
            }
           
                cmd.ExecuteNonQuery(); DataTable dt = new DataTable(); SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt); 
                switch (tabDate.SelectedIndex)
                {
                    case 0: contract_datagrid.DataSource = dt; break;
                    case 1: items_datagrid.DataSource = dt; break;
                    case 2: clients_datagrid.DataSource = dt; break;
                    case 3: sale_datagrid.DataSource = dt; break;
                    case 4: sellers_datagrid.DataSource = dt; break;
                }
            
        }
        private void search_name_cl_TextChanged(object sender, EventArgs e)
        {
            Like();
        }

        private void search_adress_cl_TextChanged(object sender, EventArgs e)
        {
             Like(); 
        }

        private void edit_button_MouseUp(object sender, MouseEventArgs e)
        {
            /*if( edit_button.BackgroundImage == BD.Properties.Resources.change){
              edit_button.BackgroundImage = BD.Properties.Resources.change_hover;}
            else
                edit_button.BackgroundImage = BD.Properties.Resources.change;*/
            DataGridView DG = null ;
            switch (tabDate.SelectedIndex)
            {
                case 0:
                    DG = contract_datagrid; break;
                case 1:
                    DG = items_datagrid; break;
                case 2:
                    DG = clients_datagrid; break;
                case 3:
                    DG = sale_datagrid; break;
                case 4:
                    DG = sellers_datagrid; break;
              
            } 
            lombard lb = new lombard();
            SqlCommand cmd = lb.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
         
            if (DG.ReadOnly == true)
            {
                lombardDataSet.AcceptChanges();
                edit_button.BackgroundImage = BD.Properties.Resources.change_hover;   
                    DG.AllowUserToDeleteRows = true;
                    DG.ReadOnly = false; DG.BorderStyle = BorderStyle.FixedSingle;
                    DG.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
                
                
            }
            else
            {
               // cmd.CommandText = "";
                
                edit_button.BackgroundImage = BD.Properties.Resources.change;
                DG.AllowUserToDeleteRows = false;
                DG.ReadOnly = true; DG.BorderStyle = BorderStyle.None;
                DG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                ///////
                /* string value = DG.CurrentCell.Value.ToString(); //значение
                 string cell = DG.Columns[contract_datagrid.CurrentCell.ColumnIndex].DataPropertyName; //имя ячейки
                 string row = DG[contract_datagrid.CurrentCell.RowIndex, 0].Value.ToString(); // айди строки
                 //cmd.CommandText = "UPDATE contract SET " + cell + "=" + value + " WHERE " + row + "";
                 //contract_datagrid[contract_datagrid.CurrentCell.RowIndex, 0].State = DataGridViewElementStates.Frozen;
                 switch (tabDate.SelectedIndex)
                 {
                     case 0: cmd.CommandText = "UPDATE contract SET " + cell + "='" + value + "' WHERE id_contract='" + row + "'";
                      cmd.ExecuteNonQuery(); lombardDataSet.AcceptChanges();break;

                     case 1:
                         this.clientsTableAdapter.Update(this.lombardDataSet); break;
                     case 4: cmd.CommandText = "UPDATE sellers SET " + cell + "='" + value + "' WHERE id_seller='" + row + "'";
                         MessageBox.Show(cmd.CommandText);
                          cmd.ExecuteNonQuery(); lombardDataSet.AcceptChanges(); break;

                 } */
            }
           
        }

        private void search_lvl_sellers_TextChanged(object sender, EventArgs e)
        {
            Like(); 
        }

        private void search_post_sellers_TextChanged(object sender, EventArgs e)
        {
            Like(); 
        }

        private void search_name_sellers_TextChanged(object sender, EventArgs e)
        {
            Like(); 
        }

        private void search_datein_contract_TextChanged(object sender, EventArgs e)
        {
            Like(); 
        }

        private void search_namesl_contract_TextChanged(object sender, EventArgs e)
        {
            Like(); 
        }

        private void search_priceOut_contract_TextChanged(object sender, EventArgs e)
        {
            Like(); 
        }

        private void search_namecl_contract_TextChanged(object sender, EventArgs e)
        {
            Like(); 
        }

        private void contract_datagrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {}

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void contract_datagrid_SelectionChanged(object sender, EventArgs e)
        { /*//MessageBox.Show(contract_datagrid.Columns[contract_datagrid.CurrentCell.ColumnIndex].DataPropertyName);
           MessageBox.Show(contract_datagrid.Columns[contract_datagrid.CurrentCell.ColumnIndex].DataPropertyName); 
           MessageBox.Show(contract_datagrid[contract_datagrid.CurrentCell.RowIndex, 0].Value.ToString());
            MessageBox.Show(contract_datagrid.Columns[contract_datagrid.CurrentCell.ColumnIndex].DataPropertyName); 
        */}

        private void sellers_datagrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {lombard lb = new lombard();
            SqlCommand cmd = lb.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if(!sellers_datagrid.ReadOnly) Change(sellers_datagrid,cmd);
        }

        private void sellers_datagrid_SelectionChanged(object sender, EventArgs e)
        {
            /*MessageBox.Show(sellers_datagrid.Columns[sellers_datagrid.CurrentCell.ColumnIndex].DataPropertyName);
            MessageBox.Show(sellers_datagrid[0, sellers_datagrid.CurrentCell.RowIndex].Value.ToString());*/
            
        }

        private void contract_datagrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            lombard lb = new lombard();
            SqlCommand cmd = lb.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if (!contract_datagrid.ReadOnly) Change(contract_datagrid, cmd);
        }

        private void items_datagrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            lombard lb = new lombard();
            SqlCommand cmd = lb.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if (!items_datagrid.ReadOnly) Change(items_datagrid, cmd);
        }

        private void clients_datagrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            lombard lb = new lombard();
            SqlCommand cmd = lb.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if (!clients_datagrid.ReadOnly) Change(clients_datagrid, cmd);
        }

        private void sale_datagrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            lombard lb = new lombard();
            SqlCommand cmd = lb.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if (!sale_datagrid.ReadOnly) Change(sale_datagrid, cmd);
        }

        private void delete_button_MouseUp(object sender, MouseEventArgs e)
        {
            DialogResult res = new DialogResult();
            res = MessageBox.Show("Вы действительно хотите удалить запись?",
                                             "Удалить",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            { Wizard lg = new Wizard(); lg.ShowDialog(); }
            else
            { return; } 
        }

        private void create_wizard_MouseUp(object sender, MouseEventArgs e)
        {
            DialogResult res = new DialogResult();
            res = MessageBox.Show("Вы действительно хотите создать запись?",
                                             "Создать",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            { Wizard lg = new Wizard(); lg.ShowDialog(); }
            else
            { return; } 
        }

        private void sell_item_MouseUp(object sender, MouseEventArgs e)
        {
            DialogResult res = new DialogResult();
            res = MessageBox.Show("Вы действительно хотите продать предмет?",
                                             "Продать",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            { sell_item_wizard.Visible = true; }
            else
            { return; }
        }

        private void price_sell_item_wiz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
            if (price_sell_item_wiz.TextLength > 0) s_i_in_wiz.Visible = true;
            else s_i_in_wiz.Visible = false;
        }

        private void c_s_i_in_wiz_Click(object sender, EventArgs e)
        {
            price_sell_item_wiz.Text = ""; sell_item_wizard.Visible = false; 
        }

        private void s_i_in_wiz_Click(object sender, EventArgs e)
        {
            string row = items_datagrid[0, items_datagrid.CurrentCell.RowIndex].Value.ToString();
            lombard lb = new lombard();SqlCommand cmd = lb.con.CreateCommand();cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO sale values('" + row + "','" + price_sell_item_wiz.Text + "','" + current_user + "','" + DateTime.Now + "')";
            cmd.ExecuteNonQuery(); lombardDataSet.AcceptChanges();
            cmd.CommandText = "UPDATE items SET status_id='4' WHERE id_item='" + row + "'"; MessageBox.Show(cmd.CommandText);
            cmd.ExecuteNonQuery(); lombardDataSet.AcceptChanges();
        }

        private void sale_datagrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
       
       
    }
}
