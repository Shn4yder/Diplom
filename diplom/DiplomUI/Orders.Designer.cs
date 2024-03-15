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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.good_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.note_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orders_GV = new System.Windows.Forms.DataGridView();
            this.Add_btn = new System.Windows.Forms.Button();
            this.IdOrd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTime_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // orders_GV
            // 
            this.orders_GV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;


            this.orders_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orders_GV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdOrd,
            this.Num_col,
            this.Name_col,
            this.N_col,
            this.DateTime_col,
            this.Comment_col});


            this.orders_GV.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;

            this.orders_GV.Location = new System.Drawing.Point(24, 42);
            this.orders_GV.Name = "orders_GV";
            this.orders_GV.RowHeadersVisible = false;    // отключение поля со звездочкой
            this.orders_GV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;    // выбор всей строки
            this.orders_GV.Size = new System.Drawing.Size(719, 359);
            this.orders_GV.TabIndex = 1;
            this.orders_GV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;   // адаптивная ширина ячеек
            this.orders_GV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
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
            // IdOrd
            // 
            this.IdOrd.HeaderText = "ID";
            this.IdOrd.Name = "IdOrd";
            this.IdOrd.ReadOnly = true;
            this.IdOrd.Visible = false;
            // 
            // Num_col
            // 
            this.Num_col.HeaderText = "Номер";
            this.Num_col.Name = "Num_col";
            this.Num_col.ReadOnly = true;
            this.Num_col.Width = 120;
            // 
            // Name_col
            // 
            this.Name_col.HeaderText = "Имя";
            this.Name_col.Name = "Name_col";
            this.Name_col.ReadOnly = true;
            this.Name_col.Width = 150;
            // 
            // N_col
            // 
            this.N_col.HeaderText = "Кол-во";
            this.N_col.Name = "N_col";
            this.N_col.ReadOnly = true;
            this.N_col.Width = 40;
            // 
            // DateTime_col
            // 
            this.DateTime_col.FillWeight = 200F;
            this.DateTime_col.HeaderText = "Начат в";
            this.DateTime_col.Name = "DateTime_col";
            this.DateTime_col.ReadOnly = true;
            // 
            // Comment_col
            // 
            this.Comment_col.HeaderText = "Комментарий";
            this.Comment_col.Name = "Comment_col";
            this.Comment_col.ReadOnly = true;
            this.Comment_col.Width = 306;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.orders_GV);
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
        private System.Windows.Forms.DataGridView orders_GV;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment_col;
    }
}