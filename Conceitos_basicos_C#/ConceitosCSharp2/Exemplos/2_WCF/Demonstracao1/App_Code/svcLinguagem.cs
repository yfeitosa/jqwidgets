using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Configuration;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "svcLinguagem" in code, svc and config file together.
public class svcLinguagem : IsvcLinguagem
{
    public List<Linguagem> Listar()
    {
        List<Linguagem> lstRetorno = new List<Linguagem>();

        //Criei uma conexão com o SQL Server (BASE DE DADOS)
        using (SqlConnection Conexao =
            new SqlConnection(
         WebConfigurationManager.ConnectionStrings["CURSO"].ConnectionString))
        {
            //Abri a conexão
            Conexao.Open();

            //Declarei um comando (INSTRUÇÃO TSQL QUE VOU EXECUTAR)
            using (SqlCommand Comando = new SqlCommand())
            {
                //Vinculei a conexão
                Comando.Connection = Conexao;

                //Falei que vou executar um comando do tipo TSQL
                Comando.CommandType = CommandType.Text;

                //Informei o comando que vou executar
                Comando.CommandText = "SELECT * FROM TB_LINGUAGEM";

                //Armazenei o retorno da consulta (SELECT)
                using (SqlDataReader Leitor = Comando.ExecuteReader())
                {
                    //Percorri registro por registro que foi retornado
                    while (Leitor.Read())
                    {
                        //Armazenei cada registro retornado na classe(Linguagem)
                        Linguagem Registro = new Linguagem();
                        Registro.Codigo = Convert.ToInt32(Leitor["ID_LINGUAGEM"]);
                        Registro.Nome = Leitor["NM_LINGUAGEM"].ToString();

                        //Adicionei o registro retornado na coleção de registros
                        lstRetorno.Add(Registro);
                    }
                }
            }
        }

        //Retornei a coleção de registros
        return lstRetorno;
    }

    public void Inserir(Linguagem pLinguagem)
    {
        //configurei a conexao
        using (SqlConnection Conexao =
            new SqlConnection(
          WebConfigurationManager.ConnectionStrings["CURSO"].ConnectionString))
        {
            Conexao.Open();

            using (SqlCommand Comando = new SqlCommand())
            {
                Comando.Connection = Conexao;
                Comando.CommandType = CommandType.Text;
                Comando.CommandText =
                "INSERT INTO TB_LINGUAGEM(NM_LINGUAGEM) VALUES('" + pLinguagem.Nome + "')";

                Comando.ExecuteNonQuery();
            }
        }
    }
}
