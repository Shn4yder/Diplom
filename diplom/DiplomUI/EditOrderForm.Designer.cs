namespace diplom
{
    partial class EditOrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ppl_UpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // name_tB
            // 
            this.name_tB.Location = new System.Drawing.Point(87, 12);
            this.name_tB.Name = "name_tB";
            this.name_tB.Size = new System.Drawing.Size(248, 20);
            this.name_tB.TabIndex = 0;
            // 
            // ppl_UpDown
            // 
            this.ppl_UpDown.Location = new System.Drawing.Point(284, 51);
            this.ppl_UpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ppl_UpDown.Name = "ppl_UpDown";
            this.ppl_UpDown.Size = new System.Drawing.Size(51, 20);
            this.ppl_UpDown.TabIndex = 1;
            this.ppl_UpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comment_tB
            // 
            this.comment_tB.Location = new System.Drawing.Point(12, 89);
            this.comment_tB.Name = "comment_tB";
            this.comment_tB.Size = new System.Drawing.Size(323, 96);
            this.comment_tB.TabIndex = 2;
            this.comment_tB.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество человек";
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(13, 192);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 5;
            this.delete_btn.Text = "Удалить";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = " Сохранить изменения";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EditOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 227);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comment_tB);
            this.Controls.Add(this.ppl_UpDown);
            this.Controls.Add(this.name_tB);
            this.Name = "EditOrderForm";
            this.Text = "EditOrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.ppl_UpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_tB;
        private System.Windows.Forms.NumericUpDown ppl_UpDown;
        private System.Windows.Forms.RichTextBox comment_tB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button button1;
    }
}