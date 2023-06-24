# GenerativeAI
This application is designed to validate a string against different validation criteria using custom pattern andregular expressions. 
Pattern description:
```c#
(?=.*[a-z])                               - the string contains at least one lower letter
(?=.*[A-Z])                               - the string contains at least one uppercase letter
(?=.*\d)                                  - the string contains at least one digit
(?=.*[!""#$%&'()*+,-./:;<=>?@[\]^_`{|}~]) - the string contains at least one special character from a predefined list
^(?=.{1,10}$).*                           - the string should have minimum 1 symbol and maximum 10 symbols 
^[^\s\t\n]+$                              - the string does not contain any whitespace characters (spaces, tabs, or newlines)
```
