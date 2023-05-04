using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoCinema.Models
{
    public partial class Posto
    {
        public string Fila { get; set; } = null!;

        public int Numero { get; set; }

        public int Costo { get; set; }

        public int FkUtente { get; set; }

        public int FkNumSala { get; set; }

        //public virtual Sala FkNumSalaNavigation { get; set; } = null!;

        //public virtual Utente FkUtenteNavigation { get; set; } = null!;
    }
}
