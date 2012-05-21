using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dados_Simples_Exemplo1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        //Botão Criar
        //Armazenei o conteúdo do textbox no cache
        Cache.Insert("NOME", TextBox1.Text.Trim());
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        //Botão Alterar
        //Atualizei o conteúdo do cache com o conteúdo do textbox
        Cache["NOME"] = TextBox1.Text.Trim();
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        //Botão Remover
        //Removi o conteúdo do cache (NOME)
        Cache.Remove("NOME");
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        //Botão Ler
        //Exibi uma mensagem 
        //na página com o conteúdo do cache
        if (Cache["NOME"] != null)
            Response.Write("<script>alert('"
             + Cache["NOME"].ToString() + "');</script>");
    }
}