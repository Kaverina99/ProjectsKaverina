using BLL.Interfaces;
using BLL.Models.OtchetModels;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class OtchetsService : IOtchetService
    {
        private IDbRepos db;
        public OtchetsService(IDbRepos repos)
        {
            db = repos;
        }
        
        //выполнить ХП
        public List<OtchetProspochka> Otchet2(DateTime date)
        {
            return db.Otchets.Otchet2(date).Select(i => new OtchetProspochka
            { Id = i.Id, Date_Death = i.Date_Death, Nazvanie = i.Nazvanie, Tip = i.Tip, Cost = i.Cost, Kolichestvo = i.Kolichestvo, TotalCost = i.TotalCost}).ToList();

        }

        public List<OtchetTipov> Otchet1(int tip)
        {
            var produktt = db.Otchets.Otchet1(tip)
             .Select(i => new OtchetTipov() { Id = i.Id, Nazvanie = i.Nazvanie, Cost = i.Cost, Kolichestvo = i.Kolichestvo, Date_Birth = i.Date_Birth, Date_Death = i.Date_Death })
             .ToList();
            return produktt;
        }
    }
}