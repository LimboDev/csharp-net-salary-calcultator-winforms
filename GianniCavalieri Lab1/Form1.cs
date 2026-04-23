using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GianniCavalieri_Lab1
{
    public partial class CalculadoraSalarioNeto : Form
    {
        public CalculadoraSalarioNeto()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            //Declaración de variables
            string nombre, cedula;
            double salarioBruto, salarioNeto, seguroSocial, seguroEducativo;

            nombre = txtNombre.Text;
            cedula = txtCedula.Text;
            salarioBruto = Convert.ToDouble(txtSalarioBruto.Text);
            // Creación del objeto Empleado
            Empleado empleado = new Empleado(nombre, cedula, salarioBruto);
            // Calcular datos
            seguroSocial = empleado.CalcularSeguroSocial();
            seguroEducativo = empleado.CalcularSeguroEducativo();
            salarioNeto = empleado.CalcularSalarioNeto(seguroEducativo, seguroSocial);
            lbSalarioNeto.Text = "Salario neto mensual: $" + salarioNeto.ToString("F2");
            lbSeguroSocial.Text = "Seguro Social: $" + seguroSocial.ToString("F2");
            lbSeguroEducativo.Text = "Seguro Educativo: $" + seguroEducativo.ToString("F2");
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
