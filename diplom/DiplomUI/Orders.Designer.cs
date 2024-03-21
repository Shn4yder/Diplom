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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.good_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.note_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_btn = new System.Windows.Forms.Button();
            this.orders_GV = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_usr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orders_GV)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.good_MenuItem,
            this.note_MenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(773, 24);
            this.menuStrip1.TabIndex = 0;
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
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(336, 415);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(75, 23);
            this.Add_btn.TabIndex = 2;
            this.Add_btn.Text = "+ Создать";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // orders_GV
            // 
            this.orders_GV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.orders_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orders_GV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.number,
            this.name,
            this.counter,
            this.start,
            this.comm,
            this.id_usr});
            this.orders_GV.Location = new System.Drawing.Point(24, 47);
            this.orders_GV.MultiSelect = false;
            this.orders_GV.Name = "orders_GV";
            this.orders_GV.RowHeadersVisible = false;
            this.orders_GV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orders_GV.Size = new System.Drawing.Size(723, 334);
            this.orders_GV.TabIndex = 3;
            this.orders_GV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orders_GV_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id_order";
            this.id.HeaderText = "id_order";
            this.id.Name = "id";
            // 
            // number
            // 
            this.number.DataPropertyName = "Number";
            this.number.HeaderText = "Номер";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Имя";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // counter
            // 
            this.counter.DataPropertyName = "Counter";
            this.counter.HeaderText = "Кол-во";
            this.counter.Name = "counter";
            this.counter.ReadOnly = true;
            // 
            // start
            // 
            this.start.DataPropertyName = "Time_start";
            this.start.HeaderText = "Начат в ";
            this.start.Name = "start";
            this.start.ReadOnly = true;
            // 
            // comm
            // 
            this.comm.DataPropertyName = "Comment";
            this.comm.HeaderText = "Коментарий";
            this.comm.Name = "comm";
            this.comm.ReadOnly = true;
            // 
            // id_usr
            // 
            this.id_usr.DataPropertyName = "Id_user";
            this.id_usr.HeaderText = "id_user";
            this.id_usr.Name = "id_usr";
            this.id_usr.ReadOnly = true;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.orders_GV);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Orders";
            this.Text = "Заказы";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orders_GV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem good_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem note_MenuItem;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.DataGridView orders_GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn counter;
        private System.Windows.Forms.DataGridViewTextBoxColumn start;
        private System.Windows.Forms.DataGridViewTextBoxColumn comm;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usr;
    }
}