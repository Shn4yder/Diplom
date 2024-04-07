namespace diplom
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.login_lbl = new System.Windows.Forms.Label();
            this.pwd_lbl = new System.Windows.Forms.Label();
            this.main_lbl = new System.Windows.Forms.Label();
            this.login_tB = new System.Windows.Forms.TextBox();
            this.pass_tB = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Enter_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_lbl.Location = new System.Drawing.Point(45, 221);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(54, 19);
            this.login_lbl.TabIndex = 0;
            this.login_lbl.Text = "Логин:";
            // 
            // pwd_lbl
            // 
            this.pwd_lbl.AutoSize = true;
            this.pwd_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pwd_lbl.Location = new System.Drawing.Point(36, 268);
            this.pwd_lbl.Name = "pwd_lbl";
            this.pwd_lbl.Size = new System.Drawing.Size(63, 19);
            this.pwd_lbl.TabIndex = 1;
            this.pwd_lbl.Text = "Пароль:";
            // 
            // main_lbl
            // 
            this.main_lbl.AutoSize = true;
            this.main_lbl.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.main_lbl.Location = new System.Drawing.Point(40, 9);
            this.main_lbl.Name = "main_lbl";
            this.main_lbl.Size = new System.Drawing.Size(252, 45);
            this.main_lbl.TabIndex = 2;
            this.main_lbl.Text = "Art & Coworking";
            // 
            // login_tB
            // 
            this.login_tB.Location = new System.Drawing.Point(105, 222);
            this.login_tB.Name = "login_tB";
            this.login_tB.Size = new System.Drawing.Size(168, 20);
            this.login_tB.TabIndex = 3;
            // 
            // pass_tB
            // 
            this.pass_tB.Location = new System.Drawing.Point(105, 269);
            this.pass_tB.Name = "pass_tB";
            this.pass_tB.Size = new System.Drawing.Size(168, 20);
            this.pass_tB.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(94, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 132);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Enter_btn
            // 
            this.Enter_btn.Location = new System.Drawing.Point(118, 317);
            this.Enter_btn.Name = "Enter_btn";
            this.Enter_btn.Size = new System.Drawing.Size(75, 23);
            this.Enter_btn.TabIndex = 6;
            this.Enter_btn.Text = "Вход";
            this.Enter_btn.UseVisualStyleBackColor = true;
            this.Enter_btn.Click += new System.EventHandler(this.Enter_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 307);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(223, 333);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 386);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Enter_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pass_tB);
            this.Controls.Add(this.login_tB);
            this.Controls.Add(this.main_lbl);
            this.Controls.Add(this.pwd_lbl);
            this.Controls.Add(this.login_lbl);
            this.Name = "Authorization";
            this.Text = "Вход";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login_lbl;
        private System.Windows.Forms.Label pwd_lbl;
        private System.Windows.Forms.Label main_lbl;
        private System.Windows.Forms.TextBox login_tB;
        private System.Windows.Forms.TextBox pass_tB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Enter_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}