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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.email_tB = new System.Windows.Forms.TextBox();
            this.phone_tB = new System.Windows.Forms.TextBox();
            this.name_tB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.confirm_tB = new System.Windows.Forms.TextBox();
            this.pwd_tB = new System.Windows.Forms.TextBox();
            this.login_tB = new System.Windows.Forms.TextBox();
            this.status_cB = new System.Windows.Forms.ComboBox();
            this.create_btn = new diplom.Controls.RoundBtn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(103, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Новый пользователь";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.email_tB);
            this.groupBox1.Controls.Add(this.phone_tB);
            this.groupBox1.Controls.Add(this.name_tB);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 115);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Личные данные";
            // 
            // email_tB
            // 
            this.email_tB.Location = new System.Drawing.Point(209, 68);
            this.email_tB.Name = "email_tB";
            this.email_tB.Size = new System.Drawing.Size(194, 20);
            this.email_tB.TabIndex = 2;
            // 
            // phone_tB
            // 
            this.phone_tB.Location = new System.Drawing.Point(16, 68);
            this.phone_tB.Name = "phone_tB";
            this.phone_tB.Size = new System.Drawing.Size(160, 20);
            this.phone_tB.TabIndex = 1;
            // 
            // name_tB
            // 
            this.name_tB.Location = new System.Drawing.Point(16, 19);
            this.name_tB.Name = "name_tB";
            this.name_tB.Size = new System.Drawing.Size(387, 20);
            this.name_tB.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.confirm_tB);
            this.groupBox2.Controls.Add(this.pwd_tB);
            this.groupBox2.Controls.Add(this.login_tB);
            this.groupBox2.Controls.Add(this.status_cB);
            this.groupBox2.Location = new System.Drawing.Point(12, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 143);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Приложение";
            // 
            // confirm_tB
            // 
            this.confirm_tB.Location = new System.Drawing.Point(209, 91);
            this.confirm_tB.Name = "confirm_tB";
            this.confirm_tB.Size = new System.Drawing.Size(194, 20);
            this.confirm_tB.TabIndex = 3;
            // 
            // pwd_tB
            // 
            this.pwd_tB.Location = new System.Drawing.Point(209, 43);
            this.pwd_tB.Name = "pwd_tB";
            this.pwd_tB.Size = new System.Drawing.Size(194, 20);
            this.pwd_tB.TabIndex = 2;
            // 
            // login_tB
            // 
            this.login_tB.Location = new System.Drawing.Point(16, 91);
            this.login_tB.Name = "login_tB";
            this.login_tB.Size = new System.Drawing.Size(177, 20);
            this.login_tB.TabIndex = 1;
            // 
            // status_cB
            // 
            this.status_cB.FormattingEnabled = true;
            this.status_cB.Items.AddRange(new object[] {
            "Сотрудник",
            "Менеджер",
            "Стажер",
            "Администратор"});
            this.status_cB.Location = new System.Drawing.Point(16, 42);
            this.status_cB.Name = "status_cB";
            this.status_cB.Size = new System.Drawing.Size(177, 21);
            this.status_cB.TabIndex = 0;
            // 
            // create_btn
            // 
            this.create_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.create_btn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.create_btn.Location = new System.Drawing.Point(182, 340);
            this.create_btn.Name = "create_btn";
            this.create_btn.Radius = 10;
            this.create_btn.Size = new System.Drawing.Size(76, 24);
            this.create_btn.TabIndex = 14;
            this.create_btn.Text = "Создать";
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(445, 376);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "AddUser";
            this.Text = "Создать пользователя";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox name_tB;
        private System.Windows.Forms.TextBox phone_tB;
        private System.Windows.Forms.TextBox email_tB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox pwd_tB;
        private System.Windows.Forms.TextBox login_tB;
        private System.Windows.Forms.ComboBox status_cB;
        private System.Windows.Forms.TextBox confirm_tB;
        private Controls.RoundBtn create_btn;
    }
}