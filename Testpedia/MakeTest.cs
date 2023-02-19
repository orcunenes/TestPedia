using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testpedia
{
    public partial class MakeTest : Form
    {
        List<TextBox> Titles = new List<TextBox>();
        List<TextBox> Questions = new List<TextBox>();
        List<TextBox> Answers = new List<TextBox>();
        List<TextBox> TrueAnswer = new List<TextBox>();
        string generatedtestcode = string.Empty;

        public MakeTest()
        {
            InitializeComponent();
            Random rng = new Random();
            generatedtestcode = GenerateDigits(rng, 9);
            testcode.Text = testcode.Text + " : " + generatedtestcode;

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
            Titles.Add(TITLE);

        }


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
                ForeColor = Color.Gray,
            };
            Question.Click += new EventHandler(Textbox_click);
            Questions.Add(Question);
            questionlist.Controls.Add(Question);
            y += 35;


            TextBox Answer1 = new TextBox
            {
                Location = new Point(x, y),
                Size = new Size(150, 20),
                Font = new Font("Calibri", 13),
                Text = "Answer",
                Name = "Answer1" + questioncount,
                BackColor = questionlist.BackColor,
                ForeColor = Color.Gray,

            };
            Answers.Add(Answer1);
            Answer1.Click += new EventHandler(Textbox_click);
            questionlist.Controls.Add(Answer1);

            x += 225;

            TextBox Answer2 = new TextBox
            {
                Location = new Point(x, y),
                Size = new Size(150, 20),
                Font = new Font("Calibri", 13),
                Text = "Answer",
                Name = "Answer2" + questioncount,
                BackColor = questionlist.BackColor,
                ForeColor = Color.Gray,

            };
            Answers.Add(Answer2);
            Answer2.Click += new EventHandler(Textbox_click);
            questionlist.Controls.Add(Answer2);

            x += 225;

            TextBox Answer3 = new TextBox
            {
                Location = new Point(x, y),
                Size = new Size(150, 20),
                Font = new Font("Calibri", 13),
                Text = "Answer",
                Name = "Answer3" + questioncount,
                BackColor = questionlist.BackColor,
                ForeColor = Color.Gray,

            };
            Answers.Add(Answer3);
            Answer3.Click += new EventHandler(Textbox_click);
            questionlist.Controls.Add(Answer3);

            x += 225;
            TextBox Answer4 = new TextBox
            {
                Location = new Point(x, y),
                Size = new Size(150, 20),
                Font = new Font("Calibri", 13),
                Text = "Answer",
                Name = "Answer4" + questioncount,
                BackColor = questionlist.BackColor,
                ForeColor = Color.Gray,

            };
            Answers.Add(Answer4);
            Answer4.Click += new EventHandler(Textbox_click);
            questionlist.Controls.Add(Answer4);
            x += 65;


            y += 40;
        }

        private void testmaker_Click(object sender, EventArgs e)
        {
            MakeTest maketest = new MakeTest();
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

        private void save_Click(object sender, EventArgs e)
        {
            foreach (TextBox Question in Questions)
            {
                int i = 0;
                if (Question.Text != null || Question.Text != string.Empty)
                {
                    string sql = "Insert into Sorular(Soru,Dcevap,Ycevap1,Ycevap2,Ycevap3,Testkodu) Values('" + Question.Text + "','" + Answers.Single(x => x.Name == ("Answer1" + (i + 1).ToString())).Text + "','" +
                                             Answers.Single(x => x.Name == ("Answer2" + (i + 1).ToString())).Text + "','" + Answers.Single(x => x.Name == ("Answer3" + (i + 1).ToString())).Text + "','" + Answers.Single(x => x.Name == ("Answer4" + (i + 1).ToString())).Text + "','" + generatedtestcode + "')";
                    savequestion(sql);
                }   
            }
        }
        public static bool savequestion(string sql)
        {
            SQLiteCommand cmd = new SQLiteCommand(sql, Connect.connection);
            Connect.connection.Open();
            cmd.ExecuteReader();
            return true;
        }
    }
}
