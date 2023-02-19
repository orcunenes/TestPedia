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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            fetch();
        }

        private void testmaker_Click(object sender, EventArgs e)
        {
            MakeTest maketest = new MakeTest();
            maketest.Show();

        }

        private void browse_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void fetch()
        {
            string sql = "select * from Sorular";
            dataGridView1.DataSource= Fetch.Getdata(sql);
        }

        private void jointest_Click(object sender, EventArgs e)
        {
            Entertest entertest= new Entertest();
            entertest.Show();
        }
    }
}
