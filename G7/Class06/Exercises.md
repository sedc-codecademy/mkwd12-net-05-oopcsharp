## Retro
* Create a class Student that has properties: Name, Academy and Group

* Create an array with 5 new Students ( objects )

* The user should enter a name and the user information should be displayed in the console if a user by that name exists

* If there is no such user it should show an error message

## Task 1
* You are given the following string "The whole group of G2 loves C#.They find learning this language fun and easy!". Print the text after the ".", using string methods.

## Task 2

Create a method called NumberStats that accepts a number. This method should:

* Find out if the number is negative or positive
* Find out if the number is odd or even
* Find out if the number is decimal or integer
* After finding all the stats it should print them like this:

* **Stats for number: 25**
  * Positive
  * Integer
  * Odd

The number should be entered in the console by the user.

**Bonus**: Validate if the user is entering a number

**Bonus**: Ask the user to press Y to try again or X to exit

## Task 3

Create a class User with the following:

* Id - int
* Username - string
* Password - string
* Messages - Array of strings

Create an array of users and add 3 users to it manually ( hard-coded ).

Create a Console UI that will give the user two options to choose from:

* Log in - When selected the user should be asked for username and password. If the user is found print welcome message and the messages that the user has in the Messages property:
  * **Welcome NAME. Here are your messages:**
    * Message1
    * Message2
  * If not found, it should print an error message
* Register - When selected the user should be asked to enter ID, Username and password. It should then check if a there is already a username in the array of users like that. If there is, print a message that there is already a user called like that. If not, create a new user object from the information given in the console and add it to the Users array. Then print all the users by Id and Username
  * **Registration complete! Users:**
    * 23 Username1
    * 44 Username2
    * 1 Username3
    * 56 Username4**
