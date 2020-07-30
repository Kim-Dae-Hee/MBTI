using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBTI.Data
{
    public class DataRepository
    {
        public static PersonalityTypeData PersonalityType { get; set; } = new PersonalityTypeData();
        public static QuestionData Question { get; set; } = new QuestionData();
        public static ResponseData Response { get; set; } = new ResponseData();
        public static TestData Test { get; set; } = new TestData();
        public static UserData User { get; set; } = new UserData();
    }
}
