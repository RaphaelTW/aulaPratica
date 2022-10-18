using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using Login.Modelo;

namespace Login.Controle
{
    public class ctlLogin
    {
        //Declarando o método ValidaLogin como Boolean o retorno será tratado e retornado para a tela
        public Boolean ValidaLoginSQL(mdlLogin _mdlLogin)
        {
            //String de conexão que será utilizada 
            
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\aluno\Documents\Cadastro.accdb";

           //Variável Query será alimentada com a minha instrução SQL;
           //Select/Insert/Update/Delete

            string query = "INSERT INTO TB_Usuario (Usuario, Senha)" + "VALUES ('" + _mdlLogin.usuario + "' , '" + _mdlLogin.senha + "')";

            //Efetua instância do objeto reader para ler instrução
            OleDbDataReader reader = null;
            //Efetua instância do objeto conn para efetuar conexão
            OleDbConnection conn = null;

            try
            {
                
                //instância da conexão                
                conn = new OleDbConnection(connectionString);

                
                //verifica se conexão está fechada, se tiver abre.                
                if (conn.State == ConnectionState.Closed)
                {
                    
                    //abre conexão                    
                    conn.Open();
                }
                
                // Criação do objeto comando, que recebe a query que será utilizada na operação e a conexão com o banco.
                
                OleDbCommand cmd = new OleDbCommand(query, conn);
                
                // Executa comando
                reader = cmd.ExecuteReader();
                
                //interage com a tabela retornada
                //Valida se o registro foi incluído com sucesso
                while (reader.Read())
                {
                    return true;
                }
                
                // Fecha conexão com o banco                
                conn.Close();
            }
            catch (Exception ex)
            {
                //captura erro da instrução executada
                throw ex;
            }
            finally
            {                
                // Garante que a conexão será fechada mesmo que ocorra algum erro.                               
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return true;
        }
    }
}
