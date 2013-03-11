namespace Cleaner_Tool_For_Car_Radio
{
    partial class MyApplicationView
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyApplicationView));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposDeCTFCRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRun = new System.Windows.Forms.Button();
            this.labelChoixDestination = new System.Windows.Forms.Label();
            this.labelChoixSource = new System.Windows.Forms.Label();
            this.buttonDestination = new System.Windows.Forms.Button();
            this.labelDossierDestination = new System.Windows.Forms.Label();
            this.buttonSource = new System.Windows.Forms.Button();
            this.labelDossierSource = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.checkBoxTypeOptimisation = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.toolStripMenuItem1});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            resources.ApplyResources(this.fichierToolStripMenuItem, "fichierToolStripMenuItem");
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            resources.ApplyResources(this.quitterToolStripMenuItem, "quitterToolStripMenuItem");
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aideToolStripMenuItem,
            this.aProposDeCTFCRToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            resources.ApplyResources(this.aideToolStripMenuItem, "aideToolStripMenuItem");
            this.aideToolStripMenuItem.Click += new System.EventHandler(this.aideToolStripMenuItem_Click);
            // 
            // aProposDeCTFCRToolStripMenuItem
            // 
            this.aProposDeCTFCRToolStripMenuItem.Name = "aProposDeCTFCRToolStripMenuItem";
            resources.ApplyResources(this.aProposDeCTFCRToolStripMenuItem, "aProposDeCTFCRToolStripMenuItem");
            this.aProposDeCTFCRToolStripMenuItem.Click += new System.EventHandler(this.aProposDeCTFCRToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxTypeOptimisation);
            this.panel1.Controls.Add(this.buttonRun);
            this.panel1.Controls.Add(this.labelChoixDestination);
            this.panel1.Controls.Add(this.labelChoixSource);
            this.panel1.Controls.Add(this.buttonDestination);
            this.panel1.Controls.Add(this.labelDossierDestination);
            this.panel1.Controls.Add(this.buttonSource);
            this.panel1.Controls.Add(this.labelDossierSource);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // buttonRun
            // 
            resources.ApplyResources(this.buttonRun, "buttonRun");
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // labelChoixDestination
            // 
            resources.ApplyResources(this.labelChoixDestination, "labelChoixDestination");
            this.labelChoixDestination.Name = "labelChoixDestination";
            // 
            // labelChoixSource
            // 
            resources.ApplyResources(this.labelChoixSource, "labelChoixSource");
            this.labelChoixSource.Name = "labelChoixSource";
            // 
            // buttonDestination
            // 
            resources.ApplyResources(this.buttonDestination, "buttonDestination");
            this.buttonDestination.Name = "buttonDestination";
            this.buttonDestination.UseVisualStyleBackColor = true;
            this.buttonDestination.Click += new System.EventHandler(this.buttonDestination_Click);
            // 
            // labelDossierDestination
            // 
            resources.ApplyResources(this.labelDossierDestination, "labelDossierDestination");
            this.labelDossierDestination.Name = "labelDossierDestination";
            // 
            // buttonSource
            // 
            resources.ApplyResources(this.buttonSource, "buttonSource");
            this.buttonSource.Name = "buttonSource";
            this.buttonSource.UseVisualStyleBackColor = true;
            this.buttonSource.Click += new System.EventHandler(this.buttonSource_Click);
            // 
            // labelDossierSource
            // 
            resources.ApplyResources(this.labelDossierSource, "labelDossierSource");
            this.labelDossierSource.Name = "labelDossierSource";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // checkBoxTypeOptimisation
            // 
            resources.ApplyResources(this.checkBoxTypeOptimisation, "checkBoxTypeOptimisation");
            this.checkBoxTypeOptimisation.Name = "checkBoxTypeOptimisation";
            this.checkBoxTypeOptimisation.UseVisualStyleBackColor = true;
            // 
            // MyApplication
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MyApplication";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposDeCTFCRToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDestination;
        private System.Windows.Forms.Label labelDossierDestination;
        private System.Windows.Forms.Button buttonSource;
        private System.Windows.Forms.Label labelDossierSource;
        private System.Windows.Forms.Label labelChoixDestination;
        private System.Windows.Forms.Label labelChoixSource;
        private System.Windows.Forms.Button buttonRun;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox checkBoxTypeOptimisation;
    }
}

