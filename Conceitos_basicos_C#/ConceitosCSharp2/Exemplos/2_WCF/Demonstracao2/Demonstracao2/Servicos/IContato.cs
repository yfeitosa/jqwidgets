using System;
using System.Collections.Generic;
using System.Linq;
//Importei essa namespace para trabalhar com as classes WCF (ServiceContract, OperationContract)
using System.ServiceModel;
using System.Text;

namespace Demonstracao2.Servicos
{
    //Contrato que vai ser retornado para o cliente
    [ServiceContract]
    interface IContato
    {
        //Métodos que serão visiveis ao cliente
        [OperationContract]
        List<Pessoa> ListarPessoa();
    }
}
