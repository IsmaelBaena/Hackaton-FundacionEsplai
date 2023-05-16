using System.ComponentModel.DataAnnotations;

namespace HackatonFundacionEsplai.Entities
{
    public class Usuario
    {
        [Key]
        [StringLength(50)]
        [Required]
        public string Email { get; set; }
        [StringLength(50)]
        [Required]
        public string Psswrd { get; set; }
        [StringLength(15)]
        [Required]
        public string Nombre { get; set; }
        [StringLength(15)]
        [Required]
        public string Apellido { get; set; }
    }
}
