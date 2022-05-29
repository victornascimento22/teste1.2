using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
namespace WebApplication3.Models
{
    public class DadosMunicipio
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("nome")]
        public string Nome;

        [JsonProperty("municipio")]
        public Municipio Municipio;
    }
}
