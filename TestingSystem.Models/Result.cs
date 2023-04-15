using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSystem.Models
{
    public class Result
    {
        private int allCount = 0;
        private int correctCount = 0;
        public Result(int allCount, int correctCount)
        {
            this.allCount = allCount;
            if (correctCount > allCount)
            {
                this.correctCount = allCount;
            }
            else
            {
                this.correctCount = correctCount;
            }
        }

        public int InPercents()
        {
            return (int)(correctCount/allCount*100);
        }

        public int GetAllCount()
        {
            return allCount;
        }

        public int GetCorrectCount()
        {
            return correctCount;
        }
    }
}
