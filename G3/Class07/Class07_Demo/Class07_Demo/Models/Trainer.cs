namespace Class07_Demo.Models
{
    public class Trainer : Person
    {
        public int YearsOfExperience { get; set; }

        public override string GetInfo()
        {
            return base.GetInfo() + $", Year of experience: {YearsOfExperience}";
        }
    }
}
