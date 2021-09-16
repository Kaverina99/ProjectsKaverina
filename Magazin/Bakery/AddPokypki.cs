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

        public AddPokypki(IDbCrud dbOperation, IPokypkiService pokserv, PokypkaModel p = null)
        {
            InitializeComponent();
            db = dbOperation;
            service = pokserv;
            selectedPokypki = p;

            checkedListBox1.DataSource = db.GetAllProdukts();
            checkedListBox1.DisplayMember = "Nazvanie";
            checkedListBox1.ValueMember = "Id";

            comboBoxSotr.DataSource = db.GetSotrydniki();
            comboBoxSotr.DisplayMember = "Name";
            comboBoxSotr.ValueMember = "Id";
        }

        private void buttonOK2_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Не выбран ни один товар в заказ!");
                return;
            }
            List<int> items = new List<int>();
            foreach (var i in checkedListBox1.CheckedItems)
                items.Add((i as ProduktModel).Id);
            //  OrderModel order;

            PokypkaModel pokprodDto;
            if (selectedPokypki == null)
                pokprodDto = new PokypkaModel();
            else
                pokprodDto = selectedPokypki;

            pokprodDto.Date = DateTime.Now;
            pokprodDto.Id_Sotrydnik_Fk = (comboBoxSotr.SelectedItem as SotrydnikModel).Id;
            pokprodDto.SpisokProduktov = items;
          

            bool result = service.MakePokypka(pokprodDto);
            if (result)
            {
                MessageBox.Show("Success");
            }
            else MessageBox.Show("Failed");
        }
    }
}
