using Excercise4.Models;

#region Reqs
//Create a game where you will need to calculate which driver is faster!

//    reqs:
//    1.Create Driver class with name and level props, level of driving skills;
//    2.Create Car class with model and speed props and a method that will calculate the speed;
//    3. In program.cs, create several drivers and several cars, save them in an array and make the game!
//    HINTS: The goal is in console, the user to select inputs as follows:
//    1. Select first car
//    2. Select second car
//    3. Select first driver
//    4. Select second driver
//    After the user select all that is neccecary,
//    the app should do the rest and calculate
//    which driver and car was winner and how fast was he/she driving

#endregion

#region method

void RaceCars(Car firstCar, Car secondCar)
{
    int firstPairSpeed = firstCar.CalculateSpeed(firstCar.Driver);
    int secondPairSpeed = secondCar.CalculateSpeed(secondCar.Driver);
    if (firstPairSpeed > secondPairSpeed)
    {
        Console.WriteLine($"In the race the winner car was {firstCar.Model}. It was driving with {firstPairSpeed}km/h and the driver was {firstCar.Driver.Name}.");
    }
    else if(firstPairSpeed < secondPairSpeed)
    {
        Console.WriteLine($"In the race the winner car was {secondCar.Model}. It was driving with {secondPairSpeed}km/h and the driver was {secondCar.Driver.Name}.");
    }
    else
    {
        Console.WriteLine("They are equal!");
    }
}

#endregion

#region data

Driver d1 = new Driver("Verstapen", 5);
Driver d2 = new Driver("Hamilton", 5);
Driver d3 = new Driver("Leclerc", 4);
Driver d4 = new Driver("Perez", 3);

Car c1 = new Car("Mercedes", 320);
Car c2 = new Car("Red Bull", 380);
Car c3 = new Car("Ferarri", 290);
Car c4 = new Car("Renault", 40);

Driver[] drivers = new Driver[] {d1, d2, d3, d4 };
Car[] cars = new Car[] {c1, c2, c3, c4};
bool endGame = false;

#endregion

#region UI Logic

do
{
    endGame = false;
    Console.WriteLine($"Please select the first car: \n1. {c1.Model}\n2.{c2.Model}\n3.{c3.Model}\n4.{c4.Model}");
    bool canParseFirstCar = int.TryParse(Console.ReadLine(), out int firstCar);

    Console.WriteLine($"Please select the second car: \n1. {c1.Model}\n2.{c2.Model}\n3.{c3.Model}\n4.{c4.Model}");
    bool canParseSecondCar = int.TryParse(Console.ReadLine(), out int secondCar);

    Console.WriteLine($"Please select the first driver: \n1. {d1.Name}\n2.{d2.Name}\n3.{d3.Name}\n4.{d4.Name}");
    bool canParseFirstDriver = int.TryParse(Console.ReadLine(), out int firstDriver);

    Console.WriteLine($"Please select the second driver: \n1. {d1.Name}\n2.{d2.Name}\n3.{d3.Name}\n4.{d4.Name}");
    bool canParseSecondDriver = int.TryParse(Console.ReadLine(), out int secondDriver);

    if (canParseFirstCar && canParseSecondCar && canParseFirstDriver && canParseSecondDriver)
    {
        // Ovde pravime nova instanca od Car klasata za dvata objekta i potoa so menuvanje na property
        //vo bilokoj objekt nema da go afektira menuvanjeto na istoto property vo drugiot objekt
        //vo slucajov, firstSelectedCar i secondSelectedCar
        Car firstSelectedCar = new Car(cars[firstCar - 1].Model, cars[firstCar - 1].Speed);
        Car secondSelectedCar = new Car(cars[secondCar - 1].Model, cars[secondCar - 1].Speed);

        //prethodnoto resenie
        //Ova e povrzano so dolniot komentar, i vaka nema raboti kako sto treba bidejki rabotime na istata instanca od objektot
        //Car firstSelectedCar = cars[firstCar - 1];
        //Car secondSelectedCar = cars[secondCar - 1];

        Driver firstSelectedDriver = drivers[firstDriver - 1];
        Driver secondSelectedDriver = drivers[secondDriver - 1];

        //ovde go populirame propertito Driver vo Car klasata
        //ovde dokolku odbereme ista kola a razlicen driver, bidejki imame ist objekt ke go assignuva vtoriot driver i na dvete koli.
        //za da go sredime ova potrebno e da napravime nova instanca od istiot objekt, pa so novata instanca da rabotime i da menuvame
        firstSelectedCar.Driver = firstSelectedDriver;
        secondSelectedCar.Driver = secondSelectedDriver;


        RaceCars(firstSelectedCar, secondSelectedCar);

        Console.WriteLine("Do you want to play again? If not please enter n or N otherwise enter y or Y");
        string userInput = Console.ReadLine();
        if (userInput.ToLower() == "y")
            endGame = true;
    }
    else
    {
        Console.WriteLine("Wrong input please select using numbers from 1-4");
    }
} while (endGame);

#endregion