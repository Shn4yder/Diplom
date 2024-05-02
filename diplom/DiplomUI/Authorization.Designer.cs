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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.main_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.login_tB = new diplom.CueTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pass_cB = new System.Windows.Forms.PictureBox();
            this.pass_tB = new diplom.CueTextbox();
            this.login_lbl = new System.Windows.Forms.Label();
            this.pass_lbl = new System.Windows.Forms.Label();
            this.enter_btn = new diplom.Controls.RoundBtn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pass_cB)).BeginInit();
            this.SuspendLayout();
            // 
            // main_lbl
            // 
            this.main_lbl.AutoSize = true;
            this.main_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_lbl.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.main_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.main_lbl.Location = new System.Drawing.Point(7, 9);
            this.main_lbl.Name = "main_lbl";
            this.main_lbl.Size = new System.Drawing.Size(252, 45);
            this.main_lbl.TabIndex = 2;
            this.main_lbl.Text = "Art  Coworking";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::diplom.Properties.Resources.logo;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.login_tB);
            this.panel4.Location = new System.Drawing.Point(15, 214);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(226, 23);
            this.panel4.TabIndex = 19;
            // 
            // login_tB
            // 
            this.login_tB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_tB.Cue = "Логин";
            this.login_tB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_tB.Location = new System.Drawing.Point(3, 3);
            this.login_tB.Name = "login_tB";
            this.login_tB.Size = new System.Drawing.Size(220, 18);
            this.login_tB.TabIndex = 28;
            this.login_tB.TextChanged += new System.EventHandler(this.login_tB_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pass_cB);
            this.panel1.Controls.Add(this.pass_tB);
            this.panel1.Location = new System.Drawing.Point(15, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 23);
            this.panel1.TabIndex = 20;
            // 
            // pass_cB
            // 
            this.pass_cB.BackColor = System.Drawing.SystemColors.Window;
            this.pass_cB.Image = ((System.Drawing.Image)(resources.GetObject("pass_cB.Image")));
            this.pass_cB.Location = new System.Drawing.Point(197, 3);
            this.pass_cB.Name = "pass_cB";
            this.pass_cB.Size = new System.Drawing.Size(26, 18);
            this.pass_cB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pass_cB.TabIndex = 28;
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
            this.pass_tB.Size = new System.Drawing.Size(220, 18);
            this.pass_tB.TabIndex = 29;
            this.pass_tB.TextChanged += new System.EventHandler(this.pass_tB_TextChanged);
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_lbl.ForeColor = System.Drawing.Color.DarkRed;
            this.login_lbl.Location = new System.Drawing.Point(247, 214);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(17, 24);
            this.login_lbl.TabIndex = 36;
            this.login_lbl.Text = "*";
            // 
            // pass_lbl
            // 
            this.pass_lbl.AutoSize = true;
            this.pass_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_lbl.ForeColor = System.Drawing.Color.DarkRed;
            this.pass_lbl.Location = new System.Drawing.Point(247, 260);
            this.pass_lbl.Name = "pass_lbl";
            this.pass_lbl.Size = new System.Drawing.Size(17, 24);
            this.pass_lbl.TabIndex = 37;
            this.pass_lbl.Text = "*";
            // 
            // enter_btn
            // 
            this.enter_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.enter_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.enter_btn.Location = new System.Drawing.Point(71, 297);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Radius = 10;
            this.enter_btn.Size = new System.Drawing.Size(117, 33);
            this.enter_btn.TabIndex = 27;
            this.enter_btn.Text = "Вход";
            this.enter_btn.UseVisualStyleBackColor = false;
            this.enter_btn.Click += new System.EventHandler(this.enter_btn_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(232)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(271, 342);
            this.Controls.Add(this.pass_lbl);
            this.Controls.Add(this.login_lbl);
            this.Controls.Add(this.enter_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.main_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pass_cB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label main_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private Controls.RoundBtn enter_btn;
        private System.Windows.Forms.PictureBox pass_cB;
        private CueTextbox login_tB;
        private CueTextbox pass_tB;
        private System.Windows.Forms.Label login_lbl;
        private System.Windows.Forms.Label pass_lbl;
    }
}