using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatoRestaurant.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int16 Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Infrome o seu {0}")]
        [StringLength(60, ErrorMessage = "O {0} deve possuir no máximo {1} caracteres")]
        public string Name { get; set; }

        [Display(Name = "Descrição")]
        [StringLength(2000, ErrorMessage = "A {0} deve possuir no máximo {1} caracteres")]
        public string Description { get; set; }

        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Required(ErrorMessage = "Infrome o {0}")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Price { get; set; }

        [Display(Name = "Data de Cadastro")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Display(Name = "Categoria ")]
        public byte CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        [Display(Name = "Image")]
        [StringLength(400)]
        public string Image { get; set; }

    }
}