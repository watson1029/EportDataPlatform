using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace EportDataPlatform.AliOneTouch.DataCapture.Controllers
{
    //[Produces("application/json")]
    [Route("api/Ali/Entry")]
    public class EntryController : Controller
    {
        [HttpGet]
        [Route("GetStatus/{EntryId}")]
        public async Task<Entity.Interface.AliApi.GetStatus_Response> GetStatus(string EntryId)
        {
            HttpClient client = new HttpClient();
            var res = await client.GetStringAsync($"{Watson.Base.DotNetCore.ConfigurationHelper.Configuration.GetSection("ProjectSettings")["servicePath"]}/{EntryId}");
            var resObj = JObject.Parse(res);
            if (resObj.Value<int>("code") == 200)
            {
                if (resObj["data"][EntryId] != null)
                {
                    return new Entity.Interface.AliApi.GetStatus_Response()
                    {
                        StatusText = resObj["data"][EntryId].Value<string>("status"),
                        DeclareDate = resObj["data"][EntryId].Value<DateTime>("declare_date")
                    };
                }
                else
                    return null;
            }
            else
                return null;
        }
    }
}