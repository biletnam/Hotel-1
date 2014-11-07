﻿namespace hotel.vnesenieinfBD.nomera
{
    partial class EditNomer
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
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ставка";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 31);
            this.button1.TabIndex = 17;
            this.button1.Text = "Редактировать номер";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(13, 93);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(167, 27);
            this.numericUpDown1.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(527, 27);
            this.textBox1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Тип номера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Цена номера";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Наименование номера";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Тип размещения";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SGL (Single) – одноместное.",
            "DBL (Double) – двухместное. ",
            "TRPL (Triple) – трехместное. ",
            "QDPL (Quadriple) – четырехместное."});
            this.comboBox1.Location = new System.Drawing.Point(13, 214);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(527, 29);
            this.comboBox1.TabIndex = 21;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Arial Unicode MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Promo Rooms - по акции. ",
            "STD (Standard) – стандартная комната;",
            "STD (Standard) with Air Condition – стандартная c кондиционером;",
            "STD (Standard) without Air Condition",
            "BDR, BDRM (Bedroom) – номер со спальней;",
            "Balcony – номер с балконом;",
            "Superior (Classic) – комната большего размера, чем стандартная;",
            "Corner room – угловая комната;",
            "Studio – студия, c встроенной кухней;",
            "Family Room – семейная комната, больше стандартной;",
            "Family studio – номер для семьи с двумя смежными комнатами;",
            "Suite – номер  с гостиной и спальней;",
            "Suite mini – номер улучшенной категории;",
            "Junior suite – двухместный однокомнатный номер;",
            "Executive suite, suite senior – номер повышенной комфортности;",
            "Business – большой номер с оргтехникой;",
            "Honeymoon Room – номер для молодоженов;",
            "Connected Rooms – совмещенные номер;",
            "Duplex – двухэтажный номер;",
            "Apartment – номера, приближенные к виду современных квартир, ",
            "President – самые роскошные номера гостиницы, несколько спален, кабинет, два-три " +
                "туалета."});
            this.comboBox2.Location = new System.Drawing.Point(13, 157);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(527, 29);
            this.comboBox2.TabIndex = 22;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Arial Unicode MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "в день"});
            this.comboBox3.Location = new System.Drawing.Point(190, 93);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(350, 29);
            this.comboBox3.TabIndex = 23;
            // 
            // EditNomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::hotel.Properties.Resources.Lighthouse;
            this.ClientSize = new System.Drawing.Size(582, 290);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Vivaldi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "EditNomer";
            this.Text = "Редактирование номера";
            this.Load += new System.EventHandler(this.EditNomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}