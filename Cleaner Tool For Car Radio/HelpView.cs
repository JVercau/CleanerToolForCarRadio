using System;
using System.Windows.Forms;

namespace Cleaner_Tool_For_Car_Radio
{
    public partial class HelpView : Form
    {
        public HelpView()
        {
            InitializeComponent();
        }

        private void buttonCloseHelp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
