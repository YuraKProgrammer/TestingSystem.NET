using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSystem.Models
{
    public class Option
    {
        public int Id { get; }
        public string Text { get; }
        
        public Option(int id, string text)
        {
            Id = id;
            Text = text;
        }
    }
}
