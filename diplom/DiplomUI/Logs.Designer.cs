namespace diplom.DiplomUI
{
    partial class Logs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logs));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.log_btn = new System.Windows.Forms.Button();
            this.sidebar_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.usr_btn = new System.Windows.Forms.Button();
            this.note_btn = new System.Windows.Forms.Button();
            this.items_btn = new System.Windows.Forms.Button();
            this.log_GV = new System.Windows.Forms.DataGridView();
            this.Id_log = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_log = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event_log = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cause = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.system = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Key = new System.Windows.Forms.DataGridViewImageColumn();
            this.Iv = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menu_timer = new System.Windows.Forms.Timer(this.components);
            this.delete_btn = new diplom.Controls.RoundBtn();
            this.excel_btn = new diplom.Controls.RoundBtn();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.log_GV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            this.sidebar.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.log_btn);
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
            // log_btn
            // 
            this.log_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(69)))), ((int)(((byte)(45)))));
            this.log_btn.FlatAppearance.BorderSize = 0;
            this.log_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.log_btn.Image = global::diplom.Properties.Resources.logicon;
            this.log_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.log_btn.Location = new System.Drawing.Point(1, 176);
            this.log_btn.Name = "log_btn";
            this.log_btn.Size = new System.Drawing.Size(177, 45);
            this.log_btn.TabIndex = 7;
            this.log_btn.Text = "        Журнал событий";
            this.log_btn.UseVisualStyleBackColor = false;
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
            this.exit_btn.Text = "      Выход";
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
            // log_GV
            // 
            this.log_GV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.log_GV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.log_GV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.log_GV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.log_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.log_GV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_log,
            this.date_log,
            this.event_log,
            this.cause,
            this.User,
            this.system,
            this.Key,
            this.Iv});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.log_GV.DefaultCellStyle = dataGridViewCellStyle2;
            this.log_GV.Location = new System.Drawing.Point(84, 28);
            this.log_GV.Name = "log_GV";
            this.log_GV.RowHeadersVisible = false;
            this.log_GV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.log_GV.Size = new System.Drawing.Size(630, 366);
            this.log_GV.TabIndex = 31;
            // 
            // Id_log
            // 
            this.Id_log.DataPropertyName = "Id_log";
            this.Id_log.HeaderText = "№";
            this.Id_log.Name = "Id_log";
            this.Id_log.ReadOnly = true;
            this.Id_log.Width = 40;
            // 
            // date_log
            // 
            this.date_log.DataPropertyName = "Date_log";
            this.date_log.FillWeight = 70F;
            this.date_log.HeaderText = "Дата";
            this.date_log.Name = "date_log";
            this.date_log.ReadOnly = true;
            this.date_log.Width = 70;
            // 
            // event_log
            // 
            this.event_log.DataPropertyName = "Event";
            this.event_log.HeaderText = "Событие";
            this.event_log.Name = "event_log";
            this.event_log.ReadOnly = true;
            this.event_log.Width = 220;
            // 
            // cause
            // 
            this.cause.DataPropertyName = "Cause";
            this.cause.HeaderText = "Причина";
            this.cause.Name = "cause";
            this.cause.ReadOnly = true;
            this.cause.Width = 120;
            // 
            // User
            // 
            this.User.DataPropertyName = "User";
            this.User.HeaderText = "Пользователь";
            this.User.Name = "User";
            // 
            // system
            // 
            this.system.DataPropertyName = "System";
            this.system.HeaderText = "Система";
            this.system.Name = "system";
            this.system.ReadOnly = true;
            this.system.Width = 60;
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
            // pictureBox2
            // 
            this.pictureBox2.Image = global::diplom.Properties.Resources.background_img;
            this.pictureBox2.Location = new System.Drawing.Point(67, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(665, 432);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // menu_timer
            // 
            this.menu_timer.Interval = 10;
            this.menu_timer.Tick += new System.EventHandler(this.menu_timer_Tick);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.delete_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(199)))), ((int)(((byte)(184)))));
            this.delete_btn.FlatAppearance.BorderSize = 2;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.delete_btn.Location = new System.Drawing.Point(464, 406);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Radius = 10;
            this.delete_btn.Size = new System.Drawing.Size(79, 24);
            this.delete_btn.TabIndex = 33;
            this.delete_btn.Text = "Очистить";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // excel_btn
            // 
            this.excel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.excel_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(199)))), ((int)(((byte)(184)))));
            this.excel_btn.FlatAppearance.BorderSize = 2;
            this.excel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excel_btn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.excel_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.excel_btn.Location = new System.Drawing.Point(203, 406);
            this.excel_btn.Name = "excel_btn";
            this.excel_btn.Radius = 10;
            this.excel_btn.Size = new System.Drawing.Size(105, 24);
            this.excel_btn.TabIndex = 36;
            this.excel_btn.Text = "Открыть в Excel";
            this.excel_btn.UseVisualStyleBackColor = false;
            this.excel_btn.Click += new System.EventHandler(this.excel_btn_Click);
            // 
            // Logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.excel_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.log_GV);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Logs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Журнал событий";
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.log_GV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.RoundBtn delete_btn;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button sidebar_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button usr_btn;
        private System.Windows.Forms.Button note_btn;
        private System.Windows.Forms.Button items_btn;
        private System.Windows.Forms.DataGridView log_GV;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button log_btn;
        private System.Windows.Forms.Timer menu_timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_log;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_log;
        private System.Windows.Forms.DataGridViewTextBoxColumn event_log;
        private System.Windows.Forms.DataGridViewTextBoxColumn cause;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn system;
        private System.Windows.Forms.DataGridViewImageColumn Key;
        private System.Windows.Forms.DataGridViewImageColumn Iv;
        private Controls.RoundBtn excel_btn;
    }
}