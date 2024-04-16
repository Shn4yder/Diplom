namespace diplom
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.domain_cB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.email_tB = new diplom.CueTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.phone_tB = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.name_tB = new diplom.CueTextbox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.confirm_cB = new System.Windows.Forms.PictureBox();
            this.confirm_tB = new diplom.CueTextbox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pass_cB = new System.Windows.Forms.PictureBox();
            this.pwd_tB = new diplom.CueTextbox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.login_tB = new diplom.CueTextbox();
            this.status_cB = new System.Windows.Forms.ComboBox();
            this.create_btn = new diplom.Controls.RoundBtn();
            this.back_btn = new System.Windows.Forms.PictureBox();
            this.name_lbl = new System.Windows.Forms.Label();
            this.phone_lbl = new System.Windows.Forms.Label();
            this.email_lbl = new System.Windows.Forms.Label();
            this.login_lbl = new System.Windows.Forms.Label();
            this.pwd_lbl = new System.Windows.Forms.Label();
            this.confirm_lbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confirm_cB)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pass_cB)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(103, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Новый пользователь";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.groupBox1.Controls.Add(this.email_lbl);
            this.groupBox1.Controls.Add(this.phone_lbl);
            this.groupBox1.Controls.Add(this.name_lbl);
            this.groupBox1.Controls.Add(this.domain_cB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 106);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Личные данные";
            // 
            // domain_cB
            // 
            this.domain_cB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.domain_cB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.domain_cB.FormattingEnabled = true;
            this.domain_cB.Items.AddRange(new object[] {
            "mail.ru",
            "gmail.com",
            "yandex.ru",
            "rambler.ru"});
            this.domain_cB.Location = new System.Drawing.Point(315, 61);
            this.domain_cB.Name = "domain_cB";
            this.domain_cB.Size = new System.Drawing.Size(78, 25);
            this.domain_cB.TabIndex = 19;
            this.domain_cB.Text = "mail.ru";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(286, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "@";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.email_tB);
            this.panel3.Location = new System.Drawing.Point(159, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(121, 23);
            this.panel3.TabIndex = 17;
            // 
            // email_tB
            // 
            this.email_tB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_tB.Cue = "example";
            this.email_tB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_tB.Location = new System.Drawing.Point(3, 3);
            this.email_tB.Name = "email_tB";
            this.email_tB.Size = new System.Drawing.Size(115, 18);
            this.email_tB.TabIndex = 30;
            this.email_tB.TextChanged += new System.EventHandler(this.email_tB_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.phone_tB);
            this.panel2.Location = new System.Drawing.Point(6, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 23);
            this.panel2.TabIndex = 16;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.name_tB);
            this.panel1.Location = new System.Drawing.Point(6, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 23);
            this.panel1.TabIndex = 15;
            // 
            // name_tB
            // 
            this.name_tB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_tB.Cue = "Фамилия Имя Отчество";
            this.name_tB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_tB.Location = new System.Drawing.Point(3, 2);
            this.name_tB.Name = "name_tB";
            this.name_tB.Size = new System.Drawing.Size(381, 18);
            this.name_tB.TabIndex = 30;
            this.name_tB.TextChanged += new System.EventHandler(this.name_tB_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.groupBox2.Controls.Add(this.confirm_lbl);
            this.groupBox2.Controls.Add(this.pwd_lbl);
            this.groupBox2.Controls.Add(this.login_lbl);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.status_cB);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 132);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Приложение";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.confirm_cB);
            this.panel6.Controls.Add(this.confirm_tB);
            this.panel6.Location = new System.Drawing.Point(199, 85);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(194, 23);
            this.panel6.TabIndex = 20;
            // 
            // confirm_cB
            // 
            this.confirm_cB.BackColor = System.Drawing.SystemColors.Window;
            this.confirm_cB.Image = ((System.Drawing.Image)(resources.GetObject("confirm_cB.Image")));
            this.confirm_cB.Location = new System.Drawing.Point(165, 2);
            this.confirm_cB.Name = "confirm_cB";
            this.confirm_cB.Size = new System.Drawing.Size(26, 18);
            this.confirm_cB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.confirm_cB.TabIndex = 29;
            this.confirm_cB.TabStop = false;
            this.confirm_cB.Click += new System.EventHandler(this.confirm_cB_Click);
            // 
            // confirm_tB
            // 
            this.confirm_tB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirm_tB.Cue = "Подтвердите пароль";
            this.confirm_tB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_tB.Location = new System.Drawing.Point(3, 3);
            this.confirm_tB.Name = "confirm_tB";
            this.confirm_tB.Size = new System.Drawing.Size(188, 18);
            this.confirm_tB.TabIndex = 30;
            this.confirm_tB.Leave += new System.EventHandler(this.confirm_tB_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.pass_cB);
            this.panel5.Controls.Add(this.pwd_tB);
            this.panel5.Location = new System.Drawing.Point(199, 39);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(194, 23);
            this.panel5.TabIndex = 19;
            // 
            // pass_cB
            // 
            this.pass_cB.BackColor = System.Drawing.SystemColors.Window;
            this.pass_cB.Image = ((System.Drawing.Image)(resources.GetObject("pass_cB.Image")));
            this.pass_cB.Location = new System.Drawing.Point(165, 2);
            this.pass_cB.Name = "pass_cB";
            this.pass_cB.Size = new System.Drawing.Size(26, 18);
            this.pass_cB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pass_cB.TabIndex = 29;
            this.pass_cB.TabStop = false;
            this.pass_cB.Click += new System.EventHandler(this.pass_cB_Click);
            // 
            // pwd_tB
            // 
            this.pwd_tB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pwd_tB.Cue = "Пароль";
            this.pwd_tB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwd_tB.Location = new System.Drawing.Point(3, 3);
            this.pwd_tB.Name = "pwd_tB";
            this.pwd_tB.Size = new System.Drawing.Size(188, 18);
            this.pwd_tB.TabIndex = 30;
            this.pwd_tB.TextChanged += new System.EventHandler(this.pwd_tB_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.login_tB);
            this.panel4.Location = new System.Drawing.Point(6, 85);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(147, 23);
            this.panel4.TabIndex = 18;
            // 
            // login_tB
            // 
            this.login_tB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_tB.Cue = "Логин";
            this.login_tB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_tB.Location = new System.Drawing.Point(3, 2);
            this.login_tB.Name = "login_tB";
            this.login_tB.Size = new System.Drawing.Size(141, 18);
            this.login_tB.TabIndex = 30;
            this.login_tB.TextChanged += new System.EventHandler(this.login_tB_TextChanged);
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
            this.status_cB.Location = new System.Drawing.Point(6, 37);
            this.status_cB.Name = "status_cB";
            this.status_cB.Size = new System.Drawing.Size(170, 25);
            this.status_cB.TabIndex = 0;
            // 
            // create_btn
            // 
            this.create_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.create_btn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.create_btn.Location = new System.Drawing.Point(175, 326);
            this.create_btn.Name = "create_btn";
            this.create_btn.Radius = 10;
            this.create_btn.Size = new System.Drawing.Size(76, 24);
            this.create_btn.TabIndex = 14;
            this.create_btn.Text = "Создать";
            this.create_btn.UseVisualStyleBackColor = false;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(160)))), ((int)(((byte)(128)))));
            this.back_btn.Image = ((System.Drawing.Image)(resources.GetObject("back_btn.Image")));
            this.back_btn.Location = new System.Drawing.Point(12, 19);
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
            this.name_lbl.Location = new System.Drawing.Point(396, 28);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(17, 24);
            this.name_lbl.TabIndex = 32;
            this.name_lbl.Text = "*";
            // 
            // phone_lbl
            // 
            this.phone_lbl.AutoSize = true;
            this.phone_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phone_lbl.ForeColor = System.Drawing.Color.DarkRed;
            this.phone_lbl.Location = new System.Drawing.Point(136, 64);
            this.phone_lbl.Name = "phone_lbl";
            this.phone_lbl.Size = new System.Drawing.Size(17, 24);
            this.phone_lbl.TabIndex = 33;
            this.phone_lbl.Text = "*";
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email_lbl.ForeColor = System.Drawing.Color.DarkRed;
            this.email_lbl.Location = new System.Drawing.Point(396, 64);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(17, 24);
            this.email_lbl.TabIndex = 34;
            this.email_lbl.Text = "*";
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_lbl.ForeColor = System.Drawing.Color.DarkRed;
            this.login_lbl.Location = new System.Drawing.Point(159, 88);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(17, 24);
            this.login_lbl.TabIndex = 35;
            this.login_lbl.Text = "*";
            // 
            // pwd_lbl
            // 
            this.pwd_lbl.AutoSize = true;
            this.pwd_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pwd_lbl.ForeColor = System.Drawing.Color.DarkRed;
            this.pwd_lbl.Location = new System.Drawing.Point(396, 42);
            this.pwd_lbl.Name = "pwd_lbl";
            this.pwd_lbl.Size = new System.Drawing.Size(17, 24);
            this.pwd_lbl.TabIndex = 36;
            this.pwd_lbl.Text = "*";
            // 
            // confirm_lbl
            // 
            this.confirm_lbl.AutoSize = true;
            this.confirm_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirm_lbl.ForeColor = System.Drawing.Color.DarkRed;
            this.confirm_lbl.Location = new System.Drawing.Point(396, 88);
            this.confirm_lbl.Name = "confirm_lbl";
            this.confirm_lbl.Size = new System.Drawing.Size(17, 24);
            this.confirm_lbl.TabIndex = 37;
            this.confirm_lbl.Text = "*";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(445, 362);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddUser";
            this.Text = "Создание пользователя";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confirm_cB)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pass_cB)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox status_cB;
        private Controls.RoundBtn create_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox phone_tB;
        private System.Windows.Forms.ComboBox domain_cB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox back_btn;
        private System.Windows.Forms.PictureBox confirm_cB;
        private System.Windows.Forms.PictureBox pass_cB;
        private CueTextbox email_tB;
        private CueTextbox name_tB;
        private CueTextbox confirm_tB;
        private CueTextbox pwd_tB;
        private CueTextbox login_tB;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label phone_lbl;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.Label login_lbl;
        private System.Windows.Forms.Label pwd_lbl;
        private System.Windows.Forms.Label confirm_lbl;
    }
}