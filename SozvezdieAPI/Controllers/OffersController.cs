using Newtonsoft.Json;
using SozvezdieAPI.Models;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace SozvezdieAPI.Controllers
{
    public class OffersController : ApiController
    {
        public string ReadOffersData()
        {
            var json = File.ReadAllText(HttpContext.Current.Server.MapPath(@"~/App_Data/demo_offers.json"));
            return json;
        }

        [HttpGet]
        [ActionName("GetAll")]
        public List<Offer> GetAll()
        {
            var json = ReadOffersData();
            var offersList = JsonConvert.DeserializeObject<List<Offer>>(json);
            return offersList;
        }

        [HttpGet]
        [ActionName("GetData")]
        public OfferData GetData(int id = -1)
        {
            if (id == -1)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            var json = ReadOffersData();
            var offersList = JsonConvert.DeserializeObject<List<OfferData>>(json);
            for(var i = 0; i < offersList.Count; i++)
            {
                if(offersList[i].Id == id)
                {
                    return offersList[i];
                }
            }
            throw new HttpResponseException(HttpStatusCode.NotFound);
        }
    }
}
