using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Negocios
{
   public class Usuarios
    {
       private string nombre;
        private string cedula;
        private DateTime fecha;
       private string perfil;
        private string usuario;
        private string clave;

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Cedula
        {
            get
            {
                return cedula;
            }

            set
            {
                cedula = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public string Perfil
        {
            get
            {
                return perfil;
            }

            set
            {
                perfil = value;
            }
        }

        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public string Clave
        {
            get
            {
                return clave;
            }

            set
            {
                clave = value;
            }
        }

        public Usuarios(string nombre, string cedula, DateTime fecha, string perfil, string usuario, string clave)
        {
            this.nombre = nombre;
            this.cedula = cedula;
            this.fecha = fecha;
            this.perfil = perfil;
            this.usuario = usuario;
            this.clave = clave;
        }


        public Usuarios()
        {
            this.nombre = "";
            this.cedula = "";
            this.fecha = DateTime.Today;
            this.perfil = "";
            this.usuario = "";
            this.clave = "";
        }
    }
}
