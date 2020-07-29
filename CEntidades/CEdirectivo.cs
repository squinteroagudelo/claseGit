using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades
{
    public class CEdirectivo
    {
        private int idDirectivo;
        private string nombre;
        private string apellido;
        private string sexo;
        private string direccion;
        private string telefono;
        private string profesion;

        public int IdDirectivo { get => idDirectivo; set => idDirectivo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Profesion { get => profesion; set => profesion = value; }
    }
}
