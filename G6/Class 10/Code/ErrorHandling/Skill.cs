using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    public class Skill
    {
        public string Name { get; set; }    
        public int Points { get; set; }

        public Skill(string name, int points) {
            Name = name;
            Points = points;
        }
    }
}
