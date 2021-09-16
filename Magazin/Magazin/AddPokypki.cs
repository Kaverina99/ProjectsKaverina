using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BLL.Interfaces;
using BLL.Services;

namespace Magazin
{
    public partial class AddPokypki : Form
    {
        IDbCrud db;
        IPokypkiService service;
        PokypkaModel selectedPokypki; 

        public AddPokypki()
        {
            //InitializeComponent();
            //comboBoxSotr.DataSource = db.GetAllSotrydniki();
            //comboBoxSotr.DisplayMember = "Name";
            //comboBoxSotr.ValueMember = "Id";


            //comboBoxPro.DataSource = db.GetAllProdukts();
            //comboBoxPro.DisplayMember = "Nazvanie";
            //comboBoxPro.ValueMember = "Id";
        }

        //private void buttonOK2_Click(object sender, EventArgs e)
        //{
        //    PokypkaModel pokypka = new PokypkaModel()
        //    {
        //        Date = Convert.ToDateTime(textBoxDatee.Text),
        //        Stoimost = Convert.ToDouble(textBoxStoi.Text),
        //        Number_pokypki = Convert.ToInt32(textBoxNumber.Text),
        //        Id_Sotrydnik_Fk = (int)comboBoxSotr.SelectedValue,
        //        Id_Produkt_FK = (int)comboBoxPro.SelectedValue,
        //    };

        //    DialogResult = DialogResult.Abort;
        //    this.Close();
        //}
    }
}
