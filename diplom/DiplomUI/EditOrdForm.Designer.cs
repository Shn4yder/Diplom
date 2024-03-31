namespace diplom
{
    partial class EditOrdForm
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
            this.name_tB = new System.Windows.Forms.TextBox();
            this.ppl_UpDown = new System.Windows.Forms.NumericUpDown();
            this.comment_tB = new System.Windows.Forms.RichTextBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numb_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.order_timer = new System.Windows.Forms.Timer(this.components);
            this.time_lbl = new System.Windows.Forms.Label();
            this.goods_GV = new System.Windows.Forms.DataGridView();
            this.id_good = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image_path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo = new System.Windows.Forms.DataGridViewImageColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cart_GV = new System.Windows.Forms.DataGridView();
            this.id_cart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.good_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ppl_UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goods_GV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cart_GV)).BeginInit();
            this.SuspendLayout();
            // 
            // name_tB
            // 
            this.name_tB.Location = new System.Drawing.Point(62, 45);
            this.name_tB.Name = "name_tB";
            this.name_tB.Size = new System.Drawing.Size(201, 20);
            this.name_tB.TabIndex = 0;
            // 
            // ppl_UpDown
            // 
            this.ppl_UpDown.Location = new System.Drawing.Point(143, 80);
            this.ppl_UpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ppl_UpDown.Name = "ppl_UpDown";
            this.ppl_UpDown.Size = new System.Drawing.Size(75, 20);
            this.ppl_UpDown.TabIndex = 1;
            this.ppl_UpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comment_tB
            // 
            this.comment_tB.Location = new System.Drawing.Point(284, 32);
            this.comment_tB.Name = "comment_tB";
            this.comment_tB.Size = new System.Drawing.Size(203, 96);
            this.comment_tB.TabIndex = 2;
            this.comment_tB.Text = "";
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(12, 328);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 3;
            this.delete_btn.Text = "Удалить";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(336, 328);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(133, 23);
            this.edit_btn.TabIndex = 4;
            this.edit_btn.Text = "Сохранить изменения";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Количество человек";
            // 
            // numb_lbl
            // 
            this.numb_lbl.AutoSize = true;
            this.numb_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numb_lbl.Location = new System.Drawing.Point(9, 9);
            this.numb_lbl.Name = "numb_lbl";
            this.numb_lbl.Size = new System.Drawing.Size(92, 24);
            this.numb_lbl.TabIndex = 7;
            this.numb_lbl.Text = "Заказ № ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Прошло времени";
            // 
            // order_timer
            // 
            this.order_timer.Interval = 1000;
            this.order_timer.Tick += new System.EventHandler(this.order_timer_Tick);
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.Location = new System.Drawing.Point(167, 115);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(35, 13);
            this.time_lbl.TabIndex = 9;
            this.time_lbl.Text = "label4";
            // 
            // goods_GV
            // 
            this.goods_GV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.goods_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goods_GV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_good,
            this.name,
            this.image_path,
            this.photo,
            this.Cost});
            this.goods_GV.Location = new System.Drawing.Point(12, 154);
            this.goods_GV.Name = "goods_GV";
            this.goods_GV.RowHeadersVisible = false;
            this.goods_GV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.goods_GV.Size = new System.Drawing.Size(224, 144);
            this.goods_GV.TabIndex = 10;
            this.goods_GV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.goods_GV_CellDoubleClick);
            // 
            // id_good
            // 
            this.id_good.DataPropertyName = "Id_good";
            this.id_good.HeaderText = "id";
            this.id_good.Name = "id_good";
            this.id_good.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Наименование";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 171;
            // 
            // image_path
            // 
            this.image_path.DataPropertyName = "Img";
            this.image_path.HeaderText = "path";
            this.image_path.Name = "image_path";
            this.image_path.ReadOnly = true;
            this.image_path.Visible = false;
            // 
            // photo
            // 
            this.photo.DataPropertyName = "image";
            this.photo.HeaderText = "photo";
            this.photo.Name = "photo";
            this.photo.ReadOnly = true;
            this.photo.Visible = false;
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "Cost";
            this.Cost.HeaderText = "Цена";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Width = 50;
            // 
            // cart_GV
            // 
            this.cart_GV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.cart_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cart_GV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cart,
            this.good_name,
            this.price});
            this.cart_GV.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.cart_GV.Location = new System.Drawing.Point(256, 154);
            this.cart_GV.Name = "cart_GV";
            this.cart_GV.Size = new System.Drawing.Size(240, 144);
            this.cart_GV.TabIndex = 11;
            // 
            // id_cart
            // 
            this.id_cart.HeaderText = "cart";
            this.id_cart.Name = "id_cart";
            this.id_cart.ReadOnly = true;
            // 
            // good_name
            // 
            this.good_name.HeaderText = "Наименование";
            this.good_name.Name = "good_name";
            this.good_name.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Цена";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // EditOrdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 374);
            this.Controls.Add(this.cart_GV);
            this.Controls.Add(this.goods_GV);
            this.Controls.Add(this.time_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numb_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.comment_tB);
            this.Controls.Add(this.ppl_UpDown);
            this.Controls.Add(this.name_tB);
            this.Name = "EditOrdForm";
            this.Text = "EditOrdForm";
            ((System.ComponentModel.ISupportInitialize)(this.ppl_UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goods_GV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cart_GV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_tB;
        private System.Windows.Forms.NumericUpDown ppl_UpDown;
        private System.Windows.Forms.RichTextBox comment_tB;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numb_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer order_timer;
        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.DataGridView goods_GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_good;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn image_path;
        private System.Windows.Forms.DataGridViewImageColumn photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridView cart_GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cart;
        private System.Windows.Forms.DataGridViewTextBoxColumn good_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}