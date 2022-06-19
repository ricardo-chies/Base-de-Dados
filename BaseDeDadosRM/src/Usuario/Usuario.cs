namespace BaseDeDados.Usuario;

public class Usuario {
    public int RA { get; set; }
    public string? Nome { get; set; } = "";
    public string? CPF { get; set; }
    public string? Email { get; set; }
    public DateTime DataDeNascimento { get; set; }
}