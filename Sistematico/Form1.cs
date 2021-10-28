using AppCore.Interfaces;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistematico
{
    public partial class Form1 : Form
    {
        private IService model;   
        public Form1(IService model)
        {
            this.model = model;
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FrmActivoFijo frm = new FrmActivoFijo();
            frm.model = model;
            frm.ShowDialog();
            dataGridView1.DataSource = model.FIndAll();
        }
    }
}
