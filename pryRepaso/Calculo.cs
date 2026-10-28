using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryRepaso
{
    public partial class Calculo : Form
    {


        public Calculo()
        {
            InitializeComponent();
        }

        private void btnCalculo_Click(object sender, EventArgs e, float IVA)
        {
            float monto;
            monto = float.Parse(txtMonto.Text);
            //float IVA;
            //IVA = (cboIva.SelectedItem.ToString().Replace("%", "");
            float resultado;
            resultado = monto * IVA;
            //lblresultado.Text = "resultado= $ " + resultado;

        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            int ValorRegistroMonto = Convert.ToInt32(txtMonto.Text);

        }
    }
}
