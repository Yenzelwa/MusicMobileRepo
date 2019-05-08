using MusicAppFinalBLL.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MusicAppFinalBLL.BLL.Library
{
    class Library
    {
        public  async Task<List<LibraryModel>> GetLibrary() {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            //var client = new RestClient(orionApiUrl);
            //var request = new RestRequest(Method.POST);
            var client = new RestClient("https://orionapi32.gameassists.co.uk/Orion/VanguardAdmin/SOAP2");
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "text/xml");
            var response =  client.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                if (response.StatusCode != HttpStatusCode.Accepted)
                {
                    throw new Exception(response.StatusDescription, new Exception(response.Content));
                }
            }

            var data = JsonConvert.DeserializeObject<List<LibraryModel>>(response.Content);
            return data;
        }
    }
}
