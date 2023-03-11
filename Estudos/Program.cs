using Estudos.Util;
using Spire.Xls;

public class Program
{
    private static void Main(string[] args)
    {
        string caminho = @"D:\Documentos Importantes\";

        Workbook wb = new();

        ExcelReader excelReader = new(caminho, wb);
        excelReader.OpenFile("Formulário Logs.xlsx");
        excelReader.WriteFile("output.xlsb", ExcelVersion.Xlsb2010);
    }
}