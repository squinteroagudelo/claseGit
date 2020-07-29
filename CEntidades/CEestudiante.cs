using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades
{
    public class CEestudiante
    {
        private int idEstudiante;
        private string nombre;
        private string apellido;
        private string sexo;
        private string direccion;
        private string telefono;
        private DateTime fechaNacimiento;

        public int IdEstudiante { get => idEstudiante; set => idEstudiante = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    }
}
