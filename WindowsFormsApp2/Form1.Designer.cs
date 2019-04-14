namespace WindowsFormsApp2
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
            this.btnstrings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextMessage = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.takeText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnstrings
            // 
            this.btnstrings.Location = new System.Drawing.Point(90, 175);
            this.btnstrings.Name = "btnstrings";
            this.btnstrings.Size = new System.Drawing.Size(120, 30);
            this.btnstrings.TabIndex = 0;
            this.btnstrings.Text = "Get Text Box Data";
            this.btnstrings.UseVisualStyleBackColor = true;
            this.btnstrings.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // TextMessage
            // 
            this.TextMessage.AutoSize = true;
            this.TextMessage.Location = new System.Drawing.Point(87, 126);
            this.TextMessage.Name = "TextMessage";
            this.TextMessage.Size = new System.Drawing.Size(75, 13);
            this.TextMessage.TabIndex = 2;
            this.TextMessage.Text = "Message Area";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 3;
            // 
            // takeText
            // 
            this.takeText.Location = new System.Drawing.Point(90, 90);
            this.takeText.Name = "takeText";
            this.takeText.Size = new System.Drawing.Size(120, 20);
            this.takeText.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 313);
            this.Controls.Add(this.takeText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TextMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnstrings);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnstrings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TextMessage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox takeText;
    }
}

