
namespace Domain.Model
{
    public class Dog
    {
        public string Name {  get; set; }
        public int Age { get; set; }

        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
