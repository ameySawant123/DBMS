namespace DBMSproject
{
    partial class updateAgency
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
            this.anamecombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aDob = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.agency = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // anamecombo
            // 
            this.anamecombo.FormattingEnabled = true;
            this.anamecombo.Location = new System.Drawing.Point(60, 58);
            this.anamecombo.Name = "anamecombo";
            this.anamecombo.Size = new System.Drawing.Size(121, 21);
            this.anamecombo.TabIndex = 0;
            this.anamecombo.SelectedIndexChanged += new System.EventHandler(this.anamecombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select agent name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select date of birth";
            // 
            // aDob
            // 
            this.aDob.Enabled = false;
            this.aDob.Location = new System.Drawing.Point(60, 116);
            this.aDob.Name = "aDob";
            this.aDob.Size = new System.Drawing.Size(121, 21);
            this.aDob.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter agency name";
            // 
            // agency
            // 
            this.agency.Location = new System.Drawing.Point(60, 174);
            this.agency.Name = "agency";
            this.agency.Size = new System.Drawing.Size(100, 20);
            this.agency.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateAgency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 303);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.agency);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aDob);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.anamecombo);
            this.Name = "updateAgency";
            this.Text = "updateAgency";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox anamecombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox aDob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox agency;
        private System.Windows.Forms.Button button1;
    }
}