using BLL;
using BLL.Interfaces;
using BLL.Services;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIApp.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IPokypkiService>().To<PokypkiService>();
            Bind<IOtchetService>().To<OtchetsService>();
            Bind<IDbCrud>().To<DBDataOperation>();
        }
    }
}
