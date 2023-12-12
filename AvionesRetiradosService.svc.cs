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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "AvionesRetiradosService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione AvionesRetiradosService.svc o AvionesRetiradosService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class AvionesRetiradosService : IAvionesRetiradosService
    {
        public bool Actualizar(string id, string marca, string modelo, string serie, string nombre_avion, string dimensiones, string recorrido, string numero_orden, string tecnico)
        {
            bool Resultado = false;
            AVIONES_RETIRADOS Avion = new AVIONES_RETIRADOS
            {
                Id = id,    
                Marca = marca,
                Modelo = modelo,
                Serie = serie,
                Nombre_Avion = nombre_avion,
                Dimensiones = dimensiones,
                Recorrido = recorrido,
                Numero_Orden = numero_orden,
                Tecnico = tecnico
            };
            using (AEROPUERTODBEntities bd = new AEROPUERTODBEntities())
            {
                bd.Entry(Avion).State = EntityState.Modified;
                Resultado = bd.SaveChanges() > 0;
            }
            return Resultado;
        }

        public bool Agregar(string id, string marca, string modelo, string serie, string nombre_avion, string dimensiones, string recorrido, string numero_orden, string tecnico)
        {
            bool Resultado = false;
            AVIONES_RETIRADOS Avion = new AVIONES_RETIRADOS
            {
                Id = id,
                Marca = marca,
                Modelo = modelo,
                Serie = serie,
                Nombre_Avion = nombre_avion,
                Dimensiones = dimensiones,
                Recorrido = recorrido,
                Numero_Orden = numero_orden,
                Tecnico = tecnico
            };
            using (AEROPUERTODBEntities bd = new AEROPUERTODBEntities())
            {
                bd.AVIONES_RETIRADOS.Add(Avion);
                Resultado = bd.SaveChanges() > 0;
            }
            return Resultado;
        }

        public AVIONES_RETIRADOS Buscar(string id)
        {
            using (AEROPUERTODBEntities bd = new AEROPUERTODBEntities())
            {
                return bd.AVIONES_RETIRADOS.Find(id);
            }
        }

        public List<AVIONES_RETIRADOS> Consultar()
        {
            using (AEROPUERTODBEntities bd = new AEROPUERTODBEntities())
            {
                return bd.AVIONES_RETIRADOS.ToList();
            }
        }

        public bool Eliminar(string id)
        {
            bool Resultado = false;
            using (AEROPUERTODBEntities bd = new AEROPUERTODBEntities())
            {
                AVIONES_RETIRADOS Avion = bd.AVIONES_RETIRADOS.Find(id);
                bd.AVIONES_RETIRADOS.Remove(Avion);
                Resultado = bd.SaveChanges() > 0;

            }
            return Resultado;
        }
    }
}
