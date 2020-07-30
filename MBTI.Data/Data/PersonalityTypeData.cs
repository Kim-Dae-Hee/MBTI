using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBTI.Data
{
    public class PersonalityTypeData : EntityData<PersonalityType>
    {
        public PersonalityType Get(int PersonalityId)
        {
            MBTIEntities context = CreateContext();

            return context.PersonalityTypes.FirstOrDefault(x => x.Id == PersonalityId);
        }
    }
}
