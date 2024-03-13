namespace diplom
{
    partial class Goods_emp
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
            this.search_tB = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.order_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.note_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goods_GV = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goods_GV)).BeginInit();
            this.SuspendLayout();
            // 
            // search_tB
            // 
            this.search_tB.Location = new System.Drawing.Point(516, 39);
            this.search_tB.Name = "search_tB";
            this.search_tB.Size = new System.Drawing.Size(226, 20);
            this.search_tB.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.order_MenuItem,
            this.note_MenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(788, 24);
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
            // note_MenuItem
            // 
            this.note_MenuItem.Name = "note_MenuItem";
            this.note_MenuItem.Size = new System.Drawing.Size(65, 20);
            this.note_MenuItem.Text = "Заметки";
            this.note_MenuItem.Click += new System.EventHandler(this.note_MenuItem_Click);
            // 
            // goods_GV
            // 
            this.goods_GV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.goods_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goods_GV.Location = new System.Drawing.Point(31, 79);
            this.goods_GV.Name = "goods_GV";
            this.goods_GV.Size = new System.Drawing.Size(720, 341);
            this.goods_GV.TabIndex = 2;
            // 
            // Goods_emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.goods_GV);
            this.Controls.Add(this.search_tB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Goods_emp";
            this.Text = "Товары";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goods_GV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox search_tB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem order_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem note_MenuItem;
        private System.Windows.Forms.DataGridView goods_GV;
    }
}