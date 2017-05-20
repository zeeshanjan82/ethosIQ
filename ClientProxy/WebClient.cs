using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;

namespace ClientProxy
{
    public class WebClient
    {

        public XmlDocument StringToXml(string str)
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(str);
            return xml;
        }

        async public Task<object> GetRequest(string Url)
        {
            object result = new object();

            HttpResponseMessage response;

            using (System.Net.Http.HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(Url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                response = await client.GetAsync(Url).ConfigureAwait(false); 

                // Check that response was successful or throw exception ConfigureAwait(false); 
                response.EnsureSuccessStatusCode();

                result = await response.Content.ReadAsAsync(typeof(object));

                return result;

            }

        }

    }
}
