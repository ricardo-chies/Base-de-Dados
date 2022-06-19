global using System.Text.RegularExpressions;
namespace BaseDeDados.Usuario;

public class UsuarioManager
{
    public List<Usuario> listaUsuarios = new List<Usuario>();
    public void AdicionarUsuarioNaBase()
    {
        Console.Clear();
        var user = new Usuario();
        Console.WriteLine("Digite o nome do usuário");
        user.Nome = Console.ReadLine();

        Console.WriteLine("Digite o número do CPF");
        user.CPF = Console.ReadLine();

        Console.WriteLine("Digite o número do RA");
        user.RA = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o email");
        user.Email = Console.ReadLine();

        Console.WriteLine("Digite a data de nascimento");
        user.DataDeNascimento = Convert.ToDateTime(Console.ReadLine() ?? "");

        listaUsuarios.Add(user);

        Console.WriteLine("\nUsuário adicionado com sucesso!");
        Console.WriteLine("Tamanho da lista: " + listaUsuarios.Count);
        Console.ReadKey();
    }

    public void RemoverUsuarioDaBase()
    {
        Console.Clear();
        Console.WriteLine("Digite o nome do usuário");
        var nomeParaRemover = Console.ReadLine();
        listaUsuarios.RemoveAll(x => x.Nome.Contains(nomeParaRemover));
        Console.WriteLine("\nUsuário removido com sucesso");
        Console.WriteLine("Tamanho da lista: " + listaUsuarios.Count);
        Console.ReadKey();
    }

    public void AlterarUsuarioNaBase()
    {
        Console.Clear();
        Console.WriteLine("Digite o nome do usuario para alterar");
        var alterarUsuario = Console.ReadLine();
        foreach (Usuario user in listaUsuarios)
        {
            if (user.Nome == alterarUsuario)
            {

                Console.WriteLine("\n1 - Nome: " + user.Nome);
                Console.WriteLine("2 - CPF: " + user.CPF);
                 Console.WriteLine("3 - Ra: " + user.RA);
                Console.WriteLine("4 - Email: " + user.Email);
                Console.WriteLine("5 - Data de Nascimento: " + user.DataDeNascimento + "\n");

                Console.WriteLine("Digite a opção que deseja alterar");
                string alterando = Console.ReadLine();
                switch (alterando)
                {
                    case (string) "1":
                    Console.WriteLine("Digite o novo nome");
                    var novoNome = Console.ReadLine();
                    user.Nome = novoNome;
                    Console.WriteLine("O novo nome agora é: " + user.Nome);
                        break;
                    case (string) "2":
                    Console.WriteLine("Digite o novo CPF");
                    var novoCPF = Console.ReadLine();
                    user.CPF = novoCPF;
                    Console.WriteLine("O novo CPF é: "+ user.CPF);
                        break;
                    case (string) "3":
                    Console.WriteLine("Digite o novo RA");
                    int novoRA = Convert.ToInt32(Console.ReadLine());
                    user.RA = novoRA;
                    Console.WriteLine("O novo RA é: "+ user.RA);
                        break;
                    case (string) "4":
                    Console.WriteLine("Digite o novo Email");
                    var novoEmail = (Console.ReadLine());
                    user.Email = novoEmail;
                    Console.WriteLine("O novo Email é: "+ user.Email);
                        break;
                        case (string) "5":
                    Console.WriteLine("Digite a nova Data de nascimento");
                    var novaData =  Convert.ToDateTime(Console.ReadLine() ?? "");
                    user.DataDeNascimento = novaData;
                    Console.WriteLine("O nova Data de nascimento é: "+ user.DataDeNascimento);
                        break;
                }
            }
                    Console.ReadKey();
        }
    }

    public void PesquisarUsuarioNaBase()
    {
        Console.Clear();
        Console.WriteLine("Digite o nome do usuário");
        var usuariosEncontrados = Console.ReadLine();
        listaUsuarios.FindAll(x => x.Nome.Contains(usuariosEncontrados));
        var result = usuariosEncontrados;
        foreach (Usuario user in listaUsuarios)
        {
            if (user.Nome == result)
            {
                Console.WriteLine("\nUsuário Encontrado!\n");
                Console.WriteLine("Nome: " + user.Nome);
                Console.WriteLine("CPF: " + user.CPF);
                Console.WriteLine("RA: " + user.RA);
                Console.WriteLine("Email: " + user.Email);
                Console.WriteLine("Data de Nascimento: " + user.DataDeNascimento);
            }
        }
        Console.ReadKey();
    }

    public void ListarTodosOsUsuariosDaBase()
    {
        Console.Clear();
        Console.WriteLine("Usuários Encontrados:");
        foreach (Usuario user in listaUsuarios)
        {
            Console.WriteLine("\n[ " + user.Nome + " ]");
        }
        Console.ReadKey();
    }
}
