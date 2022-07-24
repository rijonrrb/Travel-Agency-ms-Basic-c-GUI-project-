namespace Project
{
    partial class Welcome
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
            this.label1 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.Admin1 = new System.Windows.Forms.Button();
            this.Manager1 = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.Manager3 = new System.Windows.Forms.Button();
            this.Admin3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(224, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to T Agency";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.LightCoral;
            this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(263, 109);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(173, 63);
            this.Login.TabIndex = 1;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Admin1
            // 
            this.Admin1.BackColor = System.Drawing.Color.Gray;
            this.Admin1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Admin1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Admin1.Location = new System.Drawing.Point(207, 178);
            this.Admin1.Name = "Admin1";
            this.Admin1.Size = new System.Drawing.Size(143, 46);
            this.Admin1.TabIndex = 5;
            this.Admin1.Text = "Admin";
            this.Admin1.UseVisualStyleBackColor = false;
            this.Admin1.Visible = false;
            this.Admin1.Click += new System.EventHandler(this.Admin1_Click);
            // 
            // Manager1
            // 
            this.Manager1.BackColor = System.Drawing.Color.Gray;
            this.Manager1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Manager1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Manager1.Location = new System.Drawing.Point(356, 178);
            this.Manager1.Name = "Manager1";
            this.Manager1.Size = new System.Drawing.Size(143, 46);
            this.Manager1.TabIndex = 6;
            this.Manager1.Text = "Manager";
            this.Manager1.UseVisualStyleBackColor = false;
            this.Manager1.Visible = false;
            this.Manager1.Click += new System.EventHandler(this.Manager1_Click);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.Location = new System.Drawing.Point(12, 12);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(63, 30);
            this.refresh.TabIndex = 7;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.Color.LightCoral;
            this.show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show.ForeColor = System.Drawing.Color.White;
            this.show.Location = new System.Drawing.Point(263, 269);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(173, 63);
            this.show.TabIndex = 8;
            this.show.Text = "Show Employee Details";
            this.show.UseVisualStyleBackColor = false;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // Manager3
            // 
            this.Manager3.BackColor = System.Drawing.Color.Gray;
            this.Manager3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Manager3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Manager3.Location = new System.Drawing.Point(356, 353);
            this.Manager3.Name = "Manager3";
            this.Manager3.Size = new System.Drawing.Size(143, 46);
            this.Manager3.TabIndex = 10;
            this.Manager3.Text = "Manager";
            this.Manager3.UseVisualStyleBackColor = false;
            this.Manager3.Visible = false;
            this.Manager3.Click += new System.EventHandler(this.Manager3_Click);
            // 
            // Admin3
            // 
            this.Admin3.BackColor = System.Drawing.Color.Gray;
            this.Admin3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Admin3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Admin3.Location = new System.Drawing.Point(207, 352);
            this.Admin3.Name = "Admin3";
            this.Admin3.Size = new System.Drawing.Size(143, 47);
            this.Admin3.TabIndex = 9;
            this.Admin3.Text = "Admin";
            this.Admin3.UseVisualStyleBackColor = false;
            this.Admin3.Visible = false;
            this.Admin3.Click += new System.EventHandler(this.Admin3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(448, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Not yet registered?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(574, 456);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(107, 17);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Register here";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(689, 487);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Manager3);
            this.Controls.Add(this.Admin3);
            this.Controls.Add(this.show);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.Manager1);
            this.Controls.Add(this.Admin1);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Welcome";
            this.Text = "T Agency";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Admin1;
        private System.Windows.Forms.Button Manager1;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button Manager3;
        private System.Windows.Forms.Button Admin3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

