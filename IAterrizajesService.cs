using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AeropuertoUned.Models;

namespace AeropuertoUned
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IAterrizajesService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IAterrizajesService
    {
        [OperationContract]
        bool Actualizar(string id, string fecha_Despegue, string hora_despegue, string tecnico, string mision,
          string serie, string fecha_retorno, string hora_retorno, string perdido, string perdidas_humanas, string rescate);

        [OperationContract]
        bool Agregar(string id, string fecha_Despegue, string hora_despegue, string tecnico, string mision,
          string serie, string fecha_retorno, string hora_retorno, string perdido, string perdidas_humanas, string rescate);

        [OperationContract]
        ATERRIZAJES Buscar(string id);

        [OperationContract]
        List<ATERRIZAJES> Consultar();

        [OperationContract]
        bool Eliminar(string id);
    }
}
