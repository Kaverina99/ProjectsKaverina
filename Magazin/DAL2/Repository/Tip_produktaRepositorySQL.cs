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
    public class Tip_produktaRepositorySQL : IRepository<Tip_produkta>
    {
        private MagazinContext db;

        public Tip_produktaRepositorySQL(MagazinContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<Tip_produkta> GetList()
        {
            return db.Tip_produkta.ToList();
        }

        public Tip_produkta GetItem(int id)
        {
            return db.Tip_produkta.Find(id);
        }

        public int Create(Tip_produkta item)
        {
            db.Tip_produkta.Add(item);
            return item.Id;

        }

        public void Update(Tip_produkta item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Tip_produkta item = db.Tip_produkta.Find(id);
            if (item != null)
                db.Tip_produkta.Remove(item);
        }

        public bool Save()
        {
            return db.SaveChanges() > 0;
        }

    }
}
