using Estudos.Delegates;
using Estudos.Util;
using Spire.Xls;
using static Estudos.Delegates.Message;

public class Program
{
    private static void Main(string[] args)
    {
        string RetornaValor()
        {
            return "Teste 1";
        }

        var mensagem = ObterMensagem(RetornaValor);
        Console.WriteLine(mensagem);

        //string caminho = @"D:\Documentos Importantes\";

        //Workbook wb = new();

        //ExcelReader excelReader = new(caminho, wb);
        //excelReader.OpenFile("Formulário Logs.xlsx");
        //excelReader.WriteFile("output.xlsb", ExcelVersion.Xlsb2010);
    }
}