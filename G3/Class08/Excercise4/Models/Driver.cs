namespace Excercise4.Models
{
    public class Driver
    {
        public string Name { get; set; }
        public int Level { get; set; }

        //ctor1
        public Driver(string name, int level)
        {
            Name = name;
            Level = level;
        }

        //ctor2
        public Driver(string name)
        {
            Name = name;
        }
    }
}
