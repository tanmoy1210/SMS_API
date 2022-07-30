using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SMS.API.Services.StudentRegistration;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SMS.API.Controllers.StudentRegistration
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentRegistrationController : ControllerBase
    {
        protected readonly IStudentRegistration _IStudentRegistration;

        public StudentRegistrationController(IStudentRegistration studentRegistration)
        {
            _IStudentRegistration = studentRegistration;
        }



        // GET: api/<StudentRegistrationController>
        [HttpGet]
        public string Get()
        {
            var students = _IStudentRegistration.GetAllStudents();
            if(students != null)
            {
                return JsonConvert.SerializeObject(students);
            }
            return null; 

        }

        // GET api/<StudentRegistrationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentRegistrationController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentRegistrationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentRegistrationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
