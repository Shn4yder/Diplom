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
            this.usr_GV = new System.Windows.Forms.DataGridView();
            this.Add_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.good_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.note_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usr_GV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usr_GV
            // 
            this.usr_GV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.usr_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usr_GV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fio,
            this.status,
            this.phone,
            this.email,
            this.login,
            this.password});
            this.usr_GV.Location = new System.Drawing.Point(23, 27);
            this.usr_GV.Name = "usr_GV";
            this.usr_GV.RowHeadersVisible = false;
            this.usr_GV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usr_GV.Size = new System.Drawing.Size(745, 362);
            this.usr_GV.TabIndex = 0;
            this.usr_GV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usr_GV_CellDoubleClick);
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(345, 415);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(75, 23);
            this.Add_btn.TabIndex = 1;
            this.Add_btn.Text = "+  Создать    ";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.good_MenuItem,
            this.note_MenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // good_MenuItem
            // 
            this.good_MenuItem.Name = "good_MenuItem";
            this.good_MenuItem.Size = new System.Drawing.Size(60, 20);
            this.good_MenuItem.Text = "Товары";
            this.good_MenuItem.Click += new System.EventHandler(this.good_MenuItem_Click);
            // 
            // note_MenuItem
            // 
            this.note_MenuItem.Name = "note_MenuItem";
            this.note_MenuItem.Size = new System.Drawing.Size(65, 20);
            this.note_MenuItem.Text = "Заметки";
            this.note_MenuItem.Click += new System.EventHandler(this.note_MenuItem_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id_user";
            this.id.HeaderText = "id_usr";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // fio
            // 
            this.fio.DataPropertyName = "FIO";
            this.fio.HeaderText = "ФИО ";
            this.fio.Name = "fio";
            this.fio.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "Status";
            this.status.HeaderText = "Должность";
            this.status.Name = "status";
            this.status.ReadOnly = true;
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
            // 
            // login
            // 
            this.login.DataPropertyName = "Login";
            this.login.HeaderText = "Логин";
            this.login.Name = "login";
            this.login.ReadOnly = true;
            // 
            // password
            // 
            this.password.DataPropertyName = "Password";
            this.password.HeaderText = "Пароль";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.usr_GV);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Users";
            this.Text = "Пользователи";
            ((System.ComponentModel.ISupportInitialize)(this.usr_GV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView usr_GV;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem good_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem note_MenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
    }
}