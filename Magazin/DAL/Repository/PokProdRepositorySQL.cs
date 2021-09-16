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
    public class PokProdRepositorySQL : IRepository<PokProd>
    {
        private MagazinContext db;

        public PokProdRepositorySQL(MagazinContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<PokProd> GetList()
        {
            return db.PokProd.ToList();
        }

        public PokProd GetItem(int id)
        {
            return db.PokProd.Find(id);
        }

        public void Create(PokProd item)
        {
            db.PokProd.Add(item);
        }

        public void Update(PokProd item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            PokProd item = db.PokProd.Find(id);
            if (item != null)
                db.PokProd.Remove(item);
        }

        public bool Save()
        {
            return db.SaveChanges() > 0;
        }

    }
}
