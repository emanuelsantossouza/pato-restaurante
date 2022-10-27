using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatoRestaurant.Models
{
    [Table("Reservation")]
    public class Reservation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int16 Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Infrome o seu {0}")]
        [StringLength(60, ErrorMessage = "O {0} deve possuir no máximo {1} caracteres")]
        public string Name { get; set; }

        [Display(Name = "Data do Evento")]
        [Required(ErrorMessage = "Infrome a {0}")]
        public DateTime ReservationDate { get; set; }



        [Display(Name = "Celular")]
        [Required(ErrorMessage = "Infrome o seu {0}")]
        [StringLength(60, ErrorMessage = "O {0} deve possuir no máximo {1} caracteres")]
        public string Phone { get; set; }

        [Display(Name = "Convidados")]
        [Required(ErrorMessage = "Informe o seu número de convidado")]
        public byte Guests { get; set; }

        [Display(Name = "E-mail")]
        [StringLength(60, ErrorMessage = "O {0} deve possuir no máximo {1} caracteres")]
        public string Email { get; set; }


        [Display(Name = "Data de Cadastro")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Display(Name = "Status da Resera")]
        public byte StatusReservationId { get; set; }
        [ForeignKey("StatusReservationId")]
        public StatusReservation StatusReservation { get; set; }

    }
}