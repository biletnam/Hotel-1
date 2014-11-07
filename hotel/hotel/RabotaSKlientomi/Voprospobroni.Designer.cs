namespace hotel.RabotaSKlientomi
{
    partial class Voprospobroni
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclientaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idnomeraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databroniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datazaezdaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataviezdaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bronBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelDataSet = new hotel.otelDataSet();
            this.bronTableAdapter = new hotel.otelDataSetTableAdapters.bronTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bronBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Vivaldi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(760, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выбрать бронь";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idclientaDataGridViewTextBoxColumn,
            this.idnomeraDataGridViewTextBoxColumn,
            this.databroniDataGridViewTextBoxColumn,
            this.datazaezdaDataGridViewTextBoxColumn,
            this.dataviezdaDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn,
            this.expr2DataGridViewTextBoxColumn,
            this.nomerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bronBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 316);
            this.dataGridView1.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // idclientaDataGridViewTextBoxColumn
            // 
            this.idclientaDataGridViewTextBoxColumn.DataPropertyName = "idclienta";
            this.idclientaDataGridViewTextBoxColumn.HeaderText = "idclienta";
            this.idclientaDataGridViewTextBoxColumn.Name = "idclientaDataGridViewTextBoxColumn";
            this.idclientaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idnomeraDataGridViewTextBoxColumn
            // 
            this.idnomeraDataGridViewTextBoxColumn.DataPropertyName = "idnomera";
            this.idnomeraDataGridViewTextBoxColumn.HeaderText = "idnomera";
            this.idnomeraDataGridViewTextBoxColumn.Name = "idnomeraDataGridViewTextBoxColumn";
            this.idnomeraDataGridViewTextBoxColumn.Visible = false;
            // 
            // databroniDataGridViewTextBoxColumn
            // 
            this.databroniDataGridViewTextBoxColumn.DataPropertyName = "databroni";
            this.databroniDataGridViewTextBoxColumn.HeaderText = "Дата Брони";
            this.databroniDataGridViewTextBoxColumn.Name = "databroniDataGridViewTextBoxColumn";
            // 
            // datazaezdaDataGridViewTextBoxColumn
            // 
            this.datazaezdaDataGridViewTextBoxColumn.DataPropertyName = "datazaezda";
            this.datazaezdaDataGridViewTextBoxColumn.HeaderText = "Дата заезда";
            this.datazaezdaDataGridViewTextBoxColumn.Name = "datazaezdaDataGridViewTextBoxColumn";
            // 
            // dataviezdaDataGridViewTextBoxColumn
            // 
            this.dataviezdaDataGridViewTextBoxColumn.DataPropertyName = "dataviezda";
            this.dataviezdaDataGridViewTextBoxColumn.HeaderText = "Дата выезда";
            this.dataviezdaDataGridViewTextBoxColumn.Name = "dataviezdaDataGridViewTextBoxColumn";
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            // 
            // expr2DataGridViewTextBoxColumn
            // 
            this.expr2DataGridViewTextBoxColumn.DataPropertyName = "Expr2";
            this.expr2DataGridViewTextBoxColumn.HeaderText = "Expr2";
            this.expr2DataGridViewTextBoxColumn.Name = "expr2DataGridViewTextBoxColumn";
            this.expr2DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr2DataGridViewTextBoxColumn.Visible = false;
            // 
            // nomerDataGridViewTextBoxColumn
            // 
            this.nomerDataGridViewTextBoxColumn.DataPropertyName = "nomer";
            this.nomerDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.nomerDataGridViewTextBoxColumn.Name = "nomerDataGridViewTextBoxColumn";
            // 
            // bronBindingSource
            // 
            this.bronBindingSource.DataMember = "bron";
            this.bronBindingSource.DataSource = this.otelDataSet;
            // 
            // otelDataSet
            // 
            this.otelDataSet.DataSetName = "otelDataSet";
            this.otelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bronTableAdapter
            // 
            this.bronTableAdapter.ClearBeforeFill = true;
            // 
            // Voprospobroni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::hotel.Properties.Resources.Lighthouse;
            this.ClientSize = new System.Drawing.Size(778, 383);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Voprospobroni";
            this.Text = "Оформление забронированного";
            this.Load += new System.EventHandler(this.Voprospobroni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bronBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private otelDataSet otelDataSet;
        private System.Windows.Forms.BindingSource bronBindingSource;
        private otelDataSetTableAdapters.bronTableAdapter bronTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnomeraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn databroniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datazaezdaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataviezdaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomerDataGridViewTextBoxColumn;

    }
}