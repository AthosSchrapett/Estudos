using Estudos.Util;
using Spire.Xls;

public class Program
{
    private static void Main(string[] args)
    {
        //var lista = ReadFile.Read();
        //ReadFile.Write(lista);

        Workbook wb = new Workbook();
        wb.LoadFromFile(@"D:\Meus Projetos\Estudos\Estudos gerais\Estudos\Excel\Formulário Logs.xlsx");
        wb.SaveToFile(@"D:\Meus Projetos\Estudos\Estudos gerais\Estudos\Excel\output.xlsb", ExcelVersion.Xlsb2010);
    }
}