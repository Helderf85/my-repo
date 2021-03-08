using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace E_contas_v1_MVC.Models
{
    public class ContasReceberController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Register([FromForm]ContasReceberModel model)
        {
            const string sql = "RegistarReceber";
            using (SqlConnection connection = new SqlConnection(
                @"Data Source=TD50001424\SQLEXPRESS;Initial Catalog=Db_Contas;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))

                
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter(@"DataVencimento", System.Data.SqlDbType.Date));
                command.Parameters[@"DataVencimento"].Value = model.DataVencimento;

                command.Parameters.Add(new SqlParameter(@"ClienteId", System.Data.SqlDbType.Int));
                command.Parameters[@"ClienteId"].Value = model.ClienteId;

                command.Parameters.Add(new SqlParameter(@"Valor", System.Data.SqlDbType.Money));
                command.Parameters[@"Valor"].Value = model.Valor;

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Alterar(int Id)
        {

            DataTable results = new DataTable();

            using (SqlConnection connection = new SqlConnection(@"Data Source=TD50001424\SQLEXPRESS;Initial Catalog=Db_Contas;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                //Define a t-sql query string that has a parameter form id
                string sql = "select FaturaId, DataVencimento, DataPgamento, ClienteId, Valor, ValorPago from dbo.ContasReceber";

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

                    var model = new ContasReceberModel
                    {
                        FaturaId = int.Parse(results.Rows[0]["FaturaId"].ToString()),
                        //DataVencimento = DateTime.Parse(results.Rows[0]["DataVencimento"].ToString()),
                        //DataPagamento = DateTime.Parse(results.Rows[0]["DataPgamento"].ToString()),
                        ClienteId = int.Parse(results.Rows[0]["ClienteId"].ToString()),
                        Valor = decimal.Parse( results.Rows[0]["Valor"].ToString()),
                        //ValorPago = decimal.Parse(results.Rows[0]["ValorPago"].ToString()),

                        
                    };

                    ContasReceberModel contas = new ContasReceberModel();
                    contas.CalcValorPago();

                    return View(model);
                }


            }
        }

       /* [HttpPost]
        public IActionResult Alterar([FromForm]ClienteModel model)
        {
            const string sql = "AlterarCliente";
            using (SqlConnection connection = new SqlConnection(
                @"Data Source=TD50001424\SQLEXPRESS;Initial Catalog=Db_Contas;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter(@"ClienteId", System.Data.SqlDbType.NVarChar, 80));
                command.Parameters[@"ClienteId"].Value = model.ClienteId;

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

            return View(model);
        }*/


    }
}