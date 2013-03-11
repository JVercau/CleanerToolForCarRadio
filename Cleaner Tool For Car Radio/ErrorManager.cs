using System.Windows.Forms;

namespace Cleaner_Tool_For_Car_Radio
{
    /// <summary>
    /// ErrorManager is a very little API for call a configured MessageBox. It's mostly for displaying messages exceptions into a MessageBox.
    /// </summary>
    abstract class ErrorManager
    {
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
    }
}
