namespace Workshop_Exercise4.Models
{
    public class Driver
    {
        //constructor1
        public Driver(string name, int level) //it expects string as first param and int as second param
        {
            Name = name;
            Level = level;
        }
        //constructor2
        public Driver(int level, string name)//it expects int as first param and string as second param
        {
            Name = name;
            Level = level;
        }

        //constructor3
        public Driver(string name)
        {
            Name = name;
        }

        public Driver(int level)
        {
            Level = level;
        }

        //both contructors work

        public string Name { get; set; }
        public int Level { get; set; }
    }
}
