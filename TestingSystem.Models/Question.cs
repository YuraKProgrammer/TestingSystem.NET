using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSystem.Models
{
    public class Question
    {
        private string questionText = "";
        private QuestionType questionType = QuestionType.Line;
        private string lineAnswer = "";
        private List<Option> allOptionAnswer = new List<Option>();
        private List<Option> optionsAnswer = new List<Option>();
        public string HumanLineAnswer = "";
        public List<Option> HumanOptionsAnswer = new List<Option>();
        /// <summary>
        /// Конструктор вопроса с ответом в строку
        /// </summary>
        /// <param name="questionType"></param>
        /// <param name="LineAnswer"></param>
        public Question(QuestionType questionType, string LineAnswer, string questionText)
        {
            if (questionType == QuestionType.Line)
            {
                this.questionType = questionType;
                this.lineAnswer = LineAnswer;
                this.questionText = questionText;
            }
            else
            {
                throw new Exception("Это должен быть вопрос с ответом в строку!");
            }
        }
        public Question(QuestionType questionType, List<Option> options, string questionText)
        {
            if (questionType == QuestionType.Options)
            {
                this.questionType = questionType;
                this.optionsAnswer = options;
                this.questionText = questionText;
            }
            else
            {
                throw new Exception("Это должен быть вопрос с вариантами ответа!");
            }
        }
        public bool GiveLineAnswer(string HumanLineAnswer)
        {
            if (String.Equals(lineAnswer, HumanLineAnswer))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GiveOptionsAnswer(List<Option> humanOptions)
        {
            var bm = true;
            foreach (Option o1 in humanOptions)
            {
                var i1 = o1.Id;
                var b = false;
                foreach (Option o2 in humanOptions)
                {
                    var i2 = o2.Id;
                    if (i1 == i2)
                    {
                        b = true;
                    }
                }
                if (b == false)
                {
                    bm = false;
                }
            }
            return bm;
        }
    }
}
