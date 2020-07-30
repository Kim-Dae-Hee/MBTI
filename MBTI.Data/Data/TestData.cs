using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBTI.Data
{
    public class TestData : EntityData<Test>
    {
        public Test Get(int testId)
        {
            MBTIEntities context = CreateContext();

            return context.Tests.FirstOrDefault(x => x.TestId == testId);
        }
    }
}
