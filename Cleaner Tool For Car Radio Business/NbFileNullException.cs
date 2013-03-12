using System;

namespace Cleaner_Tool_For_Car_Radio_Business
{
    /// <summary>
    /// NbFileNullException is a subclass inherit of Exception base. It's thrown when any valid file not found.
    /// </summary>
    public class NbFileNullException : Exception
    {
        /// <summary>
        /// Constructor of NbFileNullException.
        /// </summary>
        /// <param name="message">string Message of the Exception.</param>
        public NbFileNullException(string message) : base(message)
        {}
    }
}
