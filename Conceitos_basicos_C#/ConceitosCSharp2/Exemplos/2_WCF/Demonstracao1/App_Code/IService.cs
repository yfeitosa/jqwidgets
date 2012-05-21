using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{
    //OperationContract é IGUALZINHO o WEBMETHOD DO WebServices
    //Esse atributo faz com que o método seja visivel no cliente(MÁQUINA)
    [OperationContract]
    void DoWork();

    [OperationContract]
    String RetornarNome();

    [OperationContract]
    Int32 RetornarIdade();

    [OperationContract]
    void SetarNome(String pNome);

    [OperationContract]
    void SetarIdade(Int32 pIdade);
}
