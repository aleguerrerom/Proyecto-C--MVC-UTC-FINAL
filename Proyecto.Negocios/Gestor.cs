using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Proyecto.Negocios
{
     public class Gestor
    {

         #region  Metodos de Agregar

         
     public static void agregarUsuario(Usuarios user)
         {
             try
             {
                gestorBase.agregarUsuario(user);
             }
             catch (Exception)
             {
                 throw new Exception("Usuario ya exite !!!! ");
             }
         }

        public static void agregarReservacion(Reservacion res)
        {
            try
            {
                gestorBase.agregarReservacion(res);
            }
            catch (Exception)
            {
                throw new Exception("");
            }
        }




        #endregion
        #region Login
        public static Usuarios validarLogin(string usuario, string clave)
          {
              try
              {
                 return gestorBase.validaLogin(usuario, clave);
              }
              catch (Exception ex)
              {

                  throw ex;
              }

          }
        #endregion


        #region Métodos de Mostrar Usuario
        public static ArrayList mostrarUsuario()
        {
            try
            {
                return gestorBase.mostrarUsuario();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region Métodos de Mostrar Reservaciones
        public static ArrayList mostrarReservacion()
        {
            try
            {
                return gestorBase.mostrarReservacion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion
    }
}
