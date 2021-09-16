using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class SotrydnikRepositorySQL : IRepository<Sotrydnik>
    {
        private MagazinContext db;

        public SotrydnikRepositorySQL(MagazinContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<Sotrydnik> GetList()
        {
            return db.Sotrydnik.ToList();
        }

        public Sotrydnik GetItem(int id)
        {
            return db.Sotrydnik.Find(id);
        }

        public void Create(Sotrydnik item)
        {
            db.Sotrydnik.Add(item);
        }

        public void Update(Sotrydnik item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Sotrydnik item = db.Sotrydnik.Find(id);
            if (item != null)
                db.Sotrydnik.Remove(item);
        }

        public bool Save()
        {
            return db.SaveChanges() > 0;
        }

    }
}
