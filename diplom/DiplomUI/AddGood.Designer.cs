using System.Drawing;

namespace diplom
{
    partial class AddGood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGood));
            this.image_pB = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name_tB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.price_tB = new System.Windows.Forms.TextBox();
            this.create_btn = new diplom.Controls.RoundBtn();
            this.add_photo = new diplom.Controls.RoundBtn();
            ((System.ComponentModel.ISupportInitialize)(this.image_pB)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // image_pB
            // 
            this.image_pB.Location = new System.Drawing.Point(178, 96);
            this.image_pB.Name = "image_pB";
            this.image_pB.Size = new System.Drawing.Size(150, 100);
            this.image_pB.TabIndex = 0;
            this.image_pB.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Новый товар";
            // 
            // name_tB
            // 
            this.name_tB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_tB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_tB.Location = new System.Drawing.Point(3, 2);
            this.name_tB.Name = "name_tB";
            this.name_tB.Size = new System.Drawing.Size(300, 18);
            this.name_tB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Наименование";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.name_tB);
            this.panel1.Location = new System.Drawing.Point(19, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 23);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(55, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(87, 23);
            this.panel2.TabIndex = 11;
            // 
            // price_tB
            // 
            this.price_tB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.price_tB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_tB.Location = new System.Drawing.Point(58, 99);
            this.price_tB.Name = "price_tB";
            this.price_tB.Size = new System.Drawing.Size(81, 18);
            this.price_tB.TabIndex = 12;
            // 
            // create_btn
            // 
            this.create_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.create_btn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.create_btn.Location = new System.Drawing.Point(118, 208);
            this.create_btn.Name = "create_btn";
            this.create_btn.Radius = 10;
            this.create_btn.Size = new System.Drawing.Size(76, 24);
            this.create_btn.TabIndex = 9;
            this.create_btn.Text = "Создать";
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // add_photo
            // 
            this.add_photo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.add_photo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_photo.ForeColor = System.Drawing.SystemColors.Window;
            this.add_photo.Location = new System.Drawing.Point(19, 143);
            this.add_photo.Name = "add_photo";
            this.add_photo.Radius = 10;
            this.add_photo.Size = new System.Drawing.Size(101, 24);
            this.add_photo.TabIndex = 8;
            this.add_photo.Text = "Выбрать фото";
            this.add_photo.Click += new System.EventHandler(this.add_photo_Click);
            // 
            // AddGood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(347, 244);
            this.Controls.Add(this.price_tB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.add_photo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.image_pB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddGood";
            this.Text = "Создать товар";
            ((System.ComponentModel.ISupportInitialize)(this.image_pB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image_pB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_tB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Controls.RoundBtn add_photo;
        private Controls.RoundBtn create_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox price_tB;
    }
}

