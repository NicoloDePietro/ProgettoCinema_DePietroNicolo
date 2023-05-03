using ProgettoCinema.DataAccess.Data;
using ProgettoCinema.DataAccess.Repository.IRepository;
using ProgettoCinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoCinema.DataAccess.Repository
{
    public class UserRepository : Repository<Utente>, IUserRepository
    {
        private readonly ApplicationDbContext _db;
        public UserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Save()
        {
            _db.SaveChanges();
        }
        public void Update(Utente category)
        {
            _db.Utenti.Update(category);
        }
    }
}
