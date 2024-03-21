namespace diplom
{
    partial class Notes
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.order_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.good_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.note_GV = new System.Windows.Forms.DataGridView();
            this.id_note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add_btn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.note_GV)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.order_MenuItem,
            this.good_MenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // order_MenuItem
            // 
            this.order_MenuItem.Name = "order_MenuItem";
            this.order_MenuItem.Size = new System.Drawing.Size(58, 20);
            this.order_MenuItem.Text = "Заказы";
            this.order_MenuItem.Click += new System.EventHandler(this.order_MenuItem_Click);
            // 
            // good_MenuItem
            // 
            this.good_MenuItem.Name = "good_MenuItem";
            this.good_MenuItem.Size = new System.Drawing.Size(60, 20);
            this.good_MenuItem.Text = "Товары";
            this.good_MenuItem.Click += new System.EventHandler(this.good_MenuItem_Click);
            // 
            // note_GV
            // 
            this.note_GV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.note_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.note_GV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_note,
            this.name,
            this.phone,
            this.place,
            this.comment,
            this.date,
            this.fio,
            this.id_user});
            this.note_GV.Location = new System.Drawing.Point(24, 38);
            this.note_GV.MultiSelect = false;
            this.note_GV.Name = "note_GV";
            this.note_GV.RowHeadersVisible = false;
            this.note_GV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.note_GV.Size = new System.Drawing.Size(744, 371);
            this.note_GV.TabIndex = 2;
            this.note_GV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.note_GV_CellDoubleClick);
            // 
            // id_note
            // 
            this.id_note.DataPropertyName = "Id_note";
            this.id_note.HeaderText = "id";
            this.id_note.Name = "id_note";
            this.id_note.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Имя";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "Phone";
            this.phone.HeaderText = "Телефон";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // place
            // 
            this.place.DataPropertyName = "Place";
            this.place.HeaderText = "Место/стол";
            this.place.Name = "place";
            this.place.ReadOnly = true;
            // 
            // comment
            // 
            this.comment.DataPropertyName = "Comment";
            this.comment.HeaderText = "Комментарий";
            this.comment.Name = "comment";
            this.comment.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "Date_add";
            this.date.HeaderText = "Добавлено в ";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // fio
            // 
            this.fio.DataPropertyName = "Fio";
            this.fio.HeaderText = "Пользователь";
            this.fio.Name = "fio";
            this.fio.ReadOnly = true;
            // 
            // id_user
            // 
            this.id_user.DataPropertyName = "Id_user";
            this.id_user.HeaderText = "id_user";
            this.id_user.Name = "id_user";
            this.id_user.ReadOnly = true;
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(361, 415);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(75, 23);
            this.Add_btn.TabIndex = 3;
            this.Add_btn.Text = "+  Cоздать";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.note_GV);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Notes";
            this.Text = "Заметки";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.note_GV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem order_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem good_MenuItem;
        private System.Windows.Forms.DataGridView note_GV;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_note;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn place;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_user;
    }
}