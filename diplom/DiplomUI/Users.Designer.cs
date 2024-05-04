namespace diplom
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.usr_GV = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Key = new System.Windows.Forms.DataGridViewImageColumn();
            this.Iv = new System.Windows.Forms.DataGridViewImageColumn();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logs_btn = new System.Windows.Forms.Button();
            this.sidebar_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.usr_btn = new System.Windows.Forms.Button();
            this.note_btn = new System.Windows.Forms.Button();
            this.items_btn = new System.Windows.Forms.Button();
            this.menu_timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.create_btn = new diplom.Controls.RoundBtn();
            ((System.ComponentModel.ISupportInitialize)(this.usr_GV)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // usr_GV
            // 
            this.usr_GV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.usr_GV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usr_GV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.usr_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usr_GV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fio,
            this.status,
            this.phone,
            this.email,
            this.login,
            this.password,
            this.Key,
            this.Iv});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usr_GV.DefaultCellStyle = dataGridViewCellStyle2;
            this.usr_GV.Location = new System.Drawing.Point(83, 37);
            this.usr_GV.Name = "usr_GV";
            this.usr_GV.RowHeadersVisible = false;
            this.usr_GV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usr_GV.Size = new System.Drawing.Size(630, 357);
            this.usr_GV.TabIndex = 0;
            this.usr_GV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usr_GV_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id_user";
            this.id.HeaderText = "id_usr";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // fio
            // 
            this.fio.DataPropertyName = "FIO";
            this.fio.HeaderText = "ФИО ";
            this.fio.Name = "fio";
            this.fio.ReadOnly = true;
            this.fio.Width = 250;
            // 
            // status
            // 
            this.status.DataPropertyName = "Status";
            this.status.HeaderText = "Должность";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 130;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "Phone";
            this.phone.HeaderText = "Телефон";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 148;
            // 
            // login
            // 
            this.login.DataPropertyName = "Login";
            this.login.HeaderText = "Логин";
            this.login.Name = "login";
            this.login.ReadOnly = true;
            this.login.Visible = false;
            // 
            // password
            // 
            this.password.DataPropertyName = "Password";
            this.password.HeaderText = "Пароль";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Visible = false;
            // 
            // Key
            // 
            this.Key.DataPropertyName = "Key";
            this.Key.HeaderText = "Key";
            this.Key.Name = "Key";
            this.Key.ReadOnly = true;
            this.Key.Visible = false;
            // 
            // Iv
            // 
            this.Iv.DataPropertyName = "Iv";
            this.Iv.HeaderText = "Iv";
            this.Iv.Name = "Iv";
            this.Iv.ReadOnly = true;
            this.Iv.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Iv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Iv.Visible = false;
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
            this.sidebar.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.logs_btn);
            this.panel1.Controls.Add(this.sidebar_btn);
            this.panel1.Controls.Add(this.exit_btn);
            this.panel1.Controls.Add(this.usr_btn);
            this.panel1.Controls.Add(this.note_btn);
            this.panel1.Controls.Add(this.items_btn);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 447);
            this.panel1.TabIndex = 1;
            // 
            // logs_btn
            // 
            this.logs_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.logs_btn.FlatAppearance.BorderSize = 0;
            this.logs_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logs_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logs_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.logs_btn.Image = global::diplom.Properties.Resources.logicon;
            this.logs_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logs_btn.Location = new System.Drawing.Point(1, 168);
            this.logs_btn.Name = "logs_btn";
            this.logs_btn.Size = new System.Drawing.Size(177, 47);
            this.logs_btn.TabIndex = 7;
            this.logs_btn.Text = "Журнал";
            this.logs_btn.UseVisualStyleBackColor = false;
            this.logs_btn.Click += new System.EventHandler(this.logs_btn_Click);
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
            this.sidebar_btn.Text = "  Art Coworking";
            this.sidebar_btn.UseVisualStyleBackColor = false;
            this.sidebar_btn.Click += new System.EventHandler(this.sidebar_btn_Click);
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
            this.exit_btn.TabIndex = 6;
            this.exit_btn.Text = "Выход";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // usr_btn
            // 
            this.usr_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(45)))));
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
            this.usr_btn.Text = "   Пользователи";
            this.usr_btn.UseVisualStyleBackColor = false;
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
            this.note_btn.Text = "Заметки";
            this.note_btn.UseVisualStyleBackColor = true;
            this.note_btn.Click += new System.EventHandler(this.note_btn_Click);
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
            this.items_btn.Text = "Товары";
            this.items_btn.UseVisualStyleBackColor = true;
            this.items_btn.Click += new System.EventHandler(this.items_btn_Click);
            // 
            // menu_timer
            // 
            this.menu_timer.Interval = 10;
            this.menu_timer.Tick += new System.EventHandler(this.menu_timer_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::diplom.Properties.Resources.background_img;
            this.pictureBox2.Location = new System.Drawing.Point(66, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(665, 432);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // create_btn
            // 
            this.create_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.create_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(199)))), ((int)(((byte)(184)))));
            this.create_btn.FlatAppearance.BorderSize = 2;
            this.create_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_btn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.create_btn.Location = new System.Drawing.Point(348, 400);
            this.create_btn.Name = "create_btn";
            this.create_btn.Radius = 10;
            this.create_btn.Size = new System.Drawing.Size(79, 24);
            this.create_btn.TabIndex = 26;
            this.create_btn.Text = "Создать";
            this.create_btn.UseVisualStyleBackColor = false;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(748, 450);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.usr_GV);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пользователи";
            ((System.ComponentModel.ISupportInitialize)(this.usr_GV)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView usr_GV;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button usr_btn;
        private System.Windows.Forms.Button note_btn;
        private System.Windows.Forms.Button items_btn;
        private System.Windows.Forms.Button sidebar_btn;
        private System.Windows.Forms.Timer menu_timer;
        private Controls.RoundBtn create_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewImageColumn Key;
        private System.Windows.Forms.DataGridViewImageColumn Iv;
        private System.Windows.Forms.Button logs_btn;
    }
}