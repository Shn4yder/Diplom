namespace diplom
{
    partial class EditUsrForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUsrForm));
            this.status_cB = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.name_tB = new diplom.CueTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.phone_tB = new System.Windows.Forms.MaskedTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.email_tB = new diplom.CueTextbox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.login_tB = new diplom.CueTextbox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pass_cB = new System.Windows.Forms.PictureBox();
            this.pass_tB = new diplom.CueTextbox();
            this.back_btn = new System.Windows.Forms.PictureBox();
            this.del_btn = new diplom.Controls.RoundBtn();
            this.save_btn = new diplom.Controls.RoundBtn();
            this.name_lbl = new System.Windows.Forms.Label();
            this.phone_lbl = new System.Windows.Forms.Label();
            this.email_lbl = new System.Windows.Forms.Label();
            this.login_lbl = new System.Windows.Forms.Label();
            this.pwd_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pass_cB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // status_cB
            // 
            this.status_cB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status_cB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.status_cB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status_cB.FormattingEnabled = true;
            this.status_cB.Items.AddRange(new object[] {
            "Сотрудник",
            "Менеджер",
            "Стажер",
            "Администратор"});
            this.status_cB.Location = new System.Drawing.Point(12, 80);
            this.status_cB.Name = "status_cB";
            this.status_cB.Size = new System.Drawing.Size(205, 25);
            this.status_cB.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.name_tB);
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 23);
            this.panel1.TabIndex = 24;
            // 
            // name_tB
            // 
            this.name_tB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_tB.Cue = "Фамилия Имя Отчество";
            this.name_tB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_tB.Location = new System.Drawing.Point(3, 2);
            this.name_tB.Name = "name_tB";
            this.name_tB.Size = new System.Drawing.Size(269, 18);
            this.name_tB.TabIndex = 31;
            this.name_tB.TextChanged += new System.EventHandler(this.name_tB_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.phone_tB);
            this.panel2.Location = new System.Drawing.Point(12, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 23);
            this.panel2.TabIndex = 25;
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
            this.phone_tB.TextChanged += new System.EventHandler(this.phone_tB_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.email_tB);
            this.panel3.Location = new System.Drawing.Point(12, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(205, 23);
            this.panel3.TabIndex = 26;
            // 
            // email_tB
            // 
            this.email_tB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_tB.Cue = "example@mail.ru";
            this.email_tB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_tB.Location = new System.Drawing.Point(3, 2);
            this.email_tB.Name = "email_tB";
            this.email_tB.Size = new System.Drawing.Size(199, 18);
            this.email_tB.TabIndex = 31;
            this.email_tB.TextChanged += new System.EventHandler(this.email_tB_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.login_tB);
            this.panel4.Location = new System.Drawing.Point(12, 204);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(205, 23);
            this.panel4.TabIndex = 27;
            // 
            // login_tB
            // 
            this.login_tB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_tB.Cue = "Логин";
            this.login_tB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_tB.Location = new System.Drawing.Point(3, 3);
            this.login_tB.Name = "login_tB";
            this.login_tB.Size = new System.Drawing.Size(199, 18);
            this.login_tB.TabIndex = 31;
            this.login_tB.TextChanged += new System.EventHandler(this.login_tB_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.pass_cB);
            this.panel5.Controls.Add(this.pass_tB);
            this.panel5.Location = new System.Drawing.Point(12, 247);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(205, 23);
            this.panel5.TabIndex = 28;
            // 
            // pass_cB
            // 
            this.pass_cB.BackColor = System.Drawing.SystemColors.Window;
            this.pass_cB.Image = ((System.Drawing.Image)(resources.GetObject("pass_cB.Image")));
            this.pass_cB.Location = new System.Drawing.Point(176, 3);
            this.pass_cB.Name = "pass_cB";
            this.pass_cB.Size = new System.Drawing.Size(26, 18);
            this.pass_cB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pass_cB.TabIndex = 30;
            this.pass_cB.TabStop = false;
            this.pass_cB.Click += new System.EventHandler(this.pass_cB_Click);
            // 
            // pass_tB
            // 
            this.pass_tB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass_tB.Cue = "Пароль";
            this.pass_tB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_tB.Location = new System.Drawing.Point(3, 2);
            this.pass_tB.Name = "pass_tB";
            this.pass_tB.Size = new System.Drawing.Size(199, 18);
            this.pass_tB.TabIndex = 31;
            this.pass_tB.TextChanged += new System.EventHandler(this.pass_tB_TextChanged);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(160)))), ((int)(((byte)(128)))));
            this.back_btn.Image = ((System.Drawing.Image)(resources.GetObject("back_btn.Image")));
            this.back_btn.Location = new System.Drawing.Point(12, 10);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(20, 22);
            this.back_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.back_btn.TabIndex = 29;
            this.back_btn.TabStop = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.del_btn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.del_btn.Location = new System.Drawing.Point(12, 286);
            this.del_btn.Name = "del_btn";
            this.del_btn.Radius = 10;
            this.del_btn.Size = new System.Drawing.Size(79, 24);
            this.del_btn.TabIndex = 23;
            this.del_btn.Text = "Удалить";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.save_btn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.save_btn.Location = new System.Drawing.Point(150, 286);
            this.save_btn.Name = "save_btn";
            this.save_btn.Radius = 10;
            this.save_btn.Size = new System.Drawing.Size(149, 24);
            this.save_btn.TabIndex = 22;
            this.save_btn.Text = "Сохранить изменения";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_lbl.ForeColor = System.Drawing.Color.DarkRed;
            this.name_lbl.Location = new System.Drawing.Point(290, 40);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(17, 24);
            this.name_lbl.TabIndex = 33;
            this.name_lbl.Text = "*";
            this.name_lbl.Visible = false;
            // 
            // phone_lbl
            // 
            this.phone_lbl.AutoSize = true;
            this.phone_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone_lbl.ForeColor = System.Drawing.Color.DarkRed;
            this.phone_lbl.Location = new System.Drawing.Point(142, 121);
            this.phone_lbl.Name = "phone_lbl";
            this.phone_lbl.Size = new System.Drawing.Size(17, 24);
            this.phone_lbl.TabIndex = 34;
            this.phone_lbl.Text = "*";
            this.phone_lbl.Visible = false;
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email_lbl.ForeColor = System.Drawing.Color.DarkRed;
            this.email_lbl.Location = new System.Drawing.Point(220, 162);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(17, 24);
            this.email_lbl.TabIndex = 35;
            this.email_lbl.Text = "*";
            this.email_lbl.Visible = false;
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_lbl.ForeColor = System.Drawing.Color.DarkRed;
            this.login_lbl.Location = new System.Drawing.Point(220, 207);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(17, 24);
            this.login_lbl.TabIndex = 36;
            this.login_lbl.Text = "*";
            this.login_lbl.Visible = false;
            // 
            // pwd_lbl
            // 
            this.pwd_lbl.AutoSize = true;
            this.pwd_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pwd_lbl.ForeColor = System.Drawing.Color.DarkRed;
            this.pwd_lbl.Location = new System.Drawing.Point(220, 250);
            this.pwd_lbl.Name = "pwd_lbl";
            this.pwd_lbl.Size = new System.Drawing.Size(17, 24);
            this.pwd_lbl.TabIndex = 37;
            this.pwd_lbl.Text = "*";
            this.pwd_lbl.Visible = false;
            // 
            // EditUsrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(311, 322);
            this.Controls.Add(this.pwd_lbl);
            this.Controls.Add(this.login_lbl);
            this.Controls.Add(this.email_lbl);
            this.Controls.Add(this.phone_lbl);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.status_cB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditUsrForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение пользователя";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pass_cB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox status_cB;
        private Controls.RoundBtn save_btn;
        private Controls.RoundBtn del_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox phone_tB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox back_btn;
        private System.Windows.Forms.PictureBox pass_cB;
        private CueTextbox name_tB;
        private CueTextbox email_tB;
        private CueTextbox login_tB;
        private CueTextbox pass_tB;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label phone_lbl;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.Label login_lbl;
        private System.Windows.Forms.Label pwd_lbl;
    }
}