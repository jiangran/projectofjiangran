using apiPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiPlatform.Services
{
    public class LatitudeService
    {
        public LatitudeService() { }
        public int  addData(LatitudeData item){
            IList<LatitudeData> list;
            if (HttpRuntime.Cache.Get("latitude")!=null)
            {
                list = (List<LatitudeData>)HttpRuntime.Cache.Get("latitude");
                list.Add(item);
                HttpRuntime.Cache.Insert("latitude", list);
            }else{
                list=new List<LatitudeData>();
                list.Add(item);
                HttpRuntime.Cache.Insert("latitude", list);
            }
            return 1;

        }
    }
}