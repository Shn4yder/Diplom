using System.Windows.Forms;

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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.user_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.note_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_btn = new System.Windows.Forms.Button();
            this.goods_GV = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goods_GV)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.user_MenuItem,
            this.note_MenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(683, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // user_MenuItem
            // 
            this.user_MenuItem.Name = "user_MenuItem";
            this.user_MenuItem.Size = new System.Drawing.Size(97, 20);
            this.user_MenuItem.Text = "Пользователи";
            this.user_MenuItem.Click += new System.EventHandler(this.user_MenuItem_Click);
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
            this.Add_btn.Location = new System.Drawing.Point(293, 418);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(75, 23);
            this.Add_btn.TabIndex = 2;
            this.Add_btn.Text = "+ Создать";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // goods_GV
            // 
            this.goods_GV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.goods_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goods_GV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.image,
            this.name,
            this.cost});
            this.goods_GV.Location = new System.Drawing.Point(25, 60);
            this.goods_GV.Name = "goods_GV";
            this.goods_GV.Size = new System.Drawing.Size(636, 352);
            this.goods_GV.TabIndex = 3;
            // 
            // id
            // 
            this.id.DataPropertyName = "Id_good";
            this.id.HeaderText = "id_good";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // image
            // 
            this.image.DataPropertyName = "Img";
            this.image.HeaderText = "Фото";
            this.image.Name = "image";
            this.image.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Наименование";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // cost
            // 
            this.cost.DataPropertyName = "Cost";
            this.cost.HeaderText = "Цена";
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            // 
            // Goods_adm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 450);
            this.Controls.Add(this.goods_GV);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Goods_adm";
            this.Text = "Товары";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goods_GV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem user_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem note_MenuItem;
        private System.Windows.Forms.Button Add_btn;
        private DataGridView goods_GV;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn image;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn cost;
    }
}