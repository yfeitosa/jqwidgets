using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;

namespace Demonstracao2
{
    class Program
    {
        static void ServicoProtocoloHTTP()
        {
            //Configuro a URL que vou SUBIR(DISPONIBILIZAR) O SERVIÇO WCF
            Uri EnderecoServico = new Uri("http://localhost:8180/Demonstracao2/MeuServico");

            //Classe serve para (HOSPEDAR, ARMAZENAR) O SERVIÇO WCF
            //Informo o nome do SERVIÇO (Servicos.Contato)
            //Informo o endereço que vou SUBIR O SERVIÇO
            ServiceHost Host = new ServiceHost(typeof(Servicos.Contato), EnderecoServico);

            //Habilitei o WSDL para os clientes
            Host.Description.Behaviors.Add(new ServiceMetadataBehavior { HttpGetEnabled = true });

            //Adicionei o ENDPOINT (Contrato que vai ser trafegado para o cliente)
            //Adicionei o ENDPOINT (Tipo de Binding (PROTOCOLO))
            //Adicionei o ENDPOINT (Nome do SERVIÇO)
            Host.AddServiceEndpoint(typeof(Servicos.IContato),
                                    new WSHttpBinding(),
                                    "Servicos.Contato");

            //Liguei o SERVIÇO
            Host.Open();
        }

        static void ServicoProtocoloNETTCP()
        {
            //Configuro a URL que vou SUBIR(DISPONIBILIZAR) O SERVIÇO WCF
            Uri EnderecoServico = new Uri("net.tcp://localhost:8181/Demonstracao2/MeuServico");

            //Classe serve para (HOSPEDAR, ARMAZENAR) O SERVIÇO WCF
            //Informo o nome do SERVIÇO (Servicos.Contato)
            //Informo o endereço que vou SUBIR O SERVIÇO
            ServiceHost Host = new ServiceHost(typeof(Servicos.Contato), EnderecoServico);

            //Habilitei o WSDL para os clientes
            //WSDL = MEX no protocolo NET.TCP
            Host.Description.Behaviors.Add(new ServiceMetadataBehavior());

            //Configuração do WSDL(MEX)
            Host.AddServiceEndpoint(typeof(IMetadataExchange),
                                    MetadataExchangeBindings.CreateMexTcpBinding(),
                                    "MEX/");

            //Adicionei o ENDPOINT (Contrato que vai ser trafegado para o cliente)
            //Adicionei o ENDPOINT (Tipo de Binding (PROTOCOLO))
            //Adicionei o ENDPOINT (Nome do SERVIÇO)
            Host.AddServiceEndpoint(typeof(Servicos.IContato),
                                    new NetTcpBinding(),
                                    "Servicos.Contato");

            //Liguei o SERVIÇO
            Host.Open();
        }

        static void Main()
        {
            //Subi o serviço pelo protocolo NET.TCP
            ServicoProtocoloNETTCP();

            //Subi o serviço pelo protocolo HTTP
            ServicoProtocoloHTTP();

            //Deixei sempre ligado
            Console.ReadLine();
        }
    }
}
