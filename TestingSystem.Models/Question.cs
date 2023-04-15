using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSystem.Models
{
    public class Question
    {
        public int id { get; set; }
        public string questionText = "";
        private bool isCorrectAnswer = false;
        private QuestionType questionType = QuestionType.Line;
        private string lineAnswer = "";
        public List<Option> allOptionsAnswer = new List<Option>();
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
        /// <summary>
        /// Конструктор вопроса с варинтами ответа
        /// </summary>
        /// <param name="questionType"></param>
        /// <param name="options"></param>
        /// <param name="questionText"></param>
        /// <exception cref="Exception"></exception>
        public Question(QuestionType questionType, List<Option> allOptions, List<Option> rightOptions, string questionText)
        {
            if (questionType == QuestionType.Options)
            {
                this.questionType = questionType;
                this.optionsAnswer = rightOptions;
                this.allOptionsAnswer = allOptions; 
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
                isCorrectAnswer = true;
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
                foreach (Option o2 in optionsAnswer)
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
            if (bm == true)
            {
                isCorrectAnswer = true;
            }
            return bm;
        }

        public bool GetRightOrNot()
        {
            return isCorrectAnswer;
        }

        public QuestionType GetQuestionType()
        {
            return questionType;
        }

        public List<Option> GetRigthOptions()
        {
            return optionsAnswer;
        }
    }
}
