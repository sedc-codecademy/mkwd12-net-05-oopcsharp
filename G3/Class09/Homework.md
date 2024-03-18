# Homework Class 9 📒

## Task 1
* Give the user an option to input numbers
* After inputing each number ask them if they want to input another with a Y/N question
* Store all numbers in a QUEUE
* When the user is done adding numbers print the number in the order that the user entered them from the QUEUE

## Task 2
Create a class Song with the following properties: Title, Length and, Genre
Genre is enum with - Rock, Hip_Hop, Techno and Classical
Create a class Person with the following properties: Id, FirstName, LastName, Age, FavoriteMusicType (Genre enum) and FavoriteSongs
FavoriteSongs is a list of Songs
Create a method called GetFavSongs(): 
That will print out all the titles of their favorite songs or write a message that this person hates music if there are no favorite songs in their list.

## Bonus Task(not mandatory)
* Create a class Shape that has:
* Name
* Color
* Position, array of x and y coordinates (int[])
* getArea - method that will only write in the console that there is no special implementation for area
* getPerimeter - method that will only write in the console that there is no special implementation for perimeter *add method move that is shared among all instances and can be accessed through the class name. It updates the position of the input, by increasing the coordinates for 5.
* create a setter and getter for the color and name property. The setter/getter will log a corresponding message. The setter should do validation.

* Add class Rectangle, that inherits from Shape. It should have properties sideA and sideB. Override the getArea and getPerimeter methods correspondingly for a rectangle.
* Add class Circle, that inherits from Shape. It should have property radius. Override the getArea and getPerimeter methods correspondingly for a circle.
Test with few objects
