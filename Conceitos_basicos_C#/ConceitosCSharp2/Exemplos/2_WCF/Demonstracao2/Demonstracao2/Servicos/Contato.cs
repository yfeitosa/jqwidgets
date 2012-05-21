using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demonstracao2.Servicos
{
    //Serviço
    public class Contato : IContato
    {
        public List<Pessoa> ListarPessoa()
        {
            return new List<Pessoa>()
             {
                 new Pessoa { Codigo = 1, Nome = "Pessoa 1"},
                 new Pessoa { Codigo = 2, Nome = "Pessoa 2"}
             };
        }
    }
}
