namespace hotel.vnesenieinfBD.clients
{
    partial class VisibleClient
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
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelDataSet = new hotel.otelDataSet();
            this.clientTableAdapter2 = new hotel.otelDataSetTableAdapters.clientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDeliteClient
            // 
            this.buttonDeliteClient.BackgroundImage = global::hotel.Properties.Resources.Lighthouse;
            this.buttonDeliteClient.Font = new System.Drawing.Font("Vivaldi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeliteClient.Location = new System.Drawing.Point(-1, 377);
            this.buttonDeliteClient.Name = "buttonDeliteClient";
            this.buttonDeliteClient.Size = new System.Drawing.Size(137, 187);
            this.buttonDeliteClient.TabIndex = 1;
            this.buttonDeliteClient.Text = "Удалить информацию о клиенте";
            this.buttonDeliteClient.UseVisualStyleBackColor = true;
            this.buttonDeliteClient.Click += new System.EventHandler(this.buttonDeliteClient_Click);
            // 
            // buttonEditclient
            // 
            this.buttonEditclient.BackgroundImage = global::hotel.Properties.Resources.Lighthouse;
            this.buttonEditclient.Font = new System.Drawing.Font("Vivaldi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditclient.Location = new System.Drawing.Point(-1, 193);
            this.buttonEditclient.Name = "buttonEditclient";
            this.buttonEditclient.Size = new System.Drawing.Size(137, 178);
            this.buttonEditclient.TabIndex = 1;
            this.buttonEditclient.Text = "Редактировать информацию о клиенте";
            this.buttonEditclient.UseVisualStyleBackColor = true;
            this.buttonEditclient.Click += new System.EventHandler(this.buttonEditclient_Click);
            // 
            // buttonAddclient
            // 
            this.buttonAddclient.BackgroundImage = global::hotel.Properties.Resources.Lighthouse;
            this.buttonAddclient.Font = new System.Drawing.Font("Vivaldi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddclient.Location = new System.Drawing.Point(-1, 0);
            this.buttonAddclient.Name = "buttonAddclient";
            this.buttonAddclient.Size = new System.Drawing.Size(137, 187);
            this.buttonAddclient.TabIndex = 1;
            this.buttonAddclient.Text = "Добавить клиента";
            this.buttonAddclient.UseVisualStyleBackColor = true;
            this.buttonAddclient.Click += new System.EventHandler(this.buttonAddclient_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dataGridView1.DataSource = this.clientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(138, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 564);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn7.HeaderText = "id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "fio";
            this.dataGridViewTextBoxColumn8.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn9.HeaderText = "email";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.otelDataSet;
            // 
            // otelDataSet
            // 
            this.otelDataSet.DataSetName = "otelDataSet";
            this.otelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientTableAdapter2
            // 
            this.clientTableAdapter2.ClearBeforeFill = true;
            // 
            // VisibleClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonDeliteClient);
            this.Controls.Add(this.buttonEditclient);
            this.Controls.Add(this.buttonAddclient);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "VisibleClient";
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.VisibleClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddclient;
        private System.Windows.Forms.Button buttonEditclient;
        private System.Windows.Forms.Button buttonDeliteClient;
        
        private System.Windows.Forms.DataGridView dataGridView1;
        private otelDataSet otelDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private otelDataSetTableAdapters.clientTableAdapter clientTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}