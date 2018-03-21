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


        public Form1()
        {
            InitializeComponent();
        }

        private void sALARIIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.SALARII' table. You can move, or remove it, as needed.
            this.sALARIITableAdapter.Fill(this.dataSet1.SALARII);
        }

        private void salvare_actualizare_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sALARIIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_adaugare_angajat_Click(object sender, EventArgs e)
        {

        }
    }
}
