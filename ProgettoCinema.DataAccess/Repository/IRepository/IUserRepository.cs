using ProgettoCinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoCinema.DataAccess.Repository.IRepository
{
    public interface IUserRepository : IRepository<Utente>
    {
        void Update(Utente category);
        void Save();
    }
}
