namespace LL
{
    partial class FormPowerCalc
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
            this.btPowerCalc = new System.Windows.Forms.Button();
            this.tbPowerDbm = new System.Windows.Forms.TextBox();
            this.tbPowerWatter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btPowerCalc
            // 
            this.btPowerCalc.Location = new System.Drawing.Point(210, 21);
            this.btPowerCalc.Name = "btPowerCalc";
            this.btPowerCalc.Size = new System.Drawing.Size(75, 67);
            this.btPowerCalc.TabIndex = 0;
            this.btPowerCalc.Text = "计算";
            this.btPowerCalc.UseVisualStyleBackColor = true;
            this.btPowerCalc.Click += new System.EventHandler(this.btPowerCalc_Click);
            // 
            // tbPowerDbm
            // 
            this.tbPowerDbm.Location = new System.Drawing.Point(68, 21);
            this.tbPowerDbm.Name = "tbPowerDbm";
            this.tbPowerDbm.Size = new System.Drawing.Size(100, 21);
            this.tbPowerDbm.TabIndex = 1;
            // 
            // tbPowerWatter
            // 
            this.tbPowerWatter.Location = new System.Drawing.Point(68, 67);
            this.tbPowerWatter.Name = "tbPowerWatter";
            this.tbPowerWatter.Size = new System.Drawing.Size(100, 21);
            this.tbPowerWatter.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "dBm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Watter:";
            // 
            // FormPowerCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 127);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPowerWatter);
            this.Controls.Add(this.tbPowerDbm);
            this.Controls.Add(this.btPowerCalc);
            this.Name = "FormPowerCalc";
            this.Text = "PowerCalc";
            this.Load += new System.EventHandler(this.FormPowerCalc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPowerCalc;
        private System.Windows.Forms.TextBox tbPowerDbm;
        private System.Windows.Forms.TextBox tbPowerWatter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}