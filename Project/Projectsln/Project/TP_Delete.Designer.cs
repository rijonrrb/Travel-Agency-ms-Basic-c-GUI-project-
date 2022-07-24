namespace Project
{
    partial class TP_Delete
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
            this.btnsrch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnpackDel = new System.Windows.Forms.Button();
            this.tbTpId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gvTpDel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvTpDel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsrch
            // 
            this.btnsrch.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrch.Location = new System.Drawing.Point(509, 134);
            this.btnsrch.Name = "btnsrch";
            this.btnsrch.Size = new System.Drawing.Size(92, 37);
            this.btnsrch.TabIndex = 21;
            this.btnsrch.Text = "Search";
            this.btnsrch.UseVisualStyleBackColor = true;
            this.btnsrch.Click += new System.EventHandler(this.btnsrch_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(177, 527);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 37);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnpackDel
            // 
            this.btnpackDel.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpackDel.Location = new System.Drawing.Point(391, 527);
            this.btnpackDel.Name = "btnpackDel";
            this.btnpackDel.Size = new System.Drawing.Size(92, 37);
            this.btnpackDel.TabIndex = 19;
            this.btnpackDel.Text = "Delete";
            this.btnpackDel.UseVisualStyleBackColor = true;
            this.btnpackDel.Click += new System.EventHandler(this.btnpackDel_Click);
            // 
            // tbTpId
            // 
            this.tbTpId.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTpId.Location = new System.Drawing.Point(237, 139);
            this.tbTpId.Name = "tbTpId";
            this.tbTpId.Size = new System.Drawing.Size(244, 27);
            this.tbTpId.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Selected Tour Package Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tour Package ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "DELETE A TOUR PACKAGE";
            // 
            // gvTpDel
            // 
            this.gvTpDel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTpDel.Location = new System.Drawing.Point(107, 249);
            this.gvTpDel.Name = "gvTpDel";
            this.gvTpDel.RowTemplate.Height = 24;
            this.gvTpDel.Size = new System.Drawing.Size(473, 237);
            this.gvTpDel.TabIndex = 22;
            // 
            // TP_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 634);
            this.Controls.Add(this.gvTpDel);
            this.Controls.Add(this.btnsrch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnpackDel);
            this.Controls.Add(this.tbTpId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TP_Delete";
            this.Text = "TP_Delete";
            ((System.ComponentModel.ISupportInitialize)(this.gvTpDel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsrch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnpackDel;
        private System.Windows.Forms.TextBox tbTpId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvTpDel;
    }
}