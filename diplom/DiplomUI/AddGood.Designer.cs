﻿namespace diplom
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
            this.image_pB = new System.Windows.Forms.PictureBox();
            this.add_image_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.name_tB = new System.Windows.Forms.TextBox();
            this.price_tB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image_pB)).BeginInit();
            this.SuspendLayout();
            // 
            // image_pB
            // 
            this.image_pB.Location = new System.Drawing.Point(224, 96);
            this.image_pB.Name = "image_pB";
            this.image_pB.Size = new System.Drawing.Size(150, 100);
            this.image_pB.TabIndex = 0;
            this.image_pB.TabStop = false;
            // 
            // add_image_btn
            // 
            this.add_image_btn.Location = new System.Drawing.Point(29, 157);
            this.add_image_btn.Name = "add_image_btn";
            this.add_image_btn.Size = new System.Drawing.Size(99, 23);
            this.add_image_btn.TabIndex = 1;
            this.add_image_btn.Text = "Выбрать фото";
            this.add_image_btn.UseVisualStyleBackColor = true;
            this.add_image_btn.Click += new System.EventHandler(this.add_image_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(154, 210);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 2;
            this.add_btn.Text = "Создать";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Новый товар";
            // 
            // name_tB
            // 
            this.name_tB.Location = new System.Drawing.Point(29, 70);
            this.name_tB.Name = "name_tB";
            this.name_tB.Size = new System.Drawing.Size(362, 20);
            this.name_tB.TabIndex = 4;
            // 
            // price_tB
            // 
            this.price_tB.Location = new System.Drawing.Point(76, 96);
            this.price_tB.Name = "price_tB";
            this.price_tB.Size = new System.Drawing.Size(89, 20);
            this.price_tB.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Наименование";
            // 
            // AddGood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 256);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.price_tB);
            this.Controls.Add(this.name_tB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.add_image_btn);
            this.Controls.Add(this.image_pB);
            this.Name = "AddGood";
            this.Text = "Создать товар";
            ((System.ComponentModel.ISupportInitialize)(this.image_pB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image_pB;
        private System.Windows.Forms.Button add_image_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_tB;
        private System.Windows.Forms.TextBox price_tB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

