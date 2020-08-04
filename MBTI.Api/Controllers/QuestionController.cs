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
    public class QuestionController : ApiController
    {
        // GET: api/PersonalityType
        public List<Question> GetQuestions()
        {
            return DataRepository.Question.GetAll();
        }

        // GET: api/PersonalityType/5
        [ResponseType(typeof(Question))]
        public IHttpActionResult GetQuestion(string id)
        {
            Question question = DataRepository.Question.Get(id);

            if (question == null)
                return NotFound();
            
            return Ok(question);
        }

        // PUT: api/PersonalityType/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutQuestion(string id, Question question)
        {
            try
            {
                DataRepository.Question.Update(question);
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
        public IHttpActionResult PostQuestion(Question question)
        {
            try
            {
                DataRepository.Question.Insert(question);
            }
            catch (Exception ex)
            {
                //string message = ExceptionHelper.GetMessageRecursively(ex);
                string message = ex.GetMessageRecursively();
                return BadRequest(message);
            }
            return CreatedAtRoute("DefaultApi", new { id = question.Id }, question);

        }

        // DELETE: api/PersonalityType/5
        [ResponseType(typeof(Question))]
        public IHttpActionResult DeleteQuestion(string id)
        {
            Question question = DataRepository.Question.Get(id);

            if (question == null)
                return NotFound();
            try
            {
                DataRepository.Question.Delete(question);
            }
            catch (Exception ex)
            {
                //string message = ExceptionHelper.GetMessageRecursively(ex);
                string message = ex.GetMessageRecursively();
                return BadRequest(message);
            }

            return Ok(question);
        }
    }
}