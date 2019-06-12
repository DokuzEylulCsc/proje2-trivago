namespace proje2Form.Views.CustomerViews
{
    partial class UpdateUser
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 22);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hoşgeldiniz.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yeni Adınız:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yeni Soyadınız:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 143);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "UpdateUser";
            this.Text = "UpdateUser";
            this.Load += new System.EventHandler(this.UpdateUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}