using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using E_contas_v1_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_contas_v1_MVC.Controllers
{
    public class FornecedorController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register([FromForm]FornecedorModel model)
        {
            const string sql = "IncluirFornecedor";
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

            return View(model);
        }

        [HttpGet]
        public IActionResult Alterar (int id)
        {
            DataTable results = new DataTable();

            using (SqlConnection connection = new SqlConnection(@"Data Source=TD50001424\SQLEXPRESS;Initial Catalog=Db_Contas;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {

                var sql = "select FornecedorId, Nome,  Morada, Telefone, Email from dbo.Fornecedores";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();

                    using (SqlDataReader datareader = command.ExecuteReader())
                    {
                        results.Load(datareader);

                        datareader.Close();

                    }
                    connection.Close();

                    var model = new FornecedorModel
                    {
                        FornecedorId = int.Parse(results.Rows[0]["FornecedorId"].ToString()),
                        Nome = results.Rows[0]["Nome"].ToString(),

                        Morada = results.Rows[0]["Morada"].ToString(),
                        Telefone = int.Parse(results.Rows[0]["Telefone"].ToString()),
                        Email = results.Rows[0]["Email"].ToString()
                    };

                    return View(model);
                }
               
            }

        }

        [HttpPost]
        public IActionResult Alterar([FromForm]FornecedorModel model)
        {
            const string sql = "AlterarFornecedor";
            using (SqlConnection connection = new SqlConnection(
                @"Data Source=TD50001424\SQLEXPRESS;Initial Catalog=Db_Contas;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter(@"FornecedorId", System.Data.SqlDbType.NVarChar, 80));
                command.Parameters[@"FornecedorId"].Value = model.FornecedorId;

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
        }

    }
}