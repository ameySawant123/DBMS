namespace DBMSproject
{
    partial class insertwriter
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.epNo = new System.Windows.Forms.ComboBox();
            this.epcheck = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.moviecheck = new System.Windows.Forms.CheckBox();
            this.mName = new System.Windows.Forms.ComboBox();
            this.wName = new System.Windows.Forms.TextBox();
            this.aName = new System.Windows.Forms.TextBox();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter writer name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select date of birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter agency name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select episode number";
            // 
            // epNo
            // 
            this.epNo.Enabled = false;
            this.epNo.FormattingEnabled = true;
            this.epNo.Location = new System.Drawing.Point(339, 100);
            this.epNo.Name = "epNo";
            this.epNo.Size = new System.Drawing.Size(121, 21);
            this.epNo.TabIndex = 4;
            // 
            // epcheck
            // 
            this.epcheck.AutoSize = true;
            this.epcheck.Location = new System.Drawing.Point(302, 103);
            this.epcheck.Name = "epcheck";
            this.epcheck.Size = new System.Drawing.Size(15, 14);
            this.epcheck.TabIndex = 5;
            this.epcheck.UseVisualStyleBackColor = true;
            this.epcheck.CheckedChanged += new System.EventHandler(this.epcheck_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Select Movie title";
            // 
            // moviecheck
            // 
            this.moviecheck.AutoSize = true;
            this.moviecheck.Location = new System.Drawing.Point(302, 197);
            this.moviecheck.Name = "moviecheck";
            this.moviecheck.Size = new System.Drawing.Size(15, 14);
            this.moviecheck.TabIndex = 7;
            this.moviecheck.UseVisualStyleBackColor = true;
            this.moviecheck.CheckedChanged += new System.EventHandler(this.moviecheck_CheckedChanged);
            // 
            // mName
            // 
            this.mName.Enabled = false;
            this.mName.FormattingEnabled = true;
            this.mName.Location = new System.Drawing.Point(339, 198);
            this.mName.Name = "mName";
            this.mName.Size = new System.Drawing.Size(121, 21);
            this.mName.TabIndex = 8;
            // 
            // wName
            // 
            this.wName.Location = new System.Drawing.Point(73, 75);
            this.wName.Name = "wName";
            this.wName.Size = new System.Drawing.Size(100, 20);
            this.wName.TabIndex = 9;
            // 
            // aName
            // 
            this.aName.Location = new System.Drawing.Point(73, 214);
            this.aName.Name = "aName";
            this.aName.Size = new System.Drawing.Size(100, 20);
            this.aName.TabIndex = 11;
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(73, 150);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(200, 20);
            this.dob.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // insertwriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 386);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.aName);
            this.Controls.Add(this.wName);
            this.Controls.Add(this.mName);
            this.Controls.Add(this.moviecheck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.epcheck);
            this.Controls.Add(this.epNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "insertwriter";
            this.Text = "insertwriter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox epNo;
        private System.Windows.Forms.CheckBox epcheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox moviecheck;
        private System.Windows.Forms.ComboBox mName;
        private System.Windows.Forms.TextBox wName;
        private System.Windows.Forms.TextBox aName;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.Button button1;
    }
}