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
    public class ResponseController : ApiController
    {
        // GET: api/PersonalityType
        public List<Response> GetResponses()
        {
            return DataRepository.Response.GetAll();
        }

        // GET: api/PersonalityType/5
        [ResponseType(typeof(Response))]
        public IHttpActionResult GetResponse(int testId)
        {
            List<Response> responses = DataRepository.Response.Get(testId);

            if (responses.Count == 0)
                return NotFound();
            else
                return Ok(responses[0]);
        }

        // PUT: api/PersonalityType/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutResponse(int testId, Response response)
        {
            try
            {
                DataRepository.Response.Update(response);
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
        [ResponseType(typeof(Response))]
        public IHttpActionResult PostResponse(Response response)
        {
            try
            {
                DataRepository.Response.Insert(response);
            }
            catch (Exception ex)
            {
                //string message = ExceptionHelper.GetMessageRecursively(ex);
                string message = ex.GetMessageRecursively();
                return BadRequest(message);
            }
            return CreatedAtRoute("DefaultApi", new { id = response.TestId }, response );

        }

        // DELETE: api/PersonalityType/5
        [ResponseType(typeof(Response))]
        public IHttpActionResult DeleteResponse(int testId)
        {
            List<Response> responses = DataRepository.Response.Get(testId);

            if (responses.Count == 0)
                return NotFound();
            try
            {
                DataRepository.Response.Delete(responses[0]);
            }
            catch (Exception ex)
            {
                //string message = ExceptionHelper.GetMessageRecursively(ex);
                string message = ex.GetMessageRecursively();
                return BadRequest(message);
            }

            return Ok(responses[0]);
        }
    }
}