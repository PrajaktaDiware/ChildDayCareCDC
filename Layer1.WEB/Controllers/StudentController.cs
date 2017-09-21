using Layer1.ENTITIES.Model;
using Layer1.SERVICES.Abstract;
using Layer1.VIEWMODEL.StudentVM;
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
    public class StudentController : ApiController
    {
        private readonly IAddStudentService _iAddStudentService;

        public StudentController(IAddStudentService iAddStudentService)
        {
            _iAddStudentService = iAddStudentService;
        }

        /// <summary>
        /// Get all the student data from databse
        /// </summary>
        /// <returns></returns>

        // GET: api/Home
        [HttpGet]
        [Route("api/Student/")]
        public IHttpActionResult GetAllStudent()
        {
            var a = _iAddStudentService.GetAllStudentsWithoutParam();

            return Ok(a);
        }

        /// <summary>
        /// Get the particular student data
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // GET: api/Home/5
        [HttpGet]
        [Route("api/Student/{id}")]
        public IHttpActionResult GetById(long id)
        {
            var a = _iAddStudentService.GetStudentById(id);
            return Ok(a);
        }

        /// <summary>
        /// Save the student data into database
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>

        //[Authorize]
        // POST: api/Home
        [Route("api/Student/")]
        [HttpPost]
        public IHttpActionResult Post([FromBody] AddStudentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var a = _iAddStudentService.AddStudent(model);

            return Ok(a);
        }

        /// <summary>
        /// update the student data and save it into database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("api/Student/{id}")]
        [HttpPut]
        public IHttpActionResult Put(long id, [FromBody] AddStudentViewModel model)
        {
            try
            {

                if (!ModelState.IsValid)
                    return BadRequest();
                //var a= _iAddStudentService.UpdateStudent(id, model);
                //return Ok(a);
                _iAddStudentService.UpdateStudent(id, model);
                return Created(new Uri(Request.RequestUri + "/" + model.Id), model);
            }
            catch
            {
                throw;
            }
        }

        
        [HttpDelete]
        [Route("api/Student/{id}")]
        public IHttpActionResult DeleteStudentById(long Id)
        {
            var a = _iAddStudentService.DeleteStudent(Id);

            return Ok(1);
        }
    }
}

