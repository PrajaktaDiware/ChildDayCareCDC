using Layer1.SERVICES.Abstract;
using Layer1.VIEWMODEL.ClassVM;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Layer1.WEB.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]

     /// <summary>
     /// </summary>
     /// <seealso cref="System.Web.Http.ApiController" />
    public class ClassController : ApiController
    {
        private readonly IClassService _iClassprofileService;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassController" /> class.
        /// </summary>
        /// <param name="iClassprofileService"></param>
        public ClassController(IClassService iClassprofileService)
        {
            _iClassprofileService = iClassprofileService;
        }

        /// <summary>
        /// Get all the Classes 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/Class/")]
        public IHttpActionResult GetAllClasses()
        {
            var a = _iClassprofileService.GetAllClassWithoutParam();

            return Ok(a);
        }

        /// <summary>
        /// Add the Class
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Delete the Class by Identifier
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [Route("api/Class/{id}")]
        [HttpDelete]
        public IHttpActionResult DeleteClassById(long Id)
        {
            var a = _iClassprofileService.DeleteClass(Id);
            
            return Ok(a);
        }
    }
}
