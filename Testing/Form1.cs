using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiOMSRepositoryEntity;
using DiOMSEntity;
using System.Threading;

namespace Testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private async Task<int> GetValue()
        {

            return 1;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //UnitOfWork _unit = new UnitOfWork();
            //GenericRepository<DIS_SOHeader> rep = _unit.GeneralRepository<DIS_SOHeader>();
            //List<DIS_SOHeader> lst = rep.GetAll();
            //int kk = GetValue().Result;
            GetValue();
            MessageBox.Show("ok");
        }
    }
}
