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
    public class ProduktRepositorySQL : IRepository<Produkt>
    {
        private MagazinContext db;

        public ProduktRepositorySQL(MagazinContext dbcontext)
        {
            this.db = dbcontext;
        }

        public List<Produkt> GetList() => db.Produkt.ToList();

        public Produkt GetItem(int id)
        {
            return db.Produkt.Find(id);
        }

        public int Create(Produkt item)
        {
            db.Produkt.Add(item);
            return item.Id;

        }

        public void Update(Produkt item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Produkt item = db.Produkt.Find(id);
            if (item != null)
                db.Produkt.Remove(item);
        }

        public bool Save()
        {
            return db.SaveChanges() > 0;
        }

    }
}
