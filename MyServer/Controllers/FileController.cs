using MyServer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace MyServer.Controllers
{
    [RoutePrefix("api/file")]
    public class FileController : ApiController
    {

        // metoda za upload fajla sa parametrima]
        [HttpPost]
       // [Route("uploadfile/{login}/{password}/{tura}/{lokacijaID}/{tip}/{napomena}/{longg}/{lat}")]
       
        
        
        //public async Task<string> UploadFile1(string login, string password, string tura, string lokacijaID, string tip, string napomena, string longg, string lat)
        //public async Task<string> UploadFile1([FromUri]string login, string password, string tura, string lokacijaID, string tip, string napomena, string longg, string lat)


        public async Task<HttpResponseMessage> UploadFile1([FromUri] Slika slika5)               
        {
            string jsonOdgovor = "";
            SlikaModelJSON lm = new SlikaModelJSON();
            var ctx = HttpContext.Current;
            var root = ctx.Server.MapPath("~/Content/Uploads/");
            var provider = new MultipartFormDataStreamProvider(root);

         //   var request = HttpContext.Current.Request;
            var login1 = slika5.login; //request.Form["login"];
            var password1 = slika5.password;
            var tura1 = slika5.tura;
            var lokacijaID1 = slika5.lokacijaID;
            var tip1 = slika5.tip;
            var napomena1 = slika5.napomena;
            var longg1 = slika5.longg;
            var lat1 = slika5.lat;


            //var login1 = login;
            //string password1 = password;
            //string tura1 = tura;
            //string lokacijaIDa = lokacijaID;
            //string tip1 = tip;
            //string napomena1 = napomena;
            //string longg1 = longg;
            //string lat1 = lat;

            try
            {
                await Request.Content
                    .ReadAsMultipartAsync(provider);

                foreach (var file in provider.FileData)
                {
                    var name = file.Headers
                        .ContentDisposition
                        .FileName;

                    name = name.Trim('"');

                    var localFileName = file.LocalFileName;
                    var filePath = Path.Combine(root, name);

                    File.Move(localFileName, filePath);

                    // upis u bazu
                    //string Image = filePath; //+ localFileName.ToString();
                    //byte[] imageByte = System.IO.File.ReadAllBytes(Image);

                    //using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[1].ConnectionString))
                    //{ 

                    //    string sql = @"dbo.xxx";
                    //    SqlCommand kom = new SqlCommand(sql, connection);
                    //    kom.CommandType = System.Data.CommandType.StoredProcedure;                      
                       

                    //    kom.Parameters.AddWithValue("@Login", login1);
                    //    kom.Parameters.AddWithValue("@password", password1);
                    //    kom.Parameters.AddWithValue("@tura", tura1);
                    //    kom.Parameters.AddWithValue("@lokacijaID", lokacijaID1);
                    //    kom.Parameters.AddWithValue("@tip", tip1);
                    //    kom.Parameters.AddWithValue("@napomena", napomena1);
                    //    kom.Parameters.AddWithValue("@longg", longg1);
                    //    kom.Parameters.AddWithValue("@lat", lat1);
                    //    kom.Parameters.AddWithValue("@slika", imageByte);

                    //    foreach (SqlParameter Parameter in kom.Parameters)
                    //        if (Parameter.Value == null)
                    //            Parameter.Value = DBNull.Value;
                    //    if (!(connection.State == ConnectionState.Open))
                    //        connection.Open();
                    //    SqlDataReader vrati = kom.ExecuteReader(CommandBehavior.CloseConnection);

                   // }
                }
            }
            catch (Exception e)
            {
                lm.status = "Error";
                jsonOdgovor = JsonConvert.SerializeObject(lm, Formatting.None);

                return new HttpResponseMessage()
                {
                    Content = new StringContent(jsonOdgovor, System.Text.Encoding.UTF8, "application/json")
                };
            }

          


            lm.status = "OK";         
            jsonOdgovor = JsonConvert.SerializeObject(lm);

            return new HttpResponseMessage()
            {
                Content = new StringContent(jsonOdgovor, System.Text.Encoding.UTF8, "application/json")
            };
            //  return "File uploaded";
            //return 


        }
        // nova metoda za uplaod fajla


        [Route("uploadfile1")]
        [HttpPost]
        public async Task<string> UploadFile()
        {
            var ctx = HttpContext.Current;
            var root = ctx.Server.MapPath("~/Content/Uploads/");
            var provider = new MultipartFormDataStreamProvider(root);

            try
            {
                await Request.Content
                    .ReadAsMultipartAsync(provider);

                foreach(var file in provider.FileData)
                {
                    var name = file.Headers
                        .ContentDisposition
                        .FileName;

                    name = name.Trim('"');

                    var localFileName = file.LocalFileName;
                    var filePath = Path.Combine(root, name);

                    File.Move(localFileName, filePath);
                }
            }
            catch (Exception e)
            {
                return $"Error: {e.Message}"; 
            }

            return "File uploaded";
        }

        [Route("upload")]
        [HttpPost]
        public HttpResponseMessage Upload()
        {
            mydemo4Entities um = new mydemo4Entities();
            try
            {
                var request = HttpContext.Current.Request;
                var description = request.Form["description"];
                var cijena = request.Form["cijena"];
                var kolicina = request.Form["kolicina"];
                var photo = request.Files["photo"];
                photo.SaveAs(HttpContext.Current.Server.MapPath("~/Content/" +
                    "Uploads/" + photo.FileName));

                // uipis u bazu

                if (photo != null)
                {
                    Product uploadedImg = new Product();
                    int length = photo.ContentLength;
                    uploadedImg.ImageData = new byte[length]; //get imagedata  
                    photo.InputStream.Read(uploadedImg.ImageData, 0, length);
                    uploadedImg.Name = Path.GetFileName(photo.FileName);
                    uploadedImg.Price = Decimal.Parse(cijena.ToString());
                    uploadedImg.quantity = Int32.Parse(kolicina.ToString());
                    um.Products.Add(uploadedImg);
                    um.SaveChanges();

                }

                return new HttpResponseMessage(HttpStatusCode.OK);
               
              
            }

            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }
    }
}
