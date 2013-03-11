using System.Windows.Forms;

namespace Cleaner_Tool_For_Car_Radio
{
    public partial class LoadingDialogView : Form
    {
        public LoadingDialogView(int Max)
        {
            InitializeComponent();

            this.pgb.Minimum = 0;
            this.pgb.Maximum = Max;
            this.pgb.Step = 1;

            this.labelLoadingText.Text = "Elément 0 / " + Max;
        }

        /**
         * Getter for "pgb" attribute.
         * @return ProgressBar Return the ProgressBar object called "pgb".
         */
        public ProgressBar GetPgb()
        {
            return this.pgb;
        }

        /**
         * Setter for "labelLoadingText" attribute.
         * @param string txt The text to set "labelLoadingText" attribute.
         * @return LoadingDialog Return the current LoadingDialog object.
         */
        public LoadingDialogView SetLabelLoadingText(string txt)
        {
            this.labelLoadingText.Text = txt;

            return this;
        }
    }
}
