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
    public class UserController : ApiController
    {
        // GET: api/PersonalityType
        public List<User> GetUsers()
        {
            return DataRepository.User.GetAll();
        }

        // GET: api/PersonalityType/5
        [ResponseType(typeof(User))]
        public IHttpActionResult GetUser(int userId)
        {
            User user = DataRepository.User.Get(userId);

            if (user == null)
                return NotFound();

            return Ok(user);
        }

        // PUT: api/PersonalityType/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUser(int userId, User user)
        {
            try
            {
                DataRepository.User.Update(user);
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
        [ResponseType(typeof(User))]
        public IHttpActionResult PostUser(User user)
        {
            try
            {
                DataRepository.User.Insert(user);
            }
            catch (Exception ex)
            {
                //string message = ExceptionHelper.GetMessageRecursively(ex);
                string message = ex.GetMessageRecursively();
                return BadRequest(message);
            }
            return CreatedAtRoute("DefaultApi", new { id = user.UserId }, user);

        }

        // DELETE: api/PersonalityType/5
        [ResponseType(typeof(User))]
        public IHttpActionResult DeleteUser(int userId)
        {
            User user = DataRepository.User.Get(userId);

            if (user == null)
                return NotFound();
            try
            {
                DataRepository.User.Delete(user);
            }
            catch (Exception ex)
            {
                //string message = ExceptionHelper.GetMessageRecursively(ex);
                string message = ex.GetMessageRecursively();
                return BadRequest(message);
            }

            return Ok(user);
        }
    }
}