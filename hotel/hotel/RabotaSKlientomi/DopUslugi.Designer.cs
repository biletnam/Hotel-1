namespace hotel.RabotaSKlientomi
{
    partial class DopUslugi
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.otelDataSet = new hotel.otelDataSet();
            this.jurnaldopuslugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jurnaldopuslugTableAdapter = new hotel.otelDataSetTableAdapters.jurnaldopuslugTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddopuslugDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclientaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idjurnalanomeraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazvanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datazaezdaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataviezdaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jurnaldopuslugBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(342, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Офорить дополнительную услугу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(430, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(342, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Отменить дополнительную услугу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.iddopuslugDataGridViewTextBoxColumn,
            this.idclientaDataGridViewTextBoxColumn,
            this.idjurnalanomeraDataGridViewTextBoxColumn,
            this.nazvanieDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn,
            this.nomerDataGridViewTextBoxColumn,
            this.datazaezdaDataGridViewTextBoxColumn,
            this.dataviezdaDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jurnaldopuslugBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 499);
            this.dataGridView1.TabIndex = 3;
            // 
            // otelDataSet
            // 
            this.otelDataSet.DataSetName = "otelDataSet";
            this.otelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jurnaldopuslugBindingSource
            // 
            this.jurnaldopuslugBindingSource.DataMember = "jurnaldopuslug";
            this.jurnaldopuslugBindingSource.DataSource = this.otelDataSet;
            // 
            // jurnaldopuslugTableAdapter
            // 
            this.jurnaldopuslugTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // iddopuslugDataGridViewTextBoxColumn
            // 
            this.iddopuslugDataGridViewTextBoxColumn.DataPropertyName = "iddopuslug";
            this.iddopuslugDataGridViewTextBoxColumn.HeaderText = "iddopuslug";
            this.iddopuslugDataGridViewTextBoxColumn.Name = "iddopuslugDataGridViewTextBoxColumn";
            this.iddopuslugDataGridViewTextBoxColumn.Visible = false;
            // 
            // idclientaDataGridViewTextBoxColumn
            // 
            this.idclientaDataGridViewTextBoxColumn.DataPropertyName = "idclienta";
            this.idclientaDataGridViewTextBoxColumn.HeaderText = "idclienta";
            this.idclientaDataGridViewTextBoxColumn.Name = "idclientaDataGridViewTextBoxColumn";
            this.idclientaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idjurnalanomeraDataGridViewTextBoxColumn
            // 
            this.idjurnalanomeraDataGridViewTextBoxColumn.DataPropertyName = "idjurnalanomera";
            this.idjurnalanomeraDataGridViewTextBoxColumn.HeaderText = "idjurnalanomera";
            this.idjurnalanomeraDataGridViewTextBoxColumn.Name = "idjurnalanomeraDataGridViewTextBoxColumn";
            this.idjurnalanomeraDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazvanieDataGridViewTextBoxColumn
            // 
            this.nazvanieDataGridViewTextBoxColumn.DataPropertyName = "nazvanie";
            this.nazvanieDataGridViewTextBoxColumn.HeaderText = "Услуга";
            this.nazvanieDataGridViewTextBoxColumn.Name = "nazvanieDataGridViewTextBoxColumn";
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            // 
            // nomerDataGridViewTextBoxColumn
            // 
            this.nomerDataGridViewTextBoxColumn.DataPropertyName = "nomer";
            this.nomerDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.nomerDataGridViewTextBoxColumn.Name = "nomerDataGridViewTextBoxColumn";
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
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "Expr1";
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr1DataGridViewTextBoxColumn.Visible = false;
            // 
            // DopUslugi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::hotel.Properties.Resources.Lighthouse;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Vivaldi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "DopUslugi";
            this.Text = "Дополнительные услуги";
            this.Load += new System.EventHandler(this.DopUslugi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jurnaldopuslugBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private otelDataSet otelDataSet;
        private System.Windows.Forms.BindingSource jurnaldopuslugBindingSource;
        private otelDataSetTableAdapters.jurnaldopuslugTableAdapter jurnaldopuslugTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddopuslugDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idjurnalanomeraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datazaezdaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataviezdaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;







    }
}