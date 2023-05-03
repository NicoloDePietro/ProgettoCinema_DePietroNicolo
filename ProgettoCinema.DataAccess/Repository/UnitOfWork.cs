using ProgettoCinema.DataAccess.Data;
using ProgettoCinema.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoCinema.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Utente = new UserRepository(_db);
        }
        public IUserRepository Utente { get; private set; } = null!;
        public void Save()
        {
            _db.SaveChanges();
        }
    }

}
