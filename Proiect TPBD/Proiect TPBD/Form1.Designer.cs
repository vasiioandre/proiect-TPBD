﻿namespace Proiect_TPBD
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataSet1 = new Proiect_TPBD.DataSet1();
            this.sALARIIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sALARIITableAdapter = new Proiect_TPBD.DataSet1TableAdapters.SALARIITableAdapter();
            this.tableAdapterManager = new Proiect_TPBD.DataSet1TableAdapters.TableAdapterManager();
            this.sALARIIBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.sALARIIDataGridView = new System.Windows.Forms.DataGridView();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_modificare_procente = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.actualizare_date = new System.Windows.Forms.TabPage();
            this.adaugare_angajat = new System.Windows.Forms.TabPage();
            this.mesaje = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.salvare_actualizare = new System.Windows.Forms.Button();
            this.anulare = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.textBoxPrenume = new System.Windows.Forms.TextBox();
            this.textBoxFunctie = new System.Windows.Forms.TextBox();
            this.textBoxRetineri = new System.Windows.Forms.TextBox();
            this.textBoxSalar = new System.Windows.Forms.TextBox();
            this.textBoxSpor = new System.Windows.Forms.TextBox();
            this.textBoxPremii = new System.Windows.Forms.TextBox();
            this.cauta_imagine = new System.Windows.Forms.Button();
            this.button_adaugare_angajat = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALARIIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALARIIBindingNavigator)).BeginInit();
            this.sALARIIBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sALARIIDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.actualizare_date.SuspendLayout();
            this.adaugare_angajat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sALARIIBindingSource
            // 
            this.sALARIIBindingSource.DataMember = "SALARII";
            this.sALARIIBindingSource.DataSource = this.dataSet1;
            // 
            // sALARIITableAdapter
            // 
            this.sALARIITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PROCENTETableAdapter = null;
            this.tableAdapterManager.SALARIITableAdapter = this.sALARIITableAdapter;
            this.tableAdapterManager.TESTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proiect_TPBD.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sALARIIBindingNavigator
            // 
            this.sALARIIBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sALARIIBindingNavigator.BindingSource = this.sALARIIBindingSource;
            this.sALARIIBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sALARIIBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sALARIIBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sALARIIBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1,
            this.toolStripButton_modificare_procente,
            this.toolStripButton2});
            this.sALARIIBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sALARIIBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sALARIIBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sALARIIBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sALARIIBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sALARIIBindingNavigator.Name = "sALARIIBindingNavigator";
            this.sALARIIBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sALARIIBindingNavigator.Size = new System.Drawing.Size(1503, 27);
            this.sALARIIBindingNavigator.TabIndex = 0;
            this.sALARIIBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // sALARIIDataGridView
            // 
            this.sALARIIDataGridView.AllowUserToAddRows = false;
            this.sALARIIDataGridView.AutoGenerateColumns = false;
            this.sALARIIDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sALARIIDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn14});
            this.sALARIIDataGridView.DataSource = this.sALARIIBindingSource;
            this.sALARIIDataGridView.Location = new System.Drawing.Point(17, 29);
            this.sALARIIDataGridView.Name = "sALARIIDataGridView";
            this.sALARIIDataGridView.RowTemplate.Height = 24;
            this.sALARIIDataGridView.Size = new System.Drawing.Size(1221, 293);
            this.sALARIIDataGridView.TabIndex = 1;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(54, 24);
            this.toolStripButton1.Text = "Ajutor";
            // 
            // toolStripButton_modificare_procente
            // 
            this.toolStripButton_modificare_procente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_modificare_procente.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_modificare_procente.Image")));
            this.toolStripButton_modificare_procente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_modificare_procente.Name = "toolStripButton_modificare_procente";
            this.toolStripButton_modificare_procente.Size = new System.Drawing.Size(148, 24);
            this.toolStripButton_modificare_procente.Text = "Modificare procente";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(48, 24);
            this.toolStripButton2.Text = "Iesire";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.actualizare_date);
            this.tabControl1.Controls.Add(this.adaugare_angajat);
            this.tabControl1.Location = new System.Drawing.Point(28, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1453, 430);
            this.tabControl1.TabIndex = 2;
            // 
            // actualizare_date
            // 
            this.actualizare_date.Controls.Add(this.anulare);
            this.actualizare_date.Controls.Add(this.salvare_actualizare);
            this.actualizare_date.Controls.Add(this.pictureBox1);
            this.actualizare_date.Controls.Add(this.sALARIIDataGridView);
            this.actualizare_date.Location = new System.Drawing.Point(4, 25);
            this.actualizare_date.Name = "actualizare_date";
            this.actualizare_date.Padding = new System.Windows.Forms.Padding(3);
            this.actualizare_date.Size = new System.Drawing.Size(1445, 401);
            this.actualizare_date.TabIndex = 0;
            this.actualizare_date.Text = "Actualizare date";
            this.actualizare_date.UseVisualStyleBackColor = true;
            // 
            // adaugare_angajat
            // 
            this.adaugare_angajat.Controls.Add(this.textBox8);
            this.adaugare_angajat.Controls.Add(this.button_adaugare_angajat);
            this.adaugare_angajat.Controls.Add(this.cauta_imagine);
            this.adaugare_angajat.Controls.Add(this.textBoxPremii);
            this.adaugare_angajat.Controls.Add(this.textBoxSpor);
            this.adaugare_angajat.Controls.Add(this.textBoxSalar);
            this.adaugare_angajat.Controls.Add(this.textBoxRetineri);
            this.adaugare_angajat.Controls.Add(this.textBoxFunctie);
            this.adaugare_angajat.Controls.Add(this.textBoxPrenume);
            this.adaugare_angajat.Controls.Add(this.textBoxNume);
            this.adaugare_angajat.Controls.Add(this.label8);
            this.adaugare_angajat.Controls.Add(this.label7);
            this.adaugare_angajat.Controls.Add(this.label6);
            this.adaugare_angajat.Controls.Add(this.label5);
            this.adaugare_angajat.Controls.Add(this.label4);
            this.adaugare_angajat.Controls.Add(this.label3);
            this.adaugare_angajat.Controls.Add(this.label2);
            this.adaugare_angajat.Controls.Add(this.label1);
            this.adaugare_angajat.Location = new System.Drawing.Point(4, 25);
            this.adaugare_angajat.Name = "adaugare_angajat";
            this.adaugare_angajat.Padding = new System.Windows.Forms.Padding(3);
            this.adaugare_angajat.Size = new System.Drawing.Size(1445, 401);
            this.adaugare_angajat.TabIndex = 1;
            this.adaugare_angajat.Text = "Adaugare angajat";
            this.adaugare_angajat.UseVisualStyleBackColor = true;
            // 
            // mesaje
            // 
            this.mesaje.AutoSize = true;
            this.mesaje.Location = new System.Drawing.Point(397, 492);
            this.mesaje.Name = "mesaje";
            this.mesaje.Size = new System.Drawing.Size(53, 17);
            this.mesaje.TabIndex = 3;
            this.mesaje.Text = "Mesaje";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1261, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 160);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // salvare_actualizare
            // 
            this.salvare_actualizare.Location = new System.Drawing.Point(312, 338);
            this.salvare_actualizare.Name = "salvare_actualizare";
            this.salvare_actualizare.Size = new System.Drawing.Size(127, 39);
            this.salvare_actualizare.TabIndex = 3;
            this.salvare_actualizare.Text = "Salvare";
            this.salvare_actualizare.UseVisualStyleBackColor = true;
            this.salvare_actualizare.Click += new System.EventHandler(this.salvare_actualizare_Click);
            // 
            // anulare
            // 
            this.anulare.Location = new System.Drawing.Point(737, 337);
            this.anulare.Name = "anulare";
            this.anulare.Size = new System.Drawing.Size(124, 40);
            this.anulare.TabIndex = 4;
            this.anulare.Text = "Anulare";
            this.anulare.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NR_CRT";
            this.dataGridViewTextBoxColumn1.HeaderText = "NR_CRT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NUME";
            this.dataGridViewTextBoxColumn2.HeaderText = "NUME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PRENUME";
            this.dataGridViewTextBoxColumn3.HeaderText = "PRENUME";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FUNCTIE";
            this.dataGridViewTextBoxColumn4.HeaderText = "FUNCTIE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "POZA";
            this.dataGridViewTextBoxColumn5.HeaderText = "POZA";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SALAR_BAZA";
            this.dataGridViewTextBoxColumn6.HeaderText = "SALAR_BAZA";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SPOR";
            this.dataGridViewTextBoxColumn7.HeaderText = "SPOR";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PREMII_BRUTE";
            this.dataGridViewTextBoxColumn8.HeaderText = "PREMII_BRUTE";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "RETINERI";
            this.dataGridViewTextBoxColumn14.HeaderText = "RETINERI";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Functie";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(788, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salar de baza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(788, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Spor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(788, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Premii brute";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(788, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Retineri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Selecteaza fotografie";
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(349, 59);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(295, 22);
            this.textBoxNume.TabIndex = 8;
            // 
            // textBoxPrenume
            // 
            this.textBoxPrenume.Location = new System.Drawing.Point(349, 117);
            this.textBoxPrenume.Name = "textBoxPrenume";
            this.textBoxPrenume.Size = new System.Drawing.Size(295, 22);
            this.textBoxPrenume.TabIndex = 9;
            // 
            // textBoxFunctie
            // 
            this.textBoxFunctie.Location = new System.Drawing.Point(349, 176);
            this.textBoxFunctie.Name = "textBoxFunctie";
            this.textBoxFunctie.Size = new System.Drawing.Size(295, 22);
            this.textBoxFunctie.TabIndex = 10;
            // 
            // textBoxRetineri
            // 
            this.textBoxRetineri.Location = new System.Drawing.Point(919, 229);
            this.textBoxRetineri.Name = "textBoxRetineri";
            this.textBoxRetineri.Size = new System.Drawing.Size(209, 22);
            this.textBoxRetineri.TabIndex = 11;
            // 
            // textBoxSalar
            // 
            this.textBoxSalar.Location = new System.Drawing.Point(919, 64);
            this.textBoxSalar.Name = "textBoxSalar";
            this.textBoxSalar.Size = new System.Drawing.Size(209, 22);
            this.textBoxSalar.TabIndex = 12;
            // 
            // textBoxSpor
            // 
            this.textBoxSpor.Location = new System.Drawing.Point(919, 117);
            this.textBoxSpor.Name = "textBoxSpor";
            this.textBoxSpor.Size = new System.Drawing.Size(209, 22);
            this.textBoxSpor.TabIndex = 13;
            // 
            // textBoxPremii
            // 
            this.textBoxPremii.Location = new System.Drawing.Point(919, 181);
            this.textBoxPremii.Name = "textBoxPremii";
            this.textBoxPremii.Size = new System.Drawing.Size(209, 22);
            this.textBoxPremii.TabIndex = 14;
            // 
            // cauta_imagine
            // 
            this.cauta_imagine.Location = new System.Drawing.Point(383, 224);
            this.cauta_imagine.Name = "cauta_imagine";
            this.cauta_imagine.Size = new System.Drawing.Size(55, 23);
            this.cauta_imagine.TabIndex = 15;
            this.cauta_imagine.Text = "...";
            this.cauta_imagine.UseVisualStyleBackColor = true;
            // 
            // button_adaugare_angajat
            // 
            this.button_adaugare_angajat.Location = new System.Drawing.Point(697, 311);
            this.button_adaugare_angajat.Name = "button_adaugare_angajat";
            this.button_adaugare_angajat.Size = new System.Drawing.Size(129, 36);
            this.button_adaugare_angajat.TabIndex = 16;
            this.button_adaugare_angajat.Text = "Adauga";
            this.button_adaugare_angajat.UseVisualStyleBackColor = true;
            this.button_adaugare_angajat.Click += new System.EventHandler(this.button_adaugare_angajat_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(454, 226);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(190, 22);
            this.textBox8.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 531);
            this.Controls.Add(this.mesaje);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.sALARIIBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALARIIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALARIIBindingNavigator)).EndInit();
            this.sALARIIBindingNavigator.ResumeLayout(false);
            this.sALARIIBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sALARIIDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.actualizare_date.ResumeLayout(false);
            this.adaugare_angajat.ResumeLayout(false);
            this.adaugare_angajat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource sALARIIBindingSource;
        private DataSet1TableAdapters.SALARIITableAdapter sALARIITableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sALARIIBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView sALARIIDataGridView;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton_modificare_procente;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage actualizare_date;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage adaugare_angajat;
        private System.Windows.Forms.Label mesaje;
        private System.Windows.Forms.Button anulare;
        private System.Windows.Forms.Button salvare_actualizare;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button_adaugare_angajat;
        private System.Windows.Forms.Button cauta_imagine;
        private System.Windows.Forms.TextBox textBoxPremii;
        private System.Windows.Forms.TextBox textBoxSpor;
        private System.Windows.Forms.TextBox textBoxSalar;
        private System.Windows.Forms.TextBox textBoxRetineri;
        private System.Windows.Forms.TextBox textBoxFunctie;
        private System.Windows.Forms.TextBox textBoxPrenume;
        private System.Windows.Forms.TextBox textBoxNume;
    }
}

