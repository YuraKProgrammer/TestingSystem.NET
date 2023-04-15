using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSystem.Models
{
    public class Testing
    {
        public int id { get; set; }
        public string Name { get; set; }
        private List<Question> questions = new List<Question>();
        private Difficulty difficulty = Difficulty.Newbie;
        
        public Testing(string name, Difficulty difficulty)
        {
            Name = name;
            this.difficulty = difficulty;
        }

        public void AddQuestion(Question question)
        {
            question.id = questions.Count + 1;
            questions.Add(question);
        }

        public void DeleteQuestion(Question question)
        {
            questions.Remove(questions.Where(q => q.id == question.id).FirstOrDefault());
        }

        public Result GetResult()
        {
            var allCount = 0;
            var correctCount = 0;
            foreach(Question question in questions)
            {
                allCount++;
                if (question.GetRightOrNot())
                {
                    correctCount++;
                }
            }
            return new Result(allCount, correctCount);
        }

        public int GetQuestionsCount()
        {
            return questions.Count;
        }

        public Difficulty GetDifficulty()
        {
            return difficulty;
        }
    }
}
