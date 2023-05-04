using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoCinema.Models
{
    public partial class Sala
    {
        public int NumSala { get; set; }

        public int NumPosti { get; set; }

        //public virtual ICollection<Posto> Posti { get; set; } = new List<Posto>();

        //public virtual ICollection<Spettacolo> Spettacoli { get; set; } = new List<Spettacolo>();
    }
}
