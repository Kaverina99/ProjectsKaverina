namespace Magazin
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonSaveProd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpDate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewProduks = new System.Windows.Forms.DataGridView();
            this.bindingSourceProdukti = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonOtchet2 = new System.Windows.Forms.Button();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonOtchet1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxOtcchet1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.buttonPok = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridViewPokypki = new System.Windows.Forms.DataGridView();
            this.bindingSourcePokypki = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazvanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDeathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolichestvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipproduktaFK = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoimostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSotrydnikFk = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProdukti)).BeginInit();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPokypki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePokypki)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.buttonSaveProd);
            this.tabPage1.Controls.Add(this.buttonDelete);
            this.tabPage1.Controls.Add(this.buttonUpDate);
            this.tabPage1.Controls.Add(this.buttonAdd);
            this.tabPage1.Controls.Add(this.dataGridViewProduks);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1336, 741);
            this.tabPage1.TabIndex = 9;
            this.tabPage1.Text = "Продукты";
            // 
            // buttonSaveProd
            // 
            this.buttonSaveProd.Location = new System.Drawing.Point(20, 21);
            this.buttonSaveProd.Name = "buttonSaveProd";
            this.buttonSaveProd.Size = new System.Drawing.Size(184, 33);
            this.buttonSaveProd.TabIndex = 12;
            this.buttonSaveProd.Text = "Сохранить изменения";
            this.buttonSaveProd.UseVisualStyleBackColor = true;
       //     this.buttonSaveProd.Click += new System.EventHandler(this.buttonSaveProd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(554, 21);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(131, 33);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpDate
            // 
            this.buttonUpDate.Location = new System.Drawing.Point(399, 21);
            this.buttonUpDate.Name = "buttonUpDate";
            this.buttonUpDate.Size = new System.Drawing.Size(131, 33);
            this.buttonUpDate.TabIndex = 10;
            this.buttonUpDate.Text = "Изменить";
            this.buttonUpDate.UseVisualStyleBackColor = true;
            this.buttonUpDate.Click += new System.EventHandler(this.buttonUpDate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(245, 21);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(131, 33);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewProduks
            // 
            this.dataGridViewProduks.AutoGenerateColumns = false;
            this.dataGridViewProduks.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewProduks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nazvanieDataGridViewTextBoxColumn,
            this.dateBirthDataGridViewTextBoxColumn,
            this.dateDeathDataGridViewTextBoxColumn,
            this.kolichestvoDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.idTipproduktaFK});
            this.dataGridViewProduks.DataSource = this.bindingSourceProdukti;
            this.dataGridViewProduks.Location = new System.Drawing.Point(8, 71);
            this.dataGridViewProduks.Name = "dataGridViewProduks";
            this.dataGridViewProduks.RowTemplate.Height = 24;
            this.dataGridViewProduks.Size = new System.Drawing.Size(1320, 640);
            this.dataGridViewProduks.TabIndex = 6;
            // 
            // bindingSourceProdukti
            // 
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage9.Controls.Add(this.dataGridView2);
            this.tabPage9.Controls.Add(this.groupBox5);
            this.tabPage9.Location = new System.Drawing.Point(4, 25);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(1336, 741);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "Отчёт 2";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(14, 119);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1322, 575);
            this.dataGridView2.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dateTimePicker1);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.buttonOtchet2);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1108, 87);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Просроченные продукты на сегоднешний день";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(107, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "c:";
            // 
            // buttonOtchet2
            // 
            this.buttonOtchet2.Location = new System.Drawing.Point(405, 34);
            this.buttonOtchet2.Name = "buttonOtchet2";
            this.buttonOtchet2.Size = new System.Drawing.Size(125, 33);
            this.buttonOtchet2.TabIndex = 4;
            this.buttonOtchet2.Text = "Найти";
            this.buttonOtchet2.UseVisualStyleBackColor = true;
            this.buttonOtchet2.Click += new System.EventHandler(this.buttonOtchet2_Click);
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage8.Controls.Add(this.groupBox4);
            this.tabPage8.Controls.Add(this.dataGridView1);
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1336, 741);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Отчёт 1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonOtchet1);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.comboBoxOtcchet1);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1108, 81);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Фильтровать по: ";
            // 
            // buttonOtchet1
            // 
            this.buttonOtchet1.Location = new System.Drawing.Point(704, 26);
            this.buttonOtchet1.Name = "buttonOtchet1";
            this.buttonOtchet1.Size = new System.Drawing.Size(125, 33);
            this.buttonOtchet1.TabIndex = 10;
            this.buttonOtchet1.Text = "Найти";
            this.buttonOtchet1.UseVisualStyleBackColor = true;
            this.buttonOtchet1.Click += new System.EventHandler(this.buttonOtchet1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Тип продукта ";
            // 
            // comboBoxOtcchet1
            // 
            this.comboBoxOtcchet1.FormattingEnabled = true;
            this.comboBoxOtcchet1.Location = new System.Drawing.Point(234, 31);
            this.comboBoxOtcchet1.Name = "comboBoxOtcchet1";
            this.comboBoxOtcchet1.Size = new System.Drawing.Size(335, 24);
            this.comboBoxOtcchet1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1330, 584);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage6.Controls.Add(this.buttonPok);
            this.tabPage6.Controls.Add(this.buttonSave);
            this.tabPage6.Controls.Add(this.dataGridViewPokypki);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1336, 741);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Покупки";
            // 
            // buttonPok
            // 
            this.buttonPok.Location = new System.Drawing.Point(231, 19);
            this.buttonPok.Name = "buttonPok";
            this.buttonPok.Size = new System.Drawing.Size(131, 33);
            this.buttonPok.TabIndex = 10;
            this.buttonPok.Text = "Покупки";
            this.buttonPok.UseVisualStyleBackColor = true;
            this.buttonPok.Click += new System.EventHandler(this.buttonPok_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(77, 19);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(131, 33);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
        //    this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridViewPokypki
            // 
            this.dataGridViewPokypki.AutoGenerateColumns = false;
            this.dataGridViewPokypki.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPokypki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPokypki.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.stoimostDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.idSotrydnikFk});
            this.dataGridViewPokypki.DataSource = this.bindingSourcePokypki;
            this.dataGridViewPokypki.Location = new System.Drawing.Point(6, 68);
            this.dataGridViewPokypki.Name = "dataGridViewPokypki";
            this.dataGridViewPokypki.RowTemplate.Height = 24;
            this.dataGridViewPokypki.Size = new System.Drawing.Size(1322, 618);
            this.dataGridViewPokypki.TabIndex = 6;
            // 
            // bindingSourcePokypki
            // 
      //      this.bindingSourcePokypki.DataSource = typeof(BLL.PokypkaModel);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1344, 770);
            this.tabControl1.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Width = 50;
            // 
            // nazvanieDataGridViewTextBoxColumn
            // 
            this.nazvanieDataGridViewTextBoxColumn.DataPropertyName = "Nazvanie";
            this.nazvanieDataGridViewTextBoxColumn.HeaderText = "Nazvanie";
            this.nazvanieDataGridViewTextBoxColumn.Name = "nazvanieDataGridViewTextBoxColumn";
            this.nazvanieDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateBirthDataGridViewTextBoxColumn
            // 
            this.dateBirthDataGridViewTextBoxColumn.DataPropertyName = "Date_Birth";
            this.dateBirthDataGridViewTextBoxColumn.HeaderText = "Date_Birth";
            this.dateBirthDataGridViewTextBoxColumn.Name = "dateBirthDataGridViewTextBoxColumn";
            this.dateBirthDataGridViewTextBoxColumn.Width = 110;
            // 
            // dateDeathDataGridViewTextBoxColumn
            // 
            this.dateDeathDataGridViewTextBoxColumn.DataPropertyName = "Date_Death";
            this.dateDeathDataGridViewTextBoxColumn.HeaderText = "Date_Death";
            this.dateDeathDataGridViewTextBoxColumn.Name = "dateDeathDataGridViewTextBoxColumn";
            this.dateDeathDataGridViewTextBoxColumn.Width = 110;
            // 
            // kolichestvoDataGridViewTextBoxColumn
            // 
            this.kolichestvoDataGridViewTextBoxColumn.DataPropertyName = "Kolichestvo";
            this.kolichestvoDataGridViewTextBoxColumn.HeaderText = "Kolichestvo";
            this.kolichestvoDataGridViewTextBoxColumn.Name = "kolichestvoDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // idTipproduktaFK
            // 
            this.idTipproduktaFK.DataPropertyName = "Id_Tip_produkta_FK";
            this.idTipproduktaFK.HeaderText = "Id_Tip_produkta_FK";
            this.idTipproduktaFK.Name = "idTipproduktaFK";
            this.idTipproduktaFK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idTipproduktaFK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idTipproduktaFK.Width = 170;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // stoimostDataGridViewTextBoxColumn
            // 
            this.stoimostDataGridViewTextBoxColumn.DataPropertyName = "Stoimost";
            this.stoimostDataGridViewTextBoxColumn.HeaderText = "Stoimost";
            this.stoimostDataGridViewTextBoxColumn.Name = "stoimostDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 110;
            // 
            // idSotrydnikFk
            // 
            this.idSotrydnikFk.DataPropertyName = "Id_Sotrydnik_Fk";
            this.idSotrydnikFk.HeaderText = "Id_Sotrydnik_Fk";
            this.idSotrydnikFk.Name = "idSotrydnikFk";
            this.idSotrydnikFk.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idSotrydnikFk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idSotrydnikFk.Width = 220;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 770);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Продовольственный магазин";
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProdukti)).EndInit();
            this.tabPage9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPokypki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePokypki)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewProduks;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonOtchet1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxOtcchet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dataGridViewPokypki;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button buttonOtchet2;
        private System.Windows.Forms.BindingSource bindingSourceProdukti;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpDate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonPok;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSaveProd;
        private System.Windows.Forms.BindingSource bindingSourcePokypki;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDeathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolichestvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idTipproduktaFK;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoimostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idSotrydnikFk;
    }
}

