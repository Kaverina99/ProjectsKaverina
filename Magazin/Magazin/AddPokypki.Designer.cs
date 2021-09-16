namespace Magazin
{
    partial class AddPokypki
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOK2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDatee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSotr = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKolvo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOK2
            // 
            this.buttonOK2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK2.Location = new System.Drawing.Point(440, 254);
            this.buttonOK2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK2.Name = "buttonOK2";
            this.buttonOK2.Size = new System.Drawing.Size(105, 42);
            this.buttonOK2.TabIndex = 8;
            this.buttonOK2.Text = "OK";
            this.buttonOK2.UseVisualStyleBackColor = true;
   //         this.buttonOK2.Click += new System.EventHandler(this.buttonOK2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Сотрудник";
            // 
            // textBoxDatee
            // 
            this.textBoxDatee.Location = new System.Drawing.Point(185, 40);
            this.textBoxDatee.Name = "textBoxDatee";
            this.textBoxDatee.Size = new System.Drawing.Size(360, 22);
            this.textBoxDatee.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Дата покупки";
            // 
            // comboBoxSotr
            // 
            this.comboBoxSotr.FormattingEnabled = true;
            this.comboBoxSotr.Location = new System.Drawing.Point(185, 99);
            this.comboBoxSotr.Name = "comboBoxSotr";
            this.comboBoxSotr.Size = new System.Drawing.Size(360, 24);
            this.comboBoxSotr.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Продукт";
            // 
            // comboBoxPro
            // 
            this.comboBoxPro.FormattingEnabled = true;
            this.comboBoxPro.Location = new System.Drawing.Point(185, 153);
            this.comboBoxPro.Name = "comboBoxPro";
            this.comboBoxPro.Size = new System.Drawing.Size(360, 24);
            this.comboBoxPro.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Количество";
            // 
            // textBoxKolvo
            // 
            this.textBoxKolvo.Location = new System.Drawing.Point(185, 211);
            this.textBoxKolvo.Name = "textBoxKolvo";
            this.textBoxKolvo.Size = new System.Drawing.Size(360, 22);
            this.textBoxKolvo.TabIndex = 46;
            // 
            // AddPokypki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 318);
            this.Controls.Add(this.textBoxKolvo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSotr);
            this.Controls.Add(this.comboBoxPro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDatee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonOK2);
            this.Name = "AddPokypki";
            this.ShowIcon = false;
            this.Text = "Покупки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxDatee;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button buttonOK2;
        public System.Windows.Forms.ComboBox comboBoxSotr;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox comboBoxPro;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxKolvo;
    }
}