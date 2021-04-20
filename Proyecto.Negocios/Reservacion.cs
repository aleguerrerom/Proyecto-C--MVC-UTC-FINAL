using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Negocios
{
 public class Reservacion
    {
        string cedula;
        string nombre;
        string pago;
        string numhabitacion;
        double dias;
        DateTime fecha;
        string adicional;
        double costos;
       
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

        public string Pago
        {
            get
            {
                return pago;
            }

            set
            {
                pago = value;
            }
        }

        public string Numhabitacion
        {
            get
            {
                return numhabitacion;
            }

            set
            {
                numhabitacion = value;
            }
        }

        public double Dias
        {
            get
            {
                return dias;
            }

            set
            {
                dias = value;
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

        public string Adicional
        {
            get
            {
                return adicional;
            }

            set
            {
                adicional = value;
            }
        }


        public double CostoFinal
        {
            get
            {
                return dias * 20;
            }

            
        }
        public double Costos
        {
            get
            {
                return costos;
            }

            set
            {
                costos = value;
            }


        }

        public Reservacion(string cedula, string nombre, string pago, string numhabitacion, double dias, DateTime fecha, string adicional/*, double costos*/)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.pago = pago;
            this.numhabitacion = numhabitacion;
            this.dias = dias;
            this.fecha = fecha;
            this.adicional = adicional;
            this.costos = costos;

        }


        public Reservacion()
        {
            this.cedula = "";
            this.nombre = "";
            this.pago = "";
            this.numhabitacion = "";
            this.dias = 0; 
            this.fecha = DateTime.Today;
            this.adicional = "";
            this.dias = 0;
            this.costos = 0;
        }
    }
}
