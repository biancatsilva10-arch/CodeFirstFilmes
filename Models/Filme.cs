using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstFilmes.Models;

public class Filme
{
    public int Id { get; set; }

    public string Titulo { get; set; } = string.Empty;

    public int AnoLancamento { get; set; }

    public int DiretoresId { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Nota { get; set; }

    public Diretores? Diretores { get; set; }

    public ICollection<Genero> Generos { get; set; } = new List<Genero>();
}