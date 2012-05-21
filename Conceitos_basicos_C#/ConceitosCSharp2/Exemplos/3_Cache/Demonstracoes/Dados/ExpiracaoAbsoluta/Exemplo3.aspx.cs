using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Dados_ExpiracaoAbsoluta_Exemplo3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            DataTable Tabela = new DataTable();

            using (SqlConnection Conexao = new SqlConnection(WebConfigurationManager.ConnectionStrings["CURSO"].ConnectionString))
            {
                Conexao.Open();

                using (SqlDataAdapter Adaptador = new SqlDataAdapter())
                {
                    Adaptador.SelectCommand = new SqlCommand();
                    Adaptador.SelectCommand.Connection = Conexao;
                    Adaptador.SelectCommand.CommandText = "SELECT * FROM TB_LINGUAGEM";
                    Adaptador.SelectCommand.CommandType = System.Data.CommandType.Text;

                    Adaptador.Fill(Tabela);
                }

                Cache.Insert("TESTE", Tabela);
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        GridView1.DataSource = Cache["TESTE"];
        GridView1.DataBind();
    }
}