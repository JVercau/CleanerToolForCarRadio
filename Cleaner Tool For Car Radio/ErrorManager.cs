using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cleaner_Tool_For_Car_Radio
{
    /**
     * ErrorManager is a very little API for call a configured MessageBox. It's mostly for displaying messages exceptions into a MessageBox.
     * @author NaruT
     */
    abstract class ErrorManager
    {
        /**
         * Displaying warning message.
         * @param string message The message to display.
         */
        public static void warning(string message)
        {
            MessageBox.Show(message, "Une erreur s'est produite", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /**
         * Displaying error message.
         * @param string message The message to display.
         */
        public static void error(string message)
        {
            MessageBox.Show(message, "Une erreur s'est produite", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
