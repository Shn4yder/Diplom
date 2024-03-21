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
            this.name_tB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phone_tB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.place_tB = new System.Windows.Forms.TextBox();
            this.comment_tB = new System.Windows.Forms.RichTextBox();
            this.Add_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_tB
            // 
            this.name_tB.Location = new System.Drawing.Point(101, 55);
            this.name_tB.Name = "name_tB";
            this.name_tB.Size = new System.Drawing.Size(222, 20);
            this.name_tB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Новая заметка";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_lbl.Location = new System.Drawing.Point(42, 56);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(42, 19);
            this.name_lbl.TabIndex = 3;
            this.name_lbl.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Телефон:";
            // 
            // phone_tB
            // 
            this.phone_tB.Location = new System.Drawing.Point(101, 100);
            this.phone_tB.Name = "phone_tB";
            this.phone_tB.Size = new System.Drawing.Size(222, 20);
            this.phone_tB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "№ Стола/Место:";
            // 
            // place_tB
            // 
            this.place_tB.Location = new System.Drawing.Point(141, 145);
            this.place_tB.Name = "place_tB";
            this.place_tB.Size = new System.Drawing.Size(182, 20);
            this.place_tB.TabIndex = 6;
            // 
            // comment_tB
            // 
            this.comment_tB.Location = new System.Drawing.Point(26, 186);
            this.comment_tB.Name = "comment_tB";
            this.comment_tB.Size = new System.Drawing.Size(299, 78);
            this.comment_tB.TabIndex = 9;
            this.comment_tB.Text = "";
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(141, 270);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(75, 23);
            this.Add_btn.TabIndex = 11;
            this.Add_btn.Text = "Создать";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // AddNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 308);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.comment_tB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.place_tB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phone_tB);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_tB);
            this.Name = "AddNote";
            this.Text = "Создать заметку";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_tB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phone_tB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox place_tB;
        private System.Windows.Forms.RichTextBox comment_tB;
        private System.Windows.Forms.Button Add_btn;
    }
}