using cerkitMaps.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Hosting;
using System.Web.Http;

namespace cerkitMaps.Controllers
{
    public class MapDataController : ApiController
    {
		public MapShapeViewModel Get()
		{
			return Get(1); // default to Alabama
		}

		public MapShapeViewModel Get(int id)
		{
			string mapShape = Convert.ToBase64String(
				File.ReadAllBytes(
					HostingEnvironment.MapPath(
						string.Format("~/Assets/tl_2010_{0:00}_county10.shp", id)
					)
				)
			);

			string mapDbf = Convert.ToBase64String(
				File.ReadAllBytes(
					HostingEnvironment.MapPath(
						string.Format("~/Assets/tl_2010_{0:00}_county10.dbf", id)
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

        // POST: api/MapData
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/MapData/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/MapData/5
        public void Delete(int id)
        {
        }
    }
}
