Using BLL;
Using BLL.Interfaces;
Using DIApp.Util;
Using Magazin;
Using Ninject;
Using System;
Using System.Collections.Generic;
Using System.Linq;
Using System.Threading.Tasks;
Using System.Windows.Forms;

Namespace Bakery
{
    Static Class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        Static void Main()
        {
            // внедрение зависимостей
            var kernel = New StandardKernel(New NinjectRegistrations(), New ServiceModule("MagazinContext"));

            IDbCrud crudServ = kernel.Get < IDbCrud > ();
            IPokypkiService otchetsServ = kernel.Get < IPokypkiService > ();
            IOtchetService pokypkaServ = kernel.Get < IOtchetService > ();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(New Form1(crudServ, otchetsServ, pokypkaServ));
        }
    }
}
