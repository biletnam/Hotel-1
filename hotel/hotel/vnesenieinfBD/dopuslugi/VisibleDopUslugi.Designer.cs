namespace hotel.vnesenieinfBD.dopuslugi
{
    partial class VisibleDopUslugi
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
            this.buttonDeliteClient = new System.Windows.Forms.Button();
            this.buttonEditclient = new System.Windows.Forms.Button();
            this.buttonAddclient = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dopuslugiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelDataSet = new hotel.otelDataSet();
            this.dopuslugiTableAdapter2 = new hotel.otelDataSetTableAdapters.dopuslugiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dopuslugiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDeliteClient
            // 
            this.buttonDeliteClient.BackgroundImage = global::hotel.Properties.Resources.Lighthouse;
            this.buttonDeliteClient.Font = new System.Drawing.Font("Vivaldi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeliteClient.Location = new System.Drawing.Point(2, 376);
            this.buttonDeliteClient.Name = "buttonDeliteClient";
            this.buttonDeliteClient.Size = new System.Drawing.Size(137, 187);
            this.buttonDeliteClient.TabIndex = 4;
            this.buttonDeliteClient.Text = "Удалить услугу";
            this.buttonDeliteClient.UseVisualStyleBackColor = true;
            this.buttonDeliteClient.Click += new System.EventHandler(this.buttonDeliteClient_Click);
            // 
            // buttonEditclient
            // 
            this.buttonEditclient.BackgroundImage = global::hotel.Properties.Resources.Lighthouse;
            this.buttonEditclient.Font = new System.Drawing.Font("Vivaldi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditclient.Location = new System.Drawing.Point(2, 192);
            this.buttonEditclient.Name = "buttonEditclient";
            this.buttonEditclient.Size = new System.Drawing.Size(137, 178);
            this.buttonEditclient.TabIndex = 3;
            this.buttonEditclient.Text = "Редактировать услугу";
            this.buttonEditclient.UseVisualStyleBackColor = true;
            this.buttonEditclient.Click += new System.EventHandler(this.buttonEditclient_Click);
            // 
            // buttonAddclient
            // 
            this.buttonAddclient.BackgroundImage = global::hotel.Properties.Resources.Lighthouse;
            this.buttonAddclient.Font = new System.Drawing.Font("Vivaldi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddclient.Location = new System.Drawing.Point(2, -1);
            this.buttonAddclient.Name = "buttonAddclient";
            this.buttonAddclient.Size = new System.Drawing.Size(137, 187);
            this.buttonAddclient.TabIndex = 2;
            this.buttonAddclient.Text = "Добавить услугу";
            this.buttonAddclient.UseVisualStyleBackColor = true;
            this.buttonAddclient.Click += new System.EventHandler(this.buttonAddclient_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView1.DataSource = this.dopuslugiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(141, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 562);
            this.dataGridView1.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn5.HeaderText = "id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "nazvanie";
            this.dataGridViewTextBoxColumn6.HeaderText = "Название";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "cena";
            this.dataGridViewTextBoxColumn7.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "stavka";
            this.dataGridViewTextBoxColumn8.HeaderText = "Ставка";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
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
            // dopuslugiTableAdapter2
            // 
            this.dopuslugiTableAdapter2.ClearBeforeFill = true;
            // 
            // VisibleDopUslugi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::hotel.Properties.Resources.Lighthouse;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonDeliteClient);
            this.Controls.Add(this.buttonEditclient);
            this.Controls.Add(this.buttonAddclient);
            this.Font = new System.Drawing.Font("Vivaldi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "VisibleDopUslugi";
            this.Text = "Дополнительные услуги";
            this.Load += new System.EventHandler(this.VisibleDopUslugi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dopuslugiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDeliteClient;
        private System.Windows.Forms.Button buttonEditclient;
        private System.Windows.Forms.Button buttonAddclient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private otelDataSet otelDataSet;
        private System.Windows.Forms.BindingSource dopuslugiBindingSource;
        private otelDataSetTableAdapters.dopuslugiTableAdapter dopuslugiTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}