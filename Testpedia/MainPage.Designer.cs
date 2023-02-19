namespace Testpedia
{
    partial class MainPage
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.topmenu = new System.Windows.Forms.Panel();
            this.testmaker = new System.Windows.Forms.Button();
            this.jointest = new System.Windows.Forms.Button();
            this.myprofile = new System.Windows.Forms.Button();
            this.browse = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.main = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.logo.SuspendLayout();
            this.topmenu.SuspendLayout();
            this.main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Controls.Add(this.logolabel);
            this.logo.Location = new System.Drawing.Point(1, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(173, 74);
            this.logo.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(1, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 548);
            this.panel2.TabIndex = 1;
            // 
            // topmenu
            // 
            this.topmenu.Controls.Add(this.testmaker);
            this.topmenu.Controls.Add(this.jointest);
            this.topmenu.Controls.Add(this.myprofile);
            this.topmenu.Controls.Add(this.browse);
            this.topmenu.Controls.Add(this.button1);
            this.topmenu.Location = new System.Drawing.Point(194, 0);
            this.topmenu.Name = "topmenu";
            this.topmenu.Size = new System.Drawing.Size(958, 74);
            this.topmenu.TabIndex = 2;
            // 
            // testmaker
            // 
            this.testmaker.Location = new System.Drawing.Point(657, 3);
            this.testmaker.Name = "testmaker";
            this.testmaker.Size = new System.Drawing.Size(89, 37);
            this.testmaker.TabIndex = 7;
            this.testmaker.Text = "Test Maker";
            this.testmaker.UseVisualStyleBackColor = true;
            this.testmaker.Click += new System.EventHandler(this.testmaker_Click);
            // 
            // jointest
            // 
            this.jointest.Location = new System.Drawing.Point(865, 3);
            this.jointest.Name = "jointest";
            this.jointest.Size = new System.Drawing.Size(79, 37);
            this.jointest.TabIndex = 6;
            this.jointest.Text = "Join Test";
            this.jointest.UseVisualStyleBackColor = true;
            this.jointest.Click += new System.EventHandler(this.jointest_Click);
            // 
            // myprofile
            // 
            this.myprofile.Location = new System.Drawing.Point(752, 3);
            this.myprofile.Name = "myprofile";
            this.myprofile.Size = new System.Drawing.Size(107, 37);
            this.myprofile.TabIndex = 5;
            this.myprofile.Text = "My Profile";
            this.myprofile.UseVisualStyleBackColor = true;
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(302, 3);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(145, 59);
            this.browse.TabIndex = 4;
            this.browse.Text = "Browse Tests";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 59);
            this.button1.TabIndex = 3;
            this.button1.Text = "Main Page";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            this.main.Controls.Add(this.dataGridView1);
            this.main.Controls.Add(this.label1);
            this.main.Location = new System.Drawing.Point(194, 90);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(958, 548);
            this.main.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(134, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(494, 275);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1161, 648);
            this.Controls.Add(this.main);
            this.Controls.Add(this.topmenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.logo);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.logo.ResumeLayout(false);
            this.logo.PerformLayout();
            this.topmenu.ResumeLayout(false);
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Label logolabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel topmenu;
        private System.Windows.Forms.Button testmaker;
        private System.Windows.Forms.Button jointest;
        private System.Windows.Forms.Button myprofile;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

