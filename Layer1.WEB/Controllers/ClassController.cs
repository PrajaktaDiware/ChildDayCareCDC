using Layer1.SERVICES.Abstract;
using Layer1.VIEWMODEL.ClassVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Layer1.WEB.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ClassController : ApiController
    {
        private readonly IClassService _iClassprofileService;


        public ClassController(IClassService iClassprofileService)
        {
            _iClassprofileService = iClassprofileService;
        }

        // GET: api/Home
        [HttpGet]
        [Route("api/Class/")]
        public IHttpActionResult GetAllClasses()
        {
            var a = _iClassprofileService.GetAllClassWithoutParam();

            return Ok(a);
        }

        // POST: api/Home
        [Route("api/class/")]
        [HttpPost]
        public IHttpActionResult Post([FromBody] AddClassViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var a = _iClassprofileService.AddClass(model);

            return Ok(a);
        }

        [Route("api/Class/{id}")]
        [HttpDelete]
        public IHttpActionResult DeleteClassById(long Id)
        {
            var a = _iClassprofileService.DeleteClass(Id);

            return Ok(a);
        }
    }
}
