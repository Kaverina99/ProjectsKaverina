namespace Попытка_29._04
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.новаяИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таймерToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вклToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выклToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правилаИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.минБелых = new System.Windows.Forms.Label();
            this.секБелых = new System.Windows.Forms.Label();
            this.секЧёрных = new System.Windows.Forms.Label();
            this.минЧёрных = new System.Windows.Forms.Label();
            this.точкиБ = new System.Windows.Forms.Label();
            this.точкиЧ = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.пауза = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяИграToolStripMenuItem,
            this.таймерToolStripMenuItem1,
            this.помощьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1327, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // новаяИграToolStripMenuItem
            // 
            this.новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            this.новаяИграToolStripMenuItem.Size = new System.Drawing.Size(105, 23);
            this.новаяИграToolStripMenuItem.Text = "Новая игра ";
            this.новаяИграToolStripMenuItem.Click += new System.EventHandler(this.новаяИграToolStripMenuItem_Click);
            // 
            // таймерToolStripMenuItem1
            // 
            this.таймерToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вклToolStripMenuItem,
            this.выклToolStripMenuItem});
            this.таймерToolStripMenuItem1.Name = "таймерToolStripMenuItem1";
            this.таймерToolStripMenuItem1.Size = new System.Drawing.Size(74, 23);
            this.таймерToolStripMenuItem1.Text = "Таймер";
            this.таймерToolStripMenuItem1.Click += new System.EventHandler(this.таймерToolStripMenuItem1_Click);
            // 
            // вклToolStripMenuItem
            // 
            this.вклToolStripMenuItem.Name = "вклToolStripMenuItem";
            this.вклToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.вклToolStripMenuItem.Text = "Вкл.";
            this.вклToolStripMenuItem.Click += new System.EventHandler(this.вклToolStripMenuItem_Click);
            // 
            // выклToolStripMenuItem
            // 
            this.выклToolStripMenuItem.Name = "выклToolStripMenuItem";
            this.выклToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.выклToolStripMenuItem.Text = "Выкл.";
            this.выклToolStripMenuItem.Click += new System.EventHandler(this.выклToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.правилаИгрыToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(85, 23);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // правилаИгрыToolStripMenuItem
            // 
            this.правилаИгрыToolStripMenuItem.Name = "правилаИгрыToolStripMenuItem";
            this.правилаИгрыToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.правилаИгрыToolStripMenuItem.Text = "Правила игры";
            this.правилаИгрыToolStripMenuItem.Click += new System.EventHandler(this.правилаИгрыToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе ";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(70, 23);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(150, 90);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 640);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown_1);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1003, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 42);
            this.button2.TabIndex = 6;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(962, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Таймер для Белых шахмат";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1203, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Таймер для Чёрных шахмат";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(1244, 362);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 42);
            this.button3.TabIndex = 9;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // минБелых
            // 
            this.минБелых.AutoSize = true;
            this.минБелых.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.минБелых.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.минБелых.Location = new System.Drawing.Point(996, 320);
            this.минБелых.Name = "минБелых";
            this.минБелых.Size = new System.Drawing.Size(51, 39);
            this.минБелых.TabIndex = 10;
            this.минБелых.Text = "59";
            this.минБелых.Visible = false;
            this.минБелых.Click += new System.EventHandler(this.минБелых_Click);
            // 
            // секБелых
            // 
            this.секБелых.AutoSize = true;
            this.секБелых.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.секБелых.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.секБелых.Location = new System.Drawing.Point(1066, 320);
            this.секБелых.Name = "секБелых";
            this.секБелых.Size = new System.Drawing.Size(51, 39);
            this.секБелых.TabIndex = 11;
            this.секБелых.Text = "59";
            this.секБелых.Visible = false;
            this.секБелых.Click += new System.EventHandler(this.секБелых_Click);
            // 
            // секЧёрных
            // 
            this.секЧёрных.AutoSize = true;
            this.секЧёрных.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.секЧёрных.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.секЧёрных.Location = new System.Drawing.Point(1307, 320);
            this.секЧёрных.Name = "секЧёрных";
            this.секЧёрных.Size = new System.Drawing.Size(51, 39);
            this.секЧёрных.TabIndex = 13;
            this.секЧёрных.Text = "59";
            this.секЧёрных.Visible = false;
            this.секЧёрных.Click += new System.EventHandler(this.секЧёрных_Click);
            // 
            // минЧёрных
            // 
            this.минЧёрных.AutoSize = true;
            this.минЧёрных.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.минЧёрных.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.минЧёрных.Location = new System.Drawing.Point(1237, 320);
            this.минЧёрных.Name = "минЧёрных";
            this.минЧёрных.Size = new System.Drawing.Size(51, 39);
            this.минЧёрных.TabIndex = 12;
            this.минЧёрных.Text = "59";
            this.минЧёрных.Visible = false;
            this.минЧёрных.Click += new System.EventHandler(this.минЧёрных_Click);
            // 
            // точкиБ
            // 
            this.точкиБ.AutoSize = true;
            this.точкиБ.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.точкиБ.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.точкиБ.Location = new System.Drawing.Point(996, 320);
            this.точкиБ.Name = "точкиБ";
            this.точкиБ.Size = new System.Drawing.Size(134, 39);
            this.точкиБ.TabIndex = 14;
            this.точкиБ.Text = "       :     ";
            this.точкиБ.Visible = false;
            // 
            // точкиЧ
            // 
            this.точкиЧ.AutoSize = true;
            this.точкиЧ.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.точкиЧ.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.точкиЧ.Location = new System.Drawing.Point(1237, 320);
            this.точкиЧ.Name = "точкиЧ";
            this.точкиЧ.Size = new System.Drawing.Size(143, 39);
            this.точкиЧ.TabIndex = 15;
            this.точкиЧ.Text = "       :      ";
            this.точкиЧ.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Location = new System.Drawing.Point(951, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(588, 306);
            this.label5.TabIndex = 16;
            this.label5.Text = resources.GetString("label5.Text");
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // пауза
            // 
            this.пауза.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.пауза.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.пауза.Location = new System.Drawing.Point(1098, 451);
            this.пауза.Name = "пауза";
            this.пауза.Size = new System.Drawing.Size(146, 42);
            this.пауза.TabIndex = 17;
            this.пауза.Text = "Пауза";
            this.пауза.UseVisualStyleBackColor = true;
            this.пауза.Visible = false;
            this.пауза.Click += new System.EventHandler(this.пауза_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::Попытка_29._04.Properties.Resources._267616_digital;
            this.ClientSize = new System.Drawing.Size(1327, 798);
            this.Controls.Add(this.пауза);
            this.Controls.Add(this.секЧёрных);
            this.Controls.Add(this.минЧёрных);
            this.Controls.Add(this.секБелых);
            this.Controls.Add(this.минБелых);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.точкиБ);
            this.Controls.Add(this.точкиЧ);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Шахматы";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem новаяИграToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правилаИгрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label минБелых;
        private System.Windows.Forms.Label секБелых;
        private System.Windows.Forms.Label секЧёрных;
        private System.Windows.Forms.Label минЧёрных;
        private System.Windows.Forms.Label точкиБ;
        private System.Windows.Forms.Label точкиЧ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem таймерToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вклToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выклToolStripMenuItem;
        private System.Windows.Forms.Button пауза;
    }
}

