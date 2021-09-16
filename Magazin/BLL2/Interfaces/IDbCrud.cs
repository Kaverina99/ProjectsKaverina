using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface IDbCrud
    {
        List<ProduktModel> GetAllProdukts();
        ProduktModel GetProdukts(int Id);
        void CreateProdukt(ProduktModel p);
        void UpdateProdukt(ProduktModel p);
        void DeleteProdukts(int id);
        List<PokypkaModel> GetAllPokypki();
        PokypkaModel GetPokypki(int Id);
        void CreatePokypka(PokypkaModel p);
        List<SotrydnikModel> GetSotrydniki();
        List<Tip_produktaModel> GetTip_Produktas();
    }
}
