namespace Project
{
    partial class Guide_Delete
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
            this.DELETE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTGID = new System.Windows.Forms.Label();
            this.tbTGID = new System.Windows.Forms.TextBox();
            this.dtgDel = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDel)).BeginInit();
            this.SuspendLayout();
            // 
            // DELETE
            // 
            this.DELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETE.Location = new System.Drawing.Point(531, 305);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(85, 28);
            this.DELETE.TabIndex = 0;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "INFORMATION DELETE:\r\n";
            // 
            // lbTGID
            // 
            this.lbTGID.AutoSize = true;
            this.lbTGID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTGID.Location = new System.Drawing.Point(47, 138);
            this.lbTGID.Name = "lbTGID";
            this.lbTGID.Size = new System.Drawing.Size(100, 15);
            this.lbTGID.TabIndex = 2;
            this.lbTGID.Text = "Tour Guide ID:";
            // 
            // tbTGID
            // 
            this.tbTGID.Location = new System.Drawing.Point(175, 138);
            this.tbTGID.Name = "tbTGID";
            this.tbTGID.Size = new System.Drawing.Size(100, 20);
            this.tbTGID.TabIndex = 3;
            this.tbTGID.TextChanged += new System.EventHandler(this.tbTGID_TextChanged);
            // 
            // dtgDel
            // 
            this.dtgDel.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgDel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDel.Location = new System.Drawing.Point(310, 96);
            this.dtgDel.Name = "dtgDel";
            this.dtgDel.Size = new System.Drawing.Size(306, 203);
            this.dtgDel.TabIndex = 4;
            this.dtgDel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(310, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "LOAD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Guide_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(640, 345);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgDel);
            this.Controls.Add(this.tbTGID);
            this.Controls.Add(this.lbTGID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DELETE);
            this.Name = "Guide_Delete";
            this.Text = "Guide_Delete";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTGID;
        private System.Windows.Forms.TextBox tbTGID;
        private System.Windows.Forms.DataGridView dtgDel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}