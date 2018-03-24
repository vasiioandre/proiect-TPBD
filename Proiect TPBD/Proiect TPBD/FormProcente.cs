using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_TPBD
{
    public partial class FormProcente : Form
    {
        public FormProcente()
        {
            InitializeComponent();
        }

        private void FormProcente_Load(object sender, EventArgs e)
        {
            this.pROCENTETableAdapter.Fill(this.dataSet1.PROCENTE);

        }

        public static string EncodePasswordToBase64(string password)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] inArray = HashAlgorithm.Create("SHA1").ComputeHash(bytes);
            return Convert.ToBase64String(inArray);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow dgv in pROCENTEDataGridView.Rows)
                    if (EncodePasswordToBase64(textBoxParola.Text) == dgv.Cells[1].Value.ToString())
                    {
                        pROCENTEDataGridView.ReadOnly = false;
                        mesaje2.Text = "Autentificare reusita. Puteti modifica datele.";
                    }
                    else
                    {
                        mesaje2.Text = "Nu ati introdus parola corecta. Incercati din nou.";

                    }
            }
            catch (Exception ex)
            {
                mesaje2.Text = "Probleme la autentificare.";
            }
                    
        }

    private void button_salvare_procente_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pROCENTEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

            pROCENTETableAdapter.Dispose();
            this.pROCENTETableAdapter.Fill(this.dataSet1.PROCENTE);
        }

        private void anulare_modificari_procente_Click(object sender, EventArgs e)
        {

            pROCENTETableAdapter.Dispose();
            this.pROCENTETableAdapter.Fill(this.dataSet1.PROCENTE);
        }
    }
}
