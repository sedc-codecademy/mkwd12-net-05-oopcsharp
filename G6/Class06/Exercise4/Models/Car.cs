namespace Exercise4.Models
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

        //navigational prop to Driver
        public Driver Driver { get; set; }

        public int CalculateSpeed(Driver driver)
        {
            //Using the level prop of the driver class because of the navigational property
            return driver.Level * Speed;
        }
    }
}
