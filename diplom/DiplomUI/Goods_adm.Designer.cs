﻿using System.Windows.Forms;

namespace diplom
{
    partial class Goods_adm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Goods_adm));
            this.goods_GV = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img = new System.Windows.Forms.DataGridViewImageColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.log_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.usr_btn = new System.Windows.Forms.Button();
            this.order_btn = new System.Windows.Forms.Button();
            this.note_btn = new System.Windows.Forms.Button();
            this.items_btn = new System.Windows.Forms.Button();
            this.sidebar_btn = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.menu_timer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.price_tB = new diplom.CueTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.order_cB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.save_tarif_btn = new diplom.Controls.RoundBtn();
            this.create_btn = new diplom.Controls.RoundBtn();
            this.change_tarif_btn = new diplom.Controls.RoundBtn();
            ((System.ComponentModel.ISupportInitialize)(this.goods_GV)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // goods_GV
            // 
            this.goods_GV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.goods_GV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.goods_GV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.goods_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goods_GV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.image,
            this.img,
            this.name,
            this.cost});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.goods_GV.DefaultCellStyle = dataGridViewCellStyle2;
            this.goods_GV.Location = new System.Drawing.Point(81, 47);
            this.goods_GV.MultiSelect = false;
            this.goods_GV.Name = "goods_GV";
            this.goods_GV.RowHeadersVisible = false;
            this.goods_GV.RowTemplate.Height = 110;
            this.goods_GV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.goods_GV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.goods_GV.Size = new System.Drawing.Size(446, 353);
            this.goods_GV.TabIndex = 3;
            this.goods_GV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.goods_GV_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id_good";
            this.id.HeaderText = "id_good";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // image
            // 
            this.image.DataPropertyName = "Img";
            this.image.HeaderText = "Фото";
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.image.Visible = false;
            // 
            // img
            // 
            this.img.DataPropertyName = "image";
            this.img.HeaderText = "Изображение";
            this.img.Image = global::diplom.Properties.Resources.default_photo;
            this.img.Name = "img";
            this.img.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.img.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.img.Width = 140;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Наименование";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 190;
            // 
            // cost
            // 
            this.cost.DataPropertyName = "Cost";
            this.cost.HeaderText = "Цена";
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            this.cost.Width = 115;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(180, 450);
            this.sidebar.MinimumSize = new System.Drawing.Size(50, 450);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(50, 450);
            this.sidebar.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.log_btn);
            this.panel1.Controls.Add(this.exit_btn);
            this.panel1.Controls.Add(this.usr_btn);
            this.panel1.Controls.Add(this.order_btn);
            this.panel1.Controls.Add(this.note_btn);
            this.panel1.Controls.Add(this.items_btn);
            this.panel1.Controls.Add(this.sidebar_btn);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.MaximumSize = new System.Drawing.Size(180, 450);
            this.panel1.MinimumSize = new System.Drawing.Size(50, 450);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 450);
            this.panel1.TabIndex = 1;
            // 
            // log_btn
            // 
            this.log_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.log_btn.FlatAppearance.BorderSize = 0;
            this.log_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.log_btn.Image = global::diplom.Properties.Resources.logicon;
            this.log_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.log_btn.Location = new System.Drawing.Point(1, 176);
            this.log_btn.Name = "log_btn";
            this.log_btn.Size = new System.Drawing.Size(177, 44);
            this.log_btn.TabIndex = 7;
            this.log_btn.Text = "        Журнал событий";
            this.log_btn.UseVisualStyleBackColor = false;
            this.log_btn.Click += new System.EventHandler(this.log_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.exit_btn.Image = global::diplom.Properties.Resources.exit_icon;
            this.exit_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit_btn.Location = new System.Drawing.Point(0, 403);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(177, 44);
            this.exit_btn.TabIndex = 6;
            this.exit_btn.Text = "        Завершить смену";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // usr_btn
            // 
            this.usr_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.usr_btn.FlatAppearance.BorderSize = 0;
            this.usr_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usr_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usr_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.usr_btn.Image = global::diplom.Properties.Resources.users_icon;
            this.usr_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usr_btn.Location = new System.Drawing.Point(1, 126);
            this.usr_btn.Name = "usr_btn";
            this.usr_btn.Size = new System.Drawing.Size(177, 44);
            this.usr_btn.TabIndex = 5;
            this.usr_btn.Text = "       Пользователи";
            this.usr_btn.UseVisualStyleBackColor = false;
            this.usr_btn.Click += new System.EventHandler(this.usr_btn_Click);
            // 
            // order_btn
            // 
            this.order_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.order_btn.FlatAppearance.BorderSize = 0;
            this.order_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.order_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.order_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.order_btn.Image = global::diplom.Properties.Resources.orders_icon;
            this.order_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.order_btn.Location = new System.Drawing.Point(1, 126);
            this.order_btn.Name = "order_btn";
            this.order_btn.Size = new System.Drawing.Size(177, 44);
            this.order_btn.TabIndex = 4;
            this.order_btn.Text = "      Заказы";
            this.order_btn.UseVisualStyleBackColor = false;
            this.order_btn.Click += new System.EventHandler(this.order_btn_Click);
            // 
            // note_btn
            // 
            this.note_btn.FlatAppearance.BorderSize = 0;
            this.note_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.note_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.note_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.note_btn.Image = global::diplom.Properties.Resources.notes_icon;
            this.note_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.note_btn.Location = new System.Drawing.Point(1, 85);
            this.note_btn.Name = "note_btn";
            this.note_btn.Size = new System.Drawing.Size(177, 35);
            this.note_btn.TabIndex = 3;
            this.note_btn.Text = "      Заметки";
            this.note_btn.UseVisualStyleBackColor = true;
            this.note_btn.Click += new System.EventHandler(this.note_btn_Click);
            // 
            // items_btn
            // 
            this.items_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(45)))));
            this.items_btn.FlatAppearance.BorderSize = 0;
            this.items_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.items_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.items_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.items_btn.Image = global::diplom.Properties.Resources.cart_icon;
            this.items_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.items_btn.Location = new System.Drawing.Point(1, 44);
            this.items_btn.Name = "items_btn";
            this.items_btn.Size = new System.Drawing.Size(177, 35);
            this.items_btn.TabIndex = 1;
            this.items_btn.Text = "      Товары";
            this.items_btn.UseVisualStyleBackColor = false;
            // 
            // sidebar_btn
            // 
            this.sidebar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.sidebar_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sidebar_btn.FlatAppearance.BorderSize = 0;
            this.sidebar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sidebar_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sidebar_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.sidebar_btn.Image = global::diplom.Properties.Resources.menu_icon;
            this.sidebar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sidebar_btn.Location = new System.Drawing.Point(1, 3);
            this.sidebar_btn.MaximumSize = new System.Drawing.Size(177, 35);
            this.sidebar_btn.MinimumSize = new System.Drawing.Size(50, 35);
            this.sidebar_btn.Name = "sidebar_btn";
            this.sidebar_btn.Size = new System.Drawing.Size(177, 35);
            this.sidebar_btn.TabIndex = 2;
            this.sidebar_btn.Text = "        Art Coworking";
            this.sidebar_btn.UseVisualStyleBackColor = false;
            this.sidebar_btn.Click += new System.EventHandler(this.sidebar_btn_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "image";
            this.dataGridViewImageColumn1.HeaderText = "image";
            this.dataGridViewImageColumn1.Image = global::diplom.Properties.Resources.default_photo;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 140;
            // 
            // menu_timer
            // 
            this.menu_timer.Interval = 10;
            this.menu_timer.Tick += new System.EventHandler(this.menu_timer_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.price_tB);
            this.panel2.Location = new System.Drawing.Point(203, 415);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(44, 23);
            this.panel2.TabIndex = 30;
            this.panel2.Visible = false;
            // 
            // price_tB
            // 
            this.price_tB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.price_tB.Cue = "";
            this.price_tB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_tB.Location = new System.Drawing.Point(4, 3);
            this.price_tB.Name = "price_tB";
            this.price_tB.Size = new System.Drawing.Size(37, 18);
            this.price_tB.TabIndex = 32;
            this.price_tB.Visible = false;
            this.price_tB.TextChanged += new System.EventHandler(this.price_tB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(223)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.label2.Location = new System.Drawing.Point(253, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "руб/мин";
            this.label2.Visible = false;
            // 
            // order_cB
            // 
            this.order_cB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.order_cB.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.order_cB.FormattingEnabled = true;
            this.order_cB.Items.AddRange(new object[] {
            "По умолчанию",
            "По возрастанию цены",
            "По убыванию цены"});
            this.order_cB.Location = new System.Drawing.Point(379, 15);
            this.order_cB.Name = "order_cB";
            this.order_cB.Size = new System.Drawing.Size(148, 21);
            this.order_cB.TabIndex = 34;
            this.order_cB.Text = "По умолчанию";
            this.order_cB.TextChanged += new System.EventHandler(this.order_cB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(223)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(300, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Сортировка";
            // 
            // save_tarif_btn
            // 
            this.save_tarif_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.save_tarif_btn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_tarif_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.save_tarif_btn.Location = new System.Drawing.Point(315, 416);
            this.save_tarif_btn.Name = "save_tarif_btn";
            this.save_tarif_btn.Radius = 10;
            this.save_tarif_btn.Size = new System.Drawing.Size(73, 22);
            this.save_tarif_btn.TabIndex = 33;
            this.save_tarif_btn.Text = "Сохранить";
            this.save_tarif_btn.UseVisualStyleBackColor = false;
            this.save_tarif_btn.Visible = false;
            this.save_tarif_btn.Click += new System.EventHandler(this.save_tarif_btn_Click);
            // 
            // create_btn
            // 
            this.create_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.create_btn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.create_btn.Location = new System.Drawing.Point(457, 416);
            this.create_btn.Name = "create_btn";
            this.create_btn.Radius = 10;
            this.create_btn.Size = new System.Drawing.Size(70, 22);
            this.create_btn.TabIndex = 6;
            this.create_btn.Text = "Создать";
            this.create_btn.UseVisualStyleBackColor = false;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // change_tarif_btn
            // 
            this.change_tarif_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.change_tarif_btn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_tarif_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.change_tarif_btn.Location = new System.Drawing.Point(81, 416);
            this.change_tarif_btn.Name = "change_tarif_btn";
            this.change_tarif_btn.Radius = 10;
            this.change_tarif_btn.Size = new System.Drawing.Size(110, 22);
            this.change_tarif_btn.TabIndex = 8;
            this.change_tarif_btn.Text = "Изменить тариф";
            this.change_tarif_btn.UseVisualStyleBackColor = false;
            this.change_tarif_btn.Click += new System.EventHandler(this.change_tarif_btn_Click);
            // 
            // Goods_adm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.order_cB);
            this.Controls.Add(this.save_tarif_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.change_tarif_btn);
            this.Controls.Add(this.goods_GV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Goods_adm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товары";
            ((System.ComponentModel.ISupportInitialize)(this.goods_GV)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView goods_GV;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private Button order_btn;
        private Button note_btn;
        private Button items_btn;
        private Button sidebar_btn;
        private Timer menu_timer;
        private Button usr_btn;
        private Button exit_btn;
        private Controls.RoundBtn create_btn;
        private Controls.RoundBtn change_tarif_btn;
        private Panel panel2;
        private CueTextbox price_tB;
        private Label label2;
        private Controls.RoundBtn save_tarif_btn;
        private ComboBox order_cB;
        private Label label1;
        private Button log_btn;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn image;
        private DataGridViewImageColumn img;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn cost;
    }
}