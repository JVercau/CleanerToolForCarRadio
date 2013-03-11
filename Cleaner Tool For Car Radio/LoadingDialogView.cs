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

        /// </summary>
        /// Getter for "pgb" attribute.
        /// </summary>
        /// <return>ProgressBar Return the ProgressBar object called "pgb".</return>
        public ProgressBar GetPgb()
        {
            return this.pgb;
        }

        /// </summary>
        /// Setter for "labelLoadingText" attribute.
        /// </summary>
        /// <param name="txt">string The text to set "labelLoadingText" attribute.</param>
        /// <returns>LoadingDialog Return the current LoadingDialog object.</returns>
        public LoadingDialogView SetLabelLoadingText(string txt)
        {
            this.labelLoadingText.Text = txt;

            return this;
        }
    }
}
