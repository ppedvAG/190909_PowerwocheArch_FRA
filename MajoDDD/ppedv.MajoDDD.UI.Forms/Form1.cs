using ppedv.MajoDDD.Data.EF;
using ppedv.MajoDDD.Domain;
using ppedv.MajoDDD.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppedv.MajoDDD.UI.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Core core = new Core(new EFUnitOfWork(new EFContext()));

        private void DatenLadenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewBooks.DataSource = core.UoW.BookRepository.GetAll();
        }

        private void DataGridViewBooks_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            core.UoW.Save();
        }
    }
}
