using NLog.Common;

namespace NLog.DiscardFormatters
{
    /// <summary>
    /// Save  the discard message.
    /// </summary>
    public interface IDiscardLogMessage
    {
        /// <summary>
        /// Save the discard message.
        /// </summary>
        /// <param name="logEvent">LogEvent with message to be formattbed</param>
        void SaveMessage(LogEventInfo logEvent);

        /// <summary>
        /// Has the logevent properties?
        /// </summary>
        /// <param name="asyncLogEventInfo">LogEvent with message to be formatted</param>
        /// <returns>False when logevent has no properties to be extracted</returns>
        bool HasProperties(AsyncLogEventInfo asyncLogEventInfo);
    }
}
