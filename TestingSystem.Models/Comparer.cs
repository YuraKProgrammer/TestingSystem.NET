using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSystem.Models
{
    public class Comparer
    {
        public static bool CompareOptions(Option o1, Option o2) 
        {
            if (o1.Id == o2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
