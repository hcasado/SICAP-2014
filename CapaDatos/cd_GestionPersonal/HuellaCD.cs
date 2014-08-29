﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades.GestionPersonal;
namespace CapaDatos.cd_GestionPersonal
{
    public class HuellaCD
    {
        //metodo para insertar una nueva huella
        public static Huella Create(Huella not)
        {
            CapaDatosDataContext bd = new CapaDatosDataContext();
            try
            {

                Huella p = new Huella();
                p.IdHuella = not.IdHuella;
                p.Cedula = not.Cedula;
                p.DataHuella1 = not.DataHuella1;
                p.DataHuella2 = not.DataHuella2;
                bd.pa_RegistrarHuella(p.IdHuella, p.Cedula, p.DataHuella1, p.DataHuella2);
                bd.SubmitChanges();

            }
            catch (CapaDatosExcepciones ex)
            {
                throw new CapaDatosExcepciones("Error al  Insertar Huella", ex);
            }
            finally
            {
                bd = null;
            }

            return not;
        }
        
        //metodo para listar las huella de una  persona
        public static List<pa_ListarHuellaCedulaResult> ObtenerHuella(string cedula)
        {
            CapaDatosDataContext DB;
            try
            {
                using (DB = new CapaDatosDataContext())
                {
                    return DB.pa_ListarHuellaCedula(cedula).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new CapaDatosExcepciones("Error al Listar Huella", ex);
            }
            finally
            {
                DB = null;
            }
        }
      
        //metodo para saber si existe una determinada huella
        public static bool ExisteHuella(string idHuella)
        {
            CapaDatosDataContext DB;
            try
            {
                using (DB = new CapaDatosDataContext())
                {
                    var query = (from hue in DB.HUELLA where hue.IDHUELLA == idHuella select hue).Count();
                    if (query == 0)
                        return false;
                    else
                        return true;
                }
            }
            catch (Exception ex)
            {
                throw new CapaDatosExcepciones("Error al Buscar id de la huella", ex);
            }
            finally
            {
                DB = null;
            }

        }

        //metodo para eliminar una huella de una persona
        public static void EliminarHuellaIdHuella(string idHuella)
        {
            CapaDatosDataContext DB = new CapaDatosDataContext();
            try
            {

                DB.pa_EliminarHuellaIdHuella(idHuella);
                DB.SubmitChanges();


            }
            catch (Exception ex)
            {
                throw new CapaDatosExcepciones("Error al Eliminar Huella", ex);
            }
            finally
            {
                DB = null;
            }
        }

        //metodo para modificar huella
        public static Huella ModificarHuellaIdHuella(Huella hue)
        {
            CapaDatosDataContext bd = new CapaDatosDataContext();
            try
            {
                Huella h = new Huella();

                h.IdHuella = hue.IdHuella;
                h.DataHuella1 = hue.DataHuella1;
                h.DataHuella2 = hue.DataHuella2;
                bd.pa_ModificarHuellaIdHuella(h.IdHuella, h.DataHuella1, h.DataHuella2);
                bd.SubmitChanges();

            }
            catch (CapaDatosExcepciones ex)
            {
                throw new CapaDatosExcepciones("Error al Modificar Huella.", ex);
            }
            finally
            {
                bd = null;
            }

            return hue;
        }


        //metodo para la imagen
        public static byte[] getImageById(string id)
        {

            CapaDatosDataContext bd = new CapaDatosDataContext();
            try
            {
                HUELLA j = (from usu in bd.HUELLA where usu.IDHUELLA == id select usu).Single();
                if (j.DATAHUELLA1 != null)
                {
                    return j.DATAHUELLA1.ToArray();
                }
                else
                {
                    return null;
                }

            }
            catch (CapaDatosExcepciones ex)
            {
                throw new CapaDatosExcepciones("Error al  Eliminar Usuario.", ex);
            }
            finally
            {
                bd = null;
            }
        }
    }
}