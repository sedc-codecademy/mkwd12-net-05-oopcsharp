using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    public class Human
    {
        public string Name { get; set; } 

        public List<Skill> Skills { get; set; } //default value null

        public Human(string name)
        {
            Name = name;
            //for testing nullref exception purposes we will not create an empty list here
            //Skills = new List<Skill>();

        }
    }
}
