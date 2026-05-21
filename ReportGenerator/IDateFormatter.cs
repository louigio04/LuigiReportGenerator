namespace ReportGenerator
{
    /// <summary>
    /// Defines a contract for formatting textual representations of dates into a consistent format.
    /// </summary>
    /// <remarks>Implementations should parse inputs in various formats, normalize the representation, and produce
    /// predictable output; document behavior relative to culture, time zone, and handling of invalid inputs.</remarks>
    internal interface IDateFormatter
    {
        /// <summary>
        /// Formats the input string representing a date into a standardized format (e.g., "dd/MM/yyyy HH:mm:ss").
        /// </summary>
        /// <param name="Input">Represents the input string representing a date.</param>
        /// <returns>String containing the formatted date.</returns>
        string FormatDate(string Input);
    }
}
