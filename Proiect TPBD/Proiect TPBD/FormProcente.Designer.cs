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
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.button_salvare_procente = new System.Windows.Forms.Button();
            this.anulare_modificari_procente = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.mesaje2 = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAROLA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.PAROLA,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.pROCENTEDataGridView.DataSource = this.pROCENTEBindingSource;
            this.pROCENTEDataGridView.Location = new System.Drawing.Point(60, 89);
            this.pROCENTEDataGridView.Name = "pROCENTEDataGridView";
            this.pROCENTEDataGridView.ReadOnly = true;
            this.pROCENTEDataGridView.RowTemplate.Height = 24;
            this.pROCENTEDataGridView.Size = new System.Drawing.Size(454, 74);
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
            // textBoxParola
            // 
            this.textBoxParola.Location = new System.Drawing.Point(161, 25);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.Size = new System.Drawing.Size(183, 22);
            this.textBoxParola.TabIndex = 3;
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
            // mesaje2
            // 
            this.mesaje2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mesaje2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mesaje2.Location = new System.Drawing.Point(51, 258);
            this.mesaje2.Name = "mesaje2";
            this.mesaje2.ReadOnly = true;
            this.mesaje2.Size = new System.Drawing.Size(486, 20);
            this.mesaje2.TabIndex = 8;
            this.mesaje2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CAS";
            this.dataGridViewTextBoxColumn2.HeaderText = "CAS";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // PAROLA
            // 
            this.PAROLA.DataPropertyName = "PAROLA";
            this.PAROLA.HeaderText = "PAROLA";
            this.PAROLA.Name = "PAROLA";
            this.PAROLA.ReadOnly = true;
            this.PAROLA.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CASS";
            this.dataGridViewTextBoxColumn3.HeaderText = "CASS";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IMPOZIT";
            this.dataGridViewTextBoxColumn4.HeaderText = "IMPOZIT";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // FormProcente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 304);
            this.Controls.Add(this.mesaje2);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.anulare_modificari_procente);
            this.Controls.Add(this.button_salvare_procente);
            this.Controls.Add(this.textBoxParola);
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
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.Button button_salvare_procente;
        private System.Windows.Forms.Button anulare_modificari_procente;
        private System.Windows.Forms.TextBox mesaje_procente;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox mesaje2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAROLA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}