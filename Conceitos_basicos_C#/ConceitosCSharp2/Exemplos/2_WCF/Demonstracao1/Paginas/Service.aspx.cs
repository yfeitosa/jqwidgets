using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_Service : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //LER
        //Criei uma variável apontando para o PROXY(CLASSE DO SERVIÇO)
        ProxyService.ServiceClient Servico = new ProxyService.ServiceClient();

        TextBox1.Text = Servico.RetornarNome();
        TextBox2.Text = Servico.RetornarIdade().ToString();

        Servico.Close();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //GRAVAR
        ProxyService.ServiceClient Servico = new ProxyService.ServiceClient();

        Servico.SetarNome(TextBox1.Text);
        Servico.SetarIdade(Convert.ToInt32(TextBox2.Text));

        Servico.Close();
    }
}