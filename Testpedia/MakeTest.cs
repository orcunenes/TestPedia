using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testpedia
{
    public partial class MakeTest : Form
    {
        public MakeTest()
        {
            InitializeComponent();
            Random rng = new Random();
            string digits = GenerateDigits(rng, 9);
            testcode.Text =testcode.Text+" : "+ digits;

            TextBox TITLE = new TextBox
            {
                Location = new Point(30, 40),
                Size = new Size(900, 30),
                Font = new Font("Calibri", 18),
                BackColor = questionlist.BackColor,
                Text = "TITLE",
                ForeColor = Color.Gray,
            };
            TITLE.Click += new EventHandler(Textbox_click);
            topmenu.Controls.Add(TITLE);

        }
        List<Label> labels = new List<Label>();
        int y = 20;
        int questioncount = 0;
        private void addquestion_Click(object sender, EventArgs e)
        {
            int x = 20;
            questioncount++;
            Label qcount = new Label
            {
                Location = new Point(0, y),
                Size = new Size(20, 30),
                Font = new Font("Calibri", 16),
                Text = questioncount.ToString(),
                BackColor = questionlist.BackColor,
                ForeColor = Color.Red,
            };
            questionlist.Controls.Add(qcount);

            //Main Question Label
            TextBox Question = new TextBox
            {
                Location = new Point(x, y),
                Size = new Size(900, 30),
                Font = new Font("Calibri", 16),
                Text = "click here to edit question",
                BackColor = questionlist.BackColor,
                ForeColor=Color.Gray,
            };
            Question.Click += new EventHandler(Textbox_click);

            questionlist.Controls.Add(Question);
            y += 35;

            for (int i = 0; i < 4; i++)
            {
                TextBox Answer1 = new TextBox
                {
                    Location = new Point(x, y),
                    Size = new Size(150, 20),
                    Font = new Font("Calibri", 13),
                    Text = "Answer",
                    BackColor = questionlist.BackColor,
                    ForeColor = Color.Gray,

                };
                Answer1.Click += new EventHandler(Textbox_click);
                questionlist.Controls.Add(Answer1);
                x += 225;

            }
            y += 40;
        }

        private void testmaker_Click(object sender, EventArgs e)
        {
            MakeTest maketest=new MakeTest();
            maketest.Show();
        }

        private void clearall_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure", "Clearing All", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                questionlist.Controls.Clear(); 
                 y = 20;
                 questioncount = 0;

            }
        }

        protected void Textbox_click(object sender, EventArgs e)
        {
            //attempt to cast the sender as a label
            TextBox txtbox = sender as TextBox;

            //if the cast was successful (i.e. not null), navigate to the site
            if (txtbox != null)
            {
                txtbox.Text = string.Empty;
                txtbox.ForeColor = Color.Black;

            }
        }


        static string GenerateDigits(Random rng, int length)
        {
            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = (char)(rng.Next(10) + '0');
            }
            return new string(chars);
        }

    }
}
