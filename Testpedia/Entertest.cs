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
    public partial class Entertest : Form
    {
        public Entertest()
        {
            InitializeComponent();
        }

        private void Join_Click(object sender, EventArgs e)
        {
            Testpage testpage= new Testpage();
            testpage.btestcode = testcode.Text;
            testpage.Show();
            this.Close();

        }
    }
}
