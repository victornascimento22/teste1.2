using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class RegiaoImediata
    {
        [JsonProperty("id")]
        public int Id;

        [JsonProperty("nome")]
        public string Nome;

        [JsonProperty("regiao-intermediaria")]
        public RegiaoIntermediaria RegiaoIntermediaria;
    }
}
