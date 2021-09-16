using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IPokypkiService
    {
        //Создает или изменяет существующую покупку 
        bool MakePokypka(PokypkaModel pokypkaDto);
    }
}
