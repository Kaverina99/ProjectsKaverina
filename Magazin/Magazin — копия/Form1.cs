using BLL;
using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Magazin
{
    public partial class Form1 : Form
    { 
        IPokypkiService pokserv;
        IOtchetService otchserv;
        IDbCrud dbOperations;

        List<SotrydnikModel> allSotrydniki;
        List<PokypkaModel> allPokypki;
        List<ProduktModel> allProdukts;
        List<Tip_produktaModel> allTip_produktov;

        public Form1(IDbCrud crudDb, IPokypkiService pokypkiservice, IOtchetService otchetservice)
        {
            pokserv = pokypkiservice;
            otchserv = otchetservice;
            dbOperations = crudDb;
            InitializeComponent();
            loadData();
        }

        //загрузка данных в таблицы
        private void loadData()
        {
            allTip_produktov = dbOperations.GetTip_Produktas();
       //     allPokypki = dbOperations.GetPokypki();
            allSotrydniki = dbOperations.GetSotrydniki();
            
            loadProdukts();
            loadPokypki();
            // Заполнение комбобокса "Тип продукта" для отчета1.
            comboBoxOtcchet1.DataSource = allTip_produktov;
            comboBoxOtcchet1.DisplayMember = "Naimenovanie";
            comboBoxOtcchet1.ValueMember = "Id";
        }

        //загрузить все телефоны в DataGrid
        private void loadProdukts()
        {
            allProdukts = dbOperations.GetAllProdukts();
            // Отображаем данные
            bindingSourceProdukti.DataSource = allProdukts;
            // Заполнение комбобоксов для таблицы "Покупки".
            FillSotrydnikiCombobox();
            FillTip_produktovCombobox();
        }

        private void loadPokypki()
        {
            bindingSourcePokypki.DataSource = dbOperations.GetAllPokypki();
        }

        private void FillSotrydnikiCombobox()
        {
            ((DataGridViewComboBoxColumn)dataGridViewPokypki.Columns["idSotrydnikFk"]).DataSource = allSotrydniki;
            ((DataGridViewComboBoxColumn)dataGridViewPokypki.Columns["idSotrydnikFk"]).DisplayMember = "Name";
            ((DataGridViewComboBoxColumn)dataGridViewPokypki.Columns["idSotrydnikFk"]).ValueMember = "Id";
        }
        
        private void FillTip_produktovCombobox()
        {
            ((DataGridViewComboBoxColumn)dataGridViewProduks.Columns["idTipproduktaFK"]).DataSource = allTip_produktov;
            ((DataGridViewComboBoxColumn)dataGridViewProduks.Columns["idTipproduktaFK"]).DisplayMember = "Naimenovanie";
            ((DataGridViewComboBoxColumn)dataGridViewProduks.Columns["idTipproduktaFK"]).ValueMember = "Id";
        }
        /// <summary>
        /// Сохранить изменения в таблице.
        /// </summary>

        private void buttonOtchet1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = otchserv.Otchet1((int)comboBoxOtcchet1.SelectedValue);
        }
        

        private class SPResult
        {
            public string Customer { get; set; }
            public string PhoneName { get; set; }
            public DateTime Date { get; set; }
        }
        /// <summary>
        /// нажатие кнопки вызова хранимой процедуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOtchet2_Click(object sender, EventArgs e)
        {

            dataGridView2.DataSource = otchserv.Otchet2(dateTimePicker1.Value);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            NewProdukti f = new NewProdukti();
            f.comboBox1.DataSource = allTip_produktov;
            f.comboBox1.DisplayMember = "Naimenovanie";
            f.comboBox1.ValueMember = "Id";

            DialogResult result = f.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            ProduktModel produkt = new ProduktModel();
            produkt.Nazvanie = f.textBox1.Text;
            produkt.Date_Birth = Convert.ToDateTime(f.dateTimePicker1.Text);
            produkt.Date_Death = Convert.ToDateTime(f.dateTimePicker1.Text);
            produkt.Kolichestvo = Convert.ToInt32(f.textBox4.Text);
            produkt.Cost = Convert.ToDouble(f.textBox5.Text);
            produkt.Id_Tip_produkta_FK = (int)f.comboBox1.SelectedValue;

            dbOperations.CreateProdukt(produkt);
            allProdukts = dbOperations.GetAllProdukts();
            bindingSourceProdukti.DataSource = allProdukts;
            MessageBox.Show("Новый продукт добавлен");
        }

        private int getSelectedRow(DataGridView dataGridView)
        {
            int index = -1;
            if (dataGridView.SelectedRows.Count > 0 || dataGridView.SelectedCells.Count == 1)
            {
                if (dataGridView.SelectedRows.Count > 0)
                    index = dataGridView.SelectedRows[0].Index;
                else index = dataGridView.SelectedCells[0].RowIndex;
            }
            return index;
        }

        private void buttonUpDate_Click(object sender, EventArgs e)
        {
            int index = getSelectedRow(dataGridViewProduks);
            if (index != -1)
            {
                int id = 0;
                bool converted = Int32.TryParse(dataGridViewProduks[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                ProduktModel pr = allProdukts.Where(i => i.Id == id).FirstOrDefault();
                if (pr != null)
                {
                    NewProdukti f = new NewProdukti();
                    f.comboBox1.DataSource = allTip_produktov;
                    f.comboBox1.DisplayMember = "Naimenovanie";
                    f.comboBox1.ValueMember = "Id";

                    f.textBox1.Text = pr.Nazvanie;
                    f.dateTimePicker1.Text = Convert.ToString(pr.Date_Birth);
                    f.dateTimePicker2.Text = Convert.ToString(pr.Date_Death);
                    f.textBox4.Text = Convert.ToString(pr.Kolichestvo);
                    f.textBox5.Text = Convert.ToString(pr.Cost);
                    f.comboBox1.SelectedValue = pr.Id_Tip_produkta_FK;

                    DialogResult result = f.ShowDialog(this);

                    if (result == DialogResult.Cancel)
                        return;

                    pr.Nazvanie = f.textBox1.Text;
                    pr.Date_Birth = Convert.ToDateTime(f.dateTimePicker1.Text);
                    pr.Date_Death = Convert.ToDateTime(f.dateTimePicker2.Text);
                    pr.Kolichestvo = Convert.ToInt32(f.textBox4.Text);
                    pr.Cost = Convert.ToDouble(f.textBox5.Text);
                    pr.Id_Tip_produkta_FK = Convert.ToInt32(f.comboBox1.SelectedValue);

                    dbOperations.UpdateProdukt(pr);
               //     bindingSourceProdukti.DataSource = dbOperations.GetAllProdukts();

                    MessageBox.Show("Продукт обновлен");
                }
            }
            else
                MessageBox.Show("Ни один продукт не выбран!");
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = getSelectedRow(dataGridViewProduks);
            if (index != -1)
            {
                int id = 0;
                bool converted = Int32.TryParse(dataGridViewProduks[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                dbOperations.DeleteProdukts(id);
                bindingSourceProdukti.DataSource = dbOperations.GetAllProdukts();
            }

        }
        private void buttonPok_Click(object sender, EventArgs e)
        {
            //AddPokypki f = new AddPokypki();
            //if (f.ShowDialog() == DialogResult.OK)
            //    bindingSourcePokypki.DataSource = dbOperations.GetAllPokypki();
            //f.comboBoxSotr.DataSource = allSotrydniki;
            //f.comboBoxSotr.DisplayMember = "Name";
            //f.comboBoxSotr.ValueMember = "Id";

            //f.comboBoxPro.DataSource = allProdukts;
            //f.comboBoxPro.DisplayMember = "Nazvanie";
            //f.comboBoxPro.ValueMember = "Id";

            //PokypkaModel pp = new PokypkaModel();
            //pp.Date = Convert.ToDateTime(f.textBoxDatee.Text);
            //pp.Stoimost = Convert.ToDouble(f.textBoxKolvo.Text);
            //pp.Id_Sotrydnik_Fk = (int)f.comboBoxSotr.SelectedValue;

            //dbo.CreatePokypka(pp);
            //bindingSourcePokypki.DataSource = dbo.GetAllPokypki();
        }
    }
}
