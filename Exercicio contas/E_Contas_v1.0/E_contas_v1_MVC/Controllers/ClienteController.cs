using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using E_contas_v1_MVC.Models;
using E_contas_v1_MVC.Service;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace E_contas_v1_MVC.Controllers
{
    public class ClienteController : Controller
    {
        /* private readonly ICustomerService _clienteService;

         public ClienteController(ICustomerService clienteService)
         {
             _clienteService = clienteService;
         }



         //Novo metodo para poder aceder para a Api
         [HttpGet]
         public async Task<IActionResult> Alterar (int Id)
         {


             var httpClient = _clienteService.GetClient();

             var json = JsonConvert.SerializeObject(Id);


             HttpResponseMessage response = await httpClient.GetAsync("api/Cliente/id").ConfigureAwait(false);





             if (response.IsSuccessStatusCode)
             {
                 return View();
             }
             else
             {
                return BadRequest();
             }

         }

         [HttpGet]
         public IActionResult Register()
         {
             return View();
         }

         //Novo metodo para poder aceder para a Api
         [HttpPost]
         public async Task<IActionResult> Register([FromForm]ClienteModel model)
         {
             var httpClient = _clienteService.GetClient();

             var json = JsonConvert.SerializeObject(model);


             var response = await httpClient.PostAsync($"api/Cliente", new StringContent(json, System.Text.Encoding.Unicode, "application/json")).ConfigureAwait(false);

             if (response.IsSuccessStatusCode)
             {
                 return View();
             }
             else
             {
                 return BadRequest();
             }
         }*/

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register([FromForm]ClienteModel model)
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

            return View(model);
        }



        [HttpGet]
         public IActionResult Alterar (int Id)
         {

             DataTable results = new DataTable();

             using (SqlConnection connection = new SqlConnection(@"Data Source=TD50001424\SQLEXPRESS;Initial Catalog=Db_Contas;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
             {
                 //Define a t-sql query string that has a parameter form id
                 string sql = "select ClienteId, Nome,  Morada, Telefone, Email from dbo.Clientes";

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

                    var model = new ClienteModel
                    {
                         ClienteId = int.Parse( results.Rows[0]["ClienteId"].ToString()),
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
        }
    }
}