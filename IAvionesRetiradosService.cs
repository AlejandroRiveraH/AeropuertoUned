using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AeropuertoUned.Models;

namespace AeropuertoUned
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IAvionesRetiradosService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IAvionesRetiradosService
    {
        [OperationContract]
        bool Actualizar(string id, string marca, string modelo, string serie, string nombre_avion,
            string dimensiones, string recorrido, string numero_orden, string tecnico);

        [OperationContract]
        bool Agregar(string id, string marca, string modelo, string serie, string nombre_avion,
            string dimensiones, string recorrido, string numero_orden, string tecnico);

        [OperationContract]
        AVIONES_RETIRADOS Buscar(string id);

        [OperationContract]
        List<AVIONES_RETIRADOS> Consultar();

        [OperationContract]
        bool Eliminar(string id);
    }
}
