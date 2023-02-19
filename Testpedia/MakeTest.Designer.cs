namespace Testpedia
{
    partial class MakeTest
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
            this.questionlist = new System.Windows.Forms.Panel();
            this.topmenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.testcode = new System.Windows.Forms.Label();
            this.addquestion = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.clearall = new System.Windows.Forms.Button();
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
            this.logo.TabIndex = 3;
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
            // questionlist
            // 
            this.questionlist.AutoScroll = true;
            this.questionlist.Location = new System.Drawing.Point(205, 102);
            this.questionlist.Name = "questionlist";
            this.questionlist.Size = new System.Drawing.Size(958, 548);
            this.questionlist.TabIndex = 5;
            // 
            // topmenu
            // 
            this.topmenu.Location = new System.Drawing.Point(205, 12);
            this.topmenu.Name = "topmenu";
            this.topmenu.Size = new System.Drawing.Size(958, 93);
            this.topmenu.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.testcode);
            this.panel2.Controls.Add(this.addquestion);
            this.panel2.Location = new System.Drawing.Point(12, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 548);
            this.panel2.TabIndex = 4;
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
            // addquestion
            // 
            this.addquestion.Location = new System.Drawing.Point(3, 3);
            this.addquestion.Name = "addquestion";
            this.addquestion.Size = new System.Drawing.Size(167, 39);
            this.addquestion.TabIndex = 0;
            this.addquestion.Text = "Add Question";
            this.addquestion.UseVisualStyleBackColor = true;
            this.addquestion.Click += new System.EventHandler(this.addquestion_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Green;
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(976, 670);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(188, 35);
            this.save.TabIndex = 7;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // clearall
            // 
            this.clearall.BackColor = System.Drawing.Color.Red;
            this.clearall.ForeColor = System.Drawing.Color.White;
            this.clearall.Location = new System.Drawing.Point(763, 670);
            this.clearall.Name = "clearall";
            this.clearall.Size = new System.Drawing.Size(188, 35);
            this.clearall.TabIndex = 8;
            this.clearall.Text = "Clear All";
            this.clearall.UseVisualStyleBackColor = false;
            this.clearall.Click += new System.EventHandler(this.clearall_Click);
            // 
            // MakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 717);
            this.Controls.Add(this.clearall);
            this.Controls.Add(this.save);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.questionlist);
            this.Controls.Add(this.topmenu);
            this.Controls.Add(this.panel2);
            this.Name = "MakeTest";
            this.Text = "MakeTest";
            this.logo.ResumeLayout(false);
            this.logo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Label logolabel;
        private System.Windows.Forms.Panel questionlist;
        private System.Windows.Forms.Panel topmenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addquestion;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button clearall;
        private System.Windows.Forms.Label testcode;
    }
}