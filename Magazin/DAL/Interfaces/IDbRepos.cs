using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IDbRepos
    {
        IRepository<PokProd> PokProd { get; }
        IRepository<Pokypka> Pokypka { get; }
        IRepository<Produkt> Produkt { get; }
        IRepository<Sotrydnik> Sotrydnik { get; }
        IRepository<Tip_produkta> Tip_produkta { get; }
        IOtchetsRepository Otchets { get; }
        int Save();
    }
}
