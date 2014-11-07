namespace hotel.RabotaSKlientomi
{
    partial class OformlenieVNomer
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
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jurnalnomeraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelDataSet = new hotel.otelDataSet();
            this.jurnalnomeraTableAdapter = new hotel.otelDataSetTableAdapters.jurnalnomeraTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nalichbroniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbroniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idnomeraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclientaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datazaezdaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataviezdaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jurnalnomeraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(381, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Оформить забронированный номер";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(360, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Оформить незабронированный номер";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(747, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Освободить номер";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nalichbroniDataGridViewTextBoxColumn,
            this.idbroniDataGridViewTextBoxColumn,
            this.idnomeraDataGridViewTextBoxColumn,
            this.idclientaDataGridViewTextBoxColumn,
            this.datazaezdaDataGridViewTextBoxColumn,
            this.dataviezdaDataGridViewTextBoxColumn,
            this.expr3DataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jurnalnomeraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 467);
            this.dataGridView1.TabIndex = 4;
            // 
            // jurnalnomeraBindingSource
            // 
            this.jurnalnomeraBindingSource.DataMember = "jurnalnomera";
            this.jurnalnomeraBindingSource.DataSource = this.otelDataSet;
            // 
            // otelDataSet
            // 
            this.otelDataSet.DataSetName = "otelDataSet";
            this.otelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jurnalnomeraTableAdapter
            // 
            this.jurnalnomeraTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nalichbroniDataGridViewTextBoxColumn
            // 
            this.nalichbroniDataGridViewTextBoxColumn.DataPropertyName = "nalichbroni";
            this.nalichbroniDataGridViewTextBoxColumn.HeaderText = "Бронь";
            this.nalichbroniDataGridViewTextBoxColumn.Name = "nalichbroniDataGridViewTextBoxColumn";
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
            // OformlenieVNomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::hotel.Properties.Resources.Lighthouse;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Vivaldi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "OformlenieVNomer";
            this.Text = "Оформление в номер";
            this.Load += new System.EventHandler(this.OformlenieVNomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jurnalnomeraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private otelDataSet otelDataSet;
        private System.Windows.Forms.BindingSource jurnalnomeraBindingSource;
        private otelDataSetTableAdapters.jurnalnomeraTableAdapter jurnalnomeraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stavkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mestaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zanitostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nalichbroniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbroniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnomeraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datazaezdaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataviezdaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;

    }
}