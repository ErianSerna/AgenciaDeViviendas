using AgenciaViviendasParcial.Clases;
using AgenciaViviendasParcial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace AgenciaViviendassParcial.Controllers
{
    [RoutePrefix("api/Vivienda")]
    public class ViviendasController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Vivienda> ConsultarTodos()
        {
            
            clsViviendas Vivienda = new clsViviendas();
            return Vivienda.ConsultarTodos();
        }

        [HttpGet]
        [Route("ConsultarXDireccion")]
        public Vivienda ConsultarXDireccion(string Direccion)
        {
            clsViviendas Categoria = new clsViviendas();
            return Categoria.Consultar(Direccion);
        }

        [HttpGet]
        [Route("ConsultarXNumeroPisos")]
        public List<Vivienda> ConsultarXNumeroPisos(int NumPisos)
        {
            clsViviendas Vivienda = new clsViviendas();

            return Vivienda.Consultar_N_Pisos(NumPisos);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Vivienda Vivienda)
        {
            clsViviendas viv = new clsViviendas();

            viv.Vivienda = Vivienda;

            return viv.Insertar();
        }
        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Vivienda Vivienda)
        {
            clsViviendas viv = new clsViviendas();

            viv.Vivienda = Vivienda;

            return viv.Actualizar();
        }
        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] Vivienda Vivienda)
        {
            clsViviendas viv = new clsViviendas();
            viv.Vivienda = Vivienda;
            return viv.Eliminar();
        }

        [HttpDelete]
        [Route("EliminarXDireccion")]
        public string EliminarXNumeroCuartos(string Nombre)
        {
            clsViviendas Vivienda = new clsViviendas();
            return Vivienda.EliminarXDireccion(Nombre);
        }

    }
}