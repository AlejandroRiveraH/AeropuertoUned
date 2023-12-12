using AeropuertoUned.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity;

namespace AeropuertoUned
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "AterrizajesService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione AterrizajesService.svc o AterrizajesService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class AterrizajesService : IAterrizajesService
    {
        public bool Actualizar(string id, string fecha_Despegue, string hora_despegue, string tecnico, string mision, string serie, string fecha_retorno, string hora_retorno, string perdido, string perdidas_humanas, string rescate)
        {
            bool Resultado = false;
            ATERRIZAJES Avion = new ATERRIZAJES
            {
                Id = id,
                Fecha_Despegue = fecha_Despegue,
                Hora_Despegue = hora_despegue,
                Tecnico = tecnico,
                Mision = mision,
                Serie = serie,
                Fecha_Retorno = fecha_retorno,
                Hora_Retorno = hora_retorno,
                Perdido = perdido,
                Perdidas_Humanas = perdidas_humanas,
                Rescate = rescate
            };
            using (AEROPUERTODBEntities bd = new AEROPUERTODBEntities())
            {
                bd.Entry(Avion).State = EntityState.Modified;
                Resultado = bd.SaveChanges() > 0;
            }
            return Resultado;
        }

        public bool Agregar(string id, string fecha_Despegue, string hora_despegue, string tecnico, string mision, string serie, string fecha_retorno, string hora_retorno, string perdido, string perdidas_humanas, string rescate)
        {
            bool Resultado = false;
            ATERRIZAJES Avion = new ATERRIZAJES
            {
                Id = id,
                Fecha_Despegue = fecha_Despegue,
                Hora_Despegue = hora_despegue,
                Tecnico = tecnico,
                Mision = mision,
                Serie = serie,
                Fecha_Retorno = fecha_retorno,
                Hora_Retorno = hora_retorno,
                Perdido = perdido,
                Perdidas_Humanas = perdidas_humanas,
                Rescate = rescate
            };
            using (AEROPUERTODBEntities bd = new AEROPUERTODBEntities())
            {
                bd.ATERRIZAJES.Add(Avion);
                Resultado = bd.SaveChanges() > 0;
            }
            return Resultado;
        }

        public ATERRIZAJES Buscar(string id)
        {
            using (AEROPUERTODBEntities bd = new AEROPUERTODBEntities())
            {
                return bd.ATERRIZAJES.Find(id);
            }
        }

        public List<ATERRIZAJES> Consultar()
        {
            using (AEROPUERTODBEntities bd = new AEROPUERTODBEntities())
            {
                return bd.ATERRIZAJES.ToList();
            }
        }

        public bool Eliminar(string id)
        {
            bool Resultado = false;
            using (AEROPUERTODBEntities bd = new AEROPUERTODBEntities())
            {
                ATERRIZAJES Avion = bd.ATERRIZAJES.Find(id);
                bd.ATERRIZAJES.Remove(Avion);
                Resultado = bd.SaveChanges() > 0;

            }
            return Resultado;
        }
    }
}
