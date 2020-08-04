using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBTI.Data
{
    public static class ExceptionHelper
    {
        //public static string GetMessageRecursively(Exception ex)
        //{
        //    string message = "";

        //    while (ex != null)
        //    {
        //        message += ex.Message;
        //        message += Environment.NewLine;

        //        ex = ex.InnerException;
        //    }

        //    return message;
        //}
        public static string GetMessageRecursively(this Exception ex)
        {
            StringBuilder message = new StringBuilder();

            while (ex != null)
            {
                //message.Append(ex.Message);
                //message.Append(Environment.NewLine);
                message.Append(ex.Message);

                ex = ex.InnerException;
            }

            return message.ToString();
        }
    }
}
