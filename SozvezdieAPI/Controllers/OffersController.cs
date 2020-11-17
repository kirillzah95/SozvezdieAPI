using Newtonsoft.Json;
using SozvezdieAPI.Models;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Http;

namespace SozvezdieAPI.Controllers
{
    public class OffersController : ApiController
    {
        [HttpGet]
        [ActionName("GetAll")]
        public List<Offer> GetAll()
        {
            var json = File.ReadAllText(HttpContext.Current.Server.MapPath(@"~/App_Data/demo_offers.json"));
            var offersList = JsonConvert.DeserializeObject<List<Offer>>(json);
            return offersList;
        }

        [HttpGet]
        [ActionName("GetData")]
        public IHttpActionResult GetData(int id = -1)
        {
            var json = File.ReadAllText(HttpContext.Current.Server.MapPath(@"~/App_Data/demo_offers.json"));
            return Ok(json);
        }
    }
}
