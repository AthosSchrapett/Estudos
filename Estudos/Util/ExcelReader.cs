using Spire.Xls;

namespace Estudos.Util;

public class ExcelReader
{
    public string CaminhoEntrada { get; set; }
    public Workbook Workbook { get; set; }

    public ExcelReader(string caminhoEntrada, Workbook workbook)
    {
        CaminhoEntrada = caminhoEntrada;
        Workbook = workbook;
    }

    public void OpenFile(string filename)
    {
        Workbook.LoadFromFile(Path.Combine(CaminhoEntrada, filename));
    }

    public void WriteFile(string filename, ExcelVersion excelVersion)
    {
        Workbook.SaveToFile(Path.Combine(CaminhoEntrada, filename), excelVersion);
    }
}
