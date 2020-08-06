using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MBTI.Data
{
    public class UserData : EntityData<User>
    {
        public User Get(int userId)
        {
            MBTIEntities context = CreateContext();

            return context.Users.FirstOrDefault(x => x.UserId == userId);
        }

        public User Get(string name, string email)
        {
            MBTIEntities context = CreateContext();

            return context.Users.FirstOrDefault(x => x.Name == name && x.Email == email);
        }
    }
}
