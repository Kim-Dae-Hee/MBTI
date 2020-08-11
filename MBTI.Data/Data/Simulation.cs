using MBTI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBTI.Data
{
    public class Simulation
    {
        private Test myTest = new Test();
        private Dictionary<string, int> personalityTypes = new Dictionary<string, int>()
        {
            ["ISTJ"] = 1, ["ISFJ"] = 2, ["ISTP"] = 3, ["ISFP"] = 4, ["INFJ"] = 5,
            ["INTJ"] = 6, ["INFP"] = 7, ["INTP"] = 8, ["ESTP"] = 9, ["ESFP"] = 10,
            ["ESTJ"] = 11,["ESFJ"] = 12,["ENFP"] = 13,["ENTP"] = 14,["ENFJ"] = 15,
            ["ENTJ"] = 16
        };

        public Simulation(int userId)
        {
            myTest.UserId = userId;
        }

        public void CreateTest()
        {
            myTest.StartAt = DateTime.Now;
            DataRepository.Test.Insert(myTest);
        }

        public void ChoiceQuestionsRandom()
        {
            int gradeA = 0;
            int gradeB = 0;

            Random random = new Random();

            for (int i = 1; i <= 48; i++)
            {
                gradeA = random.Next(0, 6);
                gradeB = 5 - gradeA;

                for (int j = 1; j <= 2; j++)
                {
                    Response response = new Response();
                    response.TestId = myTest.TestId;
                    response.QuestionId = j % 2 != 0 ? i.ToString() + "a" : i.ToString() + "b";
                    response.Grade = j % 2 != 0 ? gradeA : gradeB;
                    DataRepository.Response.Insert(response);
                }
            }

        }

        public void SetResult()
        {
            // FinishAt, PersonalityType 구하기
            var responses = DataRepository.Response.Get(myTest.TestId);
            var sumGrades = new Dictionary<string, int>();

            foreach (Response response in responses)
            {
                string type = DataRepository.Question.Get(response.QuestionId).Type;

                if (sumGrades.ContainsKey(type))
                {
                    sumGrades[type] += (int)response.Grade;
                }
                else
                {
                    sumGrades[type] = (int)response.Grade;
                }
            }

            string personalityType = GetPersonalityType(sumGrades);
            myTest.PersonalityTypeId = personalityTypes[personalityType];
            myTest.FinishAt = DateTime.Now;
            DataRepository.Test.Update(myTest);
        }

        private string GetPersonalityType(Dictionary<string, int> sumGrades)
        {
            StringBuilder personalityType = new StringBuilder();

            personalityType.Append(sumGrades["E"] >= sumGrades["I"] ? "E" : "I");
            personalityType.Append(sumGrades["S"] >= sumGrades["N"] ? "S" : "N");
            personalityType.Append(sumGrades["T"] >= sumGrades["F"] ? "T" : "F");
            personalityType.Append(sumGrades["J"] >= sumGrades["P"] ? "J" : "P");

            return personalityType.ToString();
        }

    }
}
