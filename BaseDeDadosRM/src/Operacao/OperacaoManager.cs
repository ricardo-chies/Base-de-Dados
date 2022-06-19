namespace BaseDeDados.Operacao;

public class OperacaoManager
{
    Stack<Operacao> operacao = new Stack<Operacao>();

    public void AdicionarNovaOperacao()
    {
        Operacao novaOperacao = new Operacao();

        Console.WriteLine("\nDigite o nome do Usuario para fazer a operação:");
        novaOperacao.Usuario = Console.ReadLine();

        operacao.Push(novaOperacao);

        int count = 0;
        foreach(Operacao o in operacao){
            count++;
        }

        novaOperacao.Id = count;
        Console.WriteLine($"\nOperação: {novaOperacao.Id}");
        Console.WriteLine("Usuário: " + novaOperacao.Usuario);
        Console.ReadKey();
    }

    public void DesfazerUltimaOperacao()
    {
        operacao.Pop();
        Console.WriteLine("\nAinda tem: " + operacao.Count + " operações na pilha");

        Console.ReadLine();
    }

    public void RealizarTodasAsOperacaos()
    {
        int count = 0;
        foreach(Operacao o in operacao)
        {
            count++;
        }
        Console.WriteLine("\nOperações realizadas: "+count);

        while(count>0){
            operacao.Pop();
            count--;
        }
        Console.WriteLine("Operações restantes: "+count);
        Console.ReadKey();
    }
}
