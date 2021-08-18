using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmesCRUDRazor.Models
{
  public class Filme
  {
    public int FilmeId { get; set; }

    [Display(Name = "Título")]
    public string Titulo { get; set; }

    [Display(Name = "Data de Lançamento")]
    public DateTime DataLancamento { get; set; }

    [Display(Name = "Gênero")]
    public string Genero { get; set; }

    [Display(Name = "Preço")]
    public decimal Preco { get; set; }
  }
}