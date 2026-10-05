namespace CafeManagement
{
    partial class AdminDashBoardUc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRgelog = new System.Windows.Forms.Button();
            this.ChkRgePass = new System.Windows.Forms.CheckBox();
            this.txtRgeUpass = new System.Windows.Forms.TextBox();
            this.txtRgeUName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRgelog);
            this.panel1.Controls.Add(this.ChkRgePass);
            this.panel1.Controls.Add(this.txtRgeUpass);
            this.panel1.Controls.Add(this.txtRgeUName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 391);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "Admin Log In";
            // 
            // btnRgelog
            // 
            this.btnRgelog.BackColor = System.Drawing.Color.Gray;
            this.btnRgelog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRgelog.Location = new System.Drawing.Point(156, 264);
            this.btnRgelog.Margin = new System.Windows.Forms.Padding(4);
            this.btnRgelog.Name = "btnRgelog";
            this.btnRgelog.Size = new System.Drawing.Size(343, 41);
            this.btnRgelog.TabIndex = 30;
            this.btnRgelog.Text = "LOG IN";
            this.btnRgelog.UseVisualStyleBackColor = false;
            // 
            // ChkRgePass
            // 
            this.ChkRgePass.AutoSize = true;
            this.ChkRgePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkRgePass.Location = new System.Drawing.Point(271, 220);
            this.ChkRgePass.Margin = new System.Windows.Forms.Padding(4);
            this.ChkRgePass.Name = "ChkRgePass";
            this.ChkRgePass.Size = new System.Drawing.Size(164, 24);
            this.ChkRgePass.TabIndex = 29;
            this.ChkRgePass.Text = "Show Password";
            this.ChkRgePass.UseVisualStyleBackColor = true;
            // 
            // txtRgeUpass
            // 
            this.txtRgeUpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRgeUpass.Location = new System.Drawing.Point(268, 175);
            this.txtRgeUpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtRgeUpass.Name = "txtRgeUpass";
            this.txtRgeUpass.PasswordChar = '*';
            this.txtRgeUpass.Size = new System.Drawing.Size(232, 34);
            this.txtRgeUpass.TabIndex = 28;
            // 
            // txtRgeUName
            // 
            this.txtRgeUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRgeUName.Location = new System.Drawing.Point(268, 119);
            this.txtRgeUName.Margin = new System.Windows.Forms.Padding(4);
            this.txtRgeUName.Name = "txtRgeUName";
            this.txtRgeUName.Size = new System.Drawing.Size(232, 34);
            this.txtRgeUName.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "User Name:";
            // 
            // AdminDashBoardUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AdminDashBoardUc";
            this.Size = new System.Drawing.Size(641, 391);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRgelog;
        private System.Windows.Forms.CheckBox ChkRgePass;
        private System.Windows.Forms.TextBox txtRgeUpass;
        private System.Windows.Forms.TextBox txtRgeUName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
