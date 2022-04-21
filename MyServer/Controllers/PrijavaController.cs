using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MyServer.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Newtonsoft.Json;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace MyServer.Controllers
{
    [RoutePrefix("api/prijava")]
    public class PrijavaController : ApiController
    {

        EuroplakatEntities2 modell = new EuroplakatEntities2();

        [Route("prijavi")]
        [HttpGet]
        //public HttpResponseMessage PrijaviSe()
        public HttpResponseMessage PrijaviSe([FromUri] PristupModel pmodel)
        
        {
            string jsonOdgovor = "";

            //var request = HttpContext.Current.Request;
            //var username = request.Form["username"];
            //var password = request.Form["password"];
            //var request = HttpContext.Current.Request;
            var username = pmodel.username;
            var password = pmodel.password;
            var usermanager = new Microsoft.AspNet.Identity.UserManager<IdentityUser>(new UserStore<IdentityUser>(new IdentityDbContext(ConfigurationManager.ConnectionStrings[1].ConnectionString)));

            var u = usermanager.Find(username, password) != null; //("lzaciragic@gmail.com", "123123") != null;

            LoginModelJSON lm = new LoginModelJSON();

            if (u == true)
            {
                lm.status = "OK";
                lm.method = "zadnjaInacica";

                jsonOdgovor = JsonConvert.SerializeObject(lm);

                return new HttpResponseMessage()
                {
                    Content = new StringContent(jsonOdgovor, System.Text.Encoding.UTF8, "application/json")
                };
            }
            else
            {
                lm.status = "Error";
                lm.method = "zadnjaInacica";
                jsonOdgovor = JsonConvert.SerializeObject(lm, Formatting.None);

                return new HttpResponseMessage()
                {
                    Content = new StringContent(jsonOdgovor, System.Text.Encoding.UTF8, "application/json")
                };
            }
        }

        //[Route("detours")]
        //[HttpGet]
        //public HttpResponseMessage Detours()
        //     //public IEnumerable<geTureJSONSabiha_Result> Detours()
        //{
        //    var request = HttpContext.Current.Request;
        //    var username = request.Form["username"];
        //    var password = request.Form["password"];
        //    var usermanager = new Microsoft.AspNet.Identity.UserManager<IdentityUser>(new UserStore<IdentityUser>(new IdentityDbContext(ConfigurationManager.ConnectionStrings[1].ConnectionString)));

        //    var u = usermanager.Find(username, password); //("lzaciragic@gmail.com", "123123") != null;
        //    String idZaposlenog = u.Id.ToString();

          
        //    var tura =  modell.geTureJSONSabiha(idZaposlenog).ToList();
          
        //    return Request.CreateResponse(HttpStatusCode.OK, tura);
        //    //return tura;
        //}

        [Route("detours1")]
        [HttpGet]
        public HttpResponseMessage Detours1([FromUri] PristupModel pmodel)
        {
            SqlDataReader sdr =  null;
          
            TuraSedmicaZapJSON tz = null;// new TuraSedmicaZap();
            List<TuraSedmicaZapJSON> listaTura = new List<TuraSedmicaZapJSON>();

            var jsonResult = new StringBuilder();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString))
            {
                //var request = HttpContext.Current.Request;
                var username = pmodel.username;// request.Form["username"];
                var password = pmodel.password;//request.Form["password"];
                var usermanager = new Microsoft.AspNet.Identity.UserManager<IdentityUser>(new UserStore<IdentityUser>(new IdentityDbContext(ConfigurationManager.ConnectionStrings[1].ConnectionString)));

                var u = usermanager.Find(username, password); //("lzaciragic@gmail.com", "123123") != null;
                String idZaposlenog = u.Id.ToString();
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("osn.geTureJSONSabiha", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@zaposleni", idZaposlenog));
                    command.CommandTimeout = 5;

                    sdr = command.ExecuteReader();                   
                        while (sdr.Read())
                        {
                        tz = new TuraSedmicaZapJSON();
                       
                        int tura = Int32.Parse(sdr["tura"].ToString());
                        String datumId = sdr["datumId"].ToString();
                        int slikaCount = Int32.Parse(sdr["slikaCount"].ToString());
                        //tz.status = status;
                        //tz.method = method;
                        tz.slikaCount = slikaCount;
                        tz.datumId = datumId;
                        tz.tura = tura;
                        listaTura.Add(tz);                     
                   }                                                   
                }
                catch (Exception)
                {
                    /*Handle error*/
                }
              
            }

            var tureJSON = JsonConvert.SerializeObject(listaTura);
            StringBuilder konacanJSON = new StringBuilder();

            konacanJSON.Append(@"{ ""status"":""ok"" ," + Environment.NewLine);
            konacanJSON.Append(@" ""method"":""zadnji""," + Environment.NewLine);
           
            konacanJSON.Append(@"""array"":");

            String stureJSON = tureJSON.ToString();
            konacanJSON.Append(stureJSON);
            konacanJSON.Append(@"}");
            return new HttpResponseMessage()
            {
                Content = new StringContent(konacanJSON.ToString(), System.Text.Encoding.UTF8, "application/json")
            };
    
            //    return Request.CreateResponse(HttpStatusCode.OK, sdr);
        }

        [Route("detour")]
        [HttpGet]
        public HttpResponseMessage Detour([FromUri] PristupModel pmodel)
        {
            SqlDataReader sdr = null;

            TureModelJSON t = null;// new TuraSedmicaZap();
            List<TureModelJSON> listaTura = new List<TureModelJSON>();

            var jsonResult = new StringBuilder();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString))
            {
                // var request = HttpContext.Current.Request;
                var username = pmodel.username;//request.Form["username"];
                var password = pmodel.password;//request.Form["password"];
                var usermanager = new Microsoft.AspNet.Identity.UserManager<IdentityUser>(new UserStore<IdentityUser>(new IdentityDbContext(ConfigurationManager.ConnectionStrings[1].ConnectionString)));

                var u = usermanager.Find(username, password); //("lzaciragic@gmail.com", "123123") != null;
                String idZaposlenog = u.Id.ToString();
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("osn.getNalogStavlaJSONSabiha", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@zaposleni", idZaposlenog));
                    command.CommandTimeout = 5;

                    sdr = command.ExecuteReader();
                    while (sdr.Read())
                    {
                        t = new TureModelJSON();

                        // DODATI PRAVE PODATKE IZ NOVE PROCEDURE
                        string id = sdr["plakatId"].ToString();
                        string pbr = sdr["posta"].ToString();
                        int rb = Int32.Parse(sdr["redniBroj"].ToString());
                        string format = sdr["Format"].ToString();
                        string ulica = sdr["ulica"].ToString();
                        string akcija = sdr["akcija"].ToString();
                        String tura = sdr["tura"].ToString();
                        String datumId = sdr["datum"].ToString();
                        String napomena = sdr["Napomena"].ToString();
                        //tz.status = status;
                        //tz.method = method;
                        t.id = Int32.Parse(id);
                        t.pbr = pbr; 
                        t.akcija = akcija;
                        t.rb = rb;
                        t.format = format;
                        t.ulica = ulica;
                        t.tura = tura;
                        t.datum = datumId;
                        t.napomena = napomena;                     
                        listaTura.Add(t);
                    }
                }
                catch (Exception)
                {
                    /*Handle error*/
                }
            }

            var tureJSON = JsonConvert.SerializeObject(listaTura);
            StringBuilder konacanJSON = new StringBuilder();

            konacanJSON.Append(@"{ ""status"":""ok"" ," + Environment.NewLine);
            konacanJSON.Append(@" ""method"":""lokacija""," + Environment.NewLine);

            konacanJSON.Append(@"""array"":");

            String stureJSON = tureJSON.ToString();
            konacanJSON.Append(stureJSON);
            konacanJSON.Append(@"}");
            return new HttpResponseMessage()
            {
                Content = new StringContent(konacanJSON.ToString(), System.Text.Encoding.UTF8, "application/json")
            };

            //    return Request.CreateResponse(HttpStatusCode.OK, sdr);
        }

        //private String sqlDatoToJson(SqlDataReader dataReader)
        //{
        //    var dataTable = new DataTable();
        //    dataTable.Load(dataReader);
        //    string JSONString = string.Empty;
        //    JSONString = JsonConvert.SerializeObject(dataTable);
        //    return JSONString;
        //}




        //[HttpGet]
        //public String LogujSe()
        //{

        //    try
        //    {
        //        var request = HttpContext.Current.Request;
        //        var username = request.Form["userName"];
        //        var password = request.Form["passWord"];

        //        var usermanager = new Microsoft.AspNet.Identity.UserManager<IdentityUser>(new UserStore<IdentityUser>(new IdentityDbContext(ConfigurationManager.ConnectionStrings[1].ConnectionString)));
        //        //return 
        //        var u = usermanager.Find(username, password);// != null; //("lzaciragic@gmail.com", "123123") != null;

        //        //return true;
        //        if (u == null)
        //        {
        //            return "";  // new HttpResponseMessage(HttpStatusCode.OK);//u
        //        }
        //        else
        //        {

        //            return u.Id.ToString(); // new HttpResponseMessage(HttpStatusCode.BadRequest);//u

        //        }
        //    }
        //    catch
        //    {
        //        return "";// new HttpResponseMessage(HttpStatusCode.BadRequest);//u
        //    }
        //}
    }   
}

