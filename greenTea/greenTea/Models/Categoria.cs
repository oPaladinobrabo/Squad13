using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace greenTea.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Adicione o nome da categoria.")]
        [Column("Nome")]
        [Display(Name = "Nome da Categoria")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Selecione uma cor.")]
        [Column("Cor")]
        [Display(Name = "Cor")]
        public string Cor { get; set; }

    }
}