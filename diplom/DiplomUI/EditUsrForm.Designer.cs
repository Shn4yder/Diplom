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
            this.delete_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.pass_tB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.login_tB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.status_cB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.phone_tB = new System.Windows.Forms.TextBox();
            this.email_tB = new System.Windows.Forms.TextBox();
            this.name_tB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(32, 300);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 28;
            this.delete_btn.Text = "Удалить";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(231, 300);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(137, 23);
            this.edit_btn.TabIndex = 27;
            this.edit_btn.Text = "Сохранить изменения";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // pass_tB
            // 
            this.pass_tB.Location = new System.Drawing.Point(108, 251);
            this.pass_tB.Name = "pass_tB";
            this.pass_tB.Size = new System.Drawing.Size(260, 20);
            this.pass_tB.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Login";
            // 
            // login_tB
            // 
            this.login_tB.Location = new System.Drawing.Point(108, 208);
            this.login_tB.Name = "login_tB";
            this.login_tB.Size = new System.Drawing.Size(260, 20);
            this.login_tB.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Телефон";
            // 
            // status_cB
            // 
            this.status_cB.FormattingEnabled = true;
            this.status_cB.Items.AddRange(new object[] {
            "Сотрудник",
            "Менеджер",
            "Стажер",
            "Администратор"});
            this.status_cB.Location = new System.Drawing.Point(108, 76);
            this.status_cB.Name = "status_cB";
            this.status_cB.Size = new System.Drawing.Size(260, 21);
            this.status_cB.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Должность";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "ФИО";
            // 
            // phone_tB
            // 
            this.phone_tB.Location = new System.Drawing.Point(108, 116);
            this.phone_tB.Name = "phone_tB";
            this.phone_tB.Size = new System.Drawing.Size(260, 20);
            this.phone_tB.TabIndex = 17;
            // 
            // email_tB
            // 
            this.email_tB.Location = new System.Drawing.Point(108, 161);
            this.email_tB.Name = "email_tB";
            this.email_tB.Size = new System.Drawing.Size(260, 20);
            this.email_tB.TabIndex = 16;
            // 
            // name_tB
            // 
            this.name_tB.Location = new System.Drawing.Point(108, 32);
            this.name_tB.Name = "name_tB";
            this.name_tB.Size = new System.Drawing.Size(260, 20);
            this.name_tB.TabIndex = 15;
            // 
            // EditUsrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 348);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.pass_tB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.login_tB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.status_cB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phone_tB);
            this.Controls.Add(this.email_tB);
            this.Controls.Add(this.name_tB);
            this.Name = "EditUsrForm";
            this.Text = "EditUsrForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.TextBox pass_tB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox login_tB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox status_cB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phone_tB;
        private System.Windows.Forms.TextBox email_tB;
        private System.Windows.Forms.TextBox name_tB;
    }
}