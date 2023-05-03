using System.ComponentModel.DataAnnotations;

namespace ProgettoCinema.Models
{
    public partial class Utente
    {
        [Key]
        public int IdUtente { get; set; }
        [Required]

        public string Nome { get; set; } = null!;

        public string Cognome { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string Genere { get; set; } = null!;

        public DateTime DataNascita { get; set; }

        public string ComuneResidenza { get; set; } = null!;

        //public virtual ICollection<Posto> Posti { get; set; } = new List<Posto>();

        //public virtual ICollection<Spettacolo> Spettacoli { get; set; } = new List<Spettacolo>();
    }

}
