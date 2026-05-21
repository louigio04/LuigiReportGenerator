namespace ReportGenerator
{
    /// <summary>
    /// Defines the contract for generating reports with customizable input, title, headline, and footer.
    /// </summary>
    /// <remarks>Implementations of this interface allow users to configure report data and metadata, such as
    /// the title, headline, and footer, and generate a report as a string.</remarks>
    public interface IReportGenerator
    {
        /// <summary>
        /// Gets or sets the input data as a list of dictionaries, where each dictionary represents a row of
        /// key-value pairs.
        /// </summary>
        List<Dictionary<string, string>> Input { get; set; }

        /// <summary>
        /// Gets or sets the title associated with the current object.
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Gets or sets the headline associated with the current object.
        /// </summary>
        string HeadLine { get; set; }

        /// <summary>
        /// Gets or sets the footer line associated with the current object.
        /// </summary>
        string FooterLine { get; set; }

        /// <summary>
        /// Gets or sets the date of generation associated with the current object.
        /// </summary>
        string DateOfGeneration { get; set; }

        /// <summary>
        /// Generates a report and returns its file path.
        /// </summary>
        /// <returns>A string containing the generated report's file path.</returns>
        string GenerateReport();
    }
}
