using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AeropuertoUned.Models;

namespace AeropuertoUned
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IAvionesService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IAvionesService
    {
        [OperationContract]
        bool Actualizar(string fecha, string hora, string marca, string modelo, string serie, string nombre_avion,
            string dimensiones, string recorrido, string numero_orden, string tecnico);

        [OperationContract]
        bool Agregar(string fecha, string hora, string marca, string modelo, string serie, string nombre_avion,
            string dimensiones, string recorrido, string numero_orden, string tecnico);

        [OperationContract]
        AVIONES Buscar(string serie);

        [OperationContract]
        List<AVIONES> Consultar();

        [OperationContract]
        bool Eliminar(string serie);
    }
}
