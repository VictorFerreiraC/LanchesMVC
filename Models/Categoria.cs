using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lanchesMVC.Models
{
    [Table("categorias")]
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }

        [StringLength(100, ErrorMessage ="O tamanho maximo é 100 caracteres")]
        [Required(ErrorMessage ="Informe o nome da categoria")]
        [Display(Name ="Nome")]
        public string Nome { get; set; }

        [StringLength(200, ErrorMessage = "O tamanho maximo é 200 caracteres")]
        [Required(ErrorMessage = "Informe a descrição da categoria")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public List<Lanche> lanches { get; set; }
    }
}
