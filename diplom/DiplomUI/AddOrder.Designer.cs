namespace diplom
{
    partial class AddOrder
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
            this.numb_lbl = new System.Windows.Forms.Label();
            this.numb_tB = new System.Windows.Forms.TextBox();
            this.ppl_UpDown = new System.Windows.Forms.NumericUpDown();
            this.count_lbl = new System.Windows.Forms.Label();
            this.comment_tB = new System.Windows.Forms.RichTextBox();
            this.Add_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ppl_UpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // name_tB
            // 
            this.name_tB.Location = new System.Drawing.Point(88, 56);
            this.name_tB.Name = "name_tB";
            this.name_tB.Size = new System.Drawing.Size(193, 20);
            this.name_tB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Заполните данные заказa";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_lbl.Location = new System.Drawing.Point(40, 55);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(42, 19);
            this.name_lbl.TabIndex = 2;
            this.name_lbl.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(138, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 3;
            // 
            // numb_lbl
            // 
            this.numb_lbl.AutoSize = true;
            this.numb_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numb_lbl.Location = new System.Drawing.Point(25, 95);
            this.numb_lbl.Name = "numb_lbl";
            this.numb_lbl.Size = new System.Drawing.Size(57, 19);
            this.numb_lbl.TabIndex = 4;
            this.numb_lbl.Text = "Номер:";
            // 
            // numb_tB
            // 
            this.numb_tB.Location = new System.Drawing.Point(88, 96);
            this.numb_tB.Name = "numb_tB";
            this.numb_tB.Size = new System.Drawing.Size(193, 20);
            this.numb_tB.TabIndex = 5;
            // 
            // ppl_UpDown
            // 
            this.ppl_UpDown.Location = new System.Drawing.Point(231, 136);
            this.ppl_UpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ppl_UpDown.Name = "ppl_UpDown";
            this.ppl_UpDown.Size = new System.Drawing.Size(50, 20);
            this.ppl_UpDown.TabIndex = 6;
            this.ppl_UpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // count_lbl
            // 
            this.count_lbl.AutoSize = true;
            this.count_lbl.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_lbl.Location = new System.Drawing.Point(50, 137);
            this.count_lbl.Name = "count_lbl";
            this.count_lbl.Size = new System.Drawing.Size(175, 19);
            this.count_lbl.TabIndex = 7;
            this.count_lbl.Text = "Количество посетителей:";
            // 
            // comment_tB
            // 
            this.comment_tB.Location = new System.Drawing.Point(12, 177);
            this.comment_tB.Name = "comment_tB";
            this.comment_tB.Size = new System.Drawing.Size(299, 78);
            this.comment_tB.TabIndex = 8;
            this.comment_tB.Text = "";
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(125, 261);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(75, 23);
            this.Add_btn.TabIndex = 9;
            this.Add_btn.Text = "Создать";
            this.Add_btn.UseVisualStyleBackColor = true;
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 297);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.comment_tB);
            this.Controls.Add(this.count_lbl);
            this.Controls.Add(this.ppl_UpDown);
            this.Controls.Add(this.numb_tB);
            this.Controls.Add(this.numb_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_tB);
            this.Name = "AddOrder";
            this.Text = "Создать";
            ((System.ComponentModel.ISupportInitialize)(this.ppl_UpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_tB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numb_lbl;
        private System.Windows.Forms.TextBox numb_tB;
        private System.Windows.Forms.NumericUpDown ppl_UpDown;
        private System.Windows.Forms.Label count_lbl;
        private System.Windows.Forms.RichTextBox comment_tB;
        private System.Windows.Forms.Button Add_btn;
    }
}