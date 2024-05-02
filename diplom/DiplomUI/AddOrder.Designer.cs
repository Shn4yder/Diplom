namespace diplom
{
    partial class AddOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrder));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ppl_UpDown = new System.Windows.Forms.NumericUpDown();
            this.count_lbl = new System.Windows.Forms.Label();
            this.comment_tB = new System.Windows.Forms.RichTextBox();
            this.create_btn = new diplom.Controls.RoundBtn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.name_tB = new diplom.CueTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numb_tB = new diplom.CueTextbox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.back_btn = new System.Windows.Forms.PictureBox();
            this.name_lbl = new System.Windows.Forms.Label();
            this.numb_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ppl_UpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Новый заказ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(138, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 3;
            // 
            // ppl_UpDown
            // 
            this.ppl_UpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ppl_UpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ppl_UpDown.Location = new System.Drawing.Point(3, 3);
            this.ppl_UpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ppl_UpDown.Name = "ppl_UpDown";
            this.ppl_UpDown.Size = new System.Drawing.Size(44, 17);
            this.ppl_UpDown.TabIndex = 6;
            this.ppl_UpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // count_lbl
            // 
            this.count_lbl.AutoSize = true;
            this.count_lbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.count_lbl.Location = new System.Drawing.Point(15, 139);
            this.count_lbl.Name = "count_lbl";
            this.count_lbl.Size = new System.Drawing.Size(170, 17);
            this.count_lbl.TabIndex = 7;
            this.count_lbl.Text = "Количество посетителей:";
            // 
            // comment_tB
            // 
            this.comment_tB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.comment_tB.Location = new System.Drawing.Point(12, 177);
            this.comment_tB.Name = "comment_tB";
            this.comment_tB.Size = new System.Drawing.Size(230, 78);
            this.comment_tB.TabIndex = 8;
            this.comment_tB.Text = "Комментарий";
            // 
            // create_btn
            // 
            this.create_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.create_btn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.create_btn.Location = new System.Drawing.Point(95, 261);
            this.create_btn.Name = "create_btn";
            this.create_btn.Radius = 10;
            this.create_btn.Size = new System.Drawing.Size(76, 24);
            this.create_btn.TabIndex = 13;
            this.create_btn.Text = "Создать";
            this.create_btn.UseVisualStyleBackColor = false;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.name_tB);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 23);
            this.panel1.TabIndex = 14;
            // 
            // name_tB
            // 
            this.name_tB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_tB.Cue = "Имя";
            this.name_tB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_tB.Location = new System.Drawing.Point(6, 2);
            this.name_tB.Name = "name_tB";
            this.name_tB.Size = new System.Drawing.Size(220, 18);
            this.name_tB.TabIndex = 30;
            this.name_tB.TextChanged += new System.EventHandler(this.name_tB_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.numb_tB);
            this.panel2.Location = new System.Drawing.Point(12, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 23);
            this.panel2.TabIndex = 15;
            // 
            // numb_tB
            // 
            this.numb_tB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numb_tB.Cue = "Номер заказа";
            this.numb_tB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numb_tB.Location = new System.Drawing.Point(3, 2);
            this.numb_tB.Name = "numb_tB";
            this.numb_tB.Size = new System.Drawing.Size(223, 18);
            this.numb_tB.TabIndex = 30;
            this.numb_tB.TextChanged += new System.EventHandler(this.numb_tB_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.ppl_UpDown);
            this.panel3.Location = new System.Drawing.Point(191, 139);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(51, 23);
            this.panel3.TabIndex = 16;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(160)))), ((int)(((byte)(128)))));
            this.back_btn.Image = ((System.Drawing.Image)(resources.GetObject("back_btn.Image")));
            this.back_btn.Location = new System.Drawing.Point(12, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(20, 22);
            this.back_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.back_btn.TabIndex = 24;
            this.back_btn.TabStop = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_lbl.ForeColor = System.Drawing.Color.DarkRed;
            this.name_lbl.Location = new System.Drawing.Point(244, 55);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(17, 24);
            this.name_lbl.TabIndex = 31;
            this.name_lbl.Text = "*";
            // 
            // numb_lbl
            // 
            this.numb_lbl.AutoSize = true;
            this.numb_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numb_lbl.ForeColor = System.Drawing.Color.DarkRed;
            this.numb_lbl.Location = new System.Drawing.Point(244, 95);
            this.numb_lbl.Name = "numb_lbl";
            this.numb_lbl.Size = new System.Drawing.Size(17, 24);
            this.numb_lbl.TabIndex = 32;
            this.numb_lbl.Text = "*";
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(268, 297);
            this.Controls.Add(this.numb_lbl);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.comment_tB);
            this.Controls.Add(this.count_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание заказа";
            ((System.ComponentModel.ISupportInitialize)(this.ppl_UpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ppl_UpDown;
        private System.Windows.Forms.Label count_lbl;
        private System.Windows.Forms.RichTextBox comment_tB;
        private Controls.RoundBtn create_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox back_btn;
        private CueTextbox name_tB;
        private CueTextbox numb_tB;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label numb_lbl;
    }
}