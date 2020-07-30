using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBTI.Data
{
    public class ResponseData : EntityData<Response>
    {
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
