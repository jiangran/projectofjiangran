using apiPlatform.Models;
using apiPlatform.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace apiPlatform.api
{
    public class DataRespController : ApiController
    {
        [HttpPost]
        public int addData([FromBody]LatitudeData item) {
            LatitudeService ls = new LatitudeService();
            return ls.addData(item);
        }
        [HttpGet]
        public IList<LatitudeData> getData() {
            return (List<LatitudeData>)HttpRuntime.Cache.Get("latitude");
        }
    }
}
