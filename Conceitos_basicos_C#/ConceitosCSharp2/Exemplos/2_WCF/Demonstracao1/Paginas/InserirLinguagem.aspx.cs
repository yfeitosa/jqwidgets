using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_InserirLinguagem : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //Criei uma variável do tipo(LINGUAGEM)
        //Pois o método INSERIR espera um parametro do tipo LINGUAGEM
        ProxyLinguagem.Linguagem Registro = new ProxyLinguagem.Linguagem();

        //Declarei uma variável apontando para o PROXY
        ProxyLinguagem.IsvcLinguagemClient Servico 
        = new ProxyLinguagem.IsvcLinguagemClient();

        //Setei a propriedade NOME com o conteudo do TEXTBOX
        Registro.Nome = TextBox1.Text.Trim();

        //Chamei o método INSERIR DO (PROXY, SERVICO)
        //Passando a variável do TIPO LINGUAGEM
        Servico.Inserir(Registro);

        //Fechei a comunicação na PORTA
        Servico.Close();
    }
}