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

        private void buttonLogin_Click(object sender, EventArgs e)
        {

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
