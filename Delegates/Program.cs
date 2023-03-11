using Delegates.Delegates;
using Estudos.Delegates;

internal class Program
{
    private static void Main(string[] args)
    {
        string RetornaMensagem()
        {
            return "Teste 1";
        }

        var mensagem = Message.ObterMensagem(RetornaMensagem);
        Console.WriteLine(mensagem);

        var outraMensagem = Message.ObterOutraMensagem(x => "Teste 2");
        Console.WriteLine(outraMensagem);

        var itensPedido = new List<(decimal precoUnitario, int quantidade)>
        {
            (10.5m, 2),
            (5.25m, 4),
            (15m, 1)
        };

        decimal precoTotal = Calculo.CalcularPrecoTotalPedido((precoUnitario, quantidade) => precoUnitario * quantidade, itensPedido);

        Console.WriteLine($"O preço total do pedido é: {precoTotal}");

    }
}