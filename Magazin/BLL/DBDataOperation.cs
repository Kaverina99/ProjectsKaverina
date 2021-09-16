using BLL.Interfaces;
using DAL;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;


namespace BLL
{
    public class DBDataOperation : IDbCrud
    {
        IDbRepos db;
        public DBDataOperation(IDbRepos repos)
        {
            db = repos;
        }

        #region Produkt
        public List<ProduktModel> GetAllProdukts()
        {
            return db.Produkt.GetList().Select(i => new ProduktModel(i)).ToList();
        }

        public ProduktModel GetProdukts(int Id)
        {
            return new ProduktModel(db.Produkt.GetItem(Id));
        }

        public void CreateProdukt(ProduktModel p)
        {
            db.Produkt.Create(new Produkt() { Nazvanie = p.Nazvanie, Date_Birth = p.Date_Birth, Date_Death = p.Date_Death, Kolichestvo = p.Kolichestvo, Cost = p.Cost, Id_Tip_produkta_FK = p.Id_Tip_produkta_FK });
            Save();
            //db.Produkt.Attach(p);
        }

        public void UpdateProdukt(ProduktModel p)
        {
            Produkt ph = db.Produkt.GetItem(p.Id);
            ph.Nazvanie = p.Nazvanie;
            ph.Date_Birth = p.Date_Birth;
            ph.Date_Death = p.Date_Death;
            ph.Kolichestvo = p.Kolichestvo;
            ph.Cost = p.Cost;
            ph.Id_Tip_produkta_FK = p.Id_Tip_produkta_FK;
            Save();
        }

        public void DeleteProdukts(int id)
        {
            if (db.Produkt.GetItem(id) != null)
            {
                db.Produkt.Delete(id);
                Save();
            }
        }
        #endregion

        #region Pokypka
        public List<PokypkaModel> GetAllPokypki()
        {
            return db.Pokypka.GetList().Select(i => new PokypkaModel(i)).ToList();
        }

        public PokypkaModel GetPokypki(int Id)
        {
            return new PokypkaModel(db.Pokypka.GetItem(Id));
        }

        public void CreatePokypka(PokypkaModel p)
        {
            db.Pokypka.Create(new Pokypka()
            {
                Date = p.Date,
                Stoimost = p.Stoimost,
                Id_Sotrydnik_Fk = p.Id_Sotrydnik_Fk,
            });
            Save();
        }
        #endregion

        public bool Save()
        {
            if (db.Save() > 0) return true;
            return false;
        }

        public List<SotrydnikModel> GetSotrydniki()
        {
            return db.Sotrydnik.GetList().Select(i => new SotrydnikModel(i)).ToList();
        }
        
        public List<Tip_produktaModel> GetTip_Produktas()
        {
            return db.Tip_produkta.GetList().Select(i => new Tip_produktaModel(i)).ToList();
        }


        
    }
}