using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.IO;
//using System.Data.Odbc;
using System.Data.SqlClient;
using Proyecto.Datos;

namespace Proyecto.Negocios
{
    public class gestorBase
    {
        #region Metodos de Agregar

        public static void agregarUsuario(Usuarios obj)
        {
            string sentencia;
         sentencia = "insert into usuarios(nombre,cedula,fecha,perfil,usuario,clave) values(@nombre,@cedula,@fecha,@perfil,@usuario,@clave)";
            Parameter[] parametros = {

            new Parameter("@nombre",obj.Nombre),
            new Parameter("@cedula",obj.Cedula),
            new Parameter("@fecha",obj.Fecha),
            new Parameter("@perfil", obj.Perfil),
            new Parameter("@usuario", obj.Usuario),
            new Parameter("@clave", obj.Clave)
                                      };
            Database.exectuteNonQuery(sentencia, parametros);
        }


        #endregion
   

            #region Mostrar Usuario

        public static ArrayList mostrarUsuario()
           {
               DataSet datos = new DataSet();
               string sentencia = "select * from usuarios";
               Parameter[] parametros = { new Parameter("", 0) };
               datos = Database.executeDataset(sentencia, parametros);
             return ToUsua(datos);
           }
           
        public static ArrayList ToUsua(DataSet datos)
         {
             ArrayList lista = new ArrayList();
             Usuarios obj;
             foreach (DataRow fila in datos.Tables[0].Rows)
             {
               
                 obj = new Usuarios();
                string test = Convert.ToString(obj.Fecha);
                obj.Nombre = (string)fila["nombre"];
                 obj.Cedula = (string)fila["cedula"];
                 test = (string)fila["fecha"];
                 obj.Perfil = (string)fila["perfil"];
                 obj.Usuario = (string)fila["usuario"];
                 obj.Clave = (string)fila["clave"];
                 lista.Add(obj);
             }
             return lista;
         }
        #endregion

        #region Validar Login
        public static Usuarios validaLogin(string user, string pass)
        {
            string sentencia = "select * from usuarios where usuario =@user and clave =@pass";
            Parameter[] parametros = { new Parameter("@user", user), new Parameter("@pass", pass) };
            DataSet datos = Database.executeDataset(sentencia, parametros);
            ArrayList lista = ToUsua(datos);
            if (lista.Count > 0)
                return ((Usuarios)lista[0]);
            else throw new Exception("Ese usuario no existe");
        }
        #endregion
        #region Metodos de Agregar Reservacion
        public static void agregarReservacion(Reservacion res)
                {
                    string sentencia;
                    sentencia = "insert into reservaciones(cedula,nombre,metodo,numhabitacion,dias,fecha,adicional)"+
                    "values(@cedula,@nombre,@pago,@numhabitacion,@dias,@fecha,@adicional)";

                    Parameter[] parametros = {
                    new Parameter("@cedula",res.Cedula),
                    new Parameter("@nombre",res.Nombre),
                   new Parameter("@pago",res.Pago),
                    new Parameter("@numhabitacion", res.Numhabitacion),
                    new Parameter("@dias", res.Dias),
                    new Parameter("@fecha", res.Fecha),
                    new Parameter("@adicional", res.Adicional),
                  //  new Parameter("@costos", res.Costos)

                                              };
                    Database.exectuteNonQuery(sentencia, parametros);
                }



        #endregion
        #region Mostrar Reservacion

        public static ArrayList mostrarReservacion()
        {
            DataSet datos = new DataSet();
            string sentencia = "select * from reservaciones";
            Parameter[] parametros = { new Parameter("", 0) };
            datos = Database.executeDataset(sentencia, parametros);
            return Reserva(datos);
        }

        public static ArrayList Reserva(DataSet datosre)
        {
            ArrayList lista1 = new ArrayList();
            Reservacion res;
            foreach (DataRow fila in datosre.Tables[0].Rows)
            {
                res = new Reservacion();
                string test = Convert.ToString(res.Fecha);
                string test2 = Convert.ToString(res.Dias);
                res.Cedula = (string)fila["cedula"];
                res.Nombre = (string)fila["nombre"];
                res.Pago = (string)fila["metodo"];
                res.Numhabitacion = (string)fila["numhabitacion"];
                test2 = (string)fila["dias"];
                test = (string)fila["fecha"];
                res.Adicional = (string)fila["adicional"];
         //       res.Costos = (double)fila["costos"];

                lista1.Add(res);
            }
            return lista1;
        }
        #endregion

    }
}

