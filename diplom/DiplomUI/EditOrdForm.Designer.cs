namespace diplom
{
    partial class EditOrdForm
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
            this.ppl_UpDown = new System.Windows.Forms.NumericUpDown();
            this.comment_tB = new System.Windows.Forms.RichTextBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ppl_UpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // name_tB
            // 
            this.name_tB.Location = new System.Drawing.Point(86, 12);
            this.name_tB.Name = "name_tB";
            this.name_tB.Size = new System.Drawing.Size(201, 20);
            this.name_tB.TabIndex = 0;
            // 
            // ppl_UpDown
            // 
            this.ppl_UpDown.Location = new System.Drawing.Point(167, 50);
            this.ppl_UpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ppl_UpDown.Name = "ppl_UpDown";
            this.ppl_UpDown.Size = new System.Drawing.Size(120, 20);
            this.ppl_UpDown.TabIndex = 1;
            this.ppl_UpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comment_tB
            // 
            this.comment_tB.Location = new System.Drawing.Point(13, 90);
            this.comment_tB.Name = "comment_tB";
            this.comment_tB.Size = new System.Drawing.Size(274, 96);
            this.comment_tB.TabIndex = 2;
            this.comment_tB.Text = "";
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(13, 192);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 3;
            this.delete_btn.Text = "Удалить";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(154, 192);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(133, 23);
            this.edit_btn.TabIndex = 4;
            this.edit_btn.Text = "Сохранить изменения";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Количество человек";
            // 
            // EditOrdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 225);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.comment_tB);
            this.Controls.Add(this.ppl_UpDown);
            this.Controls.Add(this.name_tB);
            this.Name = "EditOrdForm";
            this.Text = "EditOrdForm";
            ((System.ComponentModel.ISupportInitialize)(this.ppl_UpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_tB;
        private System.Windows.Forms.NumericUpDown ppl_UpDown;
        private System.Windows.Forms.RichTextBox comment_tB;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}