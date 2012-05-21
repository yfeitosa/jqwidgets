using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Departamentos_RH_Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //Retornei as informações salvas no perfil do usuário 
        TextBox1.Text = Profile.IpMaquinaCliente;
        TextBox2.Text = Profile.DataExecucao.ToLongTimeString();
        TextBox3.Text = Profile.IdadeCliente.ToString();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //Armazenei as informações nas variáveis de perfil do usuário(CORRENTE)
        //IP DA MÁQUINA CLIENTE
        Profile.IpMaquinaCliente = Request.ServerVariables["REMOTE_ADDR"];
        Profile.DataExecucao = DateTime.Now;
        Profile.IdadeCliente = 999;

        Profile.Save();
    }
}