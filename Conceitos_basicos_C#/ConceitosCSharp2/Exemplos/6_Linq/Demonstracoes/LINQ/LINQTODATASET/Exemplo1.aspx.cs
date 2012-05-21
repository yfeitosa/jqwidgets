using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class LINQ_LINQTODATASET_Exemplo1 : System.Web.UI.Page
{
    DataTable Tabela = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        using (
        SqlConnection Conexao =
        new SqlConnection(WebConfigurationManager.ConnectionStrings["BASE_CURSO"].ConnectionString))
        {
            Conexao.Open();

            using (SqlCommand Comando = new SqlCommand())
            {
                Comando.Connection = Conexao;
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = "SELECT * FROM TB_LINGUAGEM";

                using (SqlDataAdapter Adaptador = new SqlDataAdapter())
                {
                    Adaptador.SelectCommand = Comando;
                    Adaptador.Fill(Tabela);
                }
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        GridView1.DataSource = from Registro in Tabela.AsEnumerable()
                               where Registro.Field<Int32>("ID_LINGUAGEM") >= 5
                               select new
                               {
                                   CodigoDaLinguagem = 
                                   Registro.Field<Int32>("ID_LINGUAGEM"),
                                   NomeDaLinguagem = 
                                   Registro.Field<String>("NM_LINGUAGEM")
                               };

        GridView1.DataBind();
    }
}