using System;
using System.Diagnostics;
using System.Windows.Forms;

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
            Process.Start("https://forums.slimgis.com/");
        }

        private void ContactButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please send email to \"support@slimgis.com\".", "Contact us", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void LearnButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://blog.slimgis.com/");
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.slimgis.com/");
        }
    }
}
