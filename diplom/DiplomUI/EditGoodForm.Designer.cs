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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditGoodForm));
            this.image_pB = new System.Windows.Forms.PictureBox();
            this.save_btn = new diplom.Controls.RoundBtn();
            this.del_btn = new diplom.Controls.RoundBtn();
            this.add_photo_btn = new diplom.Controls.RoundBtn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.name_tB = new diplom.CueTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cost_tB = new diplom.CueTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.PictureBox();
            this.name_lbl = new System.Windows.Forms.Label();
            this.price_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image_pB)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // image_pB
            // 
            this.image_pB.Image = global::diplom.Properties.Resources.default_photo;
            this.image_pB.Location = new System.Drawing.Point(172, 64);
            this.image_pB.Name = "image_pB";
            this.image_pB.Size = new System.Drawing.Size(131, 101);
            this.image_pB.TabIndex = 8;
            this.image_pB.TabStop = false;
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.save_btn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.save_btn.Location = new System.Drawing.Point(167, 181);
            this.save_btn.Name = "save_btn";
            this.save_btn.Radius = 10;
            this.save_btn.Size = new System.Drawing.Size(136, 24);
            this.save_btn.TabIndex = 17;
            this.save_btn.Text = "Сохранить изменения";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.del_btn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.del_btn.Location = new System.Drawing.Point(18, 181);
            this.del_btn.Name = "del_btn";
            this.del_btn.Radius = 10;
            this.del_btn.Size = new System.Drawing.Size(72, 24);
            this.del_btn.TabIndex = 16;
            this.del_btn.Text = "Удалить";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // add_photo_btn
            // 
            this.add_photo_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.add_photo_btn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_photo_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.add_photo_btn.Location = new System.Drawing.Point(18, 141);
            this.add_photo_btn.Name = "add_photo_btn";
            this.add_photo_btn.Radius = 10;
            this.add_photo_btn.Size = new System.Drawing.Size(100, 24);
            this.add_photo_btn.TabIndex = 15;
            this.add_photo_btn.Text = "Выбрать фото";
            this.add_photo_btn.UseVisualStyleBackColor = false;
            this.add_photo_btn.Click += new System.EventHandler(this.add_photo_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.name_tB);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 23);
            this.panel1.TabIndex = 18;
            // 
            // name_tB
            // 
            this.name_tB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_tB.Cue = "Наименование";
            this.name_tB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_tB.Location = new System.Drawing.Point(3, 2);
            this.name_tB.Name = "name_tB";
            this.name_tB.Size = new System.Drawing.Size(285, 18);
            this.name_tB.TabIndex = 30;
            this.name_tB.TextChanged += new System.EventHandler(this.name_tB_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cost_tB);
            this.panel2.Location = new System.Drawing.Point(12, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(90, 23);
            this.panel2.TabIndex = 19;
            // 
            // cost_tB
            // 
            this.cost_tB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cost_tB.Cue = "Стоимость";
            this.cost_tB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost_tB.Location = new System.Drawing.Point(3, 2);
            this.cost_tB.Name = "cost_tB";
            this.cost_tB.Size = new System.Drawing.Size(84, 18);
            this.cost_tB.TabIndex = 30;
            this.cost_tB.TextChanged += new System.EventHandler(this.cost_tB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(108, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "руб.";
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(160)))), ((int)(((byte)(128)))));
            this.back_btn.Image = ((System.Drawing.Image)(resources.GetObject("back_btn.Image")));
            this.back_btn.Location = new System.Drawing.Point(15, 7);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(20, 22);
            this.back_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.back_btn.TabIndex = 25;
            this.back_btn.TabStop = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_lbl.ForeColor = System.Drawing.Color.DarkRed;
            this.name_lbl.Location = new System.Drawing.Point(306, 37);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(17, 24);
            this.name_lbl.TabIndex = 31;
            this.name_lbl.Text = "*";
            this.name_lbl.Visible = false;
            // 
            // price_lbl
            // 
            this.price_lbl.AutoSize = true;
            this.price_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_lbl.ForeColor = System.Drawing.Color.DarkRed;
            this.price_lbl.Location = new System.Drawing.Point(144, 79);
            this.price_lbl.Name = "price_lbl";
            this.price_lbl.Size = new System.Drawing.Size(17, 24);
            this.price_lbl.TabIndex = 32;
            this.price_lbl.Text = "*";
            this.price_lbl.Visible = false;
            // 
            // EditGoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(332, 223);
            this.Controls.Add(this.price_lbl);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.add_photo_btn);
            this.Controls.Add(this.image_pB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditGoodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение товара";
            ((System.ComponentModel.ISupportInitialize)(this.image_pB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox image_pB;
        private Controls.RoundBtn add_photo_btn;
        private Controls.RoundBtn del_btn;
        private Controls.RoundBtn save_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox back_btn;
        private CueTextbox name_tB;
        private CueTextbox cost_tB;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label price_lbl;
    }
}