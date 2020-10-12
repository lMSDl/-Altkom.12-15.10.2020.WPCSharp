namespace SOLID.IV_ISP
{
    internal interface IExcelFormatter
    {
        void ToExcel();
    }

    interface IPdfFormatter
    {
        void ToPdf();
    }

    public class Report : IExcelFormatter, IPdfFormatter
    {
        public void ToExcel()
        {
            System.Console.WriteLine("Generating Excel file...");
        }

        public void ToPdf()
        {
            System.Console.WriteLine("Generating Pdf file...");
        }
    }

    public class Poem : IPdfFormatter
    {
        public void ToPdf()
        {
            System.Console.WriteLine("Generating Pdf file...");
        }
    }
}
