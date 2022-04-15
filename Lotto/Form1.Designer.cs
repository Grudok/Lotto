namespace Lotto
{
    partial class Form1
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
            this.Txt_Box_1 = new System.Windows.Forms.TextBox();
            this.Btn_Tipp_1 = new System.Windows.Forms.Button();
            this.Btn_Ende = new System.Windows.Forms.Button();
            this.Txt_Box_2 = new System.Windows.Forms.TextBox();
            this.Lbl_1 = new System.Windows.Forms.Label();
            this.Lbl_2 = new System.Windows.Forms.Label();
            this.Txt_Box_3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Txt_Box_1
            // 
            this.Txt_Box_1.Location = new System.Drawing.Point(33, 74);
            this.Txt_Box_1.Multiline = true;
            this.Txt_Box_1.Name = "Txt_Box_1";
            this.Txt_Box_1.Size = new System.Drawing.Size(166, 29);
            this.Txt_Box_1.TabIndex = 0;
            // 
            // Btn_Tipp_1
            // 
            this.Btn_Tipp_1.Location = new System.Drawing.Point(444, 72);
            this.Btn_Tipp_1.Name = "Btn_Tipp_1";
            this.Btn_Tipp_1.Size = new System.Drawing.Size(113, 50);
            this.Btn_Tipp_1.TabIndex = 1;
            this.Btn_Tipp_1.Text = "Tipp";
            this.Btn_Tipp_1.UseVisualStyleBackColor = true;
            this.Btn_Tipp_1.Click += new System.EventHandler(this.Btn_Tipp_1_Click);
            // 
            // Btn_Ende
            // 
            this.Btn_Ende.Location = new System.Drawing.Point(363, 429);
            this.Btn_Ende.Name = "Btn_Ende";
            this.Btn_Ende.Size = new System.Drawing.Size(107, 46);
            this.Btn_Ende.TabIndex = 1;
            this.Btn_Ende.Text = "Ende";
            this.Btn_Ende.UseVisualStyleBackColor = true;
            this.Btn_Ende.Click += new System.EventHandler(this.Btn_Ende_Click);
            // 
            // Txt_Box_2
            // 
            this.Txt_Box_2.Location = new System.Drawing.Point(33, 120);
            this.Txt_Box_2.Multiline = true;
            this.Txt_Box_2.Name = "Txt_Box_2";
            this.Txt_Box_2.Size = new System.Drawing.Size(166, 31);
            this.Txt_Box_2.TabIndex = 0;
            // 
            // Lbl_1
            // 
            this.Lbl_1.AutoSize = true;
            this.Lbl_1.Location = new System.Drawing.Point(287, 77);
            this.Lbl_1.Name = "Lbl_1";
            this.Lbl_1.Size = new System.Drawing.Size(0, 13);
            this.Lbl_1.TabIndex = 2;
            // 
            // Lbl_2
            // 
            this.Lbl_2.AutoSize = true;
            this.Lbl_2.Location = new System.Drawing.Point(287, 112);
            this.Lbl_2.Name = "Lbl_2";
            this.Lbl_2.Size = new System.Drawing.Size(0, 13);
            this.Lbl_2.TabIndex = 2;
            // 
            // Txt_Box_3
            // 
            this.Txt_Box_3.Location = new System.Drawing.Point(33, 172);
            this.Txt_Box_3.Multiline = true;
            this.Txt_Box_3.Name = "Txt_Box_3";
            this.Txt_Box_3.Size = new System.Drawing.Size(166, 32);
            this.Txt_Box_3.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 550);
            this.Controls.Add(this.Lbl_2);
            this.Controls.Add(this.Lbl_1);
            this.Controls.Add(this.Btn_Ende);
            this.Controls.Add(this.Btn_Tipp_1);
            this.Controls.Add(this.Txt_Box_2);
            this.Controls.Add(this.Txt_Box_3);
            this.Controls.Add(this.Txt_Box_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Box_1;
        private System.Windows.Forms.Button Btn_Tipp_1;
        private System.Windows.Forms.Button Btn_Ende;
        private System.Windows.Forms.TextBox Txt_Box_2;
        private System.Windows.Forms.Label Lbl_1;
        private System.Windows.Forms.Label Lbl_2;
        private System.Windows.Forms.TextBox Txt_Box_3;
    }
}

