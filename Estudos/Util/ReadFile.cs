using System.Text;

namespace Estudos.Util;

public static class ReadFile
{
    private static readonly string FilePath = @"D:\Meus Projetos\Estudos\Estudos gerais\Estudos\Empresas1";
    private static ICollection<string[]> Lista => new List<string[]>();

    public static ICollection<string[]> Read()
    {
        var filePath = Path.Combine(FilePath, "K3241.K03200Y1.D30211.EMPRECSV");
        using var reader = new StreamReader(File.OpenRead(filePath));

        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            var values = line?.Split(';');

            if (values != null)
            {
                Lista.Add(values);
            }
        }

        return Lista;
    }

    public static void Write(IEnumerable<string[]> lista)
    {
        var filePath = Path.Combine(FilePath, "teste.csv");
        var values = lista.Select(item => string.Join("|", item).Replace("\"", ""));
        File.WriteAllLines(filePath, values);
    }
}
