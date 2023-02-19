namespace Testpedia
{
    partial class Testpage
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
            this.logo = new System.Windows.Forms.Panel();
            this.logolabel = new System.Windows.Forms.Label();
            this.questionpanel = new System.Windows.Forms.Panel();
            this.topmenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.testcode = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.logo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Controls.Add(this.logolabel);
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(173, 74);
            this.logo.TabIndex = 9;
            // 
            // logolabel
            // 
            this.logolabel.AutoSize = true;
            this.logolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logolabel.ForeColor = System.Drawing.Color.Red;
            this.logolabel.Location = new System.Drawing.Point(31, 17);
            this.logolabel.Name = "logolabel";
            this.logolabel.Size = new System.Drawing.Size(101, 25);
            this.logolabel.TabIndex = 0;
            this.logolabel.Text = "TestPedia";
            // 
            // questionpanel
            // 
            this.questionpanel.AutoScroll = true;
            this.questionpanel.Location = new System.Drawing.Point(205, 102);
            this.questionpanel.Name = "questionpanel";
            this.questionpanel.Size = new System.Drawing.Size(958, 548);
            this.questionpanel.TabIndex = 11;
            // 
            // topmenu
            // 
            this.topmenu.Location = new System.Drawing.Point(205, 12);
            this.topmenu.Name = "topmenu";
            this.topmenu.Size = new System.Drawing.Size(958, 93);
            this.topmenu.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.testcode);
            this.panel2.Location = new System.Drawing.Point(12, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 548);
            this.panel2.TabIndex = 10;
            // 
            // testcode
            // 
            this.testcode.AutoSize = true;
            this.testcode.Location = new System.Drawing.Point(19, 522);
            this.testcode.Name = "testcode";
            this.testcode.Size = new System.Drawing.Size(62, 13);
            this.testcode.TabIndex = 1;
            this.testcode.Text = "Test Code: ";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Green;
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(976, 670);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(188, 35);
            this.save.TabIndex = 13;
            this.save.Text = "End Quiz";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Testpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 716);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.questionpanel);
            this.Controls.Add(this.topmenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.save);
            this.Name = "Testpage";
            this.Text = "Testpage";
            this.Load += new System.EventHandler(this.Testpage_Load);
            this.logo.ResumeLayout(false);
            this.logo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Label logolabel;
        private System.Windows.Forms.Panel questionpanel;
        private System.Windows.Forms.Panel topmenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label testcode;
        private System.Windows.Forms.Button save;
    }
}