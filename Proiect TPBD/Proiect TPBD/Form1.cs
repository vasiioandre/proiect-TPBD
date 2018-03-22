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
                mesaje.Text = "Angajatul nu are fotografie";
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
        }
    }
}
