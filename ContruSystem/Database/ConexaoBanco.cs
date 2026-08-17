using System;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace ContruSystem
{
    public static class ConexaoBanco
    {
        private static readonly string strConexao =
            ConfigurationManager.ConnectionStrings["SistemaVendas"].ConnectionString;

        public static MySqlConnection CriarConexao()
        {
            return new MySqlConnection(strConexao);
        }
    }
}