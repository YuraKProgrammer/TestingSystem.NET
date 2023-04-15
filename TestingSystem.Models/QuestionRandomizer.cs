using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSystem.Models
{
    public class QuestionRandomizer : IQuestionRandomizer
    {
        public Question Randomize(Question question)
        {
            List<Option> l = question.allOptionsAnswer;

            Random rand = new Random();
            for (int i = l.Count - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);

                Option tmp = l[j];
                l[j] = l[i];
                l[i] = tmp;
            }
            Question question1 = new Question(question.GetQuestionType(), l, question.GetRigthOptions(), question.questionText);
            question1.id = question.id;
            return question1;
        }
    }
}
