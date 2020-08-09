using System.Collections.Generic;
using System.Linq;

namespace MBTI.Data
{
    public class ResponseData : EntityData<Response>
    {
        public List<Response> Get(int testId, int questionNumber)
        {
            MBTIEntities context = CreateContext();
            var query = from x in context.Responses
                        where x.TestId == testId && (x.QuestionId == questionNumber.ToString()+"a" || x.QuestionId == questionNumber.ToString() + "b")
                        select x;

            return query.ToList();
        }

        public List<Response> Get(int testId)
        {
            MBTIEntities context = CreateContext();

            var query = from x in context.Responses
                        where x.TestId == testId  
                        select x;

            return query.ToList();
        }

    }
}
