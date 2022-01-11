using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace greenTea.Models
{
    [Table("Tabela")]
    public class CardTable
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Adicione uma URL de imagem.")]
        [Column("Img")]
        [Display(Name = "URL da Imagem")]
        public string Img { get; set; }

        [Required(ErrorMessage = "Adicione um nome para o card.")]
        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Selecione uma categoria.")]
        [Column("CategoriaID")]
        [Display(Name = "Categoria")]
        public int CategoriaID { get; set; }
        [ForeignKey("CategoriaID")]
        public virtual Categoria Categoria { get; set; }
    }
}
