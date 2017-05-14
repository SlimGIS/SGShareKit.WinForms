using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SlimGis.ShareKit.Winforms
{
    public partial class SampleFooter : UserControl
    {
        public SampleFooter()
        {
            InitializeComponent();
        }

        private void QuestionButton_Click(object sender, EventArgs e)
        {
            Process.Start("http://forums.slimgis.com/");
        }

        private void ContactButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please send email to \"support@slimgis.com\".", "Contact us", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void LearnButton_Click(object sender, EventArgs e)
        {
            Process.Start("http://blog.slimgis.com/");
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.slimgis.com/");
        }
    }
}
