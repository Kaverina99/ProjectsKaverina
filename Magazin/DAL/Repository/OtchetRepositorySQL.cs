using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class OtchetRepositorySQL : IOtchetsRepository
    {
        private MagazinContext db;
        
        public OtchetRepositorySQL(MagazinContext dbcontext)
        {
            this.db = dbcontext;
        }

        //выполнить ХП
        public List<OtchetProspochka> Otchet2(DateTime date)
        {
            System.Data.SqlClient.SqlParameter param1 = new System.Data.SqlClient.SqlParameter("@DATE1", date);
            List<OtchetProspochka> result = db.Database.SqlQuery<OtchetProspochka>("Prosrochka @DATE1", new object[] { param1 }).ToList();
            return result;
        }

        public List<OtchetTipov> Otchet1(int tip)
        {
            var produktt = db.Produkt
             .Join(db.Tip_produkta, tp => tp.Id_Tip_produkta_FK, t => t.Id, (tp, t) => tp)
             .Where(i => i.Id_Tip_produkta_FK == tip)
             .Select(i => new OtchetTipov() { Id = i.Id, Nazvanie = i.Nazvanie, Cost = i.Cost, Kolichestvo = i.Kolichestvo, Date_Birth = i.Date_Birth, Date_Death = i.Date_Death })
             .ToList();
            return produktt;
        }
    }
}
