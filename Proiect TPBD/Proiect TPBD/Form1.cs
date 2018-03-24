using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_TPBD
{
    public partial class Form1 : Form
    {
        OracleConnection conn;
        string strSQL;
        OracleCommand cmd;
        OracleDataAdapter da;
        DataSet2 d;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mesaje.Text = "";
            this.sALARIITableAdapter.Fill(this.dataSet1.SALARII);

            try
            {
                conn = new OracleConnection("DATA SOURCE=localhost:1521/XE;PASSWORD=ioana;USER ID=IOANA");
                da = new OracleDataAdapter();
            }
            catch
            {
                mesaje.Text = "Nu s-a putut realiza conexiunea la baza de date";
            }
        }


        private void salvare_actualizare_Click(object sender, EventArgs e)
        {
            mesaje.Text = "";
            try
            {
                this.Validate();
                this.sALARIIBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
            catch
            {
                mesaje.Text = "Nu s-a putut realiza salvare in baza de date";
            }

        }

        private void cauta_imagine_Click(object sender, EventArgs e)
        {
            mesaje.Text = "";
            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "All Files (.)|*.*";
                opf.Title = "Selectează imaginea angajatului";
                this.Enabled = false;

                if (opf.ShowDialog() == DialogResult.OK)
                {
                    textBoxCale.Text = opf.FileName.ToString();
                    pictureBox1.Image = Image.FromFile(textBoxCale.Text);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    this.Enabled = true;
                }
                else
                    this.Enabled = true;
            }
            catch
            {
                mesaje.Text = "Nu s-a putut incarca imaginea angajatului";
            }

        }

        private void button_adaugare_angajat_Click(object sender, EventArgs e)
        {
            mesaje.Text = "";
            try
            {
                conn.Open();
                strSQL = "INSERT INTO salarii(nume, prenume, functie, poza, salar_baza, spor, premii_brute, retineri) VALUES(:p1, :p2, :p3, :p4, :p5, :p6, :p7, :p8)";
                cmd = new OracleCommand(strSQL, conn);
                cmd.BindByName = true;

                cmd.Parameters.Add("p1", textBoxNume.Text);
                cmd.Parameters.Add("p2", textBoxPrenume.Text);
                cmd.Parameters.Add("p3", textBoxFunctie.Text);
                cmd.Parameters.Add("p4", textBoxCale.Text);
                cmd.Parameters.Add("p5", textBoxSalar.Text);
                cmd.Parameters.Add("p6", textBoxSpor.Text);
                cmd.Parameters.Add("p7", textBoxPremii.Text);
                cmd.Parameters.Add("p8", textBoxRetineri.Text);

                da.InsertCommand = cmd;
                da.InsertCommand.ExecuteNonQuery();
                conn.Close();

                sALARIITableAdapter.Dispose();
                this.sALARIITableAdapter.Fill(this.dataSet1.SALARII);

                mesaje.Text = "Anajatul a fost adaugat in baza de date";
            }
            catch
            {
                mesaje.Text = "Atentie: Angajatul nu a putut fi adaugat in baza de date!";
            }

        }

        private void sALARIIDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            mesaje.Text = "";
            try
            {
                if (sALARIIDataGridView.SelectedRows.Count > 0)
                {
                    mesaje.Text = "";
                    string img = sALARIIDataGridView.Rows[sALARIIDataGridView.SelectedRows[0].Index].Cells[4].Value.ToString();
                    if (img != null)
                    {
                        pictureBox1.Image = Image.FromFile(img);
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
            }
            catch
            {
                pictureBox1.Image = null;
            }

        }

        private void TextBoxCautaAngajat_TextChanged(object sender, EventArgs e)
        {
            mesaje.Text = "";
            try
            {
                string angajat_cautat = "nume like" + "'" + TextBoxCautaAngajat.Text + "*'";
                sALARIIBindingSource.Filter = angajat_cautat;
            }
            catch
            {
                mesaje.Text = "Nu se poate realzia filtrarea dupa nume";
            }

        }

        private void anulare_adaugare_Click(object sender, EventArgs e)
        {
            mesaje.Text = "";
            textBoxNume.Text = "";
            textBoxPrenume.Text = "";
            textBoxFunctie.Text = "";
            textBoxCale.Text = "";
            textBoxSalar.Text = "";
            textBoxSpor.Text = "0";
            textBoxPremii.Text = "0";
            textBoxRetineri.Text = "0";
        }

        private void anulare_Click(object sender, EventArgs e)
        {
            mesaje.Text = "";
            sALARIITableAdapter.Dispose();
            this.sALARIITableAdapter.Fill(this.dataSet1.SALARII);

            mesaje.Text = "S-au anulat modificarile facute";
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            mesaje.Text = "";
            sALARIIBindingSource.Filter = String.Empty;
        }

        private void textBoxCautaAngajat2_TextChanged_1(object sender, EventArgs e)
        {
            mesaje.Text = "";
            try
            {
                string angajat_cautat = "nume like" + "'" + textBoxCautaAngajat2.Text + "*'";
                sALARIIBindingSource.Filter = angajat_cautat;
            }
            catch
            {
                mesaje.Text = "Nu se poate realzia filtrarea dupa nume";
            }
        }

        private void textBoxCautaAngajat3_TextChanged(object sender, EventArgs e)
        {
            mesaje.Text = "";
            try
            {
                string angajat_cautat = "nume like" + "'" + textBoxCautaAngajat3.Text + "*'";
                sALARIIBindingSource.Filter = angajat_cautat;
            }
            catch
            {
                mesaje.Text = "Nu se poate realzia filtrarea dupa nume";
            }
        }

        private void sALARIIDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            mesaje.Text = "";
            try
            {
                if (sALARIIDataGridView1.SelectedRows.Count > 0)
                {
                    mesaje.Text = "";
                    string img = sALARIIDataGridView1.Rows[sALARIIDataGridView1.SelectedRows[0].Index].Cells[4].Value.ToString();
                    if (img != null)
                    {
                        pictureBox2.Image = Image.FromFile(img);
                        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
            }
            catch
            {
                pictureBox2.Image = null;
            }
        }

        string nr_crt_selectat = String.Empty;

        #region DataGridView Stergere angajat
        private void sALARIIDataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            mesaje.Text = "";
            try
            {
                if (sALARIIDataGridView2.SelectedRows.Count > 0)
                {
                    string img = sALARIIDataGridView2.Rows[sALARIIDataGridView2.SelectedRows[0].Index].Cells[4].Value.ToString();
                    nr_crt_selectat = sALARIIDataGridView2.Rows[sALARIIDataGridView2.SelectedRows[0].Index].Cells[0].Value.ToString();
                    if (img != null)
                    {
                        pictureBox3.Image = Image.FromFile(img);
                        pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
            }
            catch
            {
                pictureBox3.Image = null;
            }
        }
        #endregion

        #region stergere_angajat
        private void button_stergere_angajat_Click(object sender, EventArgs e)
        {
            try
            {
                if (nr_crt_selectat != string.Empty)
                {
                    if (MessageBox.Show("Sunteti siguri ca doriti sa stergeti?", "Confirmare stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        conn.Open();
                        strSQL = "DELETE FROM salarii WHERE nr_crt = :p1";
                        cmd = new OracleCommand(strSQL, conn);
                        cmd.BindByName = true;

                        cmd.Parameters.Add("p1", nr_crt_selectat);

                        da.DeleteCommand = cmd;
                        da.DeleteCommand.ExecuteNonQuery();

                        conn.Close();

                        sALARIITableAdapter.Dispose();
                        this.sALARIITableAdapter.Fill(this.dataSet1.SALARII);

                        mesaje.Text = "Stergerea angajatului s-a efectuat cu succes.";
                    }
                }
                else
                    mesaje.Text = "Nu ati selectat un angajat.";
            }
            catch (Exception)
            {
                mesaje.Text = "Nu s-a putut efectua stergerea.";
            }
        }

        #endregion

        #region ajutor
        private void toolStripButtonAjutor_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
                mesaje.Text = "Cautati un angajat dupa nume, modificati datele si apasati pe butonul de salvare.";
            else if (tabControl1.SelectedIndex == 1)
                mesaje.Text = "Introduceti datele corespunzatoare unui nou angajat si apasati butonul de salvare.";
            else if (tabControl1.SelectedIndex == 2)
                mesaje.Text = "Selectati un angajat si apasati buton sterge angajat daca doriti stergarea lui din baza de date.";
            else if (tabControl1.SelectedIndex == 3)
                mesaje.Text = "Afisarea tuturor angajatilor si a salariilor acestora. Se poate cauta un angajat dupa nume.";
            else if (tabControl1.SelectedIndex == 4)
                mesaje.Text = "De aici puteti genera statul de plata";
            else if (tabControl1.SelectedIndex == 5)
                mesaje.Text = "De aici puteti genera fluturasi de salariu, fie pentru toti angajatii, fie individual.";
        }
        #endregion

        private void toolStripButtonIesire_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void toolStripButton_modificare_procente_Click(object sender, EventArgs e)
        {
            FormProcente f = new FormProcente();
            f.Show();
        }

        #region stat plata

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                d = new DataSet2();
                da = new OracleDataAdapter("SELECT * FROM salarii", conn);
                da.Fill(d, "salarii");

                StatPlata raport = new StatPlata();
                raport.SetDataSource(d.Tables[0]);
                crystalReportViewer1.ReportSource = raport;
            }
            catch(Exception)
            {
                
            }
        }


        #endregion

        #region fluturasi
        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                d = new DataSet2();
                Fluturasi raport = new Fluturasi();

                foreach(DataGridViewRow dgv in sALARIIDataGridView3.Rows)
                {
                    d.SALARII.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value, dgv.Cells[4].Value,
                        dgv.Cells[5].Value, dgv.Cells[6].Value, dgv.Cells[7].Value, dgv.Cells[8].Value, dgv.Cells[9].Value,
                        dgv.Cells[10].Value, dgv.Cells[11].Value, dgv.Cells[12].Value, dgv.Cells[13].Value, dgv.Cells[14].Value);
                }
                
                raport.SetDataSource(d);
                crystalReportViewer2.ReportSource = raport;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void textBoxStatPlata_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string angajat_cautat = "nume like" + "'" + textBoxStatPlata.Text + "*'";
                sALARIIBindingSource.Filter = angajat_cautat;
            }
            catch
            {
                mesaje.Text = "Nu se poate realzia filtrarea dupa nume";
            }
        }
    }
}
