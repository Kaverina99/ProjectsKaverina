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
            this.comboBoxSotr = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // buttonOK2
            // 
            this.buttonOK2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK2.Location = new System.Drawing.Point(489, 396);
            this.buttonOK2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK2.Name = "buttonOK2";
            this.buttonOK2.Size = new System.Drawing.Size(105, 42);
            this.buttonOK2.TabIndex = 8;
            this.buttonOK2.Text = "OK";
            this.buttonOK2.UseVisualStyleBackColor = true;
            this.buttonOK2.Click += new System.EventHandler(this.buttonOK2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Сотрудник";
            // 
            // comboBoxSotr
            // 
            this.comboBoxSotr.FormatString = "N2";
            this.comboBoxSotr.FormattingEnabled = true;
            this.comboBoxSotr.Location = new System.Drawing.Point(234, 341);
            this.comboBoxSotr.Name = "comboBoxSotr";
            this.comboBoxSotr.Size = new System.Drawing.Size(360, 24);
            this.comboBoxSotr.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Продукт";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(41, 55);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(553, 242);
            this.checkedListBox1.TabIndex = 47;
            // 
            // AddPokypki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 451);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.comboBoxSotr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonOK2);
            this.Name = "AddPokypki";
            this.ShowIcon = false;
            this.Text = "Покупки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button buttonOK2;
        public System.Windows.Forms.ComboBox comboBoxSotr;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}