using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService 
{
	public void DoWork()
	{
	}

    public string RetornarNome()
    {
        return "Leonardo Lourenço Silva";
    }

    public int RetornarIdade()
    {
        return 25;
    }

    public void SetarNome(string pNome)
    {
    
    }

    public void SetarIdade(int pIdade)
    {
       
    }
}
