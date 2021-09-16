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
    public class PokypkaRepositorySQL : IRepository<Pokypka>
    {
        private MagazinContext db;

        public PokypkaRepositorySQL(MagazinContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<Pokypka> GetList()
        {
            return db.Pokypka.ToList();
        }

        public Pokypka GetItem(int id)
        {
            return db.Pokypka.Find(id);
        }

        public int Create(Pokypka item)
        {
            db.Pokypka.Add(item);
            return item.Id;
        }

        public void Update(Pokypka item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Pokypka item = db.Pokypka.Find(id);
            if (item != null)
                db.Pokypka.Remove(item);
        }

        public bool Save()
        {
            return db.SaveChanges() > 0;
        }

    }
}
