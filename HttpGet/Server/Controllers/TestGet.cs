using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpGet.Server.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class TestGet : ControllerBase
	{
		[HttpGet]
		public IEnumerable<string> OvoJeGet()
		{
			List<string> lst = new List<string>();
			lst.Add("Jen");
			lst.Add("Dva");
			lst.Add("Tri");

			return lst;
		}
	}
}
