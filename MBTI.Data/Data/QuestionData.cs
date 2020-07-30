using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBTI.Data
{
    public class QuestionData : EntityData<Question>
    {
        public Question Get(string questionId)
        {
            MBTIEntities context = CreateContext();

            return context.Questions.FirstOrDefault(x => x.Id == questionId);
        }
    }
}
