using System;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Cleaner_Tool_For_Car_Radio_Business;

namespace Cleaner_Tool_For_Car_Radio
{
    public partial class MyApplicationView : Form
    {
        private LoadingDialogView _ld;

        public MyApplicationView()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aProposDeCTFCRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutView about = new AboutView();
            about.ShowDialog();
        }

        private void aideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpView help = new HelpView();
            help.ShowDialog();
        }

        private void buttonSource_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                dlg.Description = "Séléctionnez le dossier source...";
                var result = dlg.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.labelChoixSource.Text = dlg.SelectedPath;
                }
            }
        }

        private void buttonDestination_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                dlg.Description = "Séléctionnez le dossier de destination...";
                var result = dlg.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.labelChoixDestination.Text = dlg.SelectedPath;
                }
            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(this.labelChoixSource.Text) || String.IsNullOrWhiteSpace(this.labelChoixDestination.Text))
                    throw new ForgetSelectException("Vous avez oublié de séléctionner la source ou la destination, merci d'effectuer cela et de réessayer.");

                if (!Directory.Exists(this.labelChoixSource.Text) || !Directory.Exists(this.labelChoixDestination.Text))
                    throw new ForgetSelectException("Les répertoires séléctionnés n'existes pas, merci de corriger les chemins et de réessayer.");

                this.backgroundWorker1.RunWorkerAsync();

                this._ld = new LoadingDialogView(CTFCRBusiness.GetNbValidFileInto(this.labelChoixSource.Text));
                this._ld.ShowDialog();
            }
            catch(Exception exc)
            {
                ErrorManager.Warning(exc.Message);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (CTFCRBusiness.GetNbValidFileInto(this.labelChoixSource.Text) > 0)
            {
                foreach (string file in CTFCRBusiness.GetValidFileInto(this.labelChoixSource.Text))
                {
                    string full_path_to = CTFCRBusiness.GetFullPath(this.labelChoixDestination.Text, file);
                    string error = "";

                    CTFCRBusiness.Copy(file, full_path_to, ref error);

                    if (error == "FILE_ALREADY_EXIST")
                    {
                        if (ErrorManager.ReplaceDemand(full_path_to))
                            CTFCRBusiness.Copy(file, full_path_to);
                    }

                    if (this.checkBoxTypeOptimisation.Checked)
                        CTFCRBusiness.EraseTags(full_path_to);
                    else
                        CTFCRBusiness.CleanTags(full_path_to);

                    Thread.Sleep(100);

                    this.backgroundWorker1.ReportProgress(this._ld.GetPgb().Value * 100 / this._ld.GetPgb().Maximum);
                }
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
                ErrorManager.Warning(e.Error.Message);
            else
            {
                this._ld.Close();
                this._ld = null;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this._ld.GetPgb().PerformStep();
            this._ld.SetLabelLoadingText("Elément " + this._ld.GetPgb().Value + " / " + this._ld.GetPgb().Maximum);
        }
    }
}
