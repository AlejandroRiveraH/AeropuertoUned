using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AeropuertoUned.Models;

namespace AeropuertoUned
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IDespeguesService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IDespeguesService
    {
        [OperationContract]
        bool Actualizar(string id, string fecha_Despegue, string hora_despegue, string tecnico, string mision,
           string serie);

        [OperationContract]
        bool Agregar(string id, string fecha_Despegue, string hora_despegue, string tecnico, string mision,
           string serie);

        [OperationContract]
        DESPEGUES Buscar(string id);

        [OperationContract]
        List<DESPEGUES> Consultar();

        [OperationContract]
        bool Eliminar(string id);
    }
}
