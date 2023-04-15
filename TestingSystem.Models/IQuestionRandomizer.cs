using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSystem.Models
{
    public interface IQuestionRandomizer
    {
        public Question Randomize(Question question);
    }
}
