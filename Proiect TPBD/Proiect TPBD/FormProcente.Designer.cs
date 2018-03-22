namespace Proiect_TPBD
{
    partial class FormProcente
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
            this.components = new System.ComponentModel.Container();
            this.dataSet1 = new Proiect_TPBD.DataSet1();
            this.pROCENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROCENTETableAdapter = new Proiect_TPBD.DataSet1TableAdapters.PROCENTETableAdapter();
            this.tableAdapterManager = new Proiect_TPBD.DataSet1TableAdapters.TableAdapterManager();
            this.pROCENTEDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_salvare_procente = new System.Windows.Forms.Button();
            this.anulare_modificari_procente = new System.Windows.Forms.Button();
            this.mesaje_procente = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROCENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROCENTEDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROCENTEBindingSource
            // 
            this.pROCENTEBindingSource.DataMember = "PROCENTE";
            this.pROCENTEBindingSource.DataSource = this.dataSet1;
            // 
            // pROCENTETableAdapter
            // 
            this.pROCENTETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PROCENTETableAdapter = this.pROCENTETableAdapter;
            this.tableAdapterManager.SALARIITableAdapter = null;
            this.tableAdapterManager.TESTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proiect_TPBD.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pROCENTEDataGridView
            // 
            this.pROCENTEDataGridView.AllowUserToAddRows = false;
            this.pROCENTEDataGridView.AutoGenerateColumns = false;
            this.pROCENTEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pROCENTEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.pROCENTEDataGridView.DataSource = this.pROCENTEBindingSource;
            this.pROCENTEDataGridView.Location = new System.Drawing.Point(60, 89);
            this.pROCENTEDataGridView.Name = "pROCENTEDataGridView";
            this.pROCENTEDataGridView.ReadOnly = true;
            this.pROCENTEDataGridView.RowTemplate.Height = 24;
            this.pROCENTEDataGridView.Size = new System.Drawing.Size(460, 67);
            this.pROCENTEDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parola";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(183, 22);
            this.textBox1.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CAS";
            this.dataGridViewTextBoxColumn2.HeaderText = "CAS";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CASS";
            this.dataGridViewTextBoxColumn3.HeaderText = "CASS";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IMPOZIT";
            this.dataGridViewTextBoxColumn4.HeaderText = "IMPOZIT";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // button_salvare_procente
            // 
            this.button_salvare_procente.Location = new System.Drawing.Point(125, 195);
            this.button_salvare_procente.Name = "button_salvare_procente";
            this.button_salvare_procente.Size = new System.Drawing.Size(83, 41);
            this.button_salvare_procente.TabIndex = 4;
            this.button_salvare_procente.Text = "Salvare";
            this.button_salvare_procente.UseVisualStyleBackColor = true;
            this.button_salvare_procente.Click += new System.EventHandler(this.button_salvare_procente_Click);
            // 
            // anulare_modificari_procente
            // 
            this.anulare_modificari_procente.Location = new System.Drawing.Point(345, 195);
            this.anulare_modificari_procente.Name = "anulare_modificari_procente";
            this.anulare_modificari_procente.Size = new System.Drawing.Size(94, 41);
            this.anulare_modificari_procente.TabIndex = 5;
            this.anulare_modificari_procente.Text = "Anulare";
            this.anulare_modificari_procente.UseVisualStyleBackColor = true;
            this.anulare_modificari_procente.Click += new System.EventHandler(this.anulare_modificari_procente_Click);
            // 
            // mesaje_procente
            // 
            this.mesaje_procente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mesaje_procente.Location = new System.Drawing.Point(62, 368);
            this.mesaje_procente.Name = "mesaje_procente";
            this.mesaje_procente.ReadOnly = true;
            this.mesaje_procente.Size = new System.Drawing.Size(465, 15);
            this.mesaje_procente.TabIndex = 6;
            this.mesaje_procente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(376, 22);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(111, 25);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // FormProcente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 279);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.mesaje_procente);
            this.Controls.Add(this.anulare_modificari_procente);
            this.Controls.Add(this.button_salvare_procente);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pROCENTEDataGridView);
            this.Name = "FormProcente";
            this.Text = "FormProcente";
            this.Load += new System.EventHandler(this.FormProcente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROCENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROCENTEDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pROCENTEBindingSource;
        private DataSet1TableAdapters.PROCENTETableAdapter pROCENTETableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView pROCENTEDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button_salvare_procente;
        private System.Windows.Forms.Button anulare_modificari_procente;
        private System.Windows.Forms.TextBox mesaje_procente;
        private System.Windows.Forms.Button buttonLogin;
    }
}