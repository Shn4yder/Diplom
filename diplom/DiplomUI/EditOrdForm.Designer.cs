namespace diplom
{
    partial class EditOrdForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditOrdForm));
            this.comment_tB = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numb_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.order_timer = new System.Windows.Forms.Timer(this.components);
            this.time_lbl = new System.Windows.Forms.Label();
            this.goods_GV = new System.Windows.Forms.DataGridView();
            this.id_good = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image_path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo = new System.Windows.Forms.DataGridViewImageColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cart_GV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cart_amount_lbl = new System.Windows.Forms.Label();
            this.pay_cB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.itogo_amount = new System.Windows.Forms.Label();
            this.time_checkB = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ppl_UpDown = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.back_btn = new System.Windows.Forms.PictureBox();
            this.name_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name_tB = new diplom.CueTextbox();
            this.nenal_tB = new diplom.CueTextbox();
            this.nal_tB = new diplom.CueTextbox();
            this.add_pay_btn = new diplom.Controls.RoundBtn();
            this.save_btn = new diplom.Controls.RoundBtn();
            this.id_cart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_good = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idgood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.goods_GV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cart_GV)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppl_UpDown)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // comment_tB
            // 
            this.comment_tB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.comment_tB.Location = new System.Drawing.Point(256, 57);
            this.comment_tB.Name = "comment_tB";
            this.comment_tB.Size = new System.Drawing.Size(240, 84);
            this.comment_tB.TabIndex = 2;
            this.comment_tB.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.label2.Location = new System.Drawing.Point(9, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Количество человек";
            // 
            // numb_lbl
            // 
            this.numb_lbl.AutoSize = true;
            this.numb_lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numb_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.numb_lbl.Location = new System.Drawing.Point(35, 9);
            this.numb_lbl.Name = "numb_lbl";
            this.numb_lbl.Size = new System.Drawing.Size(96, 25);
            this.numb_lbl.TabIndex = 7;
            this.numb_lbl.Text = "Заказ № ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.label3.Location = new System.Drawing.Point(8, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Прошло времени";
            // 
            // order_timer
            // 
            this.order_timer.Interval = 1000;
            this.order_timer.Tick += new System.EventHandler(this.order_timer_Tick);
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.time_lbl.Location = new System.Drawing.Point(147, 121);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(41, 15);
            this.time_lbl.TabIndex = 9;
            this.time_lbl.Text = "label4";
            // 
            // goods_GV
            // 
            this.goods_GV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.goods_GV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.goods_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goods_GV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_good,
            this.name,
            this.image_path,
            this.photo,
            this.Cost});
            this.goods_GV.Location = new System.Drawing.Point(9, 155);
            this.goods_GV.Name = "goods_GV";
            this.goods_GV.RowHeadersVisible = false;
            this.goods_GV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.goods_GV.Size = new System.Drawing.Size(224, 144);
            this.goods_GV.TabIndex = 10;
            this.goods_GV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.goods_GV_CellDoubleClick);
            // 
            // id_good
            // 
            this.id_good.DataPropertyName = "Id_good";
            this.id_good.HeaderText = "id";
            this.id_good.Name = "id_good";
            this.id_good.ReadOnly = true;
            this.id_good.Visible = false;
            this.id_good.Width = 50;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Наименование";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 155;
            // 
            // image_path
            // 
            this.image_path.DataPropertyName = "Img";
            this.image_path.HeaderText = "path";
            this.image_path.Name = "image_path";
            this.image_path.ReadOnly = true;
            this.image_path.Visible = false;
            // 
            // photo
            // 
            this.photo.DataPropertyName = "image";
            this.photo.HeaderText = "photo";
            this.photo.Name = "photo";
            this.photo.ReadOnly = true;
            this.photo.Visible = false;
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "Cost";
            this.Cost.HeaderText = "Цена";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Width = 52;
            // 
            // cart_GV
            // 
            this.cart_GV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.cart_GV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cart_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cart_GV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cart,
            this.name_good,
            this.price,
            this.quantity,
            this.id,
            this.idgood});
            this.cart_GV.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.cart_GV.Location = new System.Drawing.Point(256, 154);
            this.cart_GV.Name = "cart_GV";
            this.cart_GV.RowHeadersVisible = false;
            this.cart_GV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cart_GV.Size = new System.Drawing.Size(240, 144);
            this.cart_GV.TabIndex = 11;
            this.cart_GV.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.cart_GV_CellMouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.label4.Location = new System.Drawing.Point(252, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "ИТОГО по корзине:";
            // 
            // cart_amount_lbl
            // 
            this.cart_amount_lbl.AutoSize = true;
            this.cart_amount_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cart_amount_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.cart_amount_lbl.Location = new System.Drawing.Point(414, 324);
            this.cart_amount_lbl.Name = "cart_amount_lbl";
            this.cart_amount_lbl.Size = new System.Drawing.Size(17, 20);
            this.cart_amount_lbl.TabIndex = 13;
            this.cart_amount_lbl.Text = "0";
            // 
            // pay_cB
            // 
            this.pay_cB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pay_cB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pay_cB.FormattingEnabled = true;
            this.pay_cB.Items.AddRange(new object[] {
            "безналичные",
            "наличные",
            "смешанная"});
            this.pay_cB.Location = new System.Drawing.Point(9, 308);
            this.pay_cB.Name = "pay_cB";
            this.pay_cB.Size = new System.Drawing.Size(163, 21);
            this.pay_cB.TabIndex = 14;
            this.pay_cB.SelectedIndexChanged += new System.EventHandler(this.pay_cB_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.label5.Location = new System.Drawing.Point(252, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "К оплате:";
            // 
            // itogo_amount
            // 
            this.itogo_amount.AutoSize = true;
            this.itogo_amount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itogo_amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.itogo_amount.Location = new System.Drawing.Point(330, 347);
            this.itogo_amount.Name = "itogo_amount";
            this.itogo_amount.Size = new System.Drawing.Size(17, 20);
            this.itogo_amount.TabIndex = 16;
            this.itogo_amount.Text = "0";
            // 
            // time_checkB
            // 
            this.time_checkB.AutoSize = true;
            this.time_checkB.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_checkB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.time_checkB.Location = new System.Drawing.Point(256, 304);
            this.time_checkB.Name = "time_checkB";
            this.time_checkB.Size = new System.Drawing.Size(134, 17);
            this.time_checkB.TabIndex = 17;
            this.time_checkB.Text = "Не учитывать время";
            this.time_checkB.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.ppl_UpDown);
            this.panel3.Location = new System.Drawing.Point(182, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(54, 23);
            this.panel3.TabIndex = 23;
            // 
            // ppl_UpDown
            // 
            this.ppl_UpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ppl_UpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ppl_UpDown.Location = new System.Drawing.Point(3, 3);
            this.ppl_UpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ppl_UpDown.Name = "ppl_UpDown";
            this.ppl_UpDown.Size = new System.Drawing.Size(44, 17);
            this.ppl_UpDown.TabIndex = 6;
            this.ppl_UpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(9, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 23);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.nal_tB);
            this.panel2.Location = new System.Drawing.Point(12, 335);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(90, 23);
            this.panel2.TabIndex = 25;
            this.panel2.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(120, 335);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(90, 23);
            this.panel4.TabIndex = 26;
            this.panel4.Visible = false;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(160)))), ((int)(((byte)(128)))));
            this.back_btn.Image = ((System.Drawing.Image)(resources.GetObject("back_btn.Image")));
            this.back_btn.Location = new System.Drawing.Point(9, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(20, 22);
            this.back_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.back_btn.TabIndex = 27;
            this.back_btn.TabStop = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_lbl.ForeColor = System.Drawing.Color.DarkRed;
            this.name_lbl.Location = new System.Drawing.Point(239, 47);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(17, 24);
            this.name_lbl.TabIndex = 32;
            this.name_lbl.Text = "*";
            this.name_lbl.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(259, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Комментарий";
            // 
            // name_tB
            // 
            this.name_tB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_tB.Cue = "Имя";
            this.name_tB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_tB.Location = new System.Drawing.Point(12, 47);
            this.name_tB.Name = "name_tB";
            this.name_tB.Size = new System.Drawing.Size(221, 18);
            this.name_tB.TabIndex = 31;
            this.name_tB.TextChanged += new System.EventHandler(this.name_tB_TextChanged);
            // 
            // nenal_tB
            // 
            this.nenal_tB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nenal_tB.Cue = "Безналичные";
            this.nenal_tB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nenal_tB.Location = new System.Drawing.Point(123, 338);
            this.nenal_tB.Name = "nenal_tB";
            this.nenal_tB.Size = new System.Drawing.Size(84, 18);
            this.nenal_tB.TabIndex = 31;
            this.nenal_tB.TextChanged += new System.EventHandler(this.nenal_tB_TextChanged);
            // 
            // nal_tB
            // 
            this.nal_tB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nal_tB.Cue = "Наличные";
            this.nal_tB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nal_tB.Location = new System.Drawing.Point(3, 3);
            this.nal_tB.Name = "nal_tB";
            this.nal_tB.Size = new System.Drawing.Size(84, 18);
            this.nal_tB.TabIndex = 31;
            this.nal_tB.TextChanged += new System.EventHandler(this.nal_tB_TextChanged);
            // 
            // add_pay_btn
            // 
            this.add_pay_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.add_pay_btn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_pay_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.add_pay_btn.Location = new System.Drawing.Point(12, 373);
            this.add_pay_btn.Name = "add_pay_btn";
            this.add_pay_btn.Radius = 10;
            this.add_pay_btn.Size = new System.Drawing.Size(93, 24);
            this.add_pay_btn.TabIndex = 22;
            this.add_pay_btn.Text = "Завершить";
            this.add_pay_btn.UseVisualStyleBackColor = false;
            this.add_pay_btn.Click += new System.EventHandler(this.add_pay_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.save_btn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.save_btn.Location = new System.Drawing.Point(347, 373);
            this.save_btn.Name = "save_btn";
            this.save_btn.Radius = 10;
            this.save_btn.Size = new System.Drawing.Size(149, 24);
            this.save_btn.TabIndex = 21;
            this.save_btn.Text = "Сохранить изменения";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // id_cart
            // 
            this.id_cart.DataPropertyName = "Id_cart";
            this.id_cart.HeaderText = "cart";
            this.id_cart.Name = "id_cart";
            this.id_cart.ReadOnly = true;
            this.id_cart.Visible = false;
            this.id_cart.Width = 150;
            // 
            // name_good
            // 
            this.name_good.DataPropertyName = "Name";
            this.name_good.HeaderText = "Наименование";
            this.name_good.Name = "name_good";
            this.name_good.ReadOnly = true;
            this.name_good.Width = 150;
            // 
            // price
            // 
            this.price.DataPropertyName = "Cost";
            this.price.HeaderText = "Цена";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 44;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "Quantity";
            this.quantity.HeaderText = "Кол-во";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 45;
            // 
            // id
            // 
            this.id.DataPropertyName = "Id_order";
            this.id.HeaderText = "order";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // idgood
            // 
            this.idgood.DataPropertyName = "Id_good";
            this.idgood.HeaderText = "good";
            this.idgood.Name = "idgood";
            this.idgood.ReadOnly = true;
            this.idgood.Visible = false;
            // 
            // EditOrdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(508, 405);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.name_tB);
            this.Controls.Add(this.nenal_tB);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.add_pay_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.time_checkB);
            this.Controls.Add(this.itogo_amount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pay_cB);
            this.Controls.Add(this.cart_amount_lbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cart_GV);
            this.Controls.Add(this.goods_GV);
            this.Controls.Add(this.time_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numb_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comment_tB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditOrdForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение заказа";
            ((System.ComponentModel.ISupportInitialize)(this.goods_GV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cart_GV)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ppl_UpDown)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox comment_tB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numb_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer order_timer;
        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.DataGridView goods_GV;
        private System.Windows.Forms.DataGridView cart_GV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cart_amount_lbl;
        private System.Windows.Forms.ComboBox pay_cB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label itogo_amount;
        private System.Windows.Forms.CheckBox time_checkB;
        private Controls.RoundBtn save_btn;
        private Controls.RoundBtn add_pay_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown ppl_UpDown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_good;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn image_path;
        private System.Windows.Forms.DataGridViewImageColumn photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.PictureBox back_btn;
        private CueTextbox nal_tB;
        private CueTextbox nenal_tB;
        private CueTextbox name_tB;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cart;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_good;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgood;
    }
}