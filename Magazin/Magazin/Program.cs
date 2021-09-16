using BLL;
using BLL.Interfaces;
using BLL.Services;
using DIApp.Util;
using Ninject;
using System;
using System.Windows.Forms;

namespace Magazin
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // внедрение зависимостей
            var kernel = new StandardKernel(new NinjectRegistrations(), new ServiceModule("MagazinContext"));

            IDbCrud crudServ = kernel.Get<IDbCrud>();
            IPokypkiService otchetsServ = kernel.Get<IPokypkiService>();
            IOtchetService pokypkaServ = kernel.Get<IOtchetService>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(crudServ, otchetsServ , pokypkaServ));
        }
    }
}
