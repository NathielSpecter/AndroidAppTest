using AndroidAppTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AndroidAppTest
{
    public class WebApiBase
    {
        private string Url = "http://192.168.182.10:3000/";
        public async Task<HttpResponseMessage> POST(Estudantes obj)
        {
            var client = new HttpClient();
            Uri url = new Uri(string.Concat(Url,"api/users/Cadastro"));
            var response = client.PostAsJsonAsync(url, obj);
            return await response;
        }

        public async Task<HttpResponseMessage> GET()
        {
            var client = new HttpClient();
            Uri url = new Uri(string.Concat(Url,"api/users/Listar"));
            var response = client.GetAsync(url);
            return await response;
        }
    }
}
