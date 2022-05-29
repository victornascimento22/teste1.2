using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;


namespace WebApplication3.Models
{
    public class UF
    {
        [JsonProperty("id")]
        public int Id;

        [JsonProperty("sigla")]
        public string Sigla;

        [JsonProperty("nome")]
        public string Nome;

        [JsonProperty("regiao")]
        public Regiao Regiao;
    }
}
