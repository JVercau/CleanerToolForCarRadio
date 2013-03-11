using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

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
                    throw new Exception("Vous avez oublié de séléctionner la source ou la destination, merci d'effectuer cela et de réessayer.");

                if (!Directory.Exists(this.labelChoixSource.Text) || !Directory.Exists(this.labelChoixDestination.Text))
                    throw new Exception("Les répertoires séléctionnés n'existes pas, merci de corriger les chemins et de réessayer.");

                this.backgroundWorker1.RunWorkerAsync();

                this._ld = new LoadingDialogView(Directory.GetFiles(this.labelChoixSource.Text).Length);
                this._ld.ShowDialog();
            }
            catch(Exception exc)
            {
                ErrorManager.Warning(exc.Message);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Regex reg = new Regex(@"\W");
            List<string> list_ext = new List<string> { ".mp3", ".wma", ".m4a", ".ogg", ".flac" };

            foreach (string file in Directory.GetFiles(this.labelChoixSource.Text))
            {
                if (list_ext.Contains(Path.GetExtension(file).ToLower()))
                {
                    string full_path_to = this.labelChoixDestination.Text + "\\" + reg.Replace(Path.GetFileNameWithoutExtension(file), "-") + Path.GetExtension(file).ToLower();
                    bool go = true;

                    if (File.Exists(full_path_to))
                    {
                        var dr = MessageBox.Show("Voulez-vous remplacer le fichier déjà présent dans le dossier de destination ?\n\nFichier : " + full_path_to, "Ce fichier existe déjà", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dr == DialogResult.No)
                            go = false;
                    }

                    if (go)
                        File.Copy(file, full_path_to, true);

                    TagLib.File tag_of = TagLib.File.Create(full_path_to);

                    if (this.checkBoxTypeOptimisation.Checked)
                    {
                        tag_of.Tag.Album = "";
                        tag_of.Tag.AlbumArtists = new string[1];
                        tag_of.Tag.Artists = new string[1];
                        tag_of.Tag.Comment = "";
                        tag_of.Tag.Composers = new string[1];
                        tag_of.Tag.Conductor = "";
                        tag_of.Tag.Copyright = "";
                        tag_of.Tag.Title = "";
                    }
                    else
                    {
                        tag_of.Tag.Album = String.IsNullOrWhiteSpace(tag_of.Tag.Album) ? "" : reg.Replace(tag_of.Tag.Album, "_");
                        tag_of.Tag.AlbumArtists = new string[1];
                        tag_of.Tag.Artists = new string[1];
                        tag_of.Tag.Comment = String.IsNullOrWhiteSpace(tag_of.Tag.Comment) ? "" : reg.Replace(tag_of.Tag.Comment, "_");
                        tag_of.Tag.Composers = new string[1];
                        tag_of.Tag.Conductor = String.IsNullOrWhiteSpace(tag_of.Tag.Conductor) ? "" : reg.Replace(tag_of.Tag.Conductor, "_");
                        tag_of.Tag.Copyright = String.IsNullOrWhiteSpace(tag_of.Tag.Copyright) ? "" : reg.Replace(tag_of.Tag.Copyright, "_");
                        tag_of.Tag.Title = String.IsNullOrWhiteSpace(tag_of.Tag.Title) ? "" : reg.Replace(tag_of.Tag.Title, "_");
                    }

                    tag_of.Save();

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
