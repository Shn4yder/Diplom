using System.Windows.Forms;

namespace diplom
{
    partial class Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.orders_GV = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_usr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidebar_btn = new System.Windows.Forms.Button();
            this.items_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.order_btn = new System.Windows.Forms.Button();
            this.note_btn = new System.Windows.Forms.Button();
            this.menu_timer = new System.Windows.Forms.Timer(this.components);
            this.create_btn = new diplom.Controls.RoundBtn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.orders_GV)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // orders_GV
            // 
            this.orders_GV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.orders_GV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.orders_GV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orders_GV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.orders_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orders_GV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.number,
            this.name,
            this.counter,
            this.start,
            this.comm,
            this.id_usr});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orders_GV.DefaultCellStyle = dataGridViewCellStyle2;
            this.orders_GV.Location = new System.Drawing.Point(80, 47);
            this.orders_GV.MultiSelect = false;
            this.orders_GV.Name = "orders_GV";
            this.orders_GV.RowHeadersVisible = false;
            this.orders_GV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orders_GV.Size = new System.Drawing.Size(558, 350);
            this.orders_GV.TabIndex = 3;
            this.orders_GV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orders_GV_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id_order";
            this.id.HeaderText = "id_order";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // number
            // 
            this.number.DataPropertyName = "Number";
            this.number.HeaderText = "   Номер";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "    Имя";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 130;
            // 
            // counter
            // 
            this.counter.DataPropertyName = "Counter";
            this.counter.HeaderText = "Кол-во";
            this.counter.Name = "counter";
            this.counter.ReadOnly = true;
            this.counter.Width = 50;
            // 
            // start
            // 
            this.start.DataPropertyName = "Time_start";
            this.start.HeaderText = "     Начат в ";
            this.start.Name = "start";
            this.start.ReadOnly = true;
            this.start.Width = 110;
            // 
            // comm
            // 
            this.comm.DataPropertyName = "Comment";
            this.comm.HeaderText = "      Коментарий";
            this.comm.Name = "comm";
            this.comm.ReadOnly = true;
            this.comm.Width = 167;
            // 
            // id_usr
            // 
            this.id_usr.DataPropertyName = "Id_user";
            this.id_usr.HeaderText = "id_user";
            this.id_usr.Name = "id_usr";
            this.id_usr.ReadOnly = true;
            this.id_usr.Visible = false;
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
            this.sidebar.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.sidebar_btn);
            this.panel1.Controls.Add(this.items_btn);
            this.panel1.Controls.Add(this.exit_btn);
            this.panel1.Controls.Add(this.order_btn);
            this.panel1.Controls.Add(this.note_btn);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 447);
            this.panel1.TabIndex = 1;
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
            this.sidebar_btn.Name = "sidebar_btn";
            this.sidebar_btn.Size = new System.Drawing.Size(177, 35);
            this.sidebar_btn.TabIndex = 2;
            this.sidebar_btn.Text = "        Art Coworking";
            this.sidebar_btn.UseVisualStyleBackColor = false;
            this.sidebar_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // items_btn
            // 
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
            this.items_btn.UseVisualStyleBackColor = true;
            this.items_btn.Click += new System.EventHandler(this.items_btn_Click);
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
            this.exit_btn.Location = new System.Drawing.Point(1, 403);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(177, 44);
            this.exit_btn.TabIndex = 5;
            this.exit_btn.Text = "        Завершить смену";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // order_btn
            // 
            this.order_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(45)))));
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
            // menu_timer
            // 
            this.menu_timer.Interval = 10;
            this.menu_timer.Tick += new System.EventHandler(this.menu_timer_Tick);
            // 
            // create_btn
            // 
            this.create_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.create_btn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.create_btn.Location = new System.Drawing.Point(319, 403);
            this.create_btn.Name = "create_btn";
            this.create_btn.Radius = 10;
            this.create_btn.Size = new System.Drawing.Size(79, 24);
            this.create_btn.TabIndex = 25;
            this.create_btn.Text = "Создать";
            this.create_btn.UseVisualStyleBackColor = false;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::diplom.Properties.Resources.background_img;
            this.pictureBox1.Location = new System.Drawing.Point(68, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(584, 421);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.orders_GV);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы";
            ((System.ComponentModel.ISupportInitialize)(this.orders_GV)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView orders_GV;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button items_btn;
        private System.Windows.Forms.Button sidebar_btn;
        private System.Windows.Forms.Timer menu_timer;
        private System.Windows.Forms.Button note_btn;
        private System.Windows.Forms.Button order_btn;
        private System.Windows.Forms.Button exit_btn;
        private Controls.RoundBtn create_btn;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn number;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn counter;
        private DataGridViewTextBoxColumn start;
        private DataGridViewTextBoxColumn comm;
        private DataGridViewTextBoxColumn id_usr;
        private PictureBox pictureBox1;
    }
}