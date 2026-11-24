using System;

namespace SolidRefactoringLab
{
    public interface IReportFormatter
    {
        void FormatReport();
    }
    
    public class Pdfformatter : IReportFormatter
    {
        public void FormatReport()
        {
            Console.WriteLine("Formatting report as a pdf...");
        }
    }

    public class WordFormatter : IReportFormatter
    {
        public void FormatReport()
        {
            Console.WriteLine("Formatting report as a word...");
        }
    }

    public class PlainTextFormatter : IReportFormatter
    {
        public void FormatReport()
        {
            Console.WriteLine("Formatting report as a plain text...");
        }
    }

    public class ReportManager
    {
        public string ReportData { get; set; }

        private IReportFormatter formatter;

        public ReportManager(IReportFormatter formatter)
        {
            this.formatter = formatter;
        }

        public void GenerateReport()
        {
            formatter.FormatReport();
        }
    }
    
    public class ReportSaver
    {
        public void SaveToFile(string filename)
        {
            Console.WriteLine($"Saving report data to {filename}");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            IReportFormatter formatter = new Pdfformatter();

            ReportManager manager = new ReportManager(formatter);
            manager.GenerateReport();

            ReportSaver saver = new ReportSaver();
            saver.SaveToFile("Q1_Report.pdf");

        }
    }
}