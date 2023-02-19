using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testpedia
{
    public partial class Testpage : Form
    {
        public string btestcode = string.Empty;
        public Testpage()
        {
            InitializeComponent();
        }

        private void Testpage_Load(object sender, EventArgs e)
        {
            getquestions(btestcode);
            testcode.Text = btestcode;
        }



        public void  getquestions(string testcode)
        {
            int y = 20;
            int questioncount = 0;



            string sql = "select * from Sorular where Testcode=" + testcode;
            Connect.connection.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql, Connect.connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                Label TITLE = new Label
                {
                    Location = new Point(30, 40),
                    Size = new Size(900, 30),
                    Font = new Font("Calibri", 18),
                    BackColor = questionpanel.BackColor,
                    Text = reader["Title"].ToString(),
                    ForeColor = Color.Gray,
                };
                topmenu.Controls.Add(TITLE);



                #region question label


                int x = 20;
                Label qcount = new Label
                {
                    Location = new Point(0, y),
                    Size = new Size(20, 30),
                    Font = new Font("Calibri", 16),
                    Text = questioncount.ToString(),
                    BackColor = questionpanel.BackColor,
                    ForeColor = Color.Red,
                };
                questionpanel.Controls.Add(qcount);

                //Main Question Label
                Label Question = new Label
                {
                    Location = new Point(x, y),
                    Size = new Size(900, 30),
                    Font = new Font("Calibri", 16),
                    Text = reader["Question"].ToString(),
                };
                questionpanel.Controls.Add(Question);
                y += 35;
                #endregion

                #region answers
                RadioButton selection1 = new RadioButton
                {
                    Location = new Point(x - 20, y),
                    Size = new Size(20, 20),
                    Name = "selection1" + questioncount,
                };
                questionpanel.Controls.Add(selection1);

                Label Answer1 = new Label
                {
                    Location = new Point(x, y),
                    Size = new Size(150, 20),
                    Font = new Font("Calibri", 13),
                    Text = reader["Tanswer"].ToString(),
                    Name = "Answer1" + questioncount,

                };
                questionpanel.Controls.Add(Answer1);
                x += 225;


                RadioButton selection2 = new RadioButton
                {
                    Location = new Point(x - 20, y),
                    Size = new Size(20, 20),
                    Name = "selection2" + questioncount,
                };
                questionpanel.Controls.Add(selection2);

                Label Answer2 = new Label
                {
                    Location = new Point(x, y),
                    Size = new Size(150, 20),
                    Font = new Font("Calibri", 13),
                    Text = reader["Fanswer1"].ToString(),
                    Name = "Answer2" + questioncount,

                };
                questionpanel.Controls.Add(Answer2);
                x += 225;


                RadioButton selection3 = new RadioButton
                {
                    Location = new Point(x - 20, y),
                    Size = new Size(20, 20),
                    Name = "selection3" + questioncount,
                };
                questionpanel.Controls.Add(selection3);

                Label Answer3 = new Label
                {
                    Location = new Point(x, y),
                    Size = new Size(150, 20),
                    Font = new Font("Calibri", 13),
                    Text = reader["Fanswer2"].ToString(),
                    Name = "Answer3" + questioncount,

                };
                questionpanel.Controls.Add(Answer3);
                x += 225;


                RadioButton selection4 = new RadioButton
                {
                    Location = new Point(x - 20, y),
                    Size = new Size(20, 20),
                    Name = "selection4" + questioncount,
                };
                questionpanel.Controls.Add(selection4);

                Label Answer4 = new Label
                {
                    Location = new Point(x, y),
                    Size = new Size(150, 20),
                    Font = new Font("Calibri", 13),
                    Text = reader["Fanswer3"].ToString(),
                    Name = "Answer4" + questioncount,

                };
                questionpanel.Controls.Add(Answer4);
                x += 225;

                y += 40;
                questioncount++;
                #endregion
            }


            Connect.connection.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {

        }
    }
}
