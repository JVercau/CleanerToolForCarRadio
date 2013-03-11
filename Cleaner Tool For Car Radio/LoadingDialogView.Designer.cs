namespace Cleaner_Tool_For_Car_Radio
{
    partial class LoadingDialogView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pgb = new System.Windows.Forms.ProgressBar();
            this.labelLoadingText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pgb
            // 
            this.pgb.Location = new System.Drawing.Point(12, 42);
            this.pgb.Name = "pgb";
            this.pgb.Size = new System.Drawing.Size(501, 28);
            this.pgb.TabIndex = 0;
            // 
            // labelLoadingText
            // 
            this.labelLoadingText.AutoSize = true;
            this.labelLoadingText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoadingText.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelLoadingText.Location = new System.Drawing.Point(203, 9);
            this.labelLoadingText.Name = "labelLoadingText";
            this.labelLoadingText.Size = new System.Drawing.Size(99, 21);
            this.labelLoadingText.TabIndex = 1;
            this.labelLoadingText.Text = "Elément x / y";
            // 
            // LoadingDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(525, 82);
            this.ControlBox = false;
            this.Controls.Add(this.labelLoadingText);
            this.Controls.Add(this.pgb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Traitement";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgb;
        private System.Windows.Forms.Label labelLoadingText;
    }
}