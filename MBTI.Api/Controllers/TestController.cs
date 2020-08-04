using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MBTI.Data;

namespace MBTI.Api.Controllers
{
    public class TestController : ApiController
    {
        // GET: api/PersonalityType
        public List<Test> GetTests()
        {
            return DataRepository.Test.GetAll();
        }

        // GET: api/PersonalityType/5
        [ResponseType(typeof(Test))]
        public IHttpActionResult GetTest(int testId)
        {
            Test test = DataRepository.Test.Get(testId);

            if (test == null)
                return NotFound();

            return Ok(test);
        }

        // PUT: api/PersonalityType/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTest(int testId, Test test)
        {
            try
            {
                DataRepository.Test.Update(test);
            }
            catch (Exception ex)
            {
                //string message = ExceptionHelper.GetMessageRecursively(ex);
                string message = ex.GetMessageRecursively();
                return BadRequest(message);
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/PersonalityType
        [ResponseType(typeof(Test))]
        public IHttpActionResult PostTest(Test test)
        {
            try
            {
                DataRepository.Test.Insert(test);
            }
            catch (Exception ex)
            {
                //string message = ExceptionHelper.GetMessageRecursively(ex);
                string message = ex.GetMessageRecursively();
                return BadRequest(message);
            }
            return CreatedAtRoute("DefaultApi", new { id = test.TestId }, test);

        }

        // DELETE: api/PersonalityType/5
        [ResponseType(typeof(Test))]
        public IHttpActionResult DeleteTest(int testId)
        {
            Test test = DataRepository.Test.Get(testId);

            if (test == null)
                return NotFound();
            try
            {
                DataRepository.Test.Delete(test);
            }
            catch (Exception ex)
            {
                //string message = ExceptionHelper.GetMessageRecursively(ex);
                string message = ex.GetMessageRecursively();
                return BadRequest(message);
            }

            return Ok(test);
        }
    }
}