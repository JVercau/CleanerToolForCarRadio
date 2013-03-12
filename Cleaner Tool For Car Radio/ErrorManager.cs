using System.Windows.Forms;

namespace Cleaner_Tool_For_Car_Radio
{
    /// <summary>
    /// ErrorManager is a very little API for call a configured MessageBox. It's mostly for displaying messages exceptions into a MessageBox.
    /// </summary>
    public abstract class ErrorManager
    {
        #region Methods error
            /// <summary>
            /// Displaying warning message.
            /// </summary>
            /// <param name="message">string The message to display.</param>
            public static void Warning(string message)
            {
                MessageBox.Show(message, "Une erreur s'est produite", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            /// </summary>
            /// Displaying error message.
            /// <summary
            /// <param name="message">string The message to display.</param>
            public static void Error(string message)
            {
                MessageBox.Show(message, "Une erreur s'est produite", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        #endregion

        #region Methods confirm
            /// <summary>
            /// Display the confirm MessageBox for the replacement file.
            /// </summary>
            /// <param name="full_path_to">string Problematic file path.</param>
            /// <returns>bool Return the user answer.</returns>
            public static bool ReplaceDemand(string full_path_to)
            {
                var dr = MessageBox.Show("Voulez-vous remplacer le fichier déjà présent dans le dossier de destination ?\n\nFichier : " + full_path_to, "Ce fichier existe déjà", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                    return true;
                else
                    return false;
            }
        #endregion
    }
}
