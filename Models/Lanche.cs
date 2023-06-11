using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lanchesMVC.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int IdLanche { get; set; }

        [StringLength(80, MinimumLength =10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2}")]
        [Required(ErrorMessage = "Informe o nome do lanche")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [StringLength(200, MinimumLength = 20, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2}")]
        [Required(ErrorMessage = "Informe a descrição curta do lanche")]
        [Display(Name = "Descrição curta")]
        public string DescricaoCurta { get; set; }

        [StringLength(200, MinimumLength = 20, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2}")]
        [Required(ErrorMessage = "Informe a descrição detalhada do lanche")]
        [Display(Name = "Descrição detalhada")]
        public string DescricaoDetalhada { get; set; }


        [Required(ErrorMessage = "Informe o preço do lanche")]
        [Display(Name = "Preço")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage ="O preço deve estar entre 1 e 999,99")]
        public decimal Preco { get; set; }

        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {2} caracteres")]
        [Display(Name = "caminho da Imagem Normal")]
        public string ImagemUrl { get; set; }

        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {2} caracteres")]
        [Display(Name = "caminho da Imagem Miniatura")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]
        public bool LanchePrerido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        public int IdCategoria { get; set; } // FK da tabela Categoria
        public virtual Categoria Categoria { get; set; }
    }
}
