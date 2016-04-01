using cerkitMaps.Models;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Hosting;
using System.Web.Http;

namespace cerkitMaps.Controllers.Api
{
    public class MapController : ApiController
    {
        [HttpGet]
        public MapShapeViewModel StateShape(int? state = null)
        {
            state = state ?? 1; // default to Alabama

            string mapShape = Convert.ToBase64String(
                File.ReadAllBytes(
                    HostingEnvironment.MapPath(
                        string.Format("~/Assets/tl_2010_{0:00}_county10.shp", state)
                    )
                )
            );

            string mapDbf = Convert.ToBase64String(
                File.ReadAllBytes(
                    HostingEnvironment.MapPath(
                        string.Format("~/Assets/tl_2010_{0:00}_county10.dbf", state)
                    )
                )
            );

            var vm = new MapShapeViewModel()
            {
                Shape = mapShape,
                Dbf = mapDbf
            };

            return vm;
        }
    }
}
