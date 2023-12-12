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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "DespeguesService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione DespeguesService.svc o DespeguesService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class DespeguesService : IDespeguesService
    {
        public bool Actualizar(string id, string fecha_Despegue, string hora_despegue, string tecnico, string mision, string serie)
        {
            bool Resultado = false;
            DESPEGUES Avion = new DESPEGUES
            {
                Id = id,
                Fecha_Despegue = fecha_Despegue,
                Hora_Despegue = hora_despegue,
                Tecnico = tecnico,
                Mision = mision,
                Serie = serie
            };
            using (AEROPUERTODBEntities bd = new AEROPUERTODBEntities())
            {
                bd.Entry(Avion).State = EntityState.Modified;
                Resultado = bd.SaveChanges() > 0;
            }
            return Resultado;
        }

        public bool Agregar(string id, string fecha_Despegue, string hora_despegue, string tecnico, string mision, string serie)
        {
            bool Resultado = false;
            DESPEGUES Avion = new DESPEGUES
            {
                Id = id,
                Fecha_Despegue = fecha_Despegue,
                Hora_Despegue = hora_despegue,
                Tecnico = tecnico,
                Mision = mision,
                Serie = serie
            };
            using (AEROPUERTODBEntities bd = new AEROPUERTODBEntities())
            {
                bd.DESPEGUES.Add(Avion);
                Resultado = bd.SaveChanges() > 0;
            }
            return Resultado;
        }

        public DESPEGUES Buscar(string id)
        {
            using (AEROPUERTODBEntities bd = new AEROPUERTODBEntities())
            {
                return bd.DESPEGUES.Find(id);
            }
        }

        public List<DESPEGUES> Consultar()
        {
            using (AEROPUERTODBEntities bd = new AEROPUERTODBEntities())
            {
                return bd.DESPEGUES.ToList();
            }
        }

        public bool Eliminar(string id)
        {
            bool Resultado = false;
            using (AEROPUERTODBEntities bd = new AEROPUERTODBEntities())
            {
                DESPEGUES Avion = bd.DESPEGUES.Find(id);
                bd.DESPEGUES.Remove(Avion);
                Resultado = bd.SaveChanges() > 0;

            }
            return Resultado;
        }
    }
}
