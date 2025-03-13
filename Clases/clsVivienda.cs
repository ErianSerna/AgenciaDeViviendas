using AgenciaViviendasParcial.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace AgenciaViviendasParcial.Clases
{
	public class clsViviendas
	{
        private AgenciaDeVentas_DB dbAgencia = new AgenciaDeVentas_DB();
        public Vivienda Vivienda { get; set; }

        public string Insertar()
        {
            try
            {
                dbAgencia.Viviendas.Add(Vivienda);

                dbAgencia.SaveChanges();

                string direccion = Vivienda.DireccionCasa;

                return "La vivienda con dirección " + direccion + " ha sido registrada con éxito";

            }
            catch (Exception e)

            {
                return "Error: " + e.Message;
            }
        }

        public string Actualizar()
        {
            Vivienda viv = Consultar(Vivienda.DireccionCasa); //Consulta un Vivienda por su dirreción
            if (viv == null)
            {
                return "La dirección de la vivienda no es válida";
            }
            dbAgencia.Viviendas.AddOrUpdate(Vivienda);
            dbAgencia.SaveChanges();
            return "Se actualizó la Vivienda correctamente";

        }

        public Vivienda Consultar(string Dirrecion)
        {
            Vivienda viv = dbAgencia.Viviendas.FirstOrDefault(e => e.DireccionCasa == Dirrecion); //Consulta un Vivienda por su dirreción
            return viv;
        }

        public List<Vivienda> Consultar_N_Pisos(int N_pisos)
        {
            List<Vivienda> viviendas = dbAgencia.Viviendas
                .Where(e => e.NumeroDePisos == N_pisos)
                .ToList();

            return viviendas;
        }

        public List<Vivienda> ConsultarTodos()
        {
            return dbAgencia.Viviendas
                .OrderBy(e => e.Id_Vivienda) //Ordena los Viviendas por numero de pisos
                .ToList();
        }
        public string Eliminar()
        {
            try
            {
             
                Vivienda viv = Consultar(Vivienda.DireccionCasa); 
                if (viv == null)
                {
                    return "La dirección de la vivienda no es válida";
                }
                dbAgencia.Viviendas.Remove(viv);
                dbAgencia.SaveChanges();
                return "Se eliminó la vivienda correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}