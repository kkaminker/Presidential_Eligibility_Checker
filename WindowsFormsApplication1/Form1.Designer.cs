namespace WindowsFormsApplication1
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
            this.lbl_heading = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.txtbx_age = new System.Windows.Forms.TextBox();
            this.chkbx_usBorn = new System.Windows.Forms.CheckBox();
            this.lbl_yearsResided = new System.Windows.Forms.Label();
            this.txtbx_yearsResided = new System.Windows.Forms.TextBox();
            this.lbl_timesElected = new System.Windows.Forms.Label();
            this.txtbx_timesElected = new System.Windows.Forms.TextBox();
            this.chkbx_convicted = new System.Windows.Forms.CheckBox();
            this.bttn_checkEligible = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.Location = new System.Drawing.Point(3, 9);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(276, 20);
            this.lbl_heading.TabIndex = 0;
            this.lbl_heading.Text = "Are you Eligible to become President?";
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Location = new System.Drawing.Point(13, 53);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(90, 13);
            this.lbl_age.TabIndex = 1;
            this.lbl_age.Text = "How old are you?";
            // 
            // txtbx_age
            // 
            this.txtbx_age.Location = new System.Drawing.Point(190, 46);
            this.txtbx_age.Name = "txtbx_age";
            this.txtbx_age.Size = new System.Drawing.Size(82, 20);
            this.txtbx_age.TabIndex = 2;
            // 
            // chkbx_usBorn
            // 
            this.chkbx_usBorn.AutoSize = true;
            this.chkbx_usBorn.Location = new System.Drawing.Point(16, 86);
            this.chkbx_usBorn.Name = "chkbx_usBorn";
            this.chkbx_usBorn.Size = new System.Drawing.Size(77, 17);
            this.chkbx_usBorn.TabIndex = 3;
            this.chkbx_usBorn.Text = "Born in US";
            this.chkbx_usBorn.UseVisualStyleBackColor = true;
            // 
            // lbl_yearsResided
            // 
            this.lbl_yearsResided.AutoSize = true;
            this.lbl_yearsResided.Location = new System.Drawing.Point(13, 124);
            this.lbl_yearsResided.Name = "lbl_yearsResided";
            this.lbl_yearsResided.Size = new System.Drawing.Size(222, 13);
            this.lbl_yearsResided.TabIndex = 4;
            this.lbl_yearsResided.Text = "How many years have you resided in the US?";
            // 
            // txtbx_yearsResided
            // 
            this.txtbx_yearsResided.Location = new System.Drawing.Point(241, 117);
            this.txtbx_yearsResided.Name = "txtbx_yearsResided";
            this.txtbx_yearsResided.Size = new System.Drawing.Size(36, 20);
            this.txtbx_yearsResided.TabIndex = 5;
            // 
            // lbl_timesElected
            // 
            this.lbl_timesElected.AutoSize = true;
            this.lbl_timesElected.Location = new System.Drawing.Point(13, 151);
            this.lbl_timesElected.Name = "lbl_timesElected";
            this.lbl_timesElected.Size = new System.Drawing.Size(202, 13);
            this.lbl_timesElected.TabIndex = 6;
            this.lbl_timesElected.Text = "How many times have you been elected?";
            // 
            // txtbx_timesElected
            // 
            this.txtbx_timesElected.Location = new System.Drawing.Point(241, 151);
            this.txtbx_timesElected.Name = "txtbx_timesElected";
            this.txtbx_timesElected.Size = new System.Drawing.Size(36, 20);
            this.txtbx_timesElected.TabIndex = 7;
            // 
            // chkbx_convicted
            // 
            this.chkbx_convicted.AutoSize = true;
            this.chkbx_convicted.Location = new System.Drawing.Point(203, 86);
            this.chkbx_convicted.Name = "chkbx_convicted";
            this.chkbx_convicted.Size = new System.Drawing.Size(74, 17);
            this.chkbx_convicted.TabIndex = 8;
            this.chkbx_convicted.Text = "Convicted";
            this.chkbx_convicted.UseVisualStyleBackColor = true;
            // 
            // bttn_checkEligible
            // 
            this.bttn_checkEligible.BackColor = System.Drawing.Color.DarkTurquoise;
            this.bttn_checkEligible.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bttn_checkEligible.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bttn_checkEligible.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttn_checkEligible.Location = new System.Drawing.Point(89, 208);
            this.bttn_checkEligible.Name = "bttn_checkEligible";
            this.bttn_checkEligible.Size = new System.Drawing.Size(103, 41);
            this.bttn_checkEligible.TabIndex = 9;
            this.bttn_checkEligible.Text = "Check Eligibility";
            this.bttn_checkEligible.UseVisualStyleBackColor = false;
            this.bttn_checkEligible.Click += new System.EventHandler(this.bttn_checkEligible_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bttn_checkEligible);
            this.Controls.Add(this.chkbx_convicted);
            this.Controls.Add(this.txtbx_timesElected);
            this.Controls.Add(this.lbl_timesElected);
            this.Controls.Add(this.txtbx_yearsResided);
            this.Controls.Add(this.lbl_yearsResided);
            this.Controls.Add(this.chkbx_usBorn);
            this.Controls.Add(this.txtbx_age);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.lbl_heading);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.TextBox txtbx_age;
        private System.Windows.Forms.CheckBox chkbx_usBorn;
        private System.Windows.Forms.Label lbl_yearsResided;
        private System.Windows.Forms.TextBox txtbx_yearsResided;
        private System.Windows.Forms.Label lbl_timesElected;
        private System.Windows.Forms.TextBox txtbx_timesElected;
        private System.Windows.Forms.CheckBox chkbx_convicted;
        private System.Windows.Forms.Button bttn_checkEligible;
    }
}

