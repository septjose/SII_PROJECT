using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SiiProyect.Modelos;

namespace SiiProyect.WebServices
{
    class WSLogin
    {

        public async Task<List<String>> Conexion(String user, String pwd)
        {
            HttpClient httpClient = new HttpClient();
            //192.168.100.56:5000
            httpClient.BaseAddress = new Uri("http://192.168.100.56:5000");

            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //var authData = string.Format("{0}:{1}", "root", "root");
            //var authHeaderValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(authData));
            //ttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeaderValue);
            //ws/sii/login/
            var respuesta = await httpClient.GetAsync("/ws/sii/login/" + user + "/" + pwd);
            var objJSON = respuesta.Content.ReadAsStringAsync().Result;
           
            //Login objLogin = new Login();
            Login objLogin = new Login();

            if (objJSON != null)
            {
                objLogin = JsonConvert.DeserializeObject<Login>(objJSON);
            }
            List<String> list = new List<string>();
            list.Add(objLogin.nocont);
            list.Add(objLogin.token);
            Settings.Settings.token = objLogin.token;
            return list;
        }
    }
}
