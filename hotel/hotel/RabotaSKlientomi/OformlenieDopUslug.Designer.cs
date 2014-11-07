namespace hotel.RabotaSKlientomi
{
    partial class OformlenieDopUslug
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazvanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dopuslugiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelDataSet = new hotel.otelDataSet();
            this.dopuslugiTableAdapter = new hotel.otelDataSetTableAdapters.dopuslugiTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nalichbroniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbroniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idnomeraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclientaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datazaezdaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataviezdaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurnalnomeraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jurnalnomeraTableAdapter = new hotel.otelDataSetTableAdapters.jurnalnomeraTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dopuslugiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jurnalnomeraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дополнительная услуга";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazvanieDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.stavkaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dopuslugiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 211);
            this.dataGridView1.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazvanieDataGridViewTextBoxColumn
            // 
            this.nazvanieDataGridViewTextBoxColumn.DataPropertyName = "nazvanie";
            this.nazvanieDataGridViewTextBoxColumn.HeaderText = "Услуга";
            this.nazvanieDataGridViewTextBoxColumn.Name = "nazvanieDataGridViewTextBoxColumn";
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            // 
            // stavkaDataGridViewTextBoxColumn
            // 
            this.stavkaDataGridViewTextBoxColumn.DataPropertyName = "stavka";
            this.stavkaDataGridViewTextBoxColumn.HeaderText = "Ставка";
            this.stavkaDataGridViewTextBoxColumn.Name = "stavkaDataGridViewTextBoxColumn";
            // 
            // dopuslugiBindingSource
            // 
            this.dopuslugiBindingSource.DataMember = "dopuslugi";
            this.dopuslugiBindingSource.DataSource = this.otelDataSet;
            // 
            // otelDataSet
            // 
            this.otelDataSet.DataSetName = "otelDataSet";
            this.otelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dopuslugiTableAdapter
            // 
            this.dopuslugiTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выбрать оформленный номер";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nalichbroniDataGridViewTextBoxColumn,
            this.idbroniDataGridViewTextBoxColumn,
            this.idnomeraDataGridViewTextBoxColumn,
            this.idclientaDataGridViewTextBoxColumn,
            this.datazaezdaDataGridViewTextBoxColumn,
            this.dataviezdaDataGridViewTextBoxColumn,
            this.expr3DataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.jurnalnomeraBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 277);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(760, 215);
            this.dataGridView2.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nalichbroniDataGridViewTextBoxColumn
            // 
            this.nalichbroniDataGridViewTextBoxColumn.DataPropertyName = "nalichbroni";
            this.nalichbroniDataGridViewTextBoxColumn.HeaderText = "nalichbroni";
            this.nalichbroniDataGridViewTextBoxColumn.Name = "nalichbroniDataGridViewTextBoxColumn";
            this.nalichbroniDataGridViewTextBoxColumn.Visible = false;
            // 
            // idbroniDataGridViewTextBoxColumn
            // 
            this.idbroniDataGridViewTextBoxColumn.DataPropertyName = "idbroni";
            this.idbroniDataGridViewTextBoxColumn.HeaderText = "idbroni";
            this.idbroniDataGridViewTextBoxColumn.Name = "idbroniDataGridViewTextBoxColumn";
            this.idbroniDataGridViewTextBoxColumn.Visible = false;
            // 
            // idnomeraDataGridViewTextBoxColumn
            // 
            this.idnomeraDataGridViewTextBoxColumn.DataPropertyName = "idnomera";
            this.idnomeraDataGridViewTextBoxColumn.HeaderText = "idnomera";
            this.idnomeraDataGridViewTextBoxColumn.Name = "idnomeraDataGridViewTextBoxColumn";
            this.idnomeraDataGridViewTextBoxColumn.Visible = false;
            // 
            // idclientaDataGridViewTextBoxColumn
            // 
            this.idclientaDataGridViewTextBoxColumn.DataPropertyName = "idclienta";
            this.idclientaDataGridViewTextBoxColumn.HeaderText = "idclienta";
            this.idclientaDataGridViewTextBoxColumn.Name = "idclientaDataGridViewTextBoxColumn";
            this.idclientaDataGridViewTextBoxColumn.Visible = false;
            // 
            // datazaezdaDataGridViewTextBoxColumn
            // 
            this.datazaezdaDataGridViewTextBoxColumn.DataPropertyName = "datazaezda";
            this.datazaezdaDataGridViewTextBoxColumn.HeaderText = "Заезд";
            this.datazaezdaDataGridViewTextBoxColumn.Name = "datazaezdaDataGridViewTextBoxColumn";
            // 
            // dataviezdaDataGridViewTextBoxColumn
            // 
            this.dataviezdaDataGridViewTextBoxColumn.DataPropertyName = "dataviezda";
            this.dataviezdaDataGridViewTextBoxColumn.HeaderText = "Выезд";
            this.dataviezdaDataGridViewTextBoxColumn.Name = "dataviezdaDataGridViewTextBoxColumn";
            // 
            // expr3DataGridViewTextBoxColumn
            // 
            this.expr3DataGridViewTextBoxColumn.DataPropertyName = "Expr3";
            this.expr3DataGridViewTextBoxColumn.HeaderText = "Номер";
            this.expr3DataGridViewTextBoxColumn.Name = "expr3DataGridViewTextBoxColumn";
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            // 
            // jurnalnomeraBindingSource
            // 
            this.jurnalnomeraBindingSource.DataMember = "jurnalnomera";
            this.jurnalnomeraBindingSource.DataSource = this.otelDataSet;
            // 
            // jurnalnomeraTableAdapter
            // 
            this.jurnalnomeraTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(760, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Оформить дополнительную услугу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OformlenieDopUslug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::hotel.Properties.Resources.Lighthouse;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Vivaldi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "OformlenieDopUslug";
            this.Text = "Оформление дополнительных услуг";
            this.Load += new System.EventHandler(this.OformlenieDopUslug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dopuslugiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jurnalnomeraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private otelDataSet otelDataSet;
        private System.Windows.Forms.BindingSource dopuslugiBindingSource;
        private otelDataSetTableAdapters.dopuslugiTableAdapter dopuslugiTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource jurnalnomeraBindingSource;
        private otelDataSetTableAdapters.jurnalnomeraTableAdapter jurnalnomeraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nalichbroniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbroniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnomeraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datazaezdaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataviezdaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}