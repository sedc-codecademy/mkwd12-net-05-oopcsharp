namespace Excercise4.Models
{
    public class Car
    {
        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        public string Model { get; set; }
        public int Speed { get; set; }

        //navigational prop
        public Driver Driver { get; set; }

        public int CalculateSpeed(Driver driver)
        {
            return driver.Level * Speed;
        }
    }
}
