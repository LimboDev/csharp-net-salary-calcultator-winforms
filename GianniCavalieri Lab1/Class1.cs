using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GianniCavalieri_Lab1
{
    internal class Empleado
    {
        //Atributos
        private string nombreEmpleado, cedula;
        private double salarioBruto;

        //Método Constructor
        public Empleado(string nombreEmpleado, string cedula, double salarioBruto)
        {
            this.nombreEmpleado = nombreEmpleado;
            this.cedula = cedula;
            this.salarioBruto = salarioBruto;
        }

        //Método set
        public void setNombre(string nombre)
        {

        }

        //Método get
        public string getNombre()
        {
            return nombreEmpleado;
        }
        public string getcedula()
        {
            return cedula;
        }
        public double getSalarioBruto()
        {
            return salarioBruto;
        }

        //Funciones
        public double CalcularSeguroSocial()
        {
            double seguroSocial;
            seguroSocial = salarioBruto * 0.0975;
            return seguroSocial;
        }
        public double CalcularSeguroEducativo()
        {
            double seguroEducativo;
            seguroEducativo = salarioBruto * 0.0125;
            return seguroEducativo;
        }
        public double CalcularSalarioNeto(double seguroEducativo, double seguroSocial)
        {
            double salarioNeto;
            salarioNeto = salarioBruto - (seguroEducativo + seguroSocial);
            return salarioNeto;
        }
    }
}
