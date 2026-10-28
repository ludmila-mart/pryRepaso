using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryRepaso
{
    public partial class frmGrupo : Form
    {
        string[] VectorPlanA = new string[4];
        string[] VectorPlanB = new string[3];
        string[] VectorPlanC = new string[3];
        private int indiceGrabar;

        public frmGrupo()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {


            VectorPlanA[0] = "CPU";
            VectorPlanA[1] = "Micro";
            VectorPlanA[2] = "Placa";
            VectorPlanA[3] = "Memoria";

            VectorPlanB[0] = "Visual";
            VectorPlanB[1] = "C#";
            VectorPlanB[2] = "Desktop";

            VectorPlanC[0] = "Server";
            VectorPlanC[1] = "AWS";
            VectorPlanC[2] = "Cloud";
        }

        private void cboGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {




            switch (cboGrupo.Text)
            {

                case "Plan A":
                    lstResultado.Items.Clear();
                    lstResultado.Items.Add("CPU");
                    lstResultado.Items.Add("Micro");
                    lstResultado.Items.Add("Placa");
                    lstResultado.Items.Add("Memoria");

                    for (int i = 0; i < VectorPlanA.Length; i++)
                    {
                        lstResultado.Items.Add(VectorPlanA[i]);

                    }

                    break;

                case "Plan B":
                    lstResultado.Items.Clear();
                    lstResultado.Items.Add("Visual");
                    lstResultado.Items.Add("C#");
                    lstResultado.Items.Add("Desktop");


                    for (int i = 0; i < VectorPlanB.Length; i++)
                    {
                        lstResultado.Items.Add(VectorPlanB[i]);

                    }
                    break;

                case "Plan C":
                    lstResultado.Items.Clear();
                    lstResultado.Items.Add("Server");
                    lstResultado.Items.Add("AWS");
                    lstResultado.Items.Add("Cloud");


                    for (int i = 0; i < VectorPlanC.Length; i++)
                    {
                        lstResultado.Items.Add(VectorPlanC[i]);

                    }
                    break;

            }


        }

        private void frmGrupo_Load(object sender, EventArgs e)
        {
            cboGrupo.Items.Add("Plan A");
            cboGrupo.Items.Add("Plan B");
            cboGrupo.Items.Add("Plan C");
            cboGrupo.DropDownStyle = ComboBoxStyle.DropDownList;



        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            switch (cboGrup.Text)
            {
                case "Plan A":
                    VectorPlanA[indiceGrabar] = txtDato.Text;
                    indiceGrabar++;
                    break;

                default: break;


            }
        }
    }
}
