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
    public class PersonalityTypeController : ApiController
    {
        // GET: api/PersonalityType
        public List<PersonalityType> GetPersonalityTypes()
        {
            return DataRepository.PersonalityType.GetAll();
        }

        // GET: api/PersonalityType/5
        [ResponseType(typeof(PersonalityType))]
        public IHttpActionResult GetPersonalityType(int id)
        {
            PersonalityType personalitytype = DataRepository.PersonalityType.Get(id);

            if (personalitytype == null)
                return NotFound();
            
            return Ok(personalitytype);
        }

        // PUT: api/PersonalityType/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPersonalityType(int id, PersonalityType personalitytype)
        {
            try
            {
                DataRepository.PersonalityType.Update(personalitytype);
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
        [ResponseType(typeof(PersonalityType))]
        public IHttpActionResult PostPersonalityType(PersonalityType personalitytype)
        {
            try
            {
                DataRepository.PersonalityType.Insert(personalitytype);
            }
            catch (Exception ex)
            {
                //string message = ExceptionHelper.GetMessageRecursively(ex);
                string message = ex.GetMessageRecursively();
                return BadRequest(message);
            }
            return CreatedAtRoute("DefaultApi", new { id = personalitytype.Id }, personalitytype);

        }

        // DELETE: api/PersonalityType/5
        [ResponseType(typeof(PersonalityType))]
        public IHttpActionResult DeletePersonalityType(int id)
        {
            PersonalityType personalitytype = DataRepository.PersonalityType.Get(id);

            if (personalitytype == null)
                return NotFound();
            try
            {
                DataRepository.PersonalityType.Delete(personalitytype);
            }
            catch (Exception ex)
            {
                //string message = ExceptionHelper.GetMessageRecursively(ex);
                string message = ex.GetMessageRecursively();
                return BadRequest(message);
            }

            return Ok(personalitytype);
        }

    }
}