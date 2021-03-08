using E_Contas_v1_API.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace E_Contas_v1_API.Repository
{
    public class repository
    {
        public DataTable ConsultarCliente(int id)
        {
            DataTable results = new DataTable();

            using (SqlConnection connection = new SqlConnection(@"Data Source=TD50001424\SQLEXPRESS;Initial Catalog=Db_Contas;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                //Define a t-sql query string that has a parameter form id
                string sql = $"select ClienteId, Nome, Morada, Telefone, Email from dbo.CLientes where ClienteId={id}";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();

                    //run query by Execuetereader
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        results.Load(dataReader);

                        dataReader.Close();
                    }
                    connection.Close();


                    return results;

                }

            }

        }

        public void Inserir(ClienteModel model)
        {
            const string sql = "IncluirCliente";
            using (SqlConnection connection = new SqlConnection(
                @"Data Source=TD50001424\SQLEXPRESS;Initial Catalog=Db_Contas;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter(@"Nome", System.Data.SqlDbType.NVarChar, 80));
                command.Parameters[@"Nome"].Value = model.Nome;

                
                command.Parameters.Add(new SqlParameter(@"Morada", System.Data.SqlDbType.NVarChar, 80));
                command.Parameters[@"Morada"].Value = model.Morada;

                command.Parameters.Add(new SqlParameter(@"Telefone", System.Data.SqlDbType.Int));
                command.Parameters[@"Telefone"].Value = model.Telefone;

                command.Parameters.Add(new SqlParameter(@"Email", System.Data.SqlDbType.NVarChar, 80));
                command.Parameters[@"Email"].Value = model.Email;

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

    }
}
