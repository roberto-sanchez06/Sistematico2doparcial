using AppCore.Interfaces;
using Domain.Entities;
using Domain.Enums;
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
    public partial class FrmActivoFijo : Form
    {
        public IService model { get; set; }
        public FrmActivoFijo()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            ActivoFijo af = new ActivoFijo()
            {
                Nombre = txtNombre.Text,
                Descripcion = txtDesc.Text,
                Codigo = txtCod.Text,
                ValorActivo = nudValorActivo.Value,
                ValorResidual = nudValorResidual.Value,
                FechaAdquisicion = dateTimePicker1.Value,
                TipoActivo = (TipoActivo)cmbTipoActivo.SelectedIndex,
                Id = model.GetLastId() + 1,
                VidaUtil = cmbTipoActivo.SelectedIndex
            };
            model.Create(af);
            Dispose();
        }
    }
}
