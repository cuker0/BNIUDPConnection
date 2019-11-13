namespace BNIUDPConnection
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.IPAdd = new System.Windows.Forms.TextBox();
            this.Label_IPAddress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 145);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 426);
            this.textBox1.TabIndex = 1;
            // 
            // IPAdd
            // 
            this.IPAdd.Location = new System.Drawing.Point(343, 34);
            this.IPAdd.Name = "IPAdd";
            this.IPAdd.Size = new System.Drawing.Size(152, 20);
            this.IPAdd.TabIndex = 2;
            // 
            // Label_IPAddress
            // 
            this.Label_IPAddress.AutoSize = true;
            this.Label_IPAddress.Location = new System.Drawing.Point(343, 13);
            this.Label_IPAddress.Name = "Label_IPAddress";
            this.Label_IPAddress.Size = new System.Drawing.Size(87, 13);
            this.Label_IPAddress.TabIndex = 3;
            this.Label_IPAddress.Text = "Label_IPAddress";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 442);
            this.Controls.Add(this.Label_IPAddress);
            this.Controls.Add(this.IPAdd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox IPAdd;
        private System.Windows.Forms.Label Label_IPAddress;
    }
}

