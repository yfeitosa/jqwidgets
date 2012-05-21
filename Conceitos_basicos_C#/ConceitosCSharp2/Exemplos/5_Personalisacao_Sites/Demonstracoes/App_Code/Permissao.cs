using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Permissao
/// </summary>
public class Permissao
{
    public String NomePagina
    {
        get;
        set;
    }

    public String NomeAcao
    {
        get;
        set;
    }
}

/// <summary>
/// Summary description for ListaPermissao
/// </summary>
[Serializable]
public class ListaPermissao : List<Permissao>
{ 

}