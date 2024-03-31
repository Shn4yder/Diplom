namespace diplom
{
    partial class EditGoodForm
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
            this.name_tB = new System.Windows.Forms.TextBox();
            this.img_tB = new System.Windows.Forms.TextBox();
            this.cost_tB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.image_pB = new System.Windows.Forms.PictureBox();
            this.img_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.image_pB)).BeginInit();
            this.SuspendLayout();
            // 
            // name_tB
            // 
            this.name_tB.Location = new System.Drawing.Point(108, 12);
            this.name_tB.Name = "name_tB";
            this.name_tB.Size = new System.Drawing.Size(234, 20);
            this.name_tB.TabIndex = 0;
            // 
            // img_tB
            // 
            this.img_tB.Location = new System.Drawing.Point(108, 50);
            this.img_tB.Name = "img_tB";
            this.img_tB.Size = new System.Drawing.Size(234, 20);
            this.img_tB.TabIndex = 1;
            // 
            // cost_tB
            // 
            this.cost_tB.Location = new System.Drawing.Point(108, 91);
            this.cost_tB.Name = "cost_tB";
            this.cost_tB.Size = new System.Drawing.Size(234, 20);
            this.cost_tB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Изображение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Цена";
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(20, 258);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 6;
            this.delete_btn.Text = "Удалить";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(204, 258);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(138, 23);
            this.edit_btn.TabIndex = 7;
            this.edit_btn.Text = "Сохранить изменения";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // image_pB
            // 
            this.image_pB.Image = global::diplom.Properties.Resources.default_photo;
            this.image_pB.Location = new System.Drawing.Point(197, 130);
            this.image_pB.Name = "image_pB";
            this.image_pB.Size = new System.Drawing.Size(131, 101);
            this.image_pB.TabIndex = 8;
            this.image_pB.TabStop = false;
            // 
            // img_btn
            // 
            this.img_btn.Location = new System.Drawing.Point(20, 198);
            this.img_btn.Name = "img_btn";
            this.img_btn.Size = new System.Drawing.Size(100, 23);
            this.img_btn.TabIndex = 9;
            this.img_btn.Text = "Выбрать фото";
            this.img_btn.UseVisualStyleBackColor = true;
            this.img_btn.Click += new System.EventHandler(this.img_btn_Click);
            // 
            // EditGoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 306);
            this.Controls.Add(this.img_btn);
            this.Controls.Add(this.image_pB);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cost_tB);
            this.Controls.Add(this.img_tB);
            this.Controls.Add(this.name_tB);
            this.Name = "EditGoodForm";
            this.Text = "Редактирование";
            ((System.ComponentModel.ISupportInitialize)(this.image_pB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_tB;
        private System.Windows.Forms.TextBox img_tB;
        private System.Windows.Forms.TextBox cost_tB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.PictureBox image_pB;
        private System.Windows.Forms.Button img_btn;
    }
}