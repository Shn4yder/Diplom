namespace diplom
{
    partial class AddNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNote));
            this.label1 = new System.Windows.Forms.Label();
            this.comment_tB = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.phone_tB = new System.Windows.Forms.MaskedTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.back_btn = new System.Windows.Forms.PictureBox();
            this.place_tB = new diplom.CueTextbox();
            this.name_tB = new diplom.CueTextbox();
            this.create_btn = new diplom.Controls.RoundBtn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Новая заметка";
            // 
            // comment_tB
            // 
            this.comment_tB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.comment_tB.Location = new System.Drawing.Point(13, 177);
            this.comment_tB.Name = "comment_tB";
            this.comment_tB.Size = new System.Drawing.Size(244, 78);
            this.comment_tB.TabIndex = 9;
            this.comment_tB.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.name_tB);
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 23);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.phone_tB);
            this.panel2.Location = new System.Drawing.Point(13, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 23);
            this.panel2.TabIndex = 14;
            // 
            // phone_tB
            // 
            this.phone_tB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phone_tB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone_tB.Location = new System.Drawing.Point(3, 3);
            this.phone_tB.Mask = "+7(000)-(000)-00-00";
            this.phone_tB.Name = "phone_tB";
            this.phone_tB.Size = new System.Drawing.Size(121, 18);
            this.phone_tB.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(13, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(161, 23);
            this.panel3.TabIndex = 14;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(160)))), ((int)(((byte)(128)))));
            this.back_btn.Image = ((System.Drawing.Image)(resources.GetObject("back_btn.Image")));
            this.back_btn.Location = new System.Drawing.Point(12, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(20, 22);
            this.back_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.back_btn.TabIndex = 23;
            this.back_btn.TabStop = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // place_tB
            // 
            this.place_tB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.place_tB.Cue = "№ Стола/места";
            this.place_tB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.place_tB.Location = new System.Drawing.Point(16, 131);
            this.place_tB.Name = "place_tB";
            this.place_tB.Size = new System.Drawing.Size(155, 18);
            this.place_tB.TabIndex = 29;
            // 
            // name_tB
            // 
            this.name_tB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_tB.Cue = "Имя";
            this.name_tB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_tB.Location = new System.Drawing.Point(3, 2);
            this.name_tB.Name = "name_tB";
            this.name_tB.Size = new System.Drawing.Size(239, 18);
            this.name_tB.TabIndex = 29;
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
            this.create_btn.TabIndex = 12;
            this.create_btn.Text = "Создать";
            this.create_btn.UseVisualStyleBackColor = false;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.label2.Location = new System.Drawing.Point(12, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Комментарий";
            // 
            // AddNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(274, 296);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.place_tB);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.comment_tB);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание заметки";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox comment_tB;
        private Controls.RoundBtn create_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox phone_tB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox back_btn;
        private CueTextbox name_tB;
        private CueTextbox place_tB;
        private System.Windows.Forms.Label label2;
    }
}