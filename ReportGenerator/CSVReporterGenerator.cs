using System.Text;

namespace ReportGenerator
{
    public class CSVReporterGenerator : IReportGenerator
    {
        public List<Dictionary<string, string>> Input { get; set; }
        public string Title { get; set; }
        public string HeadLine { get; set; }
        public string FooterLine { get; set; }
        public string DateOfGeneration { get; set; } = string.Empty;

        public CSVReporterGenerator(List<Dictionary<string, string>> input)
        {
            Input = input;
        }

        public string AddDateOfGeneration()
        {
            DateOfGeneration = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            return DateOfGeneration;
        }

        public string GenerateReport()
        {
            if (Input == null || Input.Count == 0)
            {
                throw new InvalidOperationException("Input cannot be null or empty.");
            }

            StringBuilder report = new StringBuilder();

            if (!string.IsNullOrWhiteSpace(Title))
            {
                report.AppendLine(Title);
                report.AppendLine("");
            }

            if (!string.IsNullOrWhiteSpace(HeadLine))
            {
                report.AppendLine(HeadLine);
                report.AppendLine("");
            }

            string header = string.Join(";", Input.First().Keys);

            report.AppendLine(header);

            foreach (var record in Input)
            {
                string line = string.Join(";", record.Values);
                report.AppendLine(line);
            }

            if (!string.IsNullOrWhiteSpace(FooterLine))
            {
                report.AppendLine("");
                report.AppendLine(FooterLine);
            }

            DateFormatter dateFormatter = new DateFormatter();

            if (!string.IsNullOrWhiteSpace(DateOfGeneration))
            {
                report.AppendLine(DateOfGeneration);
            }

            File.WriteAllText("report.csv", report.ToString(), Encoding.Unicode);
            return Path.GetFullPath("report.csv");
        }
    }
}