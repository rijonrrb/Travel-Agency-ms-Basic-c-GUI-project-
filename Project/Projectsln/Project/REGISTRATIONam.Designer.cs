namespace Project
{
    partial class REGISTRATIONam
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
            this.Manager2 = new System.Windows.Forms.Button();
            this.Admin2 = new System.Windows.Forms.Button();
            this.reg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(29, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Manager2
            // 
            this.Manager2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Manager2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manager2.Location = new System.Drawing.Point(175, 182);
            this.Manager2.Name = "Manager2";
            this.Manager2.Size = new System.Drawing.Size(84, 23);
            this.Manager2.TabIndex = 6;
            this.Manager2.Text = "MANAGER";
            this.Manager2.UseVisualStyleBackColor = false;
            this.Manager2.Click += new System.EventHandler(this.Manager2_Click);
            // 
            // Admin2
            // 
            this.Admin2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Admin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin2.Location = new System.Drawing.Point(175, 131);
            this.Admin2.Name = "Admin2";
            this.Admin2.Size = new System.Drawing.Size(84, 23);
            this.Admin2.TabIndex = 5;
            this.Admin2.Text = "ADMIN";
            this.Admin2.UseVisualStyleBackColor = false;
            this.Admin2.Click += new System.EventHandler(this.Admin2_Click);
            // 
            // reg
            // 
            this.reg.AutoSize = true;
            this.reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg.ForeColor = System.Drawing.Color.Blue;
            this.reg.Location = new System.Drawing.Point(161, 72);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(113, 16);
            this.reg.TabIndex = 4;
            this.reg.Text = "REGISTER AS:";
            // 
            // REGISTRATIONam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 328);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Manager2);
            this.Controls.Add(this.Admin2);
            this.Controls.Add(this.reg);
            this.Name = "REGISTRATIONam";
            this.Text = "REGISTRATIONam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Manager2;
        private System.Windows.Forms.Button Admin2;
        private System.Windows.Forms.Label reg;
    }
}