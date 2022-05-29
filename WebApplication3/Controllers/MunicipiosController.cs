using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MunicipiosController : ControllerBase
    {
        [HttpGet]        
        public async Task<IActionResult> GetDadosAsync() 
        {
            string url = "https://servicodados.ibge.gov.br/api/v1/localidades/estados/33/distritos";
            //http client para enviar um request
            HttpClient httpClient = new HttpClient();

            try
            {
                var httpResponseMessage = await httpClient.GetAsync(url);
                string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();

                var ibge = JsonConvert.DeserializeObject<int>(jsonResponse);

                return new JsonResult(new { jsonResponse });
            }

            catch (Exception)
            {
                return new JsonResult(new { erro = "Ocorreu um erro ao fazer a requsição." });
            }
        }
    }
}
