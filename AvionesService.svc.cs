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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "AvionesService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione AvionesService.svc o AvionesService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class AvionesService : IAvionesService
    {
        public bool Actualizar(string fecha, string hora, string marca, string modelo, string serie, string nombre_avion, string dimensiones, string recorrido, string numero_orden, string tecnico)
        {
            bool Resultado = false;
            AVIONES Avion = new AVIONES
            {
                Fecha = fecha,
                Hora = hora,
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

        public bool Agregar(string fecha, string hora, string marca, string modelo, string serie, string nombre_avion, string dimensiones, string recorrido, string numero_orden, string tecnico)
        {
            bool Resultado = false;
            AVIONES Avion = new AVIONES
            {
                Fecha = fecha,
                Hora = hora,
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
                bd.AVIONES.Add(Avion);
                Resultado = bd.SaveChanges() > 0;
            }
            return Resultado;
        }

        public AVIONES Buscar(string serie)
        {
            using (AEROPUERTODBEntities bd = new AEROPUERTODBEntities())
            {
                return bd.AVIONES.Find(serie);
            }

        }

        public List<AVIONES> Consultar()
        {
            using (AEROPUERTODBEntities bd = new AEROPUERTODBEntities())
            {
                return bd.AVIONES.ToList();
            }
        }

        public bool Eliminar(string serie)
        {
            bool Resultado = false;
            using (AEROPUERTODBEntities bd = new AEROPUERTODBEntities())
            {
                AVIONES Avion = bd.AVIONES.Find(serie);
                bd.AVIONES.Remove(Avion);
                Resultado = bd.SaveChanges() > 0;

            }
            return Resultado;
        }
    }
}
