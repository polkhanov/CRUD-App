namespace BD
{
    partial class Wizard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.client_contr = new System.Windows.Forms.ComboBox();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lombardDataSet = new BD.LombardDataSet();
            this.clientsTableAdapter = new BD.LombardDataSetTableAdapters.clientsTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.create_client_panel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.create_client_reg = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.db_client_reg = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.phone_client_reg = new System.Windows.Forms.TextBox();
            this.passport_client_reg = new System.Windows.Forms.TextBox();
            this.adres_client_reg = new System.Windows.Forms.TextBox();
            this.name_cl_reg = new System.Windows.Forms.TextBox();
            this.client_timer = new System.Windows.Forms.Timer(this.components);
            this.date_in_conrt = new System.Windows.Forms.DateTimePicker();
            this.date_out_contr = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.price_out_contr = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.seller_contract = new System.Windows.Forms.ComboBox();
            this.sellersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.sellersTableAdapter = new BD.LombardDataSetTableAdapters.sellersTableAdapter();
            this.create_contract = new System.Windows.Forms.Button();
            this.contract_timer = new System.Windows.Forms.Timer(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.true_sell = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.sell_or_not = new System.Windows.Forms.ComboBox();
            this.item_create_panel = new System.Windows.Forms.Panel();
            this.create_item = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.category_item_reg = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.price_item_reg = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.description_item_reg = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.count_item_reg = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.name_item_reg = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.categoryTableAdapter = new BD.LombardDataSetTableAdapters.categoryTableAdapter();
            this.item_timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lombardDataSet)).BeginInit();
            this.create_client_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource)).BeginInit();
            this.true_sell.SuspendLayout();
            this.item_create_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клиент";
            // 
            // client_contr
            // 
            this.client_contr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.client_contr.DataSource = this.clientsBindingSource;
            this.client_contr.DisplayMember = "name";
            this.client_contr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.client_contr.FormattingEnabled = true;
            this.client_contr.Location = new System.Drawing.Point(114, 95);
            this.client_contr.Name = "client_contr";
            this.client_contr.Size = new System.Drawing.Size(246, 21);
            this.client_contr.TabIndex = 1;
            this.client_contr.Visible = false;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients";
            this.clientsBindingSource.DataSource = this.lombardDataSet;
            // 
            // lombardDataSet
            // 
            this.lombardDataSet.DataSetName = "LombardDataSet";
            this.lombardDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Выбрать существующего",
            "Создать нового"});
            this.comboBox2.Location = new System.Drawing.Point(147, 67);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(180, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // create_client_panel
            // 
            this.create_client_panel.Controls.Add(this.label7);
            this.create_client_panel.Controls.Add(this.create_client_reg);
            this.create_client_panel.Controls.Add(this.label6);
            this.create_client_panel.Controls.Add(this.label5);
            this.create_client_panel.Controls.Add(this.label4);
            this.create_client_panel.Controls.Add(this.label3);
            this.create_client_panel.Controls.Add(this.db_client_reg);
            this.create_client_panel.Controls.Add(this.label2);
            this.create_client_panel.Controls.Add(this.phone_client_reg);
            this.create_client_panel.Controls.Add(this.passport_client_reg);
            this.create_client_panel.Controls.Add(this.adres_client_reg);
            this.create_client_panel.Controls.Add(this.name_cl_reg);
            this.create_client_panel.Location = new System.Drawing.Point(58, 9);
            this.create_client_panel.Name = "create_client_panel";
            this.create_client_panel.Size = new System.Drawing.Size(381, 361);
            this.create_client_panel.TabIndex = 3;
            this.create_client_panel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(14, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(364, 31);
            this.label7.TabIndex = 12;
            this.label7.Text = "Создание записи о клиенте";
            // 
            // create_client_reg
            // 
            this.create_client_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_client_reg.Location = new System.Drawing.Point(153, 314);
            this.create_client_reg.Name = "create_client_reg";
            this.create_client_reg.Size = new System.Drawing.Size(75, 23);
            this.create_client_reg.TabIndex = 11;
            this.create_client_reg.Text = "СОЗДАТЬ";
            this.create_client_reg.UseVisualStyleBackColor = true;
            this.create_client_reg.Visible = false;
            this.create_client_reg.Click += new System.EventHandler(this.create_client_reg_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Телефон";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Пасспорт";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дата Рождения";
            // 
            // db_client_reg
            // 
            this.db_client_reg.Location = new System.Drawing.Point(84, 114);
            this.db_client_reg.Name = "db_client_reg";
            this.db_client_reg.Size = new System.Drawing.Size(222, 20);
            this.db_client_reg.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ФИО";
            // 
            // phone_client_reg
            // 
            this.phone_client_reg.Location = new System.Drawing.Point(84, 276);
            this.phone_client_reg.Name = "phone_client_reg";
            this.phone_client_reg.Size = new System.Drawing.Size(222, 20);
            this.phone_client_reg.TabIndex = 4;
            this.phone_client_reg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passport_client_reg
            // 
            this.passport_client_reg.Location = new System.Drawing.Point(84, 222);
            this.passport_client_reg.Name = "passport_client_reg";
            this.passport_client_reg.Size = new System.Drawing.Size(222, 20);
            this.passport_client_reg.TabIndex = 3;
            this.passport_client_reg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // adres_client_reg
            // 
            this.adres_client_reg.Location = new System.Drawing.Point(84, 168);
            this.adres_client_reg.Name = "adres_client_reg";
            this.adres_client_reg.Size = new System.Drawing.Size(222, 20);
            this.adres_client_reg.TabIndex = 2;
            this.adres_client_reg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // name_cl_reg
            // 
            this.name_cl_reg.Location = new System.Drawing.Point(84, 60);
            this.name_cl_reg.Name = "name_cl_reg";
            this.name_cl_reg.Size = new System.Drawing.Size(222, 20);
            this.name_cl_reg.TabIndex = 0;
            this.name_cl_reg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // client_timer
            // 
            this.client_timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // date_in_conrt
            // 
            this.date_in_conrt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.date_in_conrt.Location = new System.Drawing.Point(10, 28);
            this.date_in_conrt.Name = "date_in_conrt";
            this.date_in_conrt.Size = new System.Drawing.Size(200, 20);
            this.date_in_conrt.TabIndex = 4;
            // 
            // date_out_contr
            // 
            this.date_out_contr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.date_out_contr.Location = new System.Drawing.Point(10, 75);
            this.date_out_contr.Name = "date_out_contr";
            this.date_out_contr.Size = new System.Drawing.Size(200, 20);
            this.date_out_contr.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(77, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Дата Ухода";
            // 
            // price_out_contr
            // 
            this.price_out_contr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.price_out_contr.Location = new System.Drawing.Point(60, 122);
            this.price_out_contr.Name = "price_out_contr";
            this.price_out_contr.Size = new System.Drawing.Size(100, 20);
            this.price_out_contr.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(74, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Цена выкупа";
            // 
            // seller_contract
            // 
            this.seller_contract.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seller_contract.DataSource = this.sellersBindingSource;
            this.seller_contract.DisplayMember = "name";
            this.seller_contract.FormattingEnabled = true;
            this.seller_contract.Location = new System.Drawing.Point(177, 191);
            this.seller_contract.Name = "seller_contract";
            this.seller_contract.Size = new System.Drawing.Size(121, 21);
            this.seller_contract.TabIndex = 10;
            // 
            // sellersBindingSource
            // 
            this.sellersBindingSource.DataMember = "sellers";
            this.sellersBindingSource.DataSource = this.lombardDataSet;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(209, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Продавец";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(101, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(273, 31);
            this.label12.TabIndex = 13;
            this.label12.Text = "Создание контракта";
            // 
            // sellersTableAdapter
            // 
            this.sellersTableAdapter.ClearBeforeFill = true;
            // 
            // create_contract
            // 
            this.create_contract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_contract.Location = new System.Drawing.Point(177, 371);
            this.create_contract.Name = "create_contract";
            this.create_contract.Size = new System.Drawing.Size(121, 23);
            this.create_contract.TabIndex = 14;
            this.create_contract.Text = "СОЗДАТЬ ЗАПИСЬ";
            this.create_contract.UseVisualStyleBackColor = true;
            this.create_contract.Visible = false;
            this.create_contract.Click += new System.EventHandler(this.create_contract_Click);
            // 
            // contract_timer
            // 
            this.contract_timer.Enabled = true;
            this.contract_timer.Tick += new System.EventHandler(this.contract_timer_Tick);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(218, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Выкуп";
            // 
            // true_sell
            // 
            this.true_sell.Controls.Add(this.label8);
            this.true_sell.Controls.Add(this.label10);
            this.true_sell.Controls.Add(this.price_out_contr);
            this.true_sell.Controls.Add(this.label9);
            this.true_sell.Controls.Add(this.date_out_contr);
            this.true_sell.Controls.Add(this.date_in_conrt);
            this.true_sell.Location = new System.Drawing.Point(126, 219);
            this.true_sell.Name = "true_sell";
            this.true_sell.Size = new System.Drawing.Size(222, 145);
            this.true_sell.TabIndex = 17;
            this.true_sell.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Дата Прихода";
            // 
            // sell_or_not
            // 
            this.sell_or_not.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sell_or_not.FormattingEnabled = true;
            this.sell_or_not.Items.AddRange(new object[] {
            "c выкупом",
            "без выкупа"});
            this.sell_or_not.Location = new System.Drawing.Point(177, 143);
            this.sell_or_not.Name = "sell_or_not";
            this.sell_or_not.Size = new System.Drawing.Size(121, 21);
            this.sell_or_not.TabIndex = 18;
            // 
            // item_create_panel
            // 
            this.item_create_panel.Controls.Add(this.create_item);
            this.item_create_panel.Controls.Add(this.label19);
            this.item_create_panel.Controls.Add(this.category_item_reg);
            this.item_create_panel.Controls.Add(this.price_item_reg);
            this.item_create_panel.Controls.Add(this.label18);
            this.item_create_panel.Controls.Add(this.description_item_reg);
            this.item_create_panel.Controls.Add(this.label17);
            this.item_create_panel.Controls.Add(this.label16);
            this.item_create_panel.Controls.Add(this.count_item_reg);
            this.item_create_panel.Controls.Add(this.label15);
            this.item_create_panel.Controls.Add(this.name_item_reg);
            this.item_create_panel.Controls.Add(this.label14);
            this.item_create_panel.Location = new System.Drawing.Point(76, 12);
            this.item_create_panel.Name = "item_create_panel";
            this.item_create_panel.Size = new System.Drawing.Size(310, 385);
            this.item_create_panel.TabIndex = 11;
            this.item_create_panel.Visible = false;
            // 
            // create_item
            // 
            this.create_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_item.Location = new System.Drawing.Point(128, 328);
            this.create_item.Name = "create_item";
            this.create_item.Size = new System.Drawing.Size(75, 23);
            this.create_item.TabIndex = 26;
            this.create_item.Text = "ВНЕСТИ";
            this.create_item.UseVisualStyleBackColor = true;
            this.create_item.Visible = false;
            this.create_item.Click += new System.EventHandler(this.create_item_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(135, 274);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 13);
            this.label19.TabIndex = 25;
            this.label19.Text = "Категория";
            // 
            // category_item_reg
            // 
            this.category_item_reg.DataSource = this.categoryBindingSource;
            this.category_item_reg.DisplayMember = "category";
            this.category_item_reg.FormattingEnabled = true;
            this.category_item_reg.Location = new System.Drawing.Point(105, 297);
            this.category_item_reg.Name = "category_item_reg";
            this.category_item_reg.Size = new System.Drawing.Size(121, 21);
            this.category_item_reg.TabIndex = 24;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "category";
            this.categoryBindingSource.DataSource = this.lombardDataSet;
            // 
            // price_item_reg
            // 
            this.price_item_reg.Location = new System.Drawing.Point(115, 244);
            this.price_item_reg.Name = "price_item_reg";
            this.price_item_reg.Size = new System.Drawing.Size(100, 20);
            this.price_item_reg.TabIndex = 23;
            this.price_item_reg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_item_reg_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(106, 221);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(119, 13);
            this.label18.TabIndex = 22;
            this.label18.Text = "Оценочная стоимость";
            // 
            // description_item_reg
            // 
            this.description_item_reg.Location = new System.Drawing.Point(115, 191);
            this.description_item_reg.Name = "description_item_reg";
            this.description_item_reg.Size = new System.Drawing.Size(100, 20);
            this.description_item_reg.TabIndex = 21;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(137, 168);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "Описание";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(132, 115);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Количество";
            // 
            // count_item_reg
            // 
            this.count_item_reg.Location = new System.Drawing.Point(115, 138);
            this.count_item_reg.Name = "count_item_reg";
            this.count_item_reg.Size = new System.Drawing.Size(100, 20);
            this.count_item_reg.TabIndex = 17;
            this.count_item_reg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.count_item_reg_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(137, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Название";
            // 
            // name_item_reg
            // 
            this.name_item_reg.Location = new System.Drawing.Point(115, 85);
            this.name_item_reg.Name = "name_item_reg";
            this.name_item_reg.Size = new System.Drawing.Size(100, 20);
            this.name_item_reg.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(18, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(294, 31);
            this.label14.TabIndex = 14;
            this.label14.Text = "Информация о залоге";
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // item_timer
            // 
            this.item_timer.Tick += new System.EventHandler(this.item_timer_Tick);
            // 
            // Wizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 443);
            this.Controls.Add(this.create_client_panel);
            this.Controls.Add(this.item_create_panel);
            this.Controls.Add(this.sell_or_not);
            this.Controls.Add(this.true_sell);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.create_contract);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.seller_contract);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.client_contr);
            this.Controls.Add(this.label1);
            this.Name = "Wizard";
            this.Text = "Wizard";
            this.Load += new System.EventHandler(this.Wizard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lombardDataSet)).EndInit();
            this.create_client_panel.ResumeLayout(false);
            this.create_client_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource)).EndInit();
            this.true_sell.ResumeLayout(false);
            this.true_sell.PerformLayout();
            this.item_create_panel.ResumeLayout(false);
            this.item_create_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox client_contr;
        private LombardDataSet lombardDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private LombardDataSetTableAdapters.clientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel create_client_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phone_client_reg;
        private System.Windows.Forms.TextBox passport_client_reg;
        private System.Windows.Forms.TextBox adres_client_reg;
        private System.Windows.Forms.TextBox name_cl_reg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker db_client_reg;
        private System.Windows.Forms.Button create_client_reg;
        private System.Windows.Forms.Timer client_timer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker date_in_conrt;
        private System.Windows.Forms.DateTimePicker date_out_contr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox price_out_contr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox seller_contract;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource sellersBindingSource;
        private LombardDataSetTableAdapters.sellersTableAdapter sellersTableAdapter;
        private System.Windows.Forms.Button create_contract;
        private System.Windows.Forms.Timer contract_timer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel true_sell;
        private System.Windows.Forms.ComboBox sell_or_not;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel item_create_panel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox category_item_reg;
        private System.Windows.Forms.TextBox price_item_reg;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox description_item_reg;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox count_item_reg;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox name_item_reg;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private LombardDataSetTableAdapters.categoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.Button create_item;
        private System.Windows.Forms.Timer item_timer;
    }
}