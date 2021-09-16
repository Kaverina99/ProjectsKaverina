using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class DbReposSQL : IDbRepos
    {
        private MagazinContext db;
        private PokProdRepositorySQL pokProdRepository;
        private PokypkaRepositorySQL pokypkaRepository;
        private ProduktRepositorySQL produktRepository;
        private SotrydnikRepositorySQL sotrydnikRepository;
        private Tip_produktaRepositorySQL tip_produktaRepository;
        private OtchetRepositorySQL otchetRepository;

        public DbReposSQL()
        {
            db = new MagazinContext();
        }

        public IRepository<PokProd> PokProd
        {
            get
            {
                if (pokProdRepository == null)
                    pokProdRepository = new PokProdRepositorySQL(db);
                return pokProdRepository;
            }
        }

        public IRepository<Pokypka> Pokypka
        {
            get
            {
                if (pokypkaRepository == null)
                    pokypkaRepository = new PokypkaRepositorySQL(db);
                return pokypkaRepository;
            }
        }

        public IRepository<Produkt> Produkt
        {
            get
            {
                if (produktRepository == null)
                    produktRepository = new ProduktRepositorySQL(db);
                return produktRepository;
            }
        }

        public IRepository<Sotrydnik> Sotrydnik
        {
            get
            {
                if (sotrydnikRepository == null)
                    sotrydnikRepository = new SotrydnikRepositorySQL(db);
                return sotrydnikRepository;
            }
        }

        public IRepository<Tip_produkta> Tip_produkta
        {
            get
            {
                if (tip_produktaRepository == null)
                    tip_produktaRepository = new Tip_produktaRepositorySQL(db);
                return tip_produktaRepository;
            }
        }
        public IOtchetsRepository Otchets
        {
            get
            {
                if (otchetRepository == null)
                    otchetRepository = new OtchetRepositorySQL(db);
                return otchetRepository;
            }
        }

        public int Save()
        {
            return db.SaveChanges();
        }
    }
}
