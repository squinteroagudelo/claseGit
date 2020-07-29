using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades
{
    public class CEprofesor
    {
        private int idProfesor;
        private string nombre;
        private string apellido;
        private string sexo;
        private string direccion;
        private string telefono;
        private string especialidad;

        public int IdProfesor { get => idProfesor; set => idProfesor = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
    }
}
