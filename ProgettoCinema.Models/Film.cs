using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoCinema.Models
{
    public partial class Film
    {
        [Key]
        public int IdFilm { get; set; }
        [Required]
        public string Titolo { get; set; } = null!;

        public string Genere { get; set; } = null!;

        public string Descrizione { get; set; } = null!;

        public string Durata { get; set; } = null!;

        public string AnnoProduzione { get; set; } = null!;

        public string Locandina { get; set; } = null!;

        //public ICollection<Spettacolo> Spettacoli { get; set; } = new List<Spettacolo>();
    }
}
