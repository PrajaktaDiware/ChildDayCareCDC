using Layer1.ENTITIES;
using Layer1.SERVICES.Abstract;
using Layer1.SERVICES.Services;
using Layer1.VIEWMODEL;
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
    public class HomeController : ApiController
    {

        private readonly IStudentService _iStudentService;

        public HomeController(IStudentService iStudentService)
        {
            _iStudentService = iStudentService;
        }


        // GET: api/Home
        [HttpGet]
        [Route("api/Home/")]
        public IHttpActionResult GetAllStudent()
        {
            var a = _iStudentService.GetAllStudentsWithoutParam();

            return Ok(a);
        }


        // GET: api/Home/5
        [HttpGet]
        [Route("api/Home/{id}")]
        public IHttpActionResult GetById(long id)
        {
            var a = _iStudentService.GetStudentById(id);
            return Ok(a);
        }




        // POST: api/Home
        [Route("api/Home/")]
        [HttpPost]
        public IHttpActionResult Post([FromBody] CStudentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

           var a=_iStudentService.AddStudent(model);

            return Ok(a);
        }
    }
}
