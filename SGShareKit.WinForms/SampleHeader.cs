using System.Windows.Forms;

namespace SlimGis.ShareKit.Winforms
{
    public partial class SampleHeader : UserControl
    {
        public SampleHeader()
        {
            InitializeComponent();
        }

        public PictureBox TitleImage { get { return titleImage; } }

        public Label TitleLabel { get { return titleLabel; } }
    }
}
