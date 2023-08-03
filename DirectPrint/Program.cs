using DirectPrint;

string directory = Directory.GetCurrentDirectory();
string filePath = Path.Combine(directory, "Pdfs");
string fileFullPath = filePath + "\\invoice.pdf";

if (!Directory.Exists(Path.Combine(directory, "Pdfs")))
    Directory.CreateDirectory(Path.Combine(directory, "Pdfs"));
Console.WriteLine(fileFullPath);

ConvertToPdf.HtmlToPdf();

Console.WriteLine(PrintPdf.Print(fileFullPath));

Console.ReadLine();