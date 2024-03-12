# Homework Class 4 📒

## Task 1
* Make a method called AgeCalculator
* The method will have one input parameter, your birthday date
* The method should return your age
* Show the age of a user after he inputs a date

> Note: take into consideration if the birthday is today, after or before today

## Task 2
* Write a method that formats a given date and time as a string in a specific format.
* Get the needed inputs from screen.

> Allowed formats: "MM/dd/yyyy", "MM/dd/yyyy hh:mm:ss", "dddd, dd MMMM yyyy HH:mm:ss", "MM.dd.yyyy"

> Bonus: Create separate method that validates whether the entered format is allowed
<br><br>

# Bonus Tasks 🔥

## Task 3: Reverse the Case

* Given a string, create a method to reverse the case. All lower-cased letters should be upper-cased, and vice versa.

### Examples:
```C#
ReverseCase("Happy Birthday") ➞ "hAPPY bIRTHDAY"

ReverseCase("MANY THANKS") ➞ "many thanks"

ReverseCase("sPoNtAnEoUs") ➞ "SpOnTaNeOuS"
```

## Task 4: Basic E-Mail Validation

* Create a method that accepts a string, checks if it's a valid email address and returns either true or false, depending on the evaluation.

    * The string must contain an `@` character.
    * The string must contain a `.` character.
    * The `@` must have at least one character in front of it.
        * ex. `"e@mail.com"` is valid, while `"@email.com"` is invalid.
    * The `.` and the `@` must be in the appropriate places.
        * ex. `"hello.email@com"` is invalid while `"john.smith@email.com"` is valid.

* If the string passes these tests, it's considered a valid email address.


### Examples:
```C#
ValidateEmail("@gmail.com") ➞ false

ValidateEmail("hello.gmail@com") ➞ false

ValidateEmail("gmail") ➞ false

ValidateEmail("hello@gmail") ➞ false

ValidateEmail("hello@gmail.com") ➞ true
```

