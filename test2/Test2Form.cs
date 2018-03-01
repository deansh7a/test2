
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2
{
    public partial class Test2Form : Form
    {
        public Test2Form()
        {
            InitializeComponent();
        }

        private void Test2Form_Load(object sender, EventArgs e)
        {
            //adding test comment
            try
            {
                //test
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
