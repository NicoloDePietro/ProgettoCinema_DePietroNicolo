using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoCinema.Models
{
    public partial class Spettacolo
    {
        public string Orario { get; set; } = null!;

        public DateTime Data { get; set; }

        public string FkTitolo { get; set; } = null!;

        //public virtual Film FkTitoloNavigation { get; set; } = null!;

        //public virtual ICollection<Sala> Sale { get; set; } = new List<Sala>();

        //public virtual ICollection<Utente> Utenti { get; set; } = new List<Utente>();
    }
}
