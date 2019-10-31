namespace DBMSproject
{
    partial class updateProduction
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
            this.sCombo = new System.Windows.Forms.ComboBox();
            this.pCompTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select series name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Insert the Production company";
            // 
            // sCombo
            // 
            this.sCombo.FormattingEnabled = true;
            this.sCombo.Location = new System.Drawing.Point(74, 73);
            this.sCombo.Name = "sCombo";
            this.sCombo.Size = new System.Drawing.Size(121, 21);
            this.sCombo.TabIndex = 2;
            // 
            // pCompTB
            // 
            this.pCompTB.Location = new System.Drawing.Point(76, 161);
            this.pCompTB.Name = "pCompTB";
            this.pCompTB.Size = new System.Drawing.Size(100, 20);
            this.pCompTB.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 323);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pCompTB);
            this.Controls.Add(this.sCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "updateProduction";
            this.Text = "updateProduction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sCombo;
        private System.Windows.Forms.TextBox pCompTB;
        private System.Windows.Forms.Button button1;
    }
}