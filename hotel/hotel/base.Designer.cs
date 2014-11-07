namespace hotel
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuhotel = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuClient = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuNomera = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenurezerv = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuVeshi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuVeshinomer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuBron = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuZakaz = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuFirma = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuStrokaBD = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuhotel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuhotel
            // 
            this.menuhotel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuhotel.BackgroundImage = global::hotel.Properties.Resources.Lighthouse;
            this.menuhotel.Dock = System.Windows.Forms.DockStyle.None;
            this.menuhotel.Font = new System.Drawing.Font("Vivaldi", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuhotel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem12,
            this.toolStripMenuItem4,
            this.toolStripMenuHelp});
            this.menuhotel.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuhotel.Location = new System.Drawing.Point(50, 60);
            this.menuhotel.Name = "menuhotel";
            this.menuhotel.Size = new System.Drawing.Size(252, 181);
            this.menuhotel.TabIndex = 0;
            this.menuhotel.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuClient,
            this.toolStripMenuNomera,
            this.toolStripMenuItem11,
            this.toolStripMenuItem5});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(245, 26);
            this.toolStripMenuItem1.Text = "Внесение информации в БД";
            // 
            // toolStripMenuClient
            // 
            this.toolStripMenuClient.Name = "toolStripMenuClient";
            this.toolStripMenuClient.Size = new System.Drawing.Size(273, 26);
            this.toolStripMenuClient.Text = "Клиенты";
            this.toolStripMenuClient.Click += new System.EventHandler(this.toolStripMenuClient_Click);
            // 
            // toolStripMenuNomera
            // 
            this.toolStripMenuNomera.Name = "toolStripMenuNomera";
            this.toolStripMenuNomera.Size = new System.Drawing.Size(273, 26);
            this.toolStripMenuNomera.Text = "Номера";
            this.toolStripMenuNomera.Click += new System.EventHandler(this.toolStripMenuNomera_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenurezerv,
            this.toolStripMenuVeshi,
            this.toolStripMenuVeshinomer});
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(273, 26);
            this.toolStripMenuItem11.Text = "Вещи";
            // 
            // toolStripMenurezerv
            // 
            this.toolStripMenurezerv.Name = "toolStripMenurezerv";
            this.toolStripMenurezerv.Size = new System.Drawing.Size(328, 26);
            this.toolStripMenurezerv.Text = "Резерв вещей";
            this.toolStripMenurezerv.Click += new System.EventHandler(this.toolStripMenurezerv_Click);
            // 
            // toolStripMenuVeshi
            // 
            this.toolStripMenuVeshi.Name = "toolStripMenuVeshi";
            this.toolStripMenuVeshi.Size = new System.Drawing.Size(328, 26);
            this.toolStripMenuVeshi.Text = "Список вешей";
            this.toolStripMenuVeshi.Click += new System.EventHandler(this.toolStripMenuVeshi_Click);
            // 
            // toolStripMenuVeshinomer
            // 
            this.toolStripMenuVeshinomer.Name = "toolStripMenuVeshinomer";
            this.toolStripMenuVeshinomer.Size = new System.Drawing.Size(328, 26);
            this.toolStripMenuVeshinomer.Text = "Закрепление вещи за номером";
            this.toolStripMenuVeshinomer.Click += new System.EventHandler(this.toolStripMenuVeshinomer_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(273, 26);
            this.toolStripMenuItem5.Text = "Дополнительные услуги";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(245, 26);
            this.toolStripMenuItem2.Text = "Отчеты";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuBron,
            this.toolStripMenuZakaz,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem10});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(245, 26);
            this.toolStripMenuItem3.Text = "Работа с клиентами";
            // 
            // toolStripMenuBron
            // 
            this.toolStripMenuBron.Name = "toolStripMenuBron";
            this.toolStripMenuBron.Size = new System.Drawing.Size(390, 26);
            this.toolStripMenuBron.Text = "Операции с бронированием";
            this.toolStripMenuBron.Click += new System.EventHandler(this.toolStripMenuBron_Click);
            // 
            // toolStripMenuZakaz
            // 
            this.toolStripMenuZakaz.Name = "toolStripMenuZakaz";
            this.toolStripMenuZakaz.Size = new System.Drawing.Size(390, 26);
            this.toolStripMenuZakaz.Text = "Оформление и освобождение номера";
            this.toolStripMenuZakaz.Click += new System.EventHandler(this.toolStripMenuZakaz_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(390, 26);
            this.toolStripMenuItem6.Text = "Оформление дополнительных услуг";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(390, 26);
            this.toolStripMenuItem7.Text = "Выезд из номера";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(390, 26);
            this.toolStripMenuItem10.Text = "Загрузить Файл системы клиент банк ";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem8,
            this.toolStripMenuItem9});
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(245, 26);
            this.toolStripMenuItem12.Text = "Работа отеля";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(299, 26);
            this.toolStripMenuItem8.Text = "Пропажа или порча вещей";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(299, 26);
            this.toolStripMenuItem9.Text = "Пополнение резерва вещей";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFirma,
            this.toolStripMenuStrokaBD});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(245, 26);
            this.toolStripMenuItem4.Text = "Настройки";
            // 
            // toolStripMenuFirma
            // 
            this.toolStripMenuFirma.Name = "toolStripMenuFirma";
            this.toolStripMenuFirma.Size = new System.Drawing.Size(350, 26);
            this.toolStripMenuFirma.Text = "Внести информацию о фирме";
            this.toolStripMenuFirma.Click += new System.EventHandler(this.toolStripMenuFirma_Click);
            // 
            // toolStripMenuStrokaBD
            // 
            this.toolStripMenuStrokaBD.Name = "toolStripMenuStrokaBD";
            this.toolStripMenuStrokaBD.Size = new System.Drawing.Size(350, 26);
            this.toolStripMenuStrokaBD.Text = "Внести строку подключения к БД";
            this.toolStripMenuStrokaBD.Click += new System.EventHandler(this.toolStripMenuStrokaBD_Click);
            // 
            // toolStripMenuHelp
            // 
            this.toolStripMenuHelp.Name = "toolStripMenuHelp";
            this.toolStripMenuHelp.Size = new System.Drawing.Size(245, 26);
            this.toolStripMenuHelp.Text = "О программе";
            this.toolStripMenuHelp.Click += new System.EventHandler(this.toolStripMenuHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::hotel.Properties.Resources.Lighthouse;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.menuhotel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Автоматизация отеля";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuhotel.ResumeLayout(false);
            this.menuhotel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuhotel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuClient;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuNomera;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenurezerv;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuVeshi;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuVeshinomer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuBron;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuZakaz;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFirma;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuStrokaBD;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
    }
}

