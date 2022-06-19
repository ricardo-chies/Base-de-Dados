namespace BaseDeDados.Acesso;

public class AcessoManager
{
    Queue<Acesso> acesso = new Queue<Acesso>();

    public void AdicionarAcessoParaUsuario()
    {
        Acesso novoAcesso = new Acesso();
        Console.WriteLine("\nDigite o nome do usuário para adicionar na fila:");
        novoAcesso.nomeUsuario = Console.ReadLine();

        acesso.Enqueue(novoAcesso);

        int count = 0;

        foreach(Acesso a in acesso){
            count++;
        }  

        novoAcesso.Id = count;
        Console.WriteLine("\nUsuário adicionado na Fila de acesso!");
        Console.ReadKey();
        
    }

    public void LiberarPrimeiroAcessoDaFila()
    {
        Console.WriteLine($"\nAcesso liberado para: {acesso.Peek().nomeUsuario}");
        acesso.Dequeue();
        Console.ReadKey();
    }

    public void RemoverPrimeiroAcessoDaFila()
    {
        int count = 0;
        foreach(Acesso a in acesso)
        {
            count++;
        }
        
        Console.WriteLine($"\nAcesso Removido para: {acesso.Dequeue().nomeUsuario}");
        Console.WriteLine($"\nAcesso Removido para: {acesso.Peek().nomeUsuario}");
        Console.ReadKey();
    }

    public void LiberarTodosOsAcessosDaFila()
    {
        int count = 0;
        foreach(Acesso a in acesso)
        {
            count++;
        }

        while(count > 0)
        {
            acesso.Dequeue();
            count--;
        }
            Console.WriteLine("\nAcesso na Fila liberado para todos!");
        Console.ReadKey();
    }
}