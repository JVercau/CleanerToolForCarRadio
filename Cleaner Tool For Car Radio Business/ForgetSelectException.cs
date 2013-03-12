using System;

namespace Cleaner_Tool_For_Car_Radio_Business
{
    /// <summary>
    /// ForgetSelectException is a subclass inherit of Exception base. It's thrown when a required option has been forgotten.
    /// </summary>
    public class ForgetSelectException : Exception
    {
        /// <summary>
        /// Constructor of ForgetSelectException.
        /// </summary>
        /// <param name="message">string Message of the Exception.</param>
        public ForgetSelectException(string message) : base(message)
        {}
    }
}
