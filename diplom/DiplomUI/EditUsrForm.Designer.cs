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
            this.name_tB = new System.Windows.Forms.TextBox();
            this.email_tB = new System.Windows.Forms.TextBox();
            this.phone_tB = new System.Windows.Forms.TextBox();
            this.login_tB = new System.Windows.Forms.TextBox();
            this.pass_tB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.status_cB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.edit_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_tB
            // 
            this.name_tB.Location = new System.Drawing.Point(66, 12);
            this.name_tB.Name = "name_tB";
            this.name_tB.Size = new System.Drawing.Size(198, 20);
            this.name_tB.TabIndex = 0;
            // 
            // email_tB
            // 
            this.email_tB.Location = new System.Drawing.Point(66, 143);
            this.email_tB.Name = "email_tB";
            this.email_tB.Size = new System.Drawing.Size(198, 20);
            this.email_tB.TabIndex = 1;
            // 
            // phone_tB
            // 
            this.phone_tB.Location = new System.Drawing.Point(66, 96);
            this.phone_tB.Name = "phone_tB";
            this.phone_tB.Size = new System.Drawing.Size(198, 20);
            this.phone_tB.TabIndex = 2;
            // 
            // login_tB
            // 
            this.login_tB.Location = new System.Drawing.Point(66, 192);
            this.login_tB.Name = "login_tB";
            this.login_tB.Size = new System.Drawing.Size(198, 20);
            this.login_tB.TabIndex = 4;
            // 
            // pass_tB
            // 
            this.pass_tB.Location = new System.Drawing.Point(66, 242);
            this.pass_tB.Name = "pass_tB";
            this.pass_tB.Size = new System.Drawing.Size(198, 20);
            this.pass_tB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ФИО";
            // 
            // status_cB
            // 
            this.status_cB.FormattingEnabled = true;
            this.status_cB.Items.AddRange(new object[] {
            "Сотрудник",
            "Менеджер",
            "Стажер",
            "Администратор"});
            this.status_cB.Location = new System.Drawing.Point(66, 56);
            this.status_cB.Name = "status_cB";
            this.status_cB.Size = new System.Drawing.Size(198, 21);
            this.status_cB.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Статус";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Логин";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Пароль";
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(144, 286);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(133, 23);
            this.edit_btn.TabIndex = 13;
            this.edit_btn.Text = "Сохранить изменения";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(15, 286);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 14;
            this.delete_btn.Text = "Удалить";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // EditUsrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 324);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.status_cB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pass_tB);
            this.Controls.Add(this.login_tB);
            this.Controls.Add(this.phone_tB);
            this.Controls.Add(this.email_tB);
            this.Controls.Add(this.name_tB);
            this.Name = "EditUsrForm";
            this.Text = "EditUsrForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_tB;
        private System.Windows.Forms.TextBox email_tB;
        private System.Windows.Forms.TextBox phone_tB;
        private System.Windows.Forms.TextBox login_tB;
        private System.Windows.Forms.TextBox pass_tB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox status_cB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button delete_btn;
    }
}