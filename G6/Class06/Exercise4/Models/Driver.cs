namespace Exercise4.Models
{
    public class Driver
    {
        //constructor1
        public Driver(string name, int level)
        {
            Name = name;
            Level = level;
        }

        //constructor2
        public Driver(string name)
        {
            Name = name;
        }

        //both contructors work

        public string Name { get; set; }
        public int Level { get; set; }
    }
}
