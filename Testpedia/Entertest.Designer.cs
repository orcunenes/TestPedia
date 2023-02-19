namespace Testpedia
{
    partial class Entertest
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
            this.Join = new System.Windows.Forms.Button();
            this.testcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Join
            // 
            this.Join.Location = new System.Drawing.Point(12, 42);
            this.Join.Name = "Join";
            this.Join.Size = new System.Drawing.Size(190, 40);
            this.Join.TabIndex = 0;
            this.Join.Text = "Join";
            this.Join.UseVisualStyleBackColor = true;
            this.Join.Click += new System.EventHandler(this.Join_Click);
            // 
            // testcode
            // 
            this.testcode.Location = new System.Drawing.Point(86, 16);
            this.testcode.Name = "testcode";
            this.testcode.Size = new System.Drawing.Size(116, 20);
            this.testcode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TESTCODE:";
            // 
            // jointest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 93);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testcode);
            this.Controls.Add(this.Join);
            this.Name = "jointest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "jointest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Join;
        private System.Windows.Forms.TextBox testcode;
        private System.Windows.Forms.Label label1;
    }
}